using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    public class TblEvent:GeneralRow
    {
        private int eventcode;
        private DateTime datevent;
        private DateTime eventime;
        private string clientname;
        private string streetc;
        private int housenumc;
        private int citycode;
       
        private string reason;
        private string volanteerid;
        private int statuscode;
        private int ratingservice;
        private string comment;
        private string clientphone;


        public int Eventcode
        {
            get { return eventcode; }
            set { eventcode = value; }
        }
       

        public DateTime Datevent
        {
            get { return datevent; }
            set { datevent = value; }
        }
      

        public DateTime Eventime
        {
            get { return eventime; }
            set { eventime = value; }
        }
        

        public string Clientname
        {
            get { return clientname; }
            set { clientname = value; }
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
        

        public int Citycode
        {
            get { return citycode; }
            set { citycode = value; }
        }
       

       
        

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        

        public string Volanteerid
        {
            get { return volanteerid; }
            set { volanteerid = value; }
        }
        

        public int Statuscode
        {
            get { return statuscode; }
            set { statuscode = value; }
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
        

        public string Clientphone
        {
            get { return clientphone; }
            set { clientphone = value; }
        }
        public TblCity city
        {
            get { return MyDB.City.GetList().FirstOrDefault(x=>x.Citycode==this.Citycode); }
        }

        public TblEvent() { }
        public TblEvent(DataRow row) : base(row) { }

        protected override void FillFields()
        {
            this.eventcode = Convert.ToInt32(row["eventcode"]);
            this.datevent = Convert.ToDateTime(row["datevent"]);
            this.eventime = Convert.ToDateTime(row["eventime"]);
            this.clientname = row["clientname"].ToString();
            this.streetc = row["streetc"].ToString();
            this.housenumc = Convert.ToInt32(row["housenumc"]);
            this.citycode = Convert.ToInt32(row["citycode"]);
            
            this.reason = row["reason"].ToString();
            this.volanteerid =row["volanteerid"].ToString();
            this.statuscode = Convert.ToInt32(row["statuscode"]);
            this.ratingservice = Convert.ToInt32(row["ratingservice"]);
            this.comment = row["comment"].ToString();
            this.clientphone = row["clientphone"].ToString() ;
        }
        public override void FillDataRow()
        {
            row["eventcode"] = this.eventcode;
            row["datevent"] = this.datevent;
            row["eventime"] =this.eventime;
            row["clientname"] =this.clientname;
            row["streetc"] = this.streetc;
            row["housenumc"] = this.housenumc;
            row["citycode"] = this.citycode;
         
            row["reason"] = this.reason;
            row["volanteerid"] = this.volanteerid;
            row["statuscode"] = this.statuscode;
            row["ratingservice"] = this.ratingservice;
            row["comment"]=this.comment;
            row["clientphone"]=this.clientphone;
        }
    }
}
