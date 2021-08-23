using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using NLog;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Services;

namespace SCG.ARS.BOI.WEB.Helpers {
    public static class Helper {
        static Logger logger = LogManager.GetCurrentClassLogger ();
        public static bool ExtractFilesFromZip (string fullFilePath, string extractPath) {
            var files = new List<string> ();
            var isSuccess = false;
            try {
                if (Directory.Exists (extractPath))
                    Directory.Delete (extractPath, true);
                ZipFile.ExtractToDirectory (fullFilePath, extractPath, true);

                // if(File.Exists(extractPath)) 
                // {
                //     // This path is a file
                //     ProcessFile(extractPath); 
                // }               
                //if (Directory.Exists (extractPath)) {
                // This path is a directory
                //files.AddRange (await ProcessDirectory (extractPath));
                ProcessDirectory (extractPath);

                //files.AddRange(Directory.GetFiles(extractPath, "*.*", SearchOption.AllDirectories));
                //}
                isSuccess = true;
            } catch (Exception ex) {
                throw ex;
            }
            return isSuccess;
        }

        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static bool ProcessDirectory (string targetDirectory) {
            //var files = new List<string> ();
            var result = false;

            try {
                // Process the list of files found in the directory.
                string[] fileEntries = Directory.GetFiles (targetDirectory, "*.zip");
                foreach (string fileName in fileEntries) {
                    var ext = Path.GetExtension (fileName);
                    var nameNoExt = Path.GetFileNameWithoutExtension (fileName);
                    var dir = Path.GetDirectoryName (fileName);
                    var extractPath = Path.Combine (dir, nameNoExt);

                    if (ext.ToLower ().Equals (".zip")) {
                        var isExtract = ExtractFilesFromZip (fileName, extractPath);
                        if (isExtract && File.Exists (fileName))
                            File.Delete (fileName);
                        //if (isSuccess) files.AddRange (unzipFiles);
                    }
                    //else files.Add (fileName);
                }

                if (Directory.Exists (targetDirectory)) {
                    // Recurse into subdirectories of this directory.
                    string[] subdirectoryEntries = Directory.GetDirectories (targetDirectory);
                    foreach (string subdirectory in subdirectoryEntries)
                        //files.AddRange( await ProcessDirectory (subdirectory));
                        ProcessDirectory (subdirectory);
                }
            } catch (Exception ex) {
                throw ex;
            }

            return result; //files.ToArray ();
        }

        // Insert logic for processing found files here.
        // public static void ProcessFile (string path) {
        //     Console.WriteLine ("Processed file '{0}'.", path);
        // }

        // The cryptographic service provider.

        // Compute the file's hash.
        public static byte[] GetHashSha256 (string filename) {
            using (var sha256 = SHA256.Create ()) {
                using (var stream = File.OpenRead (filename)) {
                    return sha256.ComputeHash (stream);
                }
            }
        }

        public static byte[] GetHashMD5 (string filename) {
            using (var md5 = MD5.Create ()) {
                using (var stream = File.OpenRead (filename)) {
                    return md5.ComputeHash (stream);
                }
            }
        }

        // Return a byte array as a sequence of hex values.
        public static string BytesToString (byte[] bytes) {
            string result = "";
            foreach (byte b in bytes) result += b.ToString ("x2");
            return result;
        }

        public static String ReadFileAsUtf8 (string fileName) {
            Encoding encoding = Encoding.Default;
            String original = String.Empty;

            using (StreamReader sr = new StreamReader (fileName, Encoding.Default)) {
                original = sr.ReadToEnd ();
                encoding = sr.CurrentEncoding;
                sr.Close ();
            }

            if (encoding == Encoding.UTF8)
                return original;

            byte[] encBytes = encoding.GetBytes (original);
            byte[] utf8Bytes = Encoding.Convert (encoding, Encoding.UTF8, encBytes);
            return Encoding.UTF8.GetString (utf8Bytes);
        }

        public static string ReadFile (string fileName) {
            var content = File.ReadAllText (fileName);
            Encoding.RegisterProvider (CodePagesEncodingProvider.Instance);
            Encoding fileEncoding = GetEncodingFormFile (fileName);

            // Encoding iso = Encoding.GetEncoding ("ISO-8859-1");
            // Encoding utf8 = Encoding.UTF8;
            // byte[] utfBytes = utf8.GetBytes (content);
            // byte[] isoBytes = Encoding.Convert (utf8, iso, utfBytes);
            // string msg = iso.GetString (isoBytes);
            // //content = ConvertFromWindowsToUnicode(content);
            content = ConvertStringEncoding (content, fileEncoding, Encoding.GetEncoding ("TIS-620"));
            content = ConvertStringEncoding (content, Encoding.GetEncoding ("TIS-620"), Encoding.UTF8);
            var bufferTIS620 = ToTIS620 (content);
            var buffer = ToUTF8 (bufferTIS620);
            var result = Encoding.UTF8.GetString (buffer, 0, buffer.Length);
            return result;
        }

