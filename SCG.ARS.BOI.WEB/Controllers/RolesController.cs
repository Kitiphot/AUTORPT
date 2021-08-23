using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SCG.ARS.BOI.WEB.Models;
using Npgsql;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class RolesController : Controller
    {
        DbContext _context = null;


        // GET: Roles
        [AuthorizedAction]
        public ActionResult Index()
        {
            //return View(await _context.Roles.ToListAsync());
            return View();
        }
        
        // GET: Roles/Create
        [AuthorizedAction]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Title,Description")] Roles roles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        // GET: Roles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var roles = await _context.Roles.SingleOrDefaultAsync(m => m.UserGroup_Id == id);
            // if (roles == null)
            // {
            //     return NotFound();
            // }

            // DataSet ds = new DataSet();
            // List<string> menus_id = _context.LinkRolesMenus.Where(s=> s.UserGroup_Id == id).Select(s => s.Menu_Id.ToString()).ToList();
            // ds = ToDataSet(_context.Menus.ToList());
            // DataTable table = ds.Tables[0];
            // DataRow[] parentMenus = table.Select("MenuParent_Id = 0");

            // var sb = new StringBuilder();
            // string unorderedList = GenerateUL(parentMenus, table, sb, menus_id);
            // ViewBag.menu = unorderedList;

            // return View(roles);

            return await Task.FromResult(Ok("ok"));
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] Roles roles)
        {
            if (id != roles.UserGroup_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RolesExists(roles.UserGroup_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var roles = await _context.Roles
            //     .SingleOrDefaultAsync(m => m.UserGroup_Id == id);
            // if (roles == null)
            // {
            //     return NotFound();
            // }

            // return View(roles);
            return await Task.FromResult(Ok("ok"));
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // foreach (var role in _context.LinkRolesMenus.Where(s=>s.UserGroup_Id == id))
            // {
            //     _context.LinkRolesMenus.Remove(role);
            // }
            // await _context.SaveChangesAsync();

            // var roles = await _context.Roles.SingleOrDefaultAsync(m => m.UserGroup_Id == id);
            // _context.Roles.Remove(roles);
            // await _context.SaveChangesAsync();
            return await Task.FromResult(Ok("ok"));
        }

        public IActionResult Update(int id, List<int> roles)
        {
            // var temp = _context.LinkRolesMenus.Where(s => s.UserGroup_Id == id);
            // foreach (var item in temp)
            // {
            //     _context.LinkRolesMenus.Remove(item);
            // }

            // foreach (var role in roles)
            // {
            //     _context.LinkRolesMenus.Add(new LinkRolesMenus { Menu_Id = role, UserGroup_Id = id });
            // }

            // _context.SaveChanges();

            return Json(new { status= true, message = "Successfully Updated Role!" });
        }

        private bool RolesExists(int id)
        {
            //return _context.Roles.Any(e => e.UserGroup_Id == id);
            return true;
        }


        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb, List<string> menus_id)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string id = dr["Menu_Id"].ToString();
                    string handler = dr["Menu_Url"].ToString();
                    string menuText = dr["Menu_Name"].ToString();
                    string icon = dr["Menu_Icon"].ToString();

                    string pid = dr["Menu_Id"].ToString();
                    string parentId = dr["MenuParent_Id"].ToString();

                    string status = (menus_id.Contains(id)) ? "Checked" : "";

                    DataRow[] subMenu = table.Select(String.Format("MenuParent_Id = '{0}'", pid));
                    if (subMenu.Length > 0 && !pid.Equals(parentId))
                    {
                        string line = String.Format(@"<li class=""has""><input type=""checkbox"" name=""subdomain[]"" id=""{5}"" value=""{1}"" {4}><label>> {1}</label>", handler, menuText, icon, "target", status, id);
                        sb.Append(line);

                        var subMenuBuilder = new StringBuilder();
                        sb.AppendLine(String.Format(@"<ul>"));
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder, menus_id));
                        sb.Append("</ul>");
                    }
                    else
                    {
                        string line = String.Format(@"<li class=""""><input type=""checkbox"" name=""subdomain[]"" id=""{5}"" value=""{1}"" {4}><label>{1}</label>", handler, menuText, icon, "target", status, id);
                        sb.Append(line);
                    }
                    sb.Append("</li>");
                }
            }
            return sb.ToString();
        }

        public DataSet ToDataSet<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            return ds;
        }
    }
}
