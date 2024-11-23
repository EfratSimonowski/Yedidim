using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace project.GUI
{
    public partial class UCApvolanteer : UserControl
    {
        TblVolanteer currentvolanteerS;
        string vId;
       
        public UCApvolanteer(string vid,TblVolanteer currentvolanteer)
        {
            InitializeComponent();
            this.vId = vid;
            currentvolanteerS = new TblVolanteer();
            this.currentvolanteerS = currentvolanteer;
            FillFields();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
        }
        public UCApvolanteer()
        {
            InitializeComponent();

            FillFields();
            combocity.DataSource = MyDB.City.GetList().Select(X => X.Cityname).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnamef.TextLength < 2 && txtnamel.TextLength < 2 && txtstreet.TextLength < 2)
            {
                errorProvider2.SetError(txtnamef, "השם הוקש באופן שאינו תקין");
                txtnamef.Text = "";
                errorProvider3.SetError(txtnamel, "השם הוקש באופן שאינו תקין");
                txtnamel.Text = ""; errorProvider4.SetError(txtstreet, "הרחוב הוקש באופן שאינו תקין");
                txtstreet.Text = "";
            }
            else { 
                if (txtnamef.TextLength < 2)
            {
                errorProvider2.SetError(txtnamef, "השם הוקש באופן שאינו תקין");
                txtnamef.Text = "";
            }

            else
            {
                    if (numericUpDown1.Text == "" || numericUpDown1.Value == 0)
                    {
                        errorProvider5.SetError(numericUpDown1, "הערך שהוקש אינו תקין");
                        numericUpDown1.Text = "";
                    }

                    else
                    {
                        if (txtnamel.TextLength < 2)
                {
                    errorProvider3.SetError(txtnamel, "השם הוקש באופן שאינו תקין");
                    txtnamel.Text = "";
                }
                else
                {
                            if (txtstreet.TextLength < 2)
                            {
                                errorProvider4.SetError(txtstreet, "הרחוב הוקש באופן שאינו תקין");
                                txtstreet.Text = "";
                            }
                            else
                            {

                                if (!Validation.IsPelepon(txtphonev.Text) )
                                {
                                    errorProvider1.SetError(txtphonev, "הפלאפון שהוקש שגוי");
                                    txtphonev.Text = "";
                                }
                                else
                                {
                                    FillObj();
                                    MyDB.Volanteer.UpdateItem(currentvolanteerS);
                                    MyDB.Volanteer.SaveChanges();
                                    MessageBox.Show("הפרטים עודכנו בהצלחה!");

                                }
                            }
                        }
                    }
                }
            }
        }
        public void FillObj()
        {
            currentvolanteerS.Volanteerid= vId;
            currentvolanteerS.Firstname=txtnamef.Text;
            currentvolanteerS.Lastname=txtnamel.Text;
            currentvolanteerS.Housenum = Convert.ToInt32(numericUpDown1.Text);
            currentvolanteerS.Citycode = combocity.SelectedIndex + 1;
            currentvolanteerS.Street=txtstreet.Text;
            currentvolanteerS.Volanteerphone = txtphonev.Text;
        }
        public void FillFields()
        {
            txtnamel.Text= currentvolanteerS.Lastname;
            txtstreet.Text = currentvolanteerS.Street;
            txtphonev.Text = currentvolanteerS.Volanteerphone;
            txtnamef.Text = currentvolanteerS.Firstname;
            combocity.SelectedItem = currentvolanteerS.City.Cityname;
            numericUpDown1.Text = currentvolanteerS.Housenum.ToString();
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

        private void txtstreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void txtphonev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsNum(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCVolanteer up = new UCVolanteer(vId);
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }
    }
}