        public static Encoding GetEncodingFormFile (string filename) {
            if (File.Exists (filename)) {
                StreamReader sr = new StreamReader (filename);
                Encoding encode = sr.CurrentEncoding;
                sr.Close ();
                return encode;
            } else
                return null;
        }

        private static readonly Dictionary<int, char> CharactersToMap = new Dictionary<int, char> { { 130, '‚' },
            { 131, 'ƒ' },
            { 132, '„' },
            { 133, '…' },
            { 134, '†' },
            { 135, '‡' },
            { 136, 'ˆ' },
            { 137, '‰' },
            { 138, 'Š' },
            { 139, '‹' },
            { 140, 'Œ' },
            { 145, '‘' },
            { 146, '’' },
            { 147, '“' },
            { 148, '”' },
            { 149, '•' },
            { 150, '–' },
            { 151, '—' },
            { 152, '˜' },
            { 153, '™' },
            { 154, 'š' },
            { 155, '›' },
            { 156, 'œ' },
            { 159, 'Ÿ' },
            { 173, '-' }
        };

        public static string ConvertFromWindowsToUnicode (string txt) {
            if (string.IsNullOrEmpty (txt)) {
                return txt;
            }

            var sb = new StringBuilder ();
            foreach (var c in txt) {
                var i = (int) c;

                if (i >= 130 && i <= 173 && CharactersToMap.TryGetValue (i, out var mappedChar)) {
                    sb.Append (mappedChar);
                    continue;
                }

                sb.Append (c);
            }

            return sb.ToString ();
        }

        public static string ConvertStringEncoding (string txt, Encoding srcEncoding, Encoding dstEncoding) {
            if (string.IsNullOrEmpty (txt)) {
                return txt;
            }

            if (srcEncoding == null) {
                throw new System.ArgumentNullException (nameof (srcEncoding));
            }

            if (dstEncoding == null) {
                throw new System.ArgumentNullException (nameof (dstEncoding));
            }

            var srcBytes = srcEncoding.GetBytes (txt);
            var dstBytes = Encoding.Convert (srcEncoding, dstEncoding, srcBytes);
            return dstEncoding.GetString (dstBytes);
        }

        public static byte[] To1252 (string utf8String) {
            List<byte> buffer = new List<byte> ();
            byte utf8Identifier = 224;
            for (var i = 0; i < utf8String.Length; i++) {
                string utf8Char = utf8String.Substring (i, 1);
                byte[] utf8CharBytes = Encoding.UTF8.GetBytes (utf8Char);
                if (utf8CharBytes.Length > 1 && utf8CharBytes[0] == utf8Identifier) {
                    var tis620Char = (utf8CharBytes[2] & 0x20AC);
                    tis620Char |= ((utf8CharBytes[1] & 0x20AC) << 6);
                    tis620Char |= ((utf8CharBytes[0] & 0x20AC) << 12);
                    tis620Char -= (0x0E00 + 0xA0);
                    byte tis620Byte = (byte) tis620Char;
                    tis620Byte += 0xA0;
                    tis620Byte += 0xA0;
                    buffer.Add (tis620Byte);
                } else {
                    buffer.Add (utf8CharBytes[0]);
                }
            }
            return buffer.ToArray ();
        }

