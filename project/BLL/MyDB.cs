using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project.BLL
{
    class MyDB
    {
        public static TblApicenterTable Apicenter = new TblApicenterTable();
        public static TblApicenterProductTable ApicenterProduct = new TblApicenterProductTable();
        public static TblCityTable City = new TblCityTable();
        public static TblDonationsTable Donations = new TblDonationsTable();
        public static TblDonorsTable Donors = new TblDonorsTable();
        public static TblEventTable Event = new TblEventTable();
        public static TblKilometerTable Kilometer = new TblKilometerTable();
        public static TblLoanApicenterTable LoanApicenter = new TblLoanApicenterTable();
        public static TblLoanFromVolanteerTable LoanFromVolanteer = new TblLoanFromVolanteerTable();
        public static TblProductVolanteerTable ProductVolanteer = new TblProductVolanteerTable();
        public static TblStatusTable Status = new TblStatusTable();
        public static TblToolsTable Tools = new TblToolsTable();
        public static TblVolanteerTable Volanteer = new TblVolanteerTable();
    }
}
