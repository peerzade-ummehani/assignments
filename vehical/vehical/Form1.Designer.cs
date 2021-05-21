namespace vehical
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdvehicle = new System.Windows.Forms.DataGridView();
            this.enginennumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chessisnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pagevehicle = new System.Windows.Forms.TabPage();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtmake = new System.Windows.Forms.TextBox();
            this.txtchessisnumber = new System.Windows.Forms.TextBox();
            this.txtenginenumber = new System.Windows.Forms.TextBox();
            this.Pageother = new System.Windows.Forms.TabPage();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvehicle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Pagevehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdvehicle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 118);
            this.panel1.TabIndex = 6;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grdvehicle
            // 
            this.grdvehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enginennumber,
            this.chessisnumber});
            this.grdvehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvehicle.Location = new System.Drawing.Point(0, 0);
            this.grdvehicle.Name = "grdvehicle";
            this.grdvehicle.Size = new System.Drawing.Size(717, 118);
            this.grdvehicle.TabIndex = 6;
            this.grdvehicle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvehicle_CellContentClick);
            // 
            // enginennumber
            // 
            this.enginennumber.DataPropertyName = "enginenumber";
            this.enginennumber.HeaderText = "enginenumber";
            this.enginennumber.Name = "enginennumber";
            // 
            // chessisnumber
            // 
            this.chessisnumber.DataPropertyName = "chessisnumber";
            this.chessisnumber.HeaderText = "chessisnumber";
            this.chessisnumber.Name = "chessisnumber";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pagevehicle);
            this.tabControl1.Controls.Add(this.Pageother);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 238);
            this.tabControl1.TabIndex = 1;
            // 
            // Pagevehicle
            // 
            this.Pagevehicle.Controls.Add(this.btnadd);
            this.Pagevehicle.Controls.Add(this.btnsave);
            this.Pagevehicle.Controls.Add(this.txtyear);
            this.Pagevehicle.Controls.Add(this.label5);
            this.Pagevehicle.Controls.Add(this.label4);
            this.Pagevehicle.Controls.Add(this.label3);
            this.Pagevehicle.Controls.Add(this.label2);
            this.Pagevehicle.Controls.Add(this.label1);
            this.Pagevehicle.Controls.Add(this.txtmodel);
            this.Pagevehicle.Controls.Add(this.txtmake);
            this.Pagevehicle.Controls.Add(this.txtchessisnumber);
            this.Pagevehicle.Controls.Add(this.txtenginenumber);
            this.Pagevehicle.Location = new System.Drawing.Point(4, 22);
            this.Pagevehicle.Name = "Pagevehicle";
            this.Pagevehicle.Padding = new System.Windows.Forms.Padding(3);
            this.Pagevehicle.Size = new System.Drawing.Size(709, 212);
            this.Pagevehicle.TabIndex = 0;
            this.Pagevehicle.Text = "vehicle information";
            this.Pagevehicle.UseVisualStyleBackColor = true;
            this.Pagevehicle.Click += new System.EventHandler(this.Pagevehicle_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(619, 150);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(82, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "&save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(225, 118);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(401, 20);
            this.txtyear.TabIndex = 4;
            this.txtyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtyear.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "manufactur year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "model";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "chessis number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "engine number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(225, 87);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(401, 20);
            this.txtmodel.TabIndex = 3;
            // 
            // txtmake
            // 
            this.txtmake.Location = new System.Drawing.Point(225, 58);
            this.txtmake.Name = "txtmake";
            this.txtmake.Size = new System.Drawing.Size(401, 20);
            this.txtmake.TabIndex = 2;
            this.txtmake.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtchessisnumber
            // 
            this.txtchessisnumber.Location = new System.Drawing.Point(225, 35);
            this.txtchessisnumber.Name = "txtchessisnumber";
            this.txtchessisnumber.Size = new System.Drawing.Size(401, 20);
            this.txtchessisnumber.TabIndex = 1;
            this.txtchessisnumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtenginenumber
            // 
            this.txtenginenumber.Location = new System.Drawing.Point(225, 6);
            this.txtenginenumber.Name = "txtenginenumber";
            this.txtenginenumber.Size = new System.Drawing.Size(401, 20);
            this.txtenginenumber.TabIndex = 0;
            this.txtenginenumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pageother
            // 
            this.Pageother.Location = new System.Drawing.Point(4, 22);
            this.Pageother.Name = "Pageother";
            this.Pageother.Padding = new System.Windows.Forms.Padding(3);
            this.Pageother.Size = new System.Drawing.Size(709, 212);
            this.Pageother.TabIndex = 1;
            this.Pageother.Text = "other information";
            this.Pageother.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(542, 149);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(71, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "&Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 356);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvehicle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Pagevehicle.ResumeLayout(false);
            this.Pagevehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pagevehicle;
        private System.Windows.Forms.TabPage Pageother;
        private System.Windows.Forms.TextBox txtchessisnumber;
        private System.Windows.Forms.TextBox txtenginenumber;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdvehicle;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtmake;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginennumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn chessisnumber;
        private System.Windows.Forms.Button btnadd;
    }
}

