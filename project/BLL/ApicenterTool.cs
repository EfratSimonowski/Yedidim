using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public  class Tblapicenterproduct:GeneralRow
    {
        private int apicenterproductcode;
        private int toolcode;
        private int apicentercode;
        private int apicenteramount;
        private int amountinstock;

        

        public int Apicenterproductcode
        {
            get { return apicenterproductcode; }
            set { apicenterproductcode = value; }
        }
        

        public int Toolcode
        {
            get { return toolcode; }
            set { toolcode = value; }
        }

        

        public int Apicentercode
        {
            get { return apicentercode; }
            set { apicentercode = value; }
        }
        

        public int Apicenteramount
        {
            get { return apicenteramount; }
            set { apicenteramount = value; }
        }

        

        public int Amountinstock
        {
            get { return amountinstock; }
            set { amountinstock = value; }
        }

        public Tblapicenterproduct()
        { }
        public Tblapicenterproduct(DataRow row) : base(row) { }

        protected override void FillFields()
        {
            this.apicenterproductcode = Convert.ToInt32(row["apicenterproductcode"]);
            this.toolcode = Convert.ToInt32(row["toolcode"]);
            this.apicentercode = Convert.ToInt32(row["apicentercode"]);
            this.apicenteramount = Convert.ToInt32(row["apicenteramount"]);
            this.amountinstock = Convert.ToInt32(row["amountinstock"]);
        }
        public override void FillDataRow()
        {
            row["apicenterproductcode"] = this.apicenterproductcode;
            row["toolcode"] = this.toolcode;
            row["apicentercode"] = this.apicentercode;
            row["apicenteramount"] = this.apicenteramount;
            row["amountinstock"] = this.amountinstock;
        }
    }
}
