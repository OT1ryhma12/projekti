namespace kokeilu
{
    partial class Uusi_varaus_UserControl
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
            this.asiakkaat_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toimipiste_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toimipaikat_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tee_uusi_varaus_button = new System.Windows.Forms.Button();
            this.palvelu_label = new System.Windows.Forms.Label();
            this.palvelut_comboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lisää_palvelu_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // asiakkaat_comboBox
            // 
            this.asiakkaat_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.asiakkaat_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.asiakkaat_comboBox.DisplayMember = "NimiJaEmail";
            this.asiakkaat_comboBox.FormattingEnabled = true;
            this.asiakkaat_comboBox.Location = new System.Drawing.Point(119, 228);
            this.asiakkaat_comboBox.Name = "asiakkaat_comboBox";
            this.asiakkaat_comboBox.Size = new System.Drawing.Size(366, 28);
            this.asiakkaat_comboBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "asiakas";
            // 
            // toimipiste_label
            // 
            this.toimipiste_label.AutoSize = true;
            this.toimipiste_label.Location = new System.Drawing.Point(6, 169);
            this.toimipiste_label.Name = "toimipiste_label";
            this.toimipiste_label.Size = new System.Drawing.Size(76, 20);
            this.toimipiste_label.TabIndex = 17;
            this.toimipiste_label.Text = "toimipiste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "loppu pmv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "alkamis pmv";
            // 
            // toimipaikat_comboBox
            // 
            this.toimipaikat_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toimipaikat_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toimipaikat_comboBox.DisplayMember = "Nimi";
            this.toimipaikat_comboBox.FormattingEnabled = true;
            this.toimipaikat_comboBox.Location = new System.Drawing.Point(119, 161);
            this.toimipaikat_comboBox.Name = "toimipaikat_comboBox";
            this.toimipaikat_comboBox.Size = new System.Drawing.Size(244, 28);
            this.toimipaikat_comboBox.TabIndex = 14;
            this.toimipaikat_comboBox.ValueMember = "Nimi";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Uusi varaus\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(119, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tee_uusi_varaus_button
            // 
            this.tee_uusi_varaus_button.AutoSize = true;
            this.tee_uusi_varaus_button.BackColor = System.Drawing.SystemColors.Control;
            this.tee_uusi_varaus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tee_uusi_varaus_button.Location = new System.Drawing.Point(258, 602);
            this.tee_uusi_varaus_button.Name = "tee_uusi_varaus_button";
            this.tee_uusi_varaus_button.Size = new System.Drawing.Size(162, 58);
            this.tee_uusi_varaus_button.TabIndex = 32;
            this.tee_uusi_varaus_button.Text = "Tee uusi varaus";
            this.tee_uusi_varaus_button.UseVisualStyleBackColor = false;
            this.tee_uusi_varaus_button.Click += new System.EventHandler(this.tee_uusi_varaus_button_Click);
            // 
            // palvelu_label
            // 
            this.palvelu_label.AutoSize = true;
            this.palvelu_label.Location = new System.Drawing.Point(6, 307);
            this.palvelu_label.Name = "palvelu_label";
            this.palvelu_label.Size = new System.Drawing.Size(58, 20);
            this.palvelu_label.TabIndex = 33;
            this.palvelu_label.Text = "palvelu";
            // 
            // palvelut_comboBox
            // 
            this.palvelut_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.palvelut_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.palvelut_comboBox.DisplayMember = "NimiJaKuvaus";
            this.palvelut_comboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.palvelut_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.palvelut_comboBox.FormattingEnabled = true;
            this.palvelut_comboBox.Location = new System.Drawing.Point(3, 3);
            this.palvelut_comboBox.Name = "palvelut_comboBox";
            this.palvelut_comboBox.Size = new System.Drawing.Size(370, 28);
            this.palvelut_comboBox.TabIndex = 34;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.palvelut_comboBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(119, 292);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 35);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // lisää_palvelu_button
            // 
            this.lisää_palvelu_button.Location = new System.Drawing.Point(512, 290);
            this.lisää_palvelu_button.Name = "lisää_palvelu_button";
            this.lisää_palvelu_button.Size = new System.Drawing.Size(133, 42);
            this.lisää_palvelu_button.TabIndex = 36;
            this.lisää_palvelu_button.Text = "lisää palvelu";
            this.lisää_palvelu_button.UseVisualStyleBackColor = true;
            this.lisää_palvelu_button.Click += new System.EventHandler(this.lisää_palvelu_button_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lisää_palvelu_button);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.palvelu_label);
            this.groupBox1.Controls.Add(this.toimipaikat_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.asiakkaat_comboBox);
            this.groupBox1.Controls.Add(this.toimipiste_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 523);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varauksen tiedot";
            // 
            // Uusi_varaus_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tee_uusi_varaus_button);
            this.Controls.Add(this.label1);
            this.Name = "Uusi_varaus_UserControl";
            this.Size = new System.Drawing.Size(1281, 699);
            this.Load += new System.EventHandler(this.Uusi_varaus_UserControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox asiakkaat_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label toimipiste_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox toimipaikat_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button tee_uusi_varaus_button;
        private System.Windows.Forms.Label palvelu_label;
        private System.Windows.Forms.ComboBox palvelut_comboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button lisää_palvelu_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
