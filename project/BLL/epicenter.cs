using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class epicenter:GeneralRow
    {
        private int epicentercode;
        private int managerphone;
        private string streetepicenter;
        private int housenumepicenter;
        private int codecity;

        

        public int Epicentercode
        {
            get { return epicentercode; }
            set { epicentercode = value; }
        }
       
        public int Managerphone
        {
            get { return managerphone; }
            set { managerphone = value; }
        }
       

        public string Streetepicenter
        {
            get { return streetepicenter; }
            set { streetepicenter = value; }
        }
        

        public int Housenumepicenter
        {
            get { return housenumepicenter; }
            set { housenumepicenter = value; }
        }
     

        public int Codedity
        {
            get { return codecity; }
            set { codecity = value; }
        }
        public epicenter() { }
        public epicenter(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.epicentercode = Convert.ToInt32(row["epicentercode"]);
            this.managerphone = Convert.ToInt32(row["managerphone"]);
            this.streetepicenter = row["streetepicenter"].ToString();
            this.housenumepicenter = Convert.ToInt32(row["housenumepicenter"]);
            this.codecity = Convert.ToInt32(row["codecity"]);
        }
        public override void FillDataRow()
        {
            row["epicentercode"] = this.epicentercode;
            row["managerphone"] = this.managerphone;
            row["streetepicenter"] = this.streetepicenter;
            row["housenumepicenter"] = this.housenumepicenter;
            row["codecity"] = this.codecity;


        }
    }
}
