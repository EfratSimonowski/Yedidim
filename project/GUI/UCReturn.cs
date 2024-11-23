using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BLL;

namespace project.GUI
{
    public partial class וןןן : UserControl
    {
        string vid;
        TblLoanApicenter currentloanapi;
        TblApicenterProduct currentproduct;
        public וןןן()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.LoanApicenter.GetList().ToList();
            if (MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Volanteerid == vid) != null)
            {
                dataGridView1.DataSource = MyDB.LoanApicenter.GetList().Where(x => x.Volanteerid == vid && x.Returnedproduct != true).Select(x => new {קוד=x.Loanapicentercode, תאריך = x.Dateloanepicenter, פלאפון = x.volanteer.Volanteerphone, עיר = x.apicenterProduct.city.Cityname, מוצר = x.apicenterProduct.tools.Toolname, תעודת_זהות = x.Volanteerid }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
            currentproduct = new TblApicenterProduct();
            currentloanapi = new TblLoanApicenter();
        }
        public וןןן(string vid)
        {
            InitializeComponent();
            this.vid = vid;
            currentproduct = new TblApicenterProduct();
            currentloanapi = new TblLoanApicenter();
            dataGridView1.DataSource = MyDB.LoanApicenter.GetList().ToList();
            if (MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Volanteerid == vid) != null)
            {
                dataGridView1.DataSource = MyDB.LoanApicenter.GetList().Where(x => x.Volanteerid == vid && x.Returnedproduct!= true).Select(x => new {קוד=x.Loanapicentercode, תאריך = x.Dateloanepicenter, פלאפון = x.volanteer.Volanteerphone, עיר = x.apicenterProduct.city.Cityname, מוצר = x.apicenterProduct.tools.Toolname, תעודת_זהות = x.Volanteerid }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;
            }         
        }

        private void combocity_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCVolanteer up = new UCVolanteer(vid);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //currentloanapi = MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Loanapicentercode ==Convert.ToInt32( dataGridView1.CurrentRow.Cells["קוד"].Value));           
            currentproduct = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.apicenter.Apicenterstreet == currentloanapi.apicenterProduct.apicenter.Apicenterstreet);
            currentproduct.Amountinstock = Convert.ToInt32(currentproduct.Amountinstock + 1);
            MyDB.ApicenterProduct.UpdateItem(currentproduct);
            MyDB.ApicenterProduct.SaveChanges();
            currentloanapi.Returnedproduct = true;
            MyDB.LoanApicenter.UpdateItem(currentloanapi);
            MyDB.LoanApicenter.SaveChanges();
            MessageBox.Show("המוצר הוחזר בהצלחה ");
            dataGridView1.DataSource = MyDB.LoanApicenter.GetList().Where(x => x.Returnedproduct != true && x.Volanteerid==vid).Select(x => new {קוד=x.Loanapicentercode, תאריך = x.Dateloanepicenter, פלאפון = x.volanteer.Volanteerphone, עיר = x.apicenterProduct.city.Cityname, מוצר = x.apicenterProduct.tools.Toolname,תעודת_זהות=x.Volanteerid }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentloanapi = MyDB.LoanApicenter.GetList().FirstOrDefault(x => x.Loanapicentercode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));

        }
    }
}
