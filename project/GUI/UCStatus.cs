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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project.GUI
{
    public partial class UCStatus : UserControl
    {
        TblProductVolanteer currentpv;
        TblLoanFromVolanteer currentloanvolanteer;
        string vId;
        public UCStatus()
        {
            InitializeComponent();
            currentloanvolanteer = new TblLoanFromVolanteer();
            currentpv = new TblProductVolanteer();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            comboBox2.DataSource = MyDB.Tools.GetList().Select(X => X.Toolname).ToList();
            dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד=x.Productcode,עיר = x.ThisVolanteer.City.Cityname,  מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }
        public UCStatus(string vId)
        {
            InitializeComponent();
            this.vId = vId; currentloanvolanteer = new TblLoanFromVolanteer();
            currentpv = new TblProductVolanteer();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            comboBox2.DataSource = MyDB.Tools.GetList().Select(X => X.Toolname).ToList();
            dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד = x.Productcode, עיר = x.ThisVolanteer.City.Cityname, מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCVolanteer up = new UCVolanteer(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCAddProduct up = new UCAddProduct(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedtool = comboBox2.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.tools.Toolname == selectedtool && x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד = x.Productcode, עיר = x.ThisVolanteer.City.Cityname, מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void combocity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = combocity.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.ThisVolanteer.City.Cityname == c && x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד = x.Productcode, עיר = x.ThisVolanteer.City.Cityname, מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void UCStatus_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד = x.Productcode, עיר = x.ThisVolanteer.City.Cityname, מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
            if (dataGridView1.RowCount != 0)
            {
                //currentpv = MyDB.ProductVolanteer.GetList().FirstOrDefault(x => x.Productcode ==Convert.ToInt32( dataGridView1.CurrentRow.Cells["קוד"].Value));
                if (currentpv.Volanteerid == vId)
                {
                    DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את מוצר?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                    MyDB.ProductVolanteer.DeleteItem(currentpv);
                    MyDB.ProductVolanteer.SaveChanges();
                    //dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { מוצר = x.tools.Toolname, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
                    MessageBox.Show("המוצר נמחק בהצלחה!");
                    dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד = x.Productcode, עיר = x.ThisVolanteer.City.Cityname, x.ThisVolanteer.Volanteerid, מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
                        dataGridView1.Columns["קוד"].Visible = false;
                    }
                   }
                else
                {
                    MessageBox.Show("אפשרות המחיקה למנהל המוקד בלבד ");
                }
            }
            else
            {
                MessageBox.Show("לא נבחר מוצר");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד = x.Productcode, עיר = x.ThisVolanteer.City.Cityname, מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
            if (dataGridView1.RowCount != 0)
            {
               
                //currentpv = MyDB.ProductVolanteer.GetList().FirstOrDefault(x => x.Productcode== Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
                currentloanvolanteer.Productcode = currentpv.Productcode;
                currentloanvolanteer.Loancode = MyDB.LoanFromVolanteer.GetNextKey();
                currentloanvolanteer.Dateofloan = DateTime.Today;
               
                currentloanvolanteer.Raturned = false;
                currentloanvolanteer.Volanteerid = vId;
                currentloanvolanteer.Volanteerphone = currentpv.ThisVolanteer.Volanteerphone;
                currentloanvolanteer.Citycode = currentpv.ThisVolanteer.City.Citycode;
                MyDB.LoanFromVolanteer.AddItem(currentloanvolanteer);
                MyDB.LoanFromVolanteer.SaveChanges();
                currentpv.Amountprov = currentpv.Amountprov - 1;
                MyDB.ProductVolanteer.UpdateItem(currentpv);
                MyDB.ProductVolanteer.SaveChanges();
                dataGridView1.DataSource = MyDB.ProductVolanteer.GetList().Where(x => x.Amountprov != 0 && x.Amountprov > 0).Select(x => new { קוד = x.Productcode, עיר = x.ThisVolanteer.City.Cityname, x.ThisVolanteer.Volanteerid, מוצר = x.tools.Toolname, רחוב = x.ThisVolanteer.Street, פלאפון = x.ThisVolanteer.Volanteerphone }).ToList();
                dataGridView1.Columns["קוד"].Visible = false;
                MessageBox.Show("המוצר הושאל בהצלחה");
                }
                else
                {
                    MessageBox.Show("לא נבחר מוצר");
                }
            }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentpv = MyDB.ProductVolanteer.GetList().FirstOrDefault(x => x.Productcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
        }
    }

       
    }

