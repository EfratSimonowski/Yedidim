using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project.GUI
{
    public partial class UCNewVolanteer : UserControl
    {
        TblVolanteer currentvolanteer;
        public UCNewVolanteer()
        {
            InitializeComponent();
            currentvolanteer = new TblVolanteer();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phonenum.Visible = true;
            txtphonenum.Visible=true;
            btnok.Visible=true;            
        }
        private void UCNewVolanteer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {if(txtnamef.TextLength<2)
            {
                errorProvider4.SetError(txtnamef, "השם הוקש באופן שגוי");
                txtnamef.Text = "";
            }
            else {
                if (txtnamel.TextLength < 2 )
                {
                    errorProvider5.SetError(txtnamel, "השם הוקש באופן שגוי");
                    txtnamel.Text = "";
                }
                else
                {
                    if (txtstreet.TextLength < 2)
                    {
                        errorProvider6.SetError(txtstreet, "הרחוב הוקש באופן שגוי");
                        txtstreet.Text = "";
                    }
                    else
                    {
                        if (numericUpDown1.Text == "" || numericUpDown1.Value == 0)
                        {
                            errorProvider7.SetError(numericUpDown1, "הערך שהוקש שגוי");
                            numericUpDown1.Text = "";
                        }
                        else
                        {
                            if (!Validation.IsPelepon(txtphonev.Text))
                        {
                            MessageBox.Show("מספר הפלאפון שהוקש שגוי");
                        }
                        else
                        {
                            if (!Validation.CheckId(txtidv.Text))
                            {
                                MessageBox.Show("תעודת הזהות שהוקשה שגויה");
                            }
                            else
                            {

                                if (MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == txtidv.Text) != null)
                                {
                                    MessageBox.Show("תעודת הזהות שהוקשה קיימת במאגר!");
                                }
                                else
                                {
                                    FillObj();
                                    MyDB.Volanteer.AddItem(currentvolanteer);
                                    MyDB.Volanteer.SaveChanges();
                                    MessageBox.Show("הבקשה נוספה לרשימה!");
                                }
                            }
                          }
                        }
                    }
                }
            }
        }
        public void FillObj()
        {                  
                currentvolanteer.Volanteerid = txtidv.Text;
                currentvolanteer.Firstname = txtnamef.Text;
                currentvolanteer.Housenum = Convert.ToInt32(numericUpDown1.Text);
                currentvolanteer.Lastname = txtnamel.Text;
                currentvolanteer.Citycode = MyDB.City.GetList().FirstOrDefault(X => X.Cityname == combocity.SelectedValue.ToString()).Citycode;
                currentvolanteer.Street = txtstreet.Text;
                currentvolanteer.Volanteerphone = txtphonev.Text;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (!Validation.CheckId(txtphonenum.Text))
            {
                MessageBox.Show("תעודת הזהות שהוקשה שגויה");
            }
            else
            {
                if (MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == txtphonenum.Text && x.Statusv==1) != null)
            {
                MessageBox.Show("הצטרפת למערך המתנדבים");
            }
            else if(MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == txtphonenum.Text && x.Statusv == 2) != null)
            { 
                MessageBox.Show("לצערנו לא התקבלת למערך המתנדבים");
            }
            else if (MyDB.Volanteer.GetList().FirstOrDefault(x => x.Volanteerid == txtphonenum.Text && x.Statusv ==0) != null)
            {
                MessageBox.Show("עדיין ממתין לאישור");
            }
           
            else
            {
                errorProvider1.SetError(txtphonenum, "מספר תעודת הזהות אינו קיים");
                txtphonenum.Text = "";
            }
        }
    }
            

        private void txtcodev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtidv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtphonenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtphonenum_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtphonev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtidv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnamef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtnamel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtstreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}
