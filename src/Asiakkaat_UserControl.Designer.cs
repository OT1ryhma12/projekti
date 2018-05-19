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
            this.postinumero_label = new System.Windows.Forms.Label();
            this.postinumero_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.puhelinnro_label = new System.Windows.Forms.Label();
            this.puhelinnro_textbox = new System.Windows.Forms.TextBox();
            this.tallenna_button = new System.Windows.Forms.Button();
            this.peruuta_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaat_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lisää_asiakas_button
            // 
            this.Lisää_asiakas_button.BackColor = System.Drawing.SystemColors.Control;
            this.Lisää_asiakas_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lisää_asiakas_button.Location = new System.Drawing.Point(17, 209);
            this.Lisää_asiakas_button.Name = "Lisää_asiakas_button";
            this.Lisää_asiakas_button.Size = new System.Drawing.Size(155, 86);
            this.Lisää_asiakas_button.TabIndex = 0;
            this.Lisää_asiakas_button.Text = "Lisää uusi \r\n  asiakas";
            this.Lisää_asiakas_button.UseVisualStyleBackColor = false;
            this.Lisää_asiakas_button.Click += new System.EventHandler(this.Lisää_asiakas_button_Click);
            // 
            // asiakkaat_dataGridView
            // 
            this.asiakkaat_dataGridView.AllowUserToAddRows = false;
            this.asiakkaat_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.asiakkaat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakkaat_dataGridView.Location = new System.Drawing.Point(193, 38);
            this.asiakkaat_dataGridView.MultiSelect = false;
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
            // postinumero_label
            // 
            this.postinumero_label.AutoSize = true;
            this.postinumero_label.Location = new System.Drawing.Point(113, 541);
            this.postinumero_label.Name = "postinumero_label";
            this.postinumero_label.Size = new System.Drawing.Size(98, 20);
            this.postinumero_label.TabIndex = 16;
            this.postinumero_label.Text = "Postinumero";
            // 
            // postinumero_textbox
            // 
            this.postinumero_textbox.Location = new System.Drawing.Point(226, 541);
            this.postinumero_textbox.Name = "postinumero_textbox";
            this.postinumero_textbox.Size = new System.Drawing.Size(100, 26);
            this.postinumero_textbox.TabIndex = 17;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(398, 541);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(46, 20);
            this.email_label.TabIndex = 18;
            this.email_label.Text = "email";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(472, 541);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(100, 26);
            this.email_textbox.TabIndex = 19;
            // 
            // puhelinnro_label
            // 
            this.puhelinnro_label.AutoSize = true;
            this.puhelinnro_label.Location = new System.Drawing.Point(589, 541);
            this.puhelinnro_label.Name = "puhelinnro_label";
            this.puhelinnro_label.Size = new System.Drawing.Size(83, 20);
            this.puhelinnro_label.TabIndex = 20;
            this.puhelinnro_label.Text = "puhelinnro";
            // 
            // puhelinnro_textbox
            // 
            this.puhelinnro_textbox.Location = new System.Drawing.Point(703, 541);
            this.puhelinnro_textbox.Name = "puhelinnro_textbox";
            this.puhelinnro_textbox.Size = new System.Drawing.Size(100, 26);
            this.puhelinnro_textbox.TabIndex = 21;
            // 
            // tallenna_button
            // 
            this.tallenna_button.BackColor = System.Drawing.SystemColors.Control;
            this.tallenna_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tallenna_button.Location = new System.Drawing.Point(374, 613);
            this.tallenna_button.Name = "tallenna_button";
            this.tallenna_button.Size = new System.Drawing.Size(155, 58);
            this.tallenna_button.TabIndex = 22;
            this.tallenna_button.Text = "Tallenna\r\n";
            this.tallenna_button.UseVisualStyleBackColor = false;
            this.tallenna_button.Click += new System.EventHandler(this.tallenna_button_Click);
            // 
            // peruuta_button
            // 
            this.peruuta_button.BackColor = System.Drawing.SystemColors.Control;
            this.peruuta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.peruuta_button.Location = new System.Drawing.Point(621, 613);
            this.peruuta_button.Name = "peruuta_button";
            this.peruuta_button.Size = new System.Drawing.Size(155, 58);
            this.peruuta_button.TabIndex = 23;
            this.peruuta_button.Text = "Peruuta";
            this.peruuta_button.UseVisualStyleBackColor = false;
            this.peruuta_button.Click += new System.EventHandler(this.peruuta_button_Click);
            // 
            // Asiakkaat_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peruuta_button);
            this.Controls.Add(this.tallenna_button);
            this.Controls.Add(this.puhelinnro_textbox);
            this.Controls.Add(this.puhelinnro_label);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.postinumero_textbox);
            this.Controls.Add(this.postinumero_label);
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
            this.Size = new System.Drawing.Size(1039, 700);
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
        private System.Windows.Forms.Label postinumero_label;
        private System.Windows.Forms.TextBox postinumero_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label puhelinnro_label;
        private System.Windows.Forms.TextBox puhelinnro_textbox;
        private System.Windows.Forms.Button tallenna_button;
        private System.Windows.Forms.Button peruuta_button;
    }
}
