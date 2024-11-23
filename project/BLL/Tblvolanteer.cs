using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace project.BLL
{
    public class TblVolanteer:GeneralRow
    {
        private string volanteerid;
        private string firstname;
        private string lastname;
        private string street;
        private int housenum;
        private int citycode;
        private string volanteerphone;
        private int statusv;
        private string message;
        private int sumg;
       



    

        public int Sumg
        {
            get { return sumg; }
            set { sumg = value; }
        }



        private int points;

      

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public int Statusv
        {
            get { return statusv; }
            set { statusv = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public string Volanteerid
        {
            get { return volanteerid; }
            set
            {
                volanteerid = value;
            }
        }
        

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
       

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        

        public int Housenum
        {
            get { return housenum; }
            set { housenum = value; }
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
        

    
        

      

   
        public TblCity City
        {
            get { return MyDB.City.GetList().FirstOrDefault(x => x.Citycode == this.Citycode); }
        }
      

        public TblVolanteer() { }
        public TblVolanteer(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.volanteerid =row["volanteerid"].ToString();
            this.firstname = row["firstname"].ToString();
            this.lastname = row["lastname"].ToString();
            this.street = row["street"].ToString();
            this.housenum = Convert.ToInt32(row["housenum"]);
            this.citycode = Convert.ToInt32(row["citycode"]);
            this.volanteerphone = row["volanteerphone"].ToString();
            this.statusv = Convert.ToInt32(row["statusv"]);
         
            this.message = row["message"].ToString();
            this.sumg = Convert.ToInt32(row["sumg"]);
            this.points = Convert.ToInt32(row["points"]);

        }
        public override void FillDataRow()
        {
            row["volanteerid"] = this.volanteerid;
            row["firstname"] = this.firstname;
            row["lastname"] = this.lastname;
            row["street"] = this.street;
            row["housenum"] = this.housenum;
            row["citycode"] = this.citycode;
            row["volanteerphone"] = this.volanteerphone;
            row["statusv"]=this.statusv;
         
            row["message"]=this.message;
            row["points"]=this.points;
            row["sumg"] = this.sumg;
        }
    }
}
