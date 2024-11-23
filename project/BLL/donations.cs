using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class donations:GeneralRow
    {
        private int codedonation;
        private int codedonor;
        private int codetool;
        private DateTime datedonation;
        private int amount;

        

        public int Codedonation
        {
            get { return codedonation; }
            set { codedonation = value; }
        }
        

        public int Codedonor
        {
            get { return codedonor; }
            set { codedonor = value; }
        }
        

        public int Codetool
        {
            get { return codetool; }
            set { codetool = value; }
        }
        

        public DateTime Datedonation
        {
            get { return datedonation; }
            set { datedonation = value; }
        }
        

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public donations() { }
        public donations(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.codedonation = Convert.ToInt32(row["codedonation"]);
            this.codedonor = Convert.ToInt32(row["codedonor"]);
            this.codetool = Convert.ToInt32(row["codetool"]);
            this.datedonation = Convert.ToDateTime(row["datedonation"]);
            this.amount = Convert.ToInt32(row["amount"]);
        }
        public override void FillDataRow()
        {
            row["codedonation"] = this.codedonation;
            row["codedonor"] = this.codedonor;
            row["codetool"] = this.codetool;
            row["datedonation"] = this.datedonation;
            row["amount"] = this.amount;
        }






    }
}
