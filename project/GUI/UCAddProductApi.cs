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
    
    public partial class UCAddProductApi : UserControl
    {
        TblTools currenttools;
        
        public UCAddProductApi()
        {
            InitializeComponent();          
            currenttools = new TblTools();
        }
    
        private void button2_Click(object sender, EventArgs e)
        {  
        }
        private void comboapi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void combocity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void UCAddProductApi_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 2 )
            {
                errorProvider1.SetError(textBox1, "שם המוצר שהוקש אינו תקין");
                textBox1.Text = "";
            }

            else
            {
                if (textBox2.TextLength < 2)
                {
                    errorProvider2.SetError(textBox2, "המחיר הוקש באופן שאינו תקין");
                    textBox2.Text = "";
                }

                else
                {
                    FillObj1();
                    MyDB.Tools.AddItem(currenttools);
                    MyDB.Tools.SaveChanges();
                    MessageBox.Show("המוצר נוסף בהצלחה");
                }
            }
        }
        public void FillObj1()
        {
            currenttools.Toolcode = MyDB.Tools.GetNextKey();
            currenttools.Toolname=textBox1.Text;
            currenttools.Toolprice = Convert.ToInt32(textBox2.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            UCManager up = new UCManager();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