        public static byte[] ToTIS620 (string utf8String) {
            List<byte> buffer = new List<byte> ();
            byte utf8Identifier = 224;
            for (var i = 0; i < utf8String.Length; i++) {
                string utf8Char = utf8String.Substring (i, 1);
                byte[] utf8CharBytes = Encoding.UTF8.GetBytes (utf8Char);
                if (utf8CharBytes.Length > 1 && utf8CharBytes[0] == utf8Identifier) {
                    var tis620Char = (utf8CharBytes[2] & 0x3F);
                    tis620Char |= ((utf8CharBytes[1] & 0x3F) << 6);
                    tis620Char |= ((utf8CharBytes[0] & 0x0F) << 12);
                    tis620Char -= (0x0E00 + 0xA0);
                    byte tis620Byte = (byte) tis620Char;
                    tis620Byte += 0xA0;
                    tis620Byte += 0xA0;
                    buffer.Add (tis620Byte);
                } else {
                    buffer.Add (utf8CharBytes[0]);
                }
            }
            return buffer.ToArray ();
        }
        public static byte[] ToUTF8 (byte[] tis620Bytes) {
            List<byte> buffer = new List<byte> ();
            byte safeAscii = 126;
            for (var i = 0; i < tis620Bytes.Length; i++) {
                if (tis620Bytes[i] > safeAscii) {
                    if (((0xa1 <= tis620Bytes[i]) && (tis620Bytes[i] <= 0xda)) ||
                        ((0xdf <= tis620Bytes[i]) && (tis620Bytes[i] <= 0xfb))) {
                        var utf8Char = 0x0e00 + tis620Bytes[i] - 0xa0;
                        byte utf8Byte1 = (byte) (0xe0 | (utf8Char >> 12));
                        buffer.Add (utf8Byte1);
                        byte utf8Byte2 = (byte) (0x80 | ((utf8Char >> 6) & 0x3f));
                        buffer.Add (utf8Byte2);
                        byte utf8Byte3 = (byte) (0x80 | (utf8Char & 0x3f));
                        buffer.Add (utf8Byte3);
                    }
                } else {
                    buffer.Add (tis620Bytes[i]);
                }
            }
            return buffer.ToArray ();
        }

        public static List<T> ConvertDataTable<T> (DataTable dt) {
            List<T> data = new List<T> ();
            foreach (DataRow row in dt.Rows) {
                T item = GetItem<T> (row);
                data.Add (item);
            }
            return data;
        }
        private static T GetItem<T> (DataRow dr) {
            Type temp = typeof (T);
            T obj = Activator.CreateInstance<T> ();

            foreach (DataColumn column in dr.Table.Columns) {
                foreach (PropertyInfo pro in temp.GetProperties ()) {
                    if (pro.Name == column.ColumnName) {
                        var value = dr[column.ColumnName];
                        //if (value != null && !pro.PropertyType.IsAssignableFrom(value.GetType()))
                        //    value = Convert.ChangeType(value, pro.PropertyType);
                        //pro.SetValue (obj, value, null);
                        SetValue (obj, column.ColumnName, value);
                    } else
                        continue;
                }
            }
            return obj;
        }

        public static DataTable ToDataTable<T> (List<T> items) {
            DataTable dataTable = new DataTable (typeof (T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof (T).GetProperties (BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props) {
                //Setting column names as Property names
                dataTable.Columns.Add (prop.Name);
            }
            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++) {
                    values[i] = Props[i].GetValue (item, null);
                }
                dataTable.Rows.Add (values);
            }
            return dataTable;
        }

