using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblStatus:GeneralRow
    {
        private int statuscode;
        private string statusname;
        
        public int Statuscode
        {
            get { return statuscode; }
            set { statuscode = value; }
        }
       

        public string Statusname
        {
            get { return statusname; }
            set { statusname = value; }
        }
        public TblStatus() { }
        public TblStatus(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.statuscode = Convert.ToInt32(row["statuscode"]);
            this.statusname = row["statusname"].ToString();
        }
        public override void FillDataRow()
        {
            row["statuscode"] = this.statuscode;
            row["statusname"] = this.statusname;
        }
    }
}
