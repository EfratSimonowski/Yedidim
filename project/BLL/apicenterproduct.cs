using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public  class apicenterproduct:GeneralRow
    {
        private int codepicenterproduct;
        private int codetool;
        private int epicentercode;
        private int epicenteramount;
        private int amountinstock;

        

        public int Codepicenterproduct
        {
            get { return codepicenterproduct; }
            set { codepicenterproduct = value; }
        }
        

        public int Codetool
        {
            get { return codetool; }
            set { codetool = value; }
        }

        

        public int Epicentercode
        {
            get { return epicentercode; }
            set { epicentercode = value; }
        }
        

        public int Epicenteramount
        {
            get { return epicenteramount; }
            set { epicenteramount = value; }
        }

        

        public int Amountinstock
        {
            get { return amountinstock; }
            set { amountinstock = value; }
        }

        public apicenterproduct()
        { }
        public apicenterproduct(DataRow row) : base(row) { }

        protected override void FillFields()
        {
            this.codepicenterproduct = Convert.ToInt32(row["codepicenterproduct"]);
            this.codetool = Convert.ToInt32(row["codetool"]);
            this.epicentercode = Convert.ToInt32(row["epicentercode"]);
            this.epicenteramount = Convert.ToInt32(row["epicenteramount"]);
            this.amountinstock = Convert.ToInt32(row["amountinstock"]);
        }
        public override void FillDataRow()
        {
            row["codepicenterproduct"] = this.codepicenterproduct;
            row["codetool"] = this.codetool;
            row["epicentercode"] = this.epicentercode;
            row["epicenteramount"] = this.epicenteramount;
            row["amountinstock"] = this.amountinstock;
        }
    }
}
