using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class Event:GeneralRow
    {
        private int codevent;
        private DateTime datevent;
        private DateTime hourevent;
        private string nameclient;
        private string streetc;
        private int housenumc;
        private int codecity;
        private int codedistance;
        private string reason;
        private int volanteerid;
        private int codestatus;
        private int ratingservice;
        private string comment;


        public int Codevent
        {
            get { return codevent; }
            set { codevent = value; }
        }
       

        public DateTime Datevent
        {
            get { return datevent; }
            set { datevent = value; }
        }
      

        public DateTime Hourevent
        {
            get { return hourevent; }
            set { hourevent = value; }
        }
        

        public string Nameclient
        {
            get { return nameclient; }
            set { nameclient = value; }
        }
        

        public string Streetc
        {
            get { return streetc; }
            set { streetc = value; }
        }
      

        public int Housenumc
        {
            get { return housenumc; }
            set { housenumc = value; }
        }
        

        public int Codecity
        {
            get { return codecity; }
            set { codecity = value; }
        }
       

        public int Codedistance
        {
            get { return codedistance; }
            set { codedistance = value; }
        }
        

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        

        public int Volanteerid
        {
            get { return volanteerid; }
            set { volanteerid = value; }
        }
        

        public int Codestatus
        {
            get { return codestatus; }
            set { codestatus = value; }
        }
        

        public int Ratingservice
        {
            get { return ratingservice; }
            set { ratingservice = value; }
        }
        

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public Event() { }
        public Event(DataRow row) : base(row) { }

        protected override void FillFields()
        {
            this.codevent = Convert.ToInt32(row["codevent"]);
            this.datevent = Convert.ToDateTime(row["datevent"]);
            this.hourevent = Convert.ToDateTime(row["hourevent"]);
            this.nameclient = row["nameclient"].ToString();
            this.streetc = row["streetc"].ToString();
            this.housenumc = Convert.ToInt32(row["housenumc"]);
            this.codecity = Convert.ToInt32(row["codecity"]);
            this.codedistance = Convert.ToInt32(row["codedistance"]);
            this.reason = row["reason"].ToString();
            this.volanteerid = Convert.ToInt32(row["volanteerid"]);
            this.codestatus = Convert.ToInt32(row["codestatus"]);
            this.ratingservice = Convert.ToInt32(row["ratingservice"]);
            this.comment = row["comment"].ToString();
        }
        public override void FillDataRow()
        {
            row["codevent"] = this.codevent;
            row["datevent"] = this.datevent;
            row["hourevent"]=this.hourevent;
            row["nameclient"]=this.nameclient;
            row["streetc"] = this.streetc;
            row["housenumc"] = this.housenumc;
            row["codecity"]= this.codecity;
            row["codedistance"] = this.codedistance;
            row["reason"] = this.reason;
            row["volanteerid"] = this.volanteerid;
            row["codestatus"] = this.codestatus;
            row["ratingservice"] = this.ratingservice;
            row["comment"]=this.comment;
        }
    }
}
