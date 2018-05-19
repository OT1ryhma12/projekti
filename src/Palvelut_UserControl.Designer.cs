namespace kokeilu
{
    partial class Palvelut_UserControl
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
            this.hinta_textbox = new System.Windows.Forms.TextBox();
            this.hinta_label = new System.Windows.Forms.Label();
            this.päivitä_button = new System.Windows.Forms.Button();
            this.poista_palvelu_button = new System.Windows.Forms.Button();
            this.kuvaus_label = new System.Windows.Forms.Label();
            this.kuvaus_textbox = new System.Windows.Forms.TextBox();
            this.nimi_label = new System.Windows.Forms.Label();
            this.nimi_textbox = new System.Windows.Forms.TextBox();
            this.palvelut_dataGridView = new System.Windows.Forms.DataGridView();
            this.Lisää_toimipiste_button = new System.Windows.Forms.Button();
            this.toimipiste_combobox = new System.Windows.Forms.ComboBox();
            this.toimipaikka_label = new System.Windows.Forms.Label();
            this.tallenna_button = new System.Windows.Forms.Button();
            this.peruuta_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.palvelut_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hinta_textbox
            // 
            this.hinta_textbox.Location = new System.Drawing.Point(705, 548);
            this.hinta_textbox.Name = "hinta_textbox";
            this.hinta_textbox.Size = new System.Drawing.Size(100, 26);
            this.hinta_textbox.TabIndex = 49;
            // 
            // hinta_label
            // 
            this.hinta_label.AutoSize = true;
            this.hinta_label.Location = new System.Drawing.Point(635, 552);
            this.hinta_label.Name = "hinta_label";
            this.hinta_label.Size = new System.Drawing.Size(44, 20);
            this.hinta_label.TabIndex = 48;
            this.hinta_label.Text = "hinta";
            // 
            // päivitä_button
            // 
            this.päivitä_button.AutoSize = true;
            this.päivitä_button.BackColor = System.Drawing.SystemColors.Control;
            this.päivitä_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.päivitä_button.Location = new System.Drawing.Point(45, 368);
            this.päivitä_button.Name = "päivitä_button";
            this.päivitä_button.Size = new System.Drawing.Size(155, 58);
            this.päivitä_button.TabIndex = 47;
            this.päivitä_button.Text = "Päivitä";
            this.päivitä_button.UseVisualStyleBackColor = false;
            // 
            // poista_palvelu_button
            // 
            this.poista_palvelu_button.AutoSize = true;
            this.poista_palvelu_button.BackColor = System.Drawing.SystemColors.Control;
            this.poista_palvelu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.poista_palvelu_button.Location = new System.Drawing.Point(45, 124);
            this.poista_palvelu_button.Name = "poista_palvelu_button";
            this.poista_palvelu_button.Size = new System.Drawing.Size(162, 58);
            this.poista_palvelu_button.TabIndex = 46;
            this.poista_palvelu_button.Text = "Poista palvelu";
            this.poista_palvelu_button.UseVisualStyleBackColor = false;
            this.poista_palvelu_button.Click += new System.EventHandler(this.poista_palvelu_button_Click);
            // 
            // kuvaus_label
            // 
            this.kuvaus_label.AutoSize = true;
            this.kuvaus_label.Location = new System.Drawing.Point(375, 555);
            this.kuvaus_label.Name = "kuvaus_label";
            this.kuvaus_label.Size = new System.Drawing.Size(59, 20);
            this.kuvaus_label.TabIndex = 45;
            this.kuvaus_label.Text = "kuvaus";
            // 
            // kuvaus_textbox
            // 
            this.kuvaus_textbox.Location = new System.Drawing.Point(440, 537);
            this.kuvaus_textbox.Multiline = true;
            this.kuvaus_textbox.Name = "kuvaus_textbox";
            this.kuvaus_textbox.Size = new System.Drawing.Size(129, 60);
            this.kuvaus_textbox.TabIndex = 44;
            // 
            // nimi_label
            // 
            this.nimi_label.AutoSize = true;
            this.nimi_label.Location = new System.Drawing.Point(140, 555);
            this.nimi_label.Name = "nimi_label";
            this.nimi_label.Size = new System.Drawing.Size(37, 20);
            this.nimi_label.TabIndex = 43;
            this.nimi_label.Text = "nimi";
            // 
            // nimi_textbox
            // 
            this.nimi_textbox.Location = new System.Drawing.Point(196, 552);
            this.nimi_textbox.Name = "nimi_textbox";
            this.nimi_textbox.Size = new System.Drawing.Size(145, 26);
            this.nimi_textbox.TabIndex = 42;
            // 
            // palvelut_dataGridView
            // 
            this.palvelut_dataGridView.AllowUserToAddRows = false;
            this.palvelut_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.palvelut_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.palvelut_dataGridView.Location = new System.Drawing.Point(234, 63);
            this.palvelut_dataGridView.Name = "palvelut_dataGridView";
            this.palvelut_dataGridView.RowTemplate.Height = 28;
            this.palvelut_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.palvelut_dataGridView.Size = new System.Drawing.Size(751, 407);
            this.palvelut_dataGridView.TabIndex = 41;
            this.palvelut_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.palvelut_dataGridView_CellClick);
            // 
            // Lisää_toimipiste_button
            // 
            this.Lisää_toimipiste_button.BackColor = System.Drawing.SystemColors.Control;
            this.Lisää_toimipiste_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lisää_toimipiste_button.Location = new System.Drawing.Point(45, 244);
            this.Lisää_toimipiste_button.Name = "Lisää_toimipiste_button";
            this.Lisää_toimipiste_button.Size = new System.Drawing.Size(155, 58);
            this.Lisää_toimipiste_button.TabIndex = 40;
            this.Lisää_toimipiste_button.Text = "Lisää palvelu";
            this.Lisää_toimipiste_button.UseVisualStyleBackColor = false;
            this.Lisää_toimipiste_button.Click += new System.EventHandler(this.Lisää_toimipiste_button_Click);
            // 
            // toimipiste_combobox
            // 
            this.toimipiste_combobox.DisplayMember = "Nimi";
            this.toimipiste_combobox.FormattingEnabled = true;
            this.toimipiste_combobox.Location = new System.Drawing.Point(196, 639);
            this.toimipiste_combobox.Name = "toimipiste_combobox";
            this.toimipiste_combobox.Size = new System.Drawing.Size(121, 28);
            this.toimipiste_combobox.TabIndex = 50;
            this.toimipiste_combobox.ValueMember = "Nimi";
            // 
            // toimipaikka_label
            // 
            this.toimipaikka_label.AutoSize = true;
            this.toimipaikka_label.Location = new System.Drawing.Point(89, 642);
            this.toimipaikka_label.Name = "toimipaikka_label";
            this.toimipaikka_label.Size = new System.Drawing.Size(76, 20);
            this.toimipaikka_label.TabIndex = 51;
            this.toimipaikka_label.Text = "toimipiste";
            // 
            // tallenna_button
            // 
            this.tallenna_button.BackColor = System.Drawing.SystemColors.Control;
            this.tallenna_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tallenna_button.Location = new System.Drawing.Point(414, 621);
            this.tallenna_button.Name = "tallenna_button";
            this.tallenna_button.Size = new System.Drawing.Size(155, 58);
            this.tallenna_button.TabIndex = 52;
            this.tallenna_button.Text = "Tallenna\r\n";
            this.tallenna_button.UseVisualStyleBackColor = false;
            this.tallenna_button.Click += new System.EventHandler(this.tallenna_button_Click);
            // 
            // peruuta_button
            // 
            this.peruuta_button.BackColor = System.Drawing.SystemColors.Control;
            this.peruuta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.peruuta_button.Location = new System.Drawing.Point(650, 621);
            this.peruuta_button.Name = "peruuta_button";
            this.peruuta_button.Size = new System.Drawing.Size(155, 58);
            this.peruuta_button.TabIndex = 53;
            this.peruuta_button.Text = "Peruuta";
            this.peruuta_button.UseVisualStyleBackColor = false;
            this.peruuta_button.Click += new System.EventHandler(this.peruuta_button_Click);
            // 
            // Palvelut_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.peruuta_button);
            this.Controls.Add(this.tallenna_button);
            this.Controls.Add(this.toimipaikka_label);
            this.Controls.Add(this.toimipiste_combobox);
            this.Controls.Add(this.hinta_textbox);
            this.Controls.Add(this.hinta_label);
            this.Controls.Add(this.päivitä_button);
            this.Controls.Add(this.poista_palvelu_button);
            this.Controls.Add(this.kuvaus_label);
            this.Controls.Add(this.kuvaus_textbox);
            this.Controls.Add(this.nimi_label);
            this.Controls.Add(this.nimi_textbox);
            this.Controls.Add(this.palvelut_dataGridView);
            this.Controls.Add(this.Lisää_toimipiste_button);
            this.Name = "Palvelut_UserControl";
            this.Size = new System.Drawing.Size(1104, 705);
            this.Load += new System.EventHandler(this.Palvelut_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.palvelut_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hinta_textbox;
        private System.Windows.Forms.Label hinta_label;
        private System.Windows.Forms.Button päivitä_button;
        private System.Windows.Forms.Button poista_palvelu_button;
        private System.Windows.Forms.Label kuvaus_label;
        private System.Windows.Forms.TextBox kuvaus_textbox;
        private System.Windows.Forms.Label nimi_label;
        private System.Windows.Forms.TextBox nimi_textbox;
        private System.Windows.Forms.DataGridView palvelut_dataGridView;
        private System.Windows.Forms.Button Lisää_toimipiste_button;
        private System.Windows.Forms.ComboBox toimipiste_combobox;
        private System.Windows.Forms.Label toimipaikka_label;
        private System.Windows.Forms.Button tallenna_button;
        private System.Windows.Forms.Button peruuta_button;
    }
}
