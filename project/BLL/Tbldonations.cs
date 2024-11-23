using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblDonations:GeneralRow
    {
        private int donationcode;
        private string donorcode;
        private int toolcode;
        private DateTime datedonation;
        private int amountd;
        private int sumd;
        private int apicentercode;
        private int citycode;

        

        public int Donationcode
        {
            get { return donationcode; }
            set { donationcode = value; }
        }
        

        public string Donorcode
        {
            get { return donorcode; }
            set { donorcode = value; }
        }
        

        public int Toolcode
        {
            get { return toolcode; }
            set { toolcode = value; }
        }
        

        public DateTime Datedonation
        {
            get { return datedonation; }
            set { datedonation = value; }
        }
        

        public int Amountd
        {
            get { return amountd; }
            set { amountd = value; }
        }
        

        public int Sumd
        {
            get { return sumd; }
            set { sumd = value; }
        }
        
      

        public int Apicentercode
        {
            get { return apicentercode; }
            set { apicentercode = value; }
        }

        public int Citycode
        {
            get { return citycode; }
            set { citycode = value; }
        }
        public TblTools tools
        {
            get { return MyDB.Tools.GetList().FirstOrDefault(x => x.Toolcode == this.toolcode); }
        }
       

        public TblDonations() { }
        public TblDonations(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.donationcode = Convert.ToInt32(row["donationcode"]);
            this.donorcode = row["donorcode"].ToString();
            this.toolcode = Convert.ToInt32(row["toolcode"]);
            this.datedonation = Convert.ToDateTime(row["datedonation"]);
            this.amountd = Convert.ToInt32(row["amountd"]);
            this.sumd = Convert.ToInt32(row["sumd"]);
            this.apicentercode = Convert.ToInt32(row["apicentercode"]);
            this.citycode = Convert.ToInt32(row["citycode"]);
        }
        public override void FillDataRow()
        {
            row["donationcode"] = this.donationcode;
            row["donorcode"] = this.donorcode;
            row["toolcode"] = this.toolcode;
            row["datedonation"] = this.datedonation;
            row["amountd"] = this.amountd;
            row["sumd"] = this.sumd;
            row["apicentercode"] = this.apicentercode;
            row["citycode"] = this.citycode;
        }






    }
}
