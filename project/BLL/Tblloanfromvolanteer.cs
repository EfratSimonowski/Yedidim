using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblLoanFromVolanteer:GeneralRow
    {
        private int loancode;
        private DateTime dateofloan;       
        private int productcode;
        private string volanteerid;
        private bool raturned;
        private int citycode;
        private string volanteerphone;

        public int Loancode
        {
            get { return loancode; }
            set { loancode = value; }
        }
        

        public DateTime Dateofloan
        {
            get { return dateofloan; }
            set { dateofloan = value; }
        }
        

     
        public int Productcode
        {
            get { return productcode; }
            set { productcode = value; }
        }
        

        public string Volanteerid
        {
            get { return volanteerid; }
            set { volanteerid = value; }
        }
       

        public bool Raturned
        {
            get { return raturned; }
            set { raturned = value; }
        }
        

        public int Citycode
        {
            get { return citycode; }
            set { citycode = value; }
        }
       

        public string Volanteerphone
        {
            get { return volanteerphone; }
            set { volanteerphone = value; }
        }

        public TblCity city
        {
            get { return MyDB.City.GetList().FirstOrDefault(x => x.Citycode == this.Citycode); }
        }
        public TblProductVolanteer productVolanteer
        {
            get { return MyDB.ProductVolanteer.GetList().FirstOrDefault(x => x.Productcode == this.productcode); }
        }
        public TblVolanteer ThisVolanteer
        {
            get { return MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == this.Volanteerid); }
        }
       
        public TblLoanFromVolanteer() { }
        public TblLoanFromVolanteer(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.loancode = Convert.ToInt32(row["loancode"]);
            this.dateofloan = Convert.ToDateTime(row["dateofloan"]);          
            this.productcode = Convert.ToInt32(row["productcode"]);
            this.volanteerid =row["volanteerid"].ToString();
            this.raturned = Convert.ToBoolean(row["raturned"]);
            this.citycode = Convert.ToInt32(row["citycode"]);
            this.volanteerphone = row["volanteerphone"].ToString();
        }
        public override void FillDataRow()
        {
            row["loancode"] = this.loancode;
            row["dateofloan"] = this.dateofloan;         
            row["productcode"] = this.productcode;
            row["volanteerid"] = this.volanteerid;
            row["raturned"] = this.raturned;
            row["citycode"] = this.citycode;
            row["volanteerphone"] = this.volanteerphone;

        }

    }
}
