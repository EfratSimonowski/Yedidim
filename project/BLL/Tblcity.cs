using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblCity:GeneralRow
    {
        private int citycode;
        private string cityname;

        

        public int Citycode
        {
            get { return citycode; }
            set { citycode = value; }
        }
        

        public string Cityname
        {
            get { return cityname; }
            set { cityname = value; }
        }
        public TblCity() { }
        public TblCity(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.citycode = Convert.ToInt32(row["citycode"]);
            this.cityname = row["cityname"].ToString();
        }
        public override void FillDataRow()
        {
            row["citycode"] = this.citycode;
            row["cityname"] = this.cityname;
        }
        public TblCity Cities
        {
            get
            {
                return MyDB.City.GetList().FirstOrDefault(x => x.Citycode == this.Citycode);
            }
        }
    }
}
