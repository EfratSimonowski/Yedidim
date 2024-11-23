using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblDonors : GeneralRow

    {
        private string donorcode;
        private string firstnamedonor;
        private string lastnamedonor;
        private string donorphone;
        private string donorstreet;
        private int donorhousenum;
        private int citycode;



        public string Donorcode
        {
            get { return donorcode; }
            set {
                donorcode = value;
               
            }
        }
       

        public string Firstnamedonor
        {
            get { return firstnamedonor; }
            set { firstnamedonor = value; }
        }
       

        public string Lastnamedonor
        {
            get { return lastnamedonor; }
            set { lastnamedonor = value; }
        }
       

        public string Donorphone
        {
            get { return donorphone; }
            set { donorphone = value; }
        }
       

        public string Donorstreet
        {
            get { return donorstreet; }
            set { donorstreet = value; }
        }
      

        public int Donorhousenum
        {
            get { return donorhousenum; }
            set { donorhousenum = value; }
        }

       

        public int Citycode
        {
            get { return citycode; }
            set { citycode = value; }
        }

        public object Cities { get; internal set; }

        public TblDonors() { }
        public TblDonors(DataRow row) : base(row) { }

        protected override void FillFields()
        {
            this.donorcode = row["donorcode"].ToString();
            this.firstnamedonor = row["firstnamedonor"].ToString();
            this.lastnamedonor = row["lastnamedonor"].ToString();
            this.donorphone = row["donorphone"].ToString();
            this.donorstreet = row["donorstreet"].ToString();
            this.donorhousenum = Convert.ToInt32(row["donorhousenum"]);
            this.citycode = Convert.ToInt32(row["citycode"]);
        }
        public override void FillDataRow()
        {
            row["donorcode"] = this.donorcode;
            row["firstnamedonor"] = this.firstnamedonor;
            row["lastnamedonor"] = this.lastnamedonor;
            row["donorphone"] = this.donorphone;
            row["donorstreet"] = this.donorstreet;
            row["donorhousenum"] = this.donorhousenum;
            row["citycode"] = this.citycode;
           
        }
    }
        
}
