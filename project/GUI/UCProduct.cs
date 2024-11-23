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
    
    public partial class UCProduct : UserControl
    {
        string vId;
        TblVolanteer currvolan;
        TblApicenterProduct currentpa;
        TblLoanApicenter currentloanapi;       
        public UCProduct()
        {
            InitializeComponent();
            currvolan = new TblVolanteer();
            currentpa = new TblApicenterProduct();
            currentloanapi = new TblLoanApicenter();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            comboBox2.DataSource = MyDB.Tools.GetList().Select(X => X.Toolname).ToList();
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.Amountinstock!= 0 && x.Amountinstock>0).Select(x => new { קוד=x.Apicenterproductcode,עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }
        public UCProduct(string vId)
        {
            InitializeComponent();
            currvolan=new TblVolanteer();
            currentpa = new TblApicenterProduct();
            currentloanapi = new TblLoanApicenter();
            this.vId = vId;
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            comboBox2.DataSource = MyDB.Tools.GetList().Select(X => X.Toolname).ToList();          
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new { קוד = x.Apicenterproductcode, עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCAddProduct up = new UCAddProduct();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCVolanteer up = new UCVolanteer(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void combocity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = combocity.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.city.Cityname == c&&x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new { קוד = x.Apicenterproductcode, עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = comboBox2.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.tools.Toolname == c&&x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new { קוד = x.Apicenterproductcode, עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
               
                    currentpa = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.Apicenterproductcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));              
                    currentloanapi.Apicenterproductcode = currentpa.Apicenterproductcode;
                    currentloanapi.Volanteerid = vId;
                    currentloanapi.Loanapicentercode = MyDB.LoanApicenter.GetNextKey();
                    currentloanapi.Dateloanepicenter = DateTime.Today;
                    currentloanapi.Returnedproduct = false;
                    MyDB.LoanApicenter.AddItem(currentloanapi);
                    MyDB.LoanApicenter.SaveChanges();
                    currentpa.Amountinstock = currentpa.Amountinstock - 1;
                    MyDB.ApicenterProduct.UpdateItem(currentpa);
                    MyDB.ApicenterProduct.SaveChanges();
                    dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new { קוד = x.Apicenterproductcode, עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
                    dataGridView1.Columns["קוד"].Visible = false;
                    MessageBox.Show(" המוצר הושאל בהצלחה");
                

            }
            else
            {
                MessageBox.Show("לא נבחר מוצר");
            }
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new { קוד = x.Apicenterproductcode, עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
            if (dataGridView1.RowCount != 0)
            {
                currvolan = MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == vId);
                currentpa = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.Apicenterproductcode ==Convert.ToInt32 (dataGridView1.CurrentRow.Cells["קוד"].Value));
                if (currentpa.apicenter.Managerphone == currvolan.Volanteerphone)
                {
                    DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את מוצר?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        MyDB.ProductVolanteer.DeleteItem(currentpa);
                    MyDB.ProductVolanteer.SaveChanges();
                    //dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new { קוד = x.Apicenterproductcode, עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
                    MessageBox.Show("המוצר נמחק בהצלחה!");
                    dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new { קוד = x.Apicenterproductcode, עיר = x.city.Cityname, מוצר = x.tools.Toolname, רחוב = x.apicenter.Apicenterstreet, פלאפון = x.Phonem }).ToList();
                        dataGridView1.Columns["קוד"].Visible = false;
                    }
                     }
                else
                {
                    MessageBox.Show(" המוצר לא שייך למתנדב זה ");
                }
            }
            else
            {
                MessageBox.Show("לא נבחר מוצר");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentpa = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.Apicenterproductcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
        }
    }
}
