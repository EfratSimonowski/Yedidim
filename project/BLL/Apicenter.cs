using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class Apicenter:GeneralRow
    {
        private int apicentercode;
        private string managerphone;
        private string apicenterstreet;
        private int apicenterhousenum;
        private int citycode;

        

        public int Apicentercode
        {
            get { return apicentercode; }
            set { apicentercode = value; }
        }
       
        public string Managerphone
        {
            get { return managerphone; }
            set { managerphone = value; }
        }
       

        public string Apicenterstreet
        {
            get { return apicenterstreet; }
            set { apicenterstreet = value; }
        }
        

        public int Apicenterhousenum
        {
            get { return apicenterhousenum; }
            set { apicenterhousenum = value; }
        }
     

        public int Citycode
        {
            get { return citycode; }
            set { citycode = value; }
        }
        public Apicenter() { }
        public Apicenter(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.apicentercode = Convert.ToInt32(row["apicentercode"]);
            this.managerphone = row["managerphone"].ToString();
            this.apicenterstreet = row["apicenterstreet"].ToString();
            this.apicenterhousenum = Convert.ToInt32(row["apicenterhousenum"]);
            this.citycode = Convert.ToInt32(row["citycode"]);
        }
        public override void FillDataRow()
        {
            row["apicentercode"] = this.apicentercode;
            row["managerphone"] = this.managerphone;
            row["apicenterstreet"] = this.apicenterstreet;
            row["apicenterhousenum"] = this.apicenterhousenum;
            row["citycode"] = this.citycode;


        }
    }
}
