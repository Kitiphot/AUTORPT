using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class TreeView
    {
        private bool _selectable = true;
        private bool _showAddButton = false;
        private bool _showEditButton = false;
        private bool _showCopyButton = false;
        private bool _showRemoveButton = false;

        public int id { get; set; }
        public string Text { get; set; }
        public string function { get; set; }
        public bool Selectable { get { return _selectable; } set { _selectable = value; } }
        public bool ShowAddButton { get { return _showAddButton; } set { _showAddButton = value; } }
        public bool ShowEditButton { get { return _showEditButton; } set { _showEditButton = value; } }
        public bool ShowCopyButton { get { return _showCopyButton; } set { _showCopyButton = value; } }
        public bool ShowRemoveButton { get { return _showRemoveButton; } set { _showRemoveButton = value; } }
        public string[] tags { get; set; }
        public TemplateReportMapping data { get; set; }
        public List<TreeView> nodes { get; set; }
    }
}
