namespace project.GUI
{
    partial class UCApvolanteer
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
            this.combocity = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.namef = new System.Windows.Forms.Label();
            this.txtphonev = new System.Windows.Forms.TextBox();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.txtnamel = new System.Windows.Forms.TextBox();
            this.txtnamef = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // combocity
            // 
            this.combocity.FormattingEnabled = true;
            this.combocity.Location = new System.Drawing.Point(377, 188);
            this.combocity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combocity.Name = "combocity";
            this.combocity.Size = new System.Drawing.Size(105, 24);
            this.combocity.TabIndex = 13;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(511, 321);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(40, 16);
            this.phone.TabIndex = 8;
            this.phone.Text = "טלפון";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Location = new System.Drawing.Point(511, 235);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(35, 16);
            this.street.TabIndex = 9;
            this.street.Text = "רחוב";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(511, 188);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(27, 16);
            this.city.TabIndex = 10;
            this.city.Text = "עיר";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(511, 140);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(67, 16);
            this.namel.TabIndex = 11;
            this.namel.Text = "שם משפחה";
            // 
            // namef
            // 
            this.namef.AutoSize = true;
            this.namef.Location = new System.Drawing.Point(511, 97);
            this.namef.Name = "namef";
            this.namef.Size = new System.Drawing.Size(54, 16);
            this.namef.TabIndex = 12;
            this.namef.Text = "שם פרטי";
            // 
            // txtphonev
            // 
            this.txtphonev.Location = new System.Drawing.Point(383, 321);
            this.txtphonev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphonev.Name = "txtphonev";
            this.txtphonev.Size = new System.Drawing.Size(100, 22);
            this.txtphonev.TabIndex = 4;
            this.txtphonev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphonev_KeyPress);
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(383, 233);
            this.txtstreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(100, 22);
            this.txtstreet.TabIndex = 5;
            this.txtstreet.TextChanged += new System.EventHandler(this.txtstreet_TextChanged);
            this.txtstreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstreet_KeyPress);
            // 
            // txtnamel
            // 
            this.txtnamel.Location = new System.Drawing.Point(383, 140);
            this.txtnamel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnamel.Name = "txtnamel";
            this.txtnamel.Size = new System.Drawing.Size(100, 22);
            this.txtnamel.TabIndex = 6;
            this.txtnamel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamel_KeyPress);
            // 
            // txtnamef
            // 
            this.txtnamef.Location = new System.Drawing.Point(383, 97);
            this.txtnamef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnamef.Name = "txtnamef";
            this.txtnamef.Size = new System.Drawing.Size(100, 22);
            this.txtnamef.TabIndex = 7;
            this.txtnamef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamef_KeyPress);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::project.Properties.Resources.tr;
            this.button1.Location = new System.Drawing.Point(377, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "לעדכון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "מספר בית";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(379, 279);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown1.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::project.Properties.Resources.tr;
            this.button2.Location = new System.Drawing.Point(767, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "חזור";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // UCApvolanteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combocity);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.namef);
            this.Controls.Add(this.txtphonev);
            this.Controls.Add(this.txtstreet);
            this.Controls.Add(this.txtnamel);
            this.Controls.Add(this.txtnamef);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCApvolanteer";
            this.Size = new System.Drawing.Size(907, 570);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combocity;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label namef;
        private System.Windows.Forms.TextBox txtphonev;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.TextBox txtnamel;
        private System.Windows.Forms.TextBox txtnamef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}
