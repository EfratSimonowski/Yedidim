using project.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project.GUI
{
    public partial class UCDeletproapi : UserControl
    {
        TblApicenterProduct currentapipro;
        public UCDeletproapi()
        {
            InitializeComponent();
            currentapipro = new TblApicenterProduct();
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x=>x.Amountinstock != 0 && x.Amountinstock > 0).Select(x => new {קוד=x.Apicenterproductcode,מוצר = x.tools.Toolname, כמות_במלאי=x.Amountinstock, רחוב = x.apicenter.Apicenterstreet,עיר=x.city.Cityname }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
            comboapicity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
            comboapi.DataSource = MyDB.Apicenter.GetList().Select(X => X.Apicenterstreet).ToList();
            comboBox1.DataSource = MyDB.Tools.GetList().Select(X => X.Toolname).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboapi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string f = comboapi.SelectedItem.ToString();
            int s = MyDB.City.GetList().FirstOrDefault(x => x.Cityname == comboapicity.SelectedItem.ToString()).Citycode;
            string nm = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.tools.Toolname == nm && x.apicenter.Apicenterstreet == f && x.Amountinstock != 0 && x.Amountinstock > 0 && x.apicenter.city.Citycode == s).Select(x => new { קוד = x.Apicenterproductcode, מוצר = x.tools.Toolname, כמות_במלאי = x.Amountinstock, רחוב = x.apicenter.Apicenterstreet, עיר = x.city.Cityname }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void comboapicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string f = comboapi.SelectedItem.ToString();
            int s = MyDB.City.GetList().FirstOrDefault(x => x.Cityname == comboapicity.SelectedItem.ToString()).Citycode;
            string nm = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.tools.Toolname == nm && x.apicenter.Apicenterstreet == f && x.Amountinstock != 0 && x.Amountinstock > 0 && x.apicenter.city.Citycode == s).Select(x => new { קוד = x.Apicenterproductcode, מוצר = x.tools.Toolname, כמות_במלאי = x.Amountinstock, רחוב = x.apicenter.Apicenterstreet, עיר = x.city.Cityname }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string f = comboapi.SelectedItem.ToString();
            int s = MyDB.City.GetList().FirstOrDefault(x => x.Cityname == comboapicity.SelectedItem.ToString()).Citycode;
            string nm = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = MyDB.ApicenterProduct.GetList().Where(x => x.tools.Toolname == nm && x.apicenter.Apicenterstreet == f && x.Amountinstock != 0 && x.Amountinstock > 0 && x.apicenter.city.Citycode == s).Select(x => new { קוד = x.Apicenterproductcode, מוצר = x.tools.Toolname, כמות_במלאי = x.Amountinstock, רחוב = x.apicenter.Apicenterstreet, עיר = x.city.Cityname }).ToList();
            dataGridView1.Columns["קוד"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                if (numericUpDown2.Text == "" || numericUpDown2.Value == 0)
                {
                    errorProvider1.SetError(numericUpDown2, "הערך שהוקש שגוי");
                    numericUpDown2.Text = "";
                }
                else
                {
                    currentapipro = MyDB.ApicenterProduct.GetList().FirstOrDefault(x => x.Apicenterproductcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
                    if (currentapipro.Amountinstock - Convert.ToInt32(numericUpDown2.Value) > 0 || currentapipro.Amountinstock - Convert.ToInt32(numericUpDown2.Value) == 0)
                    {
                        DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך למחוק את המוצר?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            currentapipro.Amountinstock = currentapipro.Amountinstock - Convert.ToInt32(numericUpDown2.Value);
                            MyDB.ApicenterProduct.UpdateItem(currentapipro);
                            MyDB.ApicenterProduct.SaveChanges();
                            MessageBox.Show("המוצר נמחק בהצלחה!");
                        }
                    }


                    else
                    {
                        MessageBox.Show("המלאי נמוך מהכמות שהזנת");
                    }
                }
            }
            else
            {
                MessageBox.Show("לא נבחר מוצר");
            }
        }

        private void comboBox1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCManager up = new  UCManager();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }
    }
}
