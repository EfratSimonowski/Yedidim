using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblLoanApicenter:GeneralRow
    {
        private int loanapicentercode;
        private string volanteerid;
        private int apicenterproductcode;
        private DateTime dateloanepicenter;
        private bool returnedproduct;



        public int Loanapicentercode
        {
            get { return loanapicentercode; }
            set { loanapicentercode = value; }
        }
        

        public string Volanteerid
        {
            get { return volanteerid; }
            set { volanteerid = value; }
        }
        

        public int Apicenterproductcode
        {
            get { return apicenterproductcode; }
            set { apicenterproductcode = value; }
        }
        

        public DateTime Dateloanepicenter
        {
            get { return dateloanepicenter; }
            set { dateloanepicenter = value; }
        }
        

        public bool Returnedproduct
        {
            get { return returnedproduct; }
            set { returnedproduct = value; }
        }
        public TblApicenterProduct apicenterProduct
        {
            get { return MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.Apicenterproductcode == this.apicenterproductcode); }
        }
        public TblVolanteer volanteer
        {
            get { return MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == this.volanteerid); }
        }


        public TblLoanApicenter() { }
        public TblLoanApicenter(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.loanapicentercode = Convert.ToInt32(row["loanapicentercode"]);
            this.volanteerid = row["volanteerid"].ToString();
            this.apicenterproductcode = Convert.ToInt32(row["apicenterproductcode"]);
            this.dateloanepicenter = Convert.ToDateTime(row["dateloanepicenter"]);
            this.returnedproduct = Convert.ToBoolean(row["returnedproduct"]);
        }
        public override void FillDataRow()
        {
            row["loanapicentercode"] = this.loanapicentercode;
            row["volanteerid"] = this.volanteerid;
            row["apicenterproductcode"] = this.apicenterproductcode;
            row["dateloanepicenter"] = this.dateloanepicenter;
            row["returnedproduct"] = this.returnedproduct;
        }
    }
}
