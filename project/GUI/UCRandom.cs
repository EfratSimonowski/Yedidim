using project.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace project.GUI
{
    public partial class UCRandom : UserControl
    {
        int curkilo;
        int minsum;
        TblVolanteer volanteer;
        List<TblVolanteer> lstvolanteer;
        public UCRandom()
        {
            InitializeComponent();
            volanteer = new TblVolanteer();

            List<TblVolanteer> lstvolanteer = new List<TblVolanteer>();
            foreach (TblVolanteer item in MyDB.Volanteer.GetList())
            {


                minsum = minsum + item.Sumg;


            }
            foreach (TblKilometer sumkilo in MyDB.Kilometer.GetList())
            {


                curkilo = curkilo + sumkilo.Sumdd;


            }

            label4.Text = (curkilo - minsum).ToString();
            if (curkilo - minsum <= 0)
            {
                button3.Visible = true;
                button1.Enabled = false;
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (textBox1.TextLength < 2 )
            {
                errorProvider1.SetError(textBox1, "המתנה הוקשה באופן שגוי");
                textBox1.Text = "";
            }

            else
            {
                if (textBox2.Text == "")
                {
                    errorProvider2.SetError(textBox1, " לא הוקש סכום");
                    textBox1.Text = "";
                }

                else

                {
                    if (Convert.ToInt32(textBox2.Text )> Convert.ToInt32(label4.Text))
                    {
                        MessageBox.Show("סכום המתנה גדול מסכום המקסימום");
                    }

                    else
                    {
                        List<TblVolanteer> lstvolanteer = new List<TblVolanteer>();
                    int count = 0;
                    foreach (TblVolanteer item in MyDB.Volanteer.GetList())
                    {

                        for (int i = 0; i < item.Points; i++)
                        {
                            lstvolanteer.Add(item);
                            count++;
                        }
                    }

                    Random rnd = new Random();
                    int num = rnd.Next(1, count + 1);
                    count = 0;
                    foreach (TblVolanteer tblVolanteer in lstvolanteer)
                    {

                        if (count == num)
                        {
                            volanteer = tblVolanteer;
                                if (volanteer.Sumg > 0)
                                {
                                    volanteer.Sumg = volanteer.Sumg + Convert.ToInt32(textBox2.Text);
                                }
                                else
                                {
                                    volanteer.Sumg = Convert.ToInt32(textBox2.Text);
                                }
                            volanteer.Message = " זכית בשבוע זה על מנת לקבל את המתנה פנה למספר 0533139566 ";
                            MyDB.Volanteer.UpdateItem(volanteer);
                            MyDB.Volanteer.SaveChanges();

                            break;
                        }
                        else
                        {
                            count++;
                        }
                        }
                      
                        name2.Visible = true;
                    label3.Visible = true;
                    name2.Text = volanteer.Firstname.ToString();
                    label3.Text = volanteer.Lastname.ToString();
                    MessageBox.Show("ההגרלה בוצעה בהצלחה");
                  
                    foreach (TblVolanteer item in MyDB.Volanteer.GetList())
                    {

                      if(volanteer.Volanteerid!=item.Volanteerid)
                        {
                            item.Message = "";
                            MyDB.Volanteer.UpdateItem(item);
                            MyDB.Volanteer.SaveChanges();

                            }
                    }
                      }
                }

            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validation.IsHebrew(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCManager up = new UCManager();
            (this.ParentForm as FrmMain).panel1.Controls.Add(up);
            (this.ParentForm as FrmMain).panel1.Controls.Remove(this);
        }

        private void name2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (TblVolanteer item in MyDB.Volanteer.GetList())
            {                                    
                    item.Message = " לצערנו השבוע לא תתקיים הגרלה עקב שהקופה ריקה ";
                    MyDB.Volanteer.UpdateItem(item);
                    MyDB.Volanteer.SaveChanges();
                   
                }
            MessageBox.Show("ההודעה נשלחה לכולם בהצלחה");
        }
    }
}

