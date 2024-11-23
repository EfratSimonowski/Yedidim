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
    public partial class UCApplication : UserControl
    {
        TblEvent i;
        public UCApplication()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            i = new TblEvent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UCApplication_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            showrating();
        }
        public void showrating()
        {
            numr.Visible = true;
            numericUpDown1.Visible = true;
            rating.Visible = true;
            txtrating.Visible = true;
            btnok.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "" || numericUpDown1.Value == 0)
            {
                errorProvider2.SetError(numericUpDown1, "הערך שהוקש שגוי");
                numericUpDown1.Text = "";
            }
            else
            {
                if (txtrating.TextLength <2)
                {
                    errorProvider3.SetError(txtrating, "המשוב שהוקש שגוי");
                    txtrating.Text = "";
                }
                else
                {
                    if (dataGridView1.RowCount != 0)
                {
                    i = MyDB.Event.GetList().FirstOrDefault(x => x.Eventcode == Convert.ToInt32(dataGridView1.CurrentRow.Cells["קוד"].Value));
                    i.Ratingservice = Convert.ToInt32(numericUpDown1.Value);
                    i.Comment = txtrating.Text;
                    MyDB.Event.UpdateItem(i);
                    MyDB.Event.SaveChanges();
                    MessageBox.Show("תודה על המשוב");
                }
                else
                {
                    MessageBox.Show("לא נבחר ארוע");
                }
            }

               }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!Validation.IsPelepon(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "מספר הפלאפון שהוקש שגוי");
                textBox1.Text = "";
            }
            else
            {
                if (MyDB.Event.GetList().FirstOrDefault(x => x.Clientphone == textBox1.Text) != null)
                {
                    dataGridView1.DataSource = MyDB.Event.GetList().Where(x => x.Clientphone == textBox1.Text).Select(x => new { תאריך = x.Datevent, שעה = x.Eventime,קוד =x.Eventcode,לקוח = x.Clientname, רחוב = x.Streetc, מספר = x.Housenumc, סיבה = x.Reason, פלאפון = x.Clientphone, דירוג = x.Ratingservice, משוב = x.Comment }).ToList();
                    dataGridView1.Columns["קוד"].Visible = false;
                }
                else
                {
                    MessageBox.Show(" מספר הפלאפון לא קיים");
                }
            }
        }

        private void txtrating_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtrating_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
