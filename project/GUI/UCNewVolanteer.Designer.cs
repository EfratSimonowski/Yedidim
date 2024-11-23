namespace project.GUI
{
    partial class UCNewVolanteer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNewVolanteer));
            this.txtidv = new System.Windows.Forms.TextBox();
            this.txtnamef = new System.Windows.Forms.TextBox();
            this.txtnamel = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtphonev = new System.Windows.Forms.TextBox();
            this.idv = new System.Windows.Forms.Label();
            this.namef = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.combocity = new System.Windows.Forms.ComboBox();
            this.btnok = new System.Windows.Forms.Button();
            this.txtphonenum = new System.Windows.Forms.TextBox();
            this.phonenum = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidv
            // 
            this.txtidv.Location = new System.Drawing.Point(492, 82);
            this.txtidv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidv.Name = "txtidv";
            this.txtidv.Size = new System.Drawing.Size(100, 22);
            this.txtidv.TabIndex = 0;
            this.txtidv.TextChanged += new System.EventHandler(this.txtidv_TextChanged);
            this.txtidv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidv_KeyPress);
            // 
            // txtnamef
            // 
            this.txtnamef.Location = new System.Drawing.Point(492, 128);
            this.txtnamef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnamef.Name = "txtnamef";
            this.txtnamef.Size = new System.Drawing.Size(100, 22);
            this.txtnamef.TabIndex = 0;
            this.txtnamef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamef_KeyPress);
            // 
            // txtnamel
            // 
            this.txtnamel.Location = new System.Drawing.Point(492, 171);
            this.txtnamel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnamel.Name = "txtnamel";
            this.txtnamel.Size = new System.Drawing.Size(100, 22);
            this.txtnamel.TabIndex = 0;
            this.txtnamel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamel_KeyPress);
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(492, 262);
            this.txtstreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(100, 22);
            this.txtstreet.TabIndex = 0;
            this.txtstreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstreet_KeyPress);
            // 
            // txtphonev
            // 
            this.txtphonev.Location = new System.Drawing.Point(492, 340);
            this.txtphonev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphonev.Name = "txtphonev";
            this.txtphonev.Size = new System.Drawing.Size(100, 22);
            this.txtphonev.TabIndex = 0;
            this.txtphonev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphonev_KeyPress);
            // 
            // idv
            // 
            this.idv.AutoSize = true;
            this.idv.Location = new System.Drawing.Point(619, 87);
            this.idv.Name = "idv";
            this.idv.Size = new System.Drawing.Size(76, 16);
            this.idv.TabIndex = 1;
            this.idv.Text = "תעודת זהות";
            // 
            // namef
            // 
            this.namef.AutoSize = true;
            this.namef.Location = new System.Drawing.Point(619, 128);
            this.namef.Name = "namef";
            this.namef.Size = new System.Drawing.Size(54, 16);
            this.namef.TabIndex = 1;
            this.namef.Text = "שם פרטי";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(619, 171);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(67, 16);
            this.namel.TabIndex = 1;
            this.namel.Text = "שם משפחה";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(619, 219);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(27, 16);
            this.city.TabIndex = 1;
            this.city.Text = "עיר";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Location = new System.Drawing.Point(619, 265);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(35, 16);
            this.street.TabIndex = 1;
            this.street.Text = "רחוב";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(619, 341);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(40, 16);
            this.phone.TabIndex = 1;
            this.phone.Text = "טלפון";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(636, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "לבקשת הצטרפות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(388, 444);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "האם מחכה לאישור?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // combocity
            // 
            this.combocity.FormattingEnabled = true;
            this.combocity.Location = new System.Drawing.Point(487, 219);
            this.combocity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combocity.Name = "combocity";
            this.combocity.Size = new System.Drawing.Size(105, 24);
            this.combocity.TabIndex = 3;
            // 
            // btnok
            // 
            this.btnok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnok.Image = ((System.Drawing.Image)(resources.GetObject("btnok.Image")));
            this.btnok.Location = new System.Drawing.Point(44, 459);
            this.btnok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(57, 38);
            this.btnok.TabIndex = 8;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtphonenum
            // 
            this.txtphonenum.Location = new System.Drawing.Point(105, 460);
            this.txtphonenum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphonenum.Name = "txtphonenum";
            this.txtphonenum.Size = new System.Drawing.Size(100, 22);
            this.txtphonenum.TabIndex = 7;
            this.txtphonenum.Visible = false;
            this.txtphonenum.TextChanged += new System.EventHandler(this.txtphonenum_TextChanged);
            this.txtphonenum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphonenum_KeyPress);
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.Location = new System.Drawing.Point(216, 463);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(140, 16);
            this.phonenum.TabIndex = 6;
            this.phonenum.Text = "הכנס מספר תעודת זהות";
            this.phonenum.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "מספר בית";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(531, 305);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // UCNewVolanteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtphonenum);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.combocity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.namef);
            this.Controls.Add(this.idv);
            this.Controls.Add(this.txtphonev);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.txtnamel);
            this.Controls.Add(this.txtnamef);
            this.Controls.Add(this.txtidv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCNewVolanteer";
            this.Size = new System.Drawing.Size(1025, 598);
            this.Load += new System.EventHandler(this.UCNewVolanteer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidv;
        private System.Windows.Forms.TextBox txtnamef;
        private System.Windows.Forms.TextBox txtnamel;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.TextBox txtphonev;
        private System.Windows.Forms.Label idv;
        private System.Windows.Forms.Label namef;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox combocity;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtphonenum;
        private System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
    }
}
