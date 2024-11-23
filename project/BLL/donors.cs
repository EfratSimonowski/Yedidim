using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class donors : GeneralRow

    {
        private string codedonor;
        private string firstnamedonor;
        private string lastnamedonor;
        private int phonedonor;
        private string streetdonor;
        private int housenumdonor;
        private int codecity;



        public string Codedonor
        {
            get { return codedonor; }
            set { codedonor = value; }
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
       

        public int Phonedonor
        {
            get { return phonedonor; }
            set { phonedonor = value; }
        }
       

        public string Streetdonor
        {
            get { return streetdonor; }
            set { streetdonor = value; }
        }
      

        public int Housenumdonor
        {
            get { return housenumdonor; }
            set { housenumdonor = value; }
        }

       

        public int Codecity
        {
            get { return codecity; }
            set { codecity = value; }
        }

        public donors() { }
        public donors(DataRow row) : base(row) { }

        protected override void FillFields()
        {
            this.codedonor = row["codedonor"].ToString();
            this.firstnamedonor = row["firstnamedonor"].ToString();
            this.lastnamedonor = row["lastnamedonor"].ToString();
            this.phonedonor = Convert.ToInt32(row["phonedonor"]);
            this.streetdonor = row["streetdonor"].ToString();
            this.housenumdonor = Convert.ToInt32(row["housenumdonor"]);
            this.codecity = Convert.ToInt32(row["codecity"]);
        }
        public override void FillDataRow()
        {
            row["codedonor"] = this.codedonor;
            row["firstnamedonor"] = this.firstnamedonor;
            row["lastnamedonor"] = this.lastnamedonor;
            row["phonedonor"] = this.phonedonor;
            row["streetdonor"] = this.streetdonor;
            row["housenumdonor"] = this.housenumdonor;
            row["codecity"] = this.codecity;
        }
    }
        
}
