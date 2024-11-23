using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
   public class TblProductVolanteer:GeneralRow
    {
        private int productcode;
        private int toolcode;
        private string volanteerid;
        private int amountprov;
        public int Amountprov
        {
            get { return amountprov; }
            set { amountprov = value; }
        }

        public int Productcode
        {
            get { return productcode; }
            set { productcode = value; }
        }
        

        public int Toolcode
        {
            get { return toolcode; }
            set { toolcode = value; }
        }

        public string Volanteerid
        {
            get { return volanteerid; }
            set { volanteerid = value; }
        }
       
        public TblVolanteer ThisVolanteer
        {
            get { return MyDB.Volanteer.GetList().FirstOrDefault(x=>x.Volanteerid == this.volanteerid); }
        }
        public TblTools tools
        {
            get { return MyDB.Tools.GetList().FirstOrDefault(x => x.Toolcode == this.toolcode); }
        }
        public TblProductVolanteer() { }
        public TblProductVolanteer(DataRow row) : base(row) { }
        protected override void FillFields()
        {
            this.productcode = Convert.ToInt32(row["productcode"]);
            this.toolcode = Convert.ToInt32(row["toolcode"]);
            this.volanteerid = row["volanteerid"].ToString();
            this.amountprov = Convert.ToInt32(row["amountprov"]);
        }
        public override void FillDataRow()
        {
            row["productcode"]= this.productcode;
            row["volanteerid"]= this.volanteerid;
            row["toolcode"]= this.toolcode;
            row["amountprov"] = this.amountprov;
        }
    }
}
