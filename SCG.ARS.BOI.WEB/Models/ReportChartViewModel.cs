using NLog.Time;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SCG.ARS.BOI.WEB.Models
{
    public class ReportChartViewModel
    {
        public string SMCreateDate { get; set; }
        public int NumberofSM { get; set; }
        
    }

    public class BarChartData
    {
        public string[] labels { get; set; }
        public string[] Multilabels { get; set; }
        public BarChartDataSet[] datasets { get; set; }
        public int countData { get; set; }
    }

    public class BarChartNPData
    {
        public string[] labels { get; set; }
        public string[] Multilabels { get; set; }
        public BarChartNPDataSet[] datasets { get; set; }
    }

    public class BarChartIntegerData
    {
        public string[] labels { get; set; }
        public string[] Multilabels { get; set; }
        public BarChartIntegerDataSet[] datasets { get; set; }

        public static implicit operator BarChartIntegerData(BarChartData v)
        {
            throw new NotImplementedException();
        }
        public int countData { get; set; }
    }

    public class BarChartNumericData
    {
        public string[] labels { get; set; }
        public string[] Multilabels { get; set; }
        public BarChartDataSet[] datasets { get; set; }

        public static implicit operator BarChartNumericData(BarChartData v)
        {
            throw new NotImplementedException();
        }
    }

    public class BarChartDataSet
    {
        public string type { get; set; }
        public string stack { get; set; }
        public string label { get; set; }
        public double[] data { get; set; }
        public string[] backgroundColor { get; set; }
        public string[] borderColor { get; set; }
        public string yAxisID { get; set; }
        public int borderWidth { get; set; }
        public datalabelsModel datalabels { get; set; }
    }


    public class BarChartNPDataSet
    {
        public string type { get; set; }
        public string stack { get; set; }
        public string label { get; set; }
        public double[] data { get; set; }
        public string[] backgroundColor { get; set; }
        public string[] borderColor { get; set; }
        public string yAxisID { get; set; }
        public int borderWidth { get; set; }
        public int radius { get; set; }
        public datalabelsModel datalabels { get; set; }
    }

    public class BarChartIntegerDataSet
    {
        public string type { get; set; }
        public string label { get; set; }
        public int[] data { get; set; }
        //public string borderDash { get; set; }
        public string[] backgroundColor { get; set; }
        public string[] borderColor { get; set; }
        public int borderWidth { get; set; }
        public string yAxisID { get; set; }
        public datalabelsModel datalabels { get; set; }
        public int order { get; set; }
    }

    public class datalabelsModel
    {
        private bool _myVal = false;
        public string align { get; set; }
        public string anchor { get; set; }
        [DefaultValue(false)]
        public bool display { get 
            {
                return _myVal;
            } 
            set
            {
                _myVal = value;
            } 
        } 
    }

    public class BarChartIntegerDataSetTest
    {
        public string type { get; set; }
        public string label { get; set; }
        public int[] data { get; set; }
        public string[] backgroundColor { get; set; }
        public string[] borderColor { get; set; }
        public int borderWidth { get; set; }
        public string yAxisID { get; set; }
        public datalabelsModelTest datalabels { get; set; }
        public int order { get; set; }
    }

    public class datalabelsModelTest
    {
        public string align { get; set; }
        public string anchor { get; set; }
        [DefaultValue(false)]
        public string display { get; set; }
    }


    public class BarChartIntegerDataTest
    {
        public string[] labels { get; set; }
        public string[] Multilabels { get; set; }
        public BarChartIntegerDataSetTest[] datasets { get; set; }

        public static implicit operator BarChartIntegerDataTest(BarChartData v)
        {
            throw new NotImplementedException();
        }
        public int countData { get; set; }
    }

}