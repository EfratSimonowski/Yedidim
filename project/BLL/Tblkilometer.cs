using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblKilometer:GeneralRow
    {
        private int moneydonationcode;
        private string donorcode;
        private DateTime datedonation;
        private int sumdd;


       

        public int Sumdd
        {
            get { return sumdd; }
            set { sumdd = value; }
        }


        public DateTime Datedonation
        {
            get { return datedonation; }
            set { datedonation = value; }
        }

        public int Moneydonationcode
        {
            get { return moneydonationcode; }
            set { moneydonationcode = value; }
        }


        public string Donorcode
        {
            get { return donorcode; }
            set { donorcode = value; }
        }
        public TblKilometer() { }
        public TblKilometer(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.moneydonationcode = Convert.ToInt32(row["moneydonationcode"]);
            this.donorcode = row["donorcode"].ToString();
            this.datedonation = Convert.ToDateTime(row["datedonation"]);
            this.sumdd = Convert.ToInt32(row["sumdd"]);
        }
        public override void FillDataRow()
        {
           row["moneydonationcode"] =this.moneydonationcode;
           row["donorcode"] = this.donorcode;
            row["datedonation"] = this.datedonation;
            row["sumdd"] = this.sumdd;

        }
    }
}
