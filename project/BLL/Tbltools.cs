using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblTools:GeneralRow
    {
        private int toolcode;
        private string toolname;
        private int toolprice;
        

        public int Toolcode
        {
            get { return toolcode; }
            set { toolcode = value; }
        }
       

        public string Toolname
        {
            get { return toolname; }
            set { toolname = value; }
        }
        

        public int Toolprice
        {
            get { return toolprice; }
            set { toolprice = value; }
        }
        public TblTools() { }
        public TblTools(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.toolcode = Convert.ToInt32(row["toolcode"]);
            this.toolname = row["toolname"].ToString();
            this.toolprice = Convert.ToInt32(row["toolprice"]);
        }
        public override void FillDataRow()
        {
            row["toolcode"] = this.toolcode;
            row["toolname"] = this.toolname;
            row["toolprice"] = this.toolprice;
        }
    }
}