        public static void SetValue (object inputObject, string propertyName, object propertyVal) {
            //find out the type
            Type type = inputObject.GetType ();

            //get the property information based on the type
            System.Reflection.PropertyInfo propertyInfo = type.GetProperty (propertyName);

            //find the property type
            Type propertyType = propertyInfo.PropertyType;

            //Convert.ChangeType does not handle conversion to nullable types
            //if the property type is nullable, we need to get the underlying type of the property
            var targetType = IsNullableType (propertyInfo.PropertyType) ? Nullable.GetUnderlyingType (propertyInfo.PropertyType) : propertyInfo.PropertyType;

            if (targetType == typeof (bool))
                propertyVal = propertyVal.ToString () == "1";
            else if (targetType == typeof (DateTime)) {
                DateTime dateTime = new DateTime ();

                if (!DateTime.TryParse (propertyVal.ToString (), out dateTime)) {

                    var date = new Regex (@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/(\d{4}))").Match (propertyVal.ToString ());
                    if (date.Success) {
                        if (!DateTime.TryParseExact (date.Value, "dd/MM/yyyy",
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                            dateTime = DateTime.Now;
                    }

                    var time = new Regex (@"((\d{2})\:(\d{2})\:(\d{2}))$").Match (propertyVal.ToString ());
                    if (time.Success) {
                        var timeSpan = TimeSpan.Parse (time.Value);
                        dateTime = dateTime.Add (timeSpan);
                    }
                }

                propertyVal = dateTime;
            }

            //Returns an System.Object with the specified System.Type and whose value is
            //equivalent to the specified object.
            propertyVal = Convert.ChangeType (propertyVal, targetType);

            //Set the value of the property
            propertyInfo.SetValue (inputObject, propertyVal, null);

        }
        private static bool IsNullableType (Type type) {
            return type.IsGenericType && type.GetGenericTypeDefinition ().Equals (typeof (Nullable<>));
        }
        public static bool IsDebug {
            get {
                bool isDebug = false;
#if DEBUG
                isDebug = true;
#endif
                return isDebug;
            }
        }

        public static int ConvertToInt (string strNumber) {
            var number = 0;
            if (!string.IsNullOrEmpty (strNumber) && Int32.TryParse (strNumber, out number)) {

            }
            return number;
        }
        public static DateTime ConvertToDateTime (string strDateTime, string format, CultureInfo culture) {
            DateTime date = DateTime.MinValue;
            if (!string.IsNullOrEmpty (strDateTime) &&
                DateTime.TryParseExact (strDateTime, format, culture, DateTimeStyles.None, out date)) {

            }

            return date;
        }

        public static DateTime ConvertToDateTime (string strDateTime) {
            DateTime date = DateTime.MinValue;
            if (!string.IsNullOrEmpty (strDateTime) &&
                DateTime.TryParse (strDateTime, out date)) {

            }

            return date;
        }

        public static bool ColumnExist (DataTable dataTable, string columnName) {
            return dataTable.Columns.Contains (columnName);
        }

        public static string GetDataRowValue (DataRow row, string columnName) {
            var result = string.Empty;
            if (row.Table.Columns.Contains (columnName))
                result = string.IsNullOrEmpty (row[columnName].ToString ()) ? "" : row[columnName].ToString ();
            return result;
        }

        // public static string GenerateMenu(int GroupId)
        // {
        //     string menu = string.Empty;

        //     var services = HttpContext.RequestServices;
        //     var _userService = (IUserService)services.GetService(typeof(IUserService));

        //     List<Menus> menus = _userService.GetMenus(GroupId);

        //     DataSet ds = new DataSet();
        //     ds = ToDataSet(menus);
        //     DataTable table = ds.Tables[0];
        //     DataRow[] parentMenus = table.Select("menuparent_id = 0");

        //     var sb = new StringBuilder();
        //     string menuString = GenerateUL(parentMenus, table, sb);

        //     return menu;
        // }

        public static DataSet ToDataSet<T> (List<T> items) {
            DataTable dataTable = new DataTable (typeof (T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof (T).GetProperties (BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props) {
                //Setting column names as Property names
                dataTable.Columns.Add (prop.Name);
            }
            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++) {
                    values[i] = Props[i].GetValue (item, null);
                }
                dataTable.Rows.Add (values);
            }
            DataSet ds = new DataSet ();
            ds.Tables.Add (dataTable);
            return ds;
        }

        public static DataTable ToDataTable (IEnumerable<dynamic> items) {
            if (items == null) return null;
            var data = items.ToArray ();
            if (data.Length == 0) return null;

            var dt = new DataTable ();
            foreach (var pair in ((IDictionary<string, object>) data[0])) {
                dt.Columns.Add (pair.Key, (pair.Value ?? string.Empty).GetType ());
            }
            foreach (var d in data) {
                dt.Rows.Add (((IDictionary<string, object>) d).Values.ToArray ());
            }
            return dt;
        }
        public static string GenerateUL (DataRow[] menu, DataTable table, StringBuilder sb) {
            if (menu.Length > 0) {
                foreach (DataRow dr in menu) {
                    string url = dr["menu_Url"].ToString ();
                    string menuText = dr["menu_Name"].ToString ();
                    string icon = dr["menu_Icon"].ToString ();

                    if (url != "#") {
                        string line = String.Format (@"<li><a href=""{0}""><i class=""{2}""></i> <span>{1}</span></a></li>", url, menuText, icon);
                        sb.Append (line);
                    }

                    string pid = dr["Menu_Id"].ToString ();
                    string parentId = dr["menuparent_id"].ToString ();

                    DataRow[] subMenu = table.Select (String.Format ("menuparent_id = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals (parentId)) {
                        string line = String.Format (@"<li class=""treeview""><a href=""#""><i class=""{0}""></i> <span>{1}</span><span class=""pull-right-container""><i class=""fa fa-angle-left pull-right""></i></span></a><ul class=""treeview-menu"">", icon, menuText);
                        var subMenuBuilder = new StringBuilder ();
                        sb.AppendLine (line);
                        sb.Append (GenerateUL (subMenu, table, subMenuBuilder));
                        sb.Append ("</ul></li>");
                    }
                }
            }
            return sb.ToString ();
        }

        public static byte[] GetFile(string s)
        {
            System.IO.FileStream fs = System.IO.File.OpenRead(s);
            byte[] data = new byte[fs.Length];
            int br = fs.Read(data, 0, data.Length);
            if (br != fs.Length)
                throw new System.IO.IOException(s);
            return data;
        }
    }
}