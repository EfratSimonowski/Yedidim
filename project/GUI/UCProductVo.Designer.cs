namespace project.GUI
{
    partial class UCProductVo
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
            this.ba = new System.Windows.Forms.Button();
            this.addm = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combotool = new System.Windows.Forms.ComboBox();
            this.combocity = new System.Windows.Forms.ComboBox();
            this.toolm = new System.Windows.Forms.Label();
            this.citym = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ba
            // 
            this.ba.Location = new System.Drawing.Point(605, 360);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(75, 23);
            this.ba.TabIndex = 14;
            this.ba.Text = "חזור";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.Click += new System.EventHandler(this.ba_Click);
            // 
            // addm
            // 
            this.addm.Location = new System.Drawing.Point(25, 27);
            this.addm.Name = "addm";
            this.addm.Size = new System.Drawing.Size(164, 29);
            this.addm.TabIndex = 13;
            this.addm.Text = "להוספת מוצר להשאלה";
            this.addm.UseVisualStyleBackColor = true;
            this.addm.Click += new System.EventHandler(this.addm_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(62, 70);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(562, 250);
            this.dataGridView2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 250);
            this.dataGridView1.TabIndex = 12;
            // 
            // combotool
            // 
            this.combotool.FormattingEnabled = true;
            this.combotool.Location = new System.Drawing.Point(287, 32);
            this.combotool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combotool.Name = "combotool";
            this.combotool.Size = new System.Drawing.Size(121, 24);
            this.combotool.TabIndex = 10;
            // 
            // combocity
            // 
            this.combocity.FormattingEnabled = true;
            this.combocity.Location = new System.Drawing.Point(478, 32);
            this.combocity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combocity.Name = "combocity";
            this.combocity.Size = new System.Drawing.Size(121, 24);
            this.combocity.TabIndex = 9;
            // 
            // toolm
            // 
            this.toolm.AutoSize = true;
            this.toolm.Location = new System.Drawing.Point(414, 35);
            this.toolm.Name = "toolm";
            this.toolm.Size = new System.Drawing.Size(34, 16);
            this.toolm.TabIndex = 7;
            this.toolm.Text = "מוצר";
            // 
            // citym
            // 
            this.citym.AutoSize = true;
            this.citym.Location = new System.Drawing.Point(604, 36);
            this.citym.Name = "citym";
            this.citym.Size = new System.Drawing.Size(27, 16);
            this.citym.TabIndex = 8;
            this.citym.Text = "עיר";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "להשאלה";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UCProductVo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.addm);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combotool);
            this.Controls.Add(this.combocity);
            this.Controls.Add(this.toolm);
            this.Controls.Add(this.citym);
            this.Name = "UCProductVo";
            this.Size = new System.Drawing.Size(714, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ba;
        private System.Windows.Forms.Button addm;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combotool;
        private System.Windows.Forms.ComboBox combocity;
        private System.Windows.Forms.Label toolm;
        private System.Windows.Forms.Label citym;
        private System.Windows.Forms.Button button1;
    }
}
