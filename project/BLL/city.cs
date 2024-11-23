using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class city:GeneralRow
    {
        private int codecity;
        private string namecity;

        

        public int Codecity
        {
            get { return codecity; }
            set { codecity = value; }
        }
        

        public string Namecity
        {
            get { return namecity; }
            set { namecity = value; }
        }
        public city() { }
        public city(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.codecity = Convert.ToInt32(row["codecity"]);
            this.namecity = row["namecity"].ToString();
        }
        public override void FillDataRow()
        {
            row["codecity"] = this.codecity;
            row["namecity"] = this.namecity;
        }
            
    }
}
