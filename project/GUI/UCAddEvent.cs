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
using project.BLL;


namespace project.GUI
{
    public partial class UCAddEvent : UserControl
    {
        
        TblEvent currentEvent;
        public UCAddEvent()
        {
            InitializeComponent();
            currentEvent = new TblEvent();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Text == "" || numericUpDown1.Value == 0)
            {
                errorProvider7.SetError(numericUpDown1, "הערך שהוקש שגוי");
                numericUpDown1.Text = "";
            }
            if (txtname.TextLength < 2)
            {
                errorProvider4.SetError(txtname, "השם שהוקש שגוי");
                txtname.Text = "";
            }
            else
            {
                if (txtstreet.TextLength < 2 )
                {
                    errorProvider5.SetError(txtstreet, "שם הרחוב שהוקש שגוי");
                    txtstreet.Text = "";
                }
                else
                {
                    if (txtreason.TextLength < 2)
                    {
                        errorProvider6.SetError(txtreason, "הסיבה הוקשה באופן שגוי");
                        txtreason.Text = "";
                    }
                    else
                    {
                        if (!Validation.IsPelepon(textBox2.Text))
                        {
                            errorProvider3.SetError(textBox2, "הפלאפון שהוקש שגוי");
                            textBox2.Text = "";
                        }
                        else
                        {
                            if (dateTimePicker2.Value.Hour == DateTime.Now.Hour)
                            {
                                if (dateTimePicker1.Value.Year == DateTime.Now.Year && dateTimePicker1.Value.Month == DateTime.Now.Month && dateTimePicker1.Value.Day == DateTime.Now.Day)
                                {
                                    FillObj();
                                    currentEvent.Statuscode = 1;
                                    MyDB.Event.AddItem(currentEvent);
                                    MyDB.Event.SaveChanges();
                                    MessageBox.Show("הקריאה נוספה לרשימה בהצלחה!");
                                }
                                else
                                {
                                    MessageBox.Show("התאריך אינו נכון");
                                }
                            }
                            else
                            {
                                MessageBox.Show("השעה אינה נכונה");
                            }
                        }
                    }
                }
            }
        
        }
        public void FillObj()
        {
            currentEvent.Eventcode=MyDB.Event.GetNextKey();
            currentEvent.Datevent = dateTimePicker1.Value;
            currentEvent.Eventime = dateTimePicker2.Value;
            currentEvent.Clientname=txtname.Text;
            currentEvent.Streetc=txtstreet.Text;
            currentEvent.Housenumc=Convert.ToInt32(numericUpDown1.Text);
            currentEvent.Reason=txtreason.Text;
            currentEvent.Clientphone=textBox2.Text;
            currentEvent.Citycode = MyDB.City.GetList().FirstOrDefault(X => X.Cityname == combocity.SelectedValue.ToString()).Citycode;
            currentEvent.Statuscode = MyDB.Status.GetList().First(x => x.Statusname == "חדש").Statuscode;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void UCAddEvent_Load(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            phonenum.Visible = true;
            txtphonenum.Visible=true;
            button3.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Validation.IsPelepon(txtphonenum.Text))
            {
                errorProvider1.SetError(txtphonenum, "הפלאפון שהוקש שגוי");
                txtphonenum.Text = "";
            }
            else
            {
                if (MyDB.Event.GetList().FirstOrDefault(x => x.Clientphone == txtphonenum.Text && DateTime.Now.Day - x.Datevent.Day <= 1 && DateTime.Now.Month == x.Datevent.Month && DateTime.Now.Year == x.Datevent.Year && x.Statuscode == 2) != null)
                {
                    MessageBox.Show("הפניה בטיפול");
                }
                else if (MyDB.Event.GetList().FirstOrDefault(x => x.Clientphone == txtphonenum.Text && DateTime.Now.Day - x.Datevent.Day <= 1 && DateTime.Now.Month == x.Datevent.Month && DateTime.Now.Year == x.Datevent.Year && x.Statuscode == 1) != null)
                {
                    MessageBox.Show("הפניה עדיין לא טופלה");
                }
                else if (MyDB.Event.GetList().FirstOrDefault(x => x.Clientphone == txtphonenum.Text && DateTime.Now.Day - x.Datevent.Day <= 1 && DateTime.Now.Month == x.Datevent.Month && DateTime.Now.Year == x.Datevent.Year && x.Statuscode == 3) != null)
                {
                    MessageBox.Show("הפניה נסגרה");
                }
                else
                {
                    errorProvider1.SetError(txtphonenum, "לא קיימת קריאה ביום האחרון על מספר הפלאפון שהוקש");
                    txtphonenum.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label10.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Validation.IsPelepon(textBox1.Text))
            {
                errorProvider2.SetError(textBox1, "הפלאפון שהוקש שגוי");
                textBox1.Text = "";
            }
            else
            {
                if (MyDB.Event.GetList().FirstOrDefault(x => x.Clientphone == textBox1.Text && DateTime.Now.Day-x.Datevent.Day<=1&&DateTime.Now.Month==x.Datevent.Month&&DateTime.Now.Year==x.Datevent.Year) != null)
                {
                    currentEvent = MyDB.Event.GetList().FirstOrDefault(x => x.Clientphone == txtphonenum.Text);
                    DialogResult r = MessageBox.Show("האם אתה בטוח שברצונך לבטל את הקריאה?", "התרעה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {              
                    MyDB.Event.DeleteItem(currentEvent);
                    MyDB.Event.SaveChanges();
                    MessageBox.Show("הקריאה נמחקה");
                    }
                }
                else
                {
                    errorProvider2.SetError(textBox1, "לא קיימת קריאה ביום האחרון על מספר הפלאפון שהוקש");
                    textBox1.Text = "";
                }
            }
        }

        private void txtstreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtreason_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtphonenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
   
}
