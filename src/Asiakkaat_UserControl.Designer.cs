namespace kokeilu
{
    partial class Asiakkaat_UserControl
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
            this.Lisää_asiakas_button = new System.Windows.Forms.Button();
            this.asiakkaat_dataGridView = new System.Windows.Forms.DataGridView();
            this.etunimi_textbox = new System.Windows.Forms.TextBox();
            this.etunimi_label = new System.Windows.Forms.Label();
            this.sukunimi_label = new System.Windows.Forms.Label();
            this.sukunimi_textbox = new System.Windows.Forms.TextBox();
            this.osoite_textbox = new System.Windows.Forms.TextBox();
            this.osoite_label = new System.Windows.Forms.Label();
            this.poista_asiakas_button = new System.Windows.Forms.Button();
            this.päivitä_button = new System.Windows.Forms.Button();
            this.postitoimipaikka_label = new System.Windows.Forms.Label();
            this.postitoimipaikka_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaat_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lisää_asiakas_button
            // 
            this.Lisää_asiakas_button.BackColor = System.Drawing.SystemColors.Control;
            this.Lisää_asiakas_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lisää_asiakas_button.Location = new System.Drawing.Point(17, 219);
            this.Lisää_asiakas_button.Name = "Lisää_asiakas_button";
            this.Lisää_asiakas_button.Size = new System.Drawing.Size(155, 58);
            this.Lisää_asiakas_button.TabIndex = 0;
            this.Lisää_asiakas_button.Text = "Lisää asiakas";
            this.Lisää_asiakas_button.UseVisualStyleBackColor = false;
            this.Lisää_asiakas_button.Click += new System.EventHandler(this.Lisää_asiakas_button_Click);
            // 
            // asiakkaat_dataGridView
            // 
            this.asiakkaat_dataGridView.AllowUserToAddRows = false;
            this.asiakkaat_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.asiakkaat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakkaat_dataGridView.Location = new System.Drawing.Point(193, 38);
            this.asiakkaat_dataGridView.Name = "asiakkaat_dataGridView";
            this.asiakkaat_dataGridView.RowTemplate.Height = 28;
            this.asiakkaat_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.asiakkaat_dataGridView.Size = new System.Drawing.Size(751, 407);
            this.asiakkaat_dataGridView.TabIndex = 5;
            this.asiakkaat_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiakkaat_dataGridView_CellClick);
            // 
            // etunimi_textbox
            // 
            this.etunimi_textbox.Location = new System.Drawing.Point(226, 481);
            this.etunimi_textbox.Name = "etunimi_textbox";
            this.etunimi_textbox.Size = new System.Drawing.Size(100, 26);
            this.etunimi_textbox.TabIndex = 6;
            // 
            // etunimi_label
            // 
            this.etunimi_label.AutoSize = true;
            this.etunimi_label.Location = new System.Drawing.Point(149, 484);
            this.etunimi_label.Name = "etunimi_label";
            this.etunimi_label.Size = new System.Drawing.Size(62, 20);
            this.etunimi_label.TabIndex = 7;
            this.etunimi_label.Text = "Etunimi";
            // 
            // sukunimi_label
            // 
            this.sukunimi_label.AutoSize = true;
            this.sukunimi_label.Location = new System.Drawing.Point(370, 484);
            this.sukunimi_label.Name = "sukunimi_label";
            this.sukunimi_label.Size = new System.Drawing.Size(74, 20);
            this.sukunimi_label.TabIndex = 8;
            this.sukunimi_label.Text = "Sukunimi";
            // 
            // sukunimi_textbox
            // 
            this.sukunimi_textbox.Location = new System.Drawing.Point(472, 481);
            this.sukunimi_textbox.Name = "sukunimi_textbox";
            this.sukunimi_textbox.Size = new System.Drawing.Size(100, 26);
            this.sukunimi_textbox.TabIndex = 9;
            // 
            // osoite_textbox
            // 
            this.osoite_textbox.Location = new System.Drawing.Point(703, 481);
            this.osoite_textbox.Name = "osoite_textbox";
            this.osoite_textbox.Size = new System.Drawing.Size(100, 26);
            this.osoite_textbox.TabIndex = 10;
            // 
            // osoite_label
            // 
            this.osoite_label.AutoSize = true;
            this.osoite_label.Location = new System.Drawing.Point(617, 484);
            this.osoite_label.Name = "osoite_label";
            this.osoite_label.Size = new System.Drawing.Size(55, 20);
            this.osoite_label.TabIndex = 11;
            this.osoite_label.Text = "Osoite";
            // 
            // poista_asiakas_button
            // 
            this.poista_asiakas_button.AutoSize = true;
            this.poista_asiakas_button.BackColor = System.Drawing.SystemColors.Control;
            this.poista_asiakas_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.poista_asiakas_button.Location = new System.Drawing.Point(17, 99);
            this.poista_asiakas_button.Name = "poista_asiakas_button";
            this.poista_asiakas_button.Size = new System.Drawing.Size(155, 58);
            this.poista_asiakas_button.TabIndex = 12;
            this.poista_asiakas_button.Text = "Poista asiakas";
            this.poista_asiakas_button.UseVisualStyleBackColor = false;
            this.poista_asiakas_button.Click += new System.EventHandler(this.poista_Asiakas_button_Click);
            // 
            // päivitä_button
            // 
            this.päivitä_button.AutoSize = true;
            this.päivitä_button.BackColor = System.Drawing.SystemColors.Control;
            this.päivitä_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.päivitä_button.Location = new System.Drawing.Point(17, 343);
            this.päivitä_button.Name = "päivitä_button";
            this.päivitä_button.Size = new System.Drawing.Size(155, 58);
            this.päivitä_button.TabIndex = 13;
            this.päivitä_button.Text = "Päivitä";
            this.päivitä_button.UseVisualStyleBackColor = false;
            this.päivitä_button.Click += new System.EventHandler(this.päivitä_button_Click);
            // 
            // postitoimipaikka_label
            // 
            this.postitoimipaikka_label.AutoSize = true;
            this.postitoimipaikka_label.Location = new System.Drawing.Point(826, 474);
            this.postitoimipaikka_label.Name = "postitoimipaikka_label";
            this.postitoimipaikka_label.Size = new System.Drawing.Size(82, 40);
            this.postitoimipaikka_label.TabIndex = 14;
            this.postitoimipaikka_label.Text = "Postitoimi-\r\npaikka";
            // 
            // postitoimipaikka_textbox
            // 
            this.postitoimipaikka_textbox.Location = new System.Drawing.Point(927, 478);
            this.postitoimipaikka_textbox.Name = "postitoimipaikka_textbox";
            this.postitoimipaikka_textbox.Size = new System.Drawing.Size(100, 26);
            this.postitoimipaikka_textbox.TabIndex = 15;
            // 
            // Asiakkaat_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postitoimipaikka_textbox);
            this.Controls.Add(this.postitoimipaikka_label);
            this.Controls.Add(this.päivitä_button);
            this.Controls.Add(this.poista_asiakas_button);
            this.Controls.Add(this.osoite_label);
            this.Controls.Add(this.osoite_textbox);
            this.Controls.Add(this.sukunimi_textbox);
            this.Controls.Add(this.sukunimi_label);
            this.Controls.Add(this.etunimi_label);
            this.Controls.Add(this.etunimi_textbox);
            this.Controls.Add(this.asiakkaat_dataGridView);
            this.Controls.Add(this.Lisää_asiakas_button);
            this.Name = "Asiakkaat_UserControl";
            this.Size = new System.Drawing.Size(1039, 602);
            this.Load += new System.EventHandler(this.asiakkaat_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaat_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lisää_asiakas_button;
        private System.Windows.Forms.DataGridView asiakkaat_dataGridView;
        private System.Windows.Forms.TextBox etunimi_textbox;
        private System.Windows.Forms.Label etunimi_label;
        private System.Windows.Forms.Label sukunimi_label;
        private System.Windows.Forms.TextBox sukunimi_textbox;
        private System.Windows.Forms.TextBox osoite_textbox;
        private System.Windows.Forms.Label osoite_label;
        private System.Windows.Forms.Button poista_asiakas_button;
        private System.Windows.Forms.Button päivitä_button;
        private System.Windows.Forms.Label postitoimipaikka_label;
        private System.Windows.Forms.TextBox postitoimipaikka_textbox;
    }
}
