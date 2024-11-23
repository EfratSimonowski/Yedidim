using project.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.GUI
{
    public partial class UCReturnv : UserControl
    {
        string vId;
        TblLoanFromVolanteer currentfromvolanteer;
        TblProductVolanteer currentvolanteerpro;
        public UCReturnv()
        {
            InitializeComponent();
            currentvolanteerpro = new TblProductVolanteer();
            currentfromvolanteer = new TblLoanFromVolanteer();
            dataGridView1.DataSource = MyDB.LoanFromVolanteer.GetList();
            if (MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId) != null)
            {
                dataGridView1.DataSource = MyDB.LoanFromVolanteer.GetList().Where(x => x.Volanteerid == vId && x.Raturned != true).Select(x => new { קוד=x.Loancode,תאריך = x.Dateofloan, פלאפון = x.Volanteerphone, עיר = x.city.Cityname, מוצר = x.productVolanteer,תעודת_זהות=x.Volanteerid }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;

            }
          
        }
        public UCReturnv(string vId)
        {
            InitializeComponent();
            currentvolanteerpro = new TblProductVolanteer();
            currentfromvolanteer = new TblLoanFromVolanteer();
            this.vId = vId;
            dataGridView1.DataSource = MyDB.LoanFromVolanteer.GetList();                   
            if (MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId) != null)
            {
                dataGridView1.DataSource = MyDB.LoanFromVolanteer.GetList().Where(x => x.Volanteerid == vId && x.Raturned != true).Select(x => new { קוד = x.Loancode, תאריך = x.Dateofloan,  פלאפון = x.Volanteerphone, עיר = x.city.Cityname, מוצר = x.productVolanteer.tools.Toolname,תעודת_זהות=x.Volanteerid }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UCVolanteer up = new UCVolanteer(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyDB.LoanFromVolanteer.GetList().Where(x => x.Raturned != true && x.Volanteerid == vId).Select(x => new { תאריך = x.Dateofloan, קוד = x.Loancode, פלאפון = x.Volanteerphone, עיר = x.city.Cityname, מוצר = x.productVolanteer.tools.Toolname }).ToList();
            currentfromvolanteer = MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Loancode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
            currentvolanteerpro = MyDB.ProductVolanteer.GetList().FirstOrDefault(x => x.Productcode == currentfromvolanteer.Productcode);
            currentvolanteerpro.Amountprov = Convert.ToInt32(currentvolanteerpro.Amountprov + 1);
            MyDB.ProductVolanteer.UpdateItem(currentvolanteerpro);
            MyDB.ProductVolanteer.SaveChanges();
            currentfromvolanteer.Raturned = true;
            MyDB.LoanFromVolanteer.UpdateItem(currentfromvolanteer);
            MyDB.LoanFromVolanteer.SaveChanges();
            MessageBox.Show("המוצר הוחזר בהצלחה");
            dataGridView1.DataSource = MyDB.LoanFromVolanteer.GetList().Where(x => x.Raturned != true && x.Volanteerid == vId).Select(x => new { תאריך = x.Dateofloan, קוד = x.Loancode, פלאפון = x.Volanteerphone, עיר = x.city.Cityname, מוצר = x.productVolanteer.tools.Toolname }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentfromvolanteer = MyDB.LoanFromVolanteer.GetList().FirstOrDefault(x => x.Loancode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
        }
    }
}
