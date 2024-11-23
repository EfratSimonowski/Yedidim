using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public  class TblApicenterProduct:GeneralRow
    {
        private int apicenterproductcode;
        private int toolcode;
        private int apicentercode;
        private int apicenteramount;
        private int amountinstock;
        private int citycode;
        private string phonem;

     

        public string Phonem
        {
            get { return phonem; }
            set { phonem = value; }
        }

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
       

        public int Citycode
        {
            get { return citycode; }
            set { citycode = value; }
        }
        public TblCity city
        {
            get { return MyDB.City.GetList().FirstOrDefault(x => x.Citycode == this.Citycode); }
        }
        public TblTools tools
        {
            get { return MyDB.Tools.GetList().FirstOrDefault(x => x.Toolcode == this.toolcode); }
        }
        public TblApicenter apicenter
        {
            get { return MyDB.Apicenter.GetList().FirstOrDefault(x => x.Apicentercode == this.apicentercode); }
        }

        public TblApicenterProduct()
        { }
        public TblApicenterProduct(DataRow row) : base(row) { }

        protected override void FillFields()
        {
            this.phonem = row["phonem"].ToString();
            this.apicenterproductcode = Convert.ToInt32(row["apicenterproductcode"]);
            this.toolcode = Convert.ToInt32(row["toolcode"]);
            this.apicentercode = Convert.ToInt32(row["apicentercode"]);
            this.apicenteramount = Convert.ToInt32(row["apicenteramount"]);
            this.amountinstock = Convert.ToInt32(row["amountinstock"]);
            this.citycode = Convert.ToInt32(row["citycode"]);
        }
        public override void FillDataRow()
        {
            row["phonem"] = this.phonem;
            row["apicenterproductcode"] = this.apicenterproductcode;
            row["toolcode"] = this.toolcode;
            row["apicentercode"] = this.apicentercode;
            row["apicenteramount"] = this.apicenteramount;
            row["amountinstock"] = this.amountinstock;
            row["citycode"]=this.citycode;
        }
    }
}
