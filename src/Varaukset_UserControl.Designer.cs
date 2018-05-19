namespace kokeilu
{
    partial class Varaukset_UserControl
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
            this.uusi_varaus_button = new System.Windows.Forms.Button();
            this.varaukset_dataGridView = new System.Windows.Forms.DataGridView();
            this.peruuta_button = new System.Windows.Forms.Button();
            this.tallenna_button = new System.Windows.Forms.Button();
            this.toimipiste_label = new System.Windows.Forms.Label();
            this.toimipiste_combobox = new System.Windows.Forms.ComboBox();
            this.varattu_loppupvm_textbox = new System.Windows.Forms.TextBox();
            this.varattu_loppupvm_label = new System.Windows.Forms.Label();
            this.varattu_alkupvm_label = new System.Windows.Forms.Label();
            this.varattu_alkupvm_textbox = new System.Windows.Forms.TextBox();
            this.varaus_id_label = new System.Windows.Forms.Label();
            this.varaus_id_textbox = new System.Windows.Forms.TextBox();
            this.asiakas_label = new System.Windows.Forms.Label();
            this.asiakas_textbox = new System.Windows.Forms.TextBox();
            this.palvelut_label = new System.Windows.Forms.Label();
            this.palvelut_listbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.varaukset_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uusi_varaus_button
            // 
            this.uusi_varaus_button.AutoSize = true;
            this.uusi_varaus_button.BackColor = System.Drawing.SystemColors.Control;
            this.uusi_varaus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uusi_varaus_button.Location = new System.Drawing.Point(349, 542);
            this.uusi_varaus_button.Name = "uusi_varaus_button";
            this.uusi_varaus_button.Size = new System.Drawing.Size(162, 58);
            this.uusi_varaus_button.TabIndex = 31;
            this.uusi_varaus_button.Text = "Uusi varaus";
            this.uusi_varaus_button.UseVisualStyleBackColor = false;
            this.uusi_varaus_button.Click += new System.EventHandler(this.uusi_varaus_button_Click);
            // 
            // varaukset_dataGridView
            // 
            this.varaukset_dataGridView.AllowUserToAddRows = false;
            this.varaukset_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varaukset_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varaukset_dataGridView.Location = new System.Drawing.Point(25, 18);
            this.varaukset_dataGridView.MultiSelect = false;
            this.varaukset_dataGridView.Name = "varaukset_dataGridView";
            this.varaukset_dataGridView.RowTemplate.Height = 28;
            this.varaukset_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.varaukset_dataGridView.Size = new System.Drawing.Size(797, 407);
            this.varaukset_dataGridView.TabIndex = 32;
            this.varaukset_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varaukset_dataGridView_CellClick);
            // 
            // peruuta_button
            // 
            this.peruuta_button.BackColor = System.Drawing.SystemColors.Control;
            this.peruuta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.peruuta_button.Location = new System.Drawing.Point(1074, 542);
            this.peruuta_button.Name = "peruuta_button";
            this.peruuta_button.Size = new System.Drawing.Size(155, 58);
            this.peruuta_button.TabIndex = 63;
            this.peruuta_button.Text = "Peruuta";
            this.peruuta_button.UseVisualStyleBackColor = false;
            // 
            // tallenna_button
            // 
            this.tallenna_button.BackColor = System.Drawing.SystemColors.Control;
            this.tallenna_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tallenna_button.Location = new System.Drawing.Point(843, 542);
            this.tallenna_button.Name = "tallenna_button";
            this.tallenna_button.Size = new System.Drawing.Size(155, 58);
            this.tallenna_button.TabIndex = 62;
            this.tallenna_button.Text = "Tallenna\r\n";
            this.tallenna_button.UseVisualStyleBackColor = false;
            // 
            // toimipiste_label
            // 
            this.toimipiste_label.AutoSize = true;
            this.toimipiste_label.Location = new System.Drawing.Point(860, 244);
            this.toimipiste_label.Name = "toimipiste_label";
            this.toimipiste_label.Size = new System.Drawing.Size(76, 20);
            this.toimipiste_label.TabIndex = 61;
            this.toimipiste_label.Text = "toimipiste";
            // 
            // toimipiste_combobox
            // 
            this.toimipiste_combobox.DisplayMember = "Nimi";
            this.toimipiste_combobox.FormattingEnabled = true;
            this.toimipiste_combobox.Location = new System.Drawing.Point(993, 236);
            this.toimipiste_combobox.Name = "toimipiste_combobox";
            this.toimipiste_combobox.Size = new System.Drawing.Size(145, 28);
            this.toimipiste_combobox.TabIndex = 60;
            this.toimipiste_combobox.ValueMember = "Nimi";
            // 
            // varattu_loppupvm_textbox
            // 
            this.varattu_loppupvm_textbox.Location = new System.Drawing.Point(993, 176);
            this.varattu_loppupvm_textbox.Name = "varattu_loppupvm_textbox";
            this.varattu_loppupvm_textbox.Size = new System.Drawing.Size(145, 26);
            this.varattu_loppupvm_textbox.TabIndex = 59;
            // 
            // varattu_loppupvm_label
            // 
            this.varattu_loppupvm_label.AutoSize = true;
            this.varattu_loppupvm_label.Location = new System.Drawing.Point(839, 176);
            this.varattu_loppupvm_label.Name = "varattu_loppupvm_label";
            this.varattu_loppupvm_label.Size = new System.Drawing.Size(135, 20);
            this.varattu_loppupvm_label.TabIndex = 58;
            this.varattu_loppupvm_label.Text = "varattu_loppupvm";
            // 
            // varattu_alkupvm_label
            // 
            this.varattu_alkupvm_label.AutoSize = true;
            this.varattu_alkupvm_label.Location = new System.Drawing.Point(843, 118);
            this.varattu_alkupvm_label.Name = "varattu_alkupvm_label";
            this.varattu_alkupvm_label.Size = new System.Drawing.Size(125, 20);
            this.varattu_alkupvm_label.TabIndex = 57;
            this.varattu_alkupvm_label.Text = "varattu_alkupvm";
            // 
            // varattu_alkupvm_textbox
            // 
            this.varattu_alkupvm_textbox.Location = new System.Drawing.Point(993, 118);
            this.varattu_alkupvm_textbox.Multiline = true;
            this.varattu_alkupvm_textbox.Name = "varattu_alkupvm_textbox";
            this.varattu_alkupvm_textbox.Size = new System.Drawing.Size(145, 26);
            this.varattu_alkupvm_textbox.TabIndex = 56;
            // 
            // varaus_id_label
            // 
            this.varaus_id_label.AutoSize = true;
            this.varaus_id_label.Location = new System.Drawing.Point(860, 54);
            this.varaus_id_label.Name = "varaus_id_label";
            this.varaus_id_label.Size = new System.Drawing.Size(77, 20);
            this.varaus_id_label.TabIndex = 55;
            this.varaus_id_label.Text = "varaus_id";
            // 
            // varaus_id_textbox
            // 
            this.varaus_id_textbox.Location = new System.Drawing.Point(993, 51);
            this.varaus_id_textbox.Name = "varaus_id_textbox";
            this.varaus_id_textbox.Size = new System.Drawing.Size(145, 26);
            this.varaus_id_textbox.TabIndex = 54;
            // 
            // asiakas_label
            // 
            this.asiakas_label.AutoSize = true;
            this.asiakas_label.Location = new System.Drawing.Point(867, 300);
            this.asiakas_label.Name = "asiakas_label";
            this.asiakas_label.Size = new System.Drawing.Size(63, 20);
            this.asiakas_label.TabIndex = 64;
            this.asiakas_label.Text = "asiakas";
            // 
            // asiakas_textbox
            // 
            this.asiakas_textbox.Location = new System.Drawing.Point(993, 294);
            this.asiakas_textbox.Multiline = true;
            this.asiakas_textbox.Name = "asiakas_textbox";
            this.asiakas_textbox.Size = new System.Drawing.Size(145, 26);
            this.asiakas_textbox.TabIndex = 65;
            // 
            // palvelut_label
            // 
            this.palvelut_label.AutoSize = true;
            this.palvelut_label.Location = new System.Drawing.Point(867, 362);
            this.palvelut_label.Name = "palvelut_label";
            this.palvelut_label.Size = new System.Drawing.Size(63, 20);
            this.palvelut_label.TabIndex = 67;
            this.palvelut_label.Text = "palvelut";
            // 
            // palvelut_listbox
            // 
            this.palvelut_listbox.DisplayMember = "Nimi";
            this.palvelut_listbox.FormattingEnabled = true;
            this.palvelut_listbox.ItemHeight = 20;
            this.palvelut_listbox.Location = new System.Drawing.Point(993, 362);
            this.palvelut_listbox.Name = "palvelut_listbox";
            this.palvelut_listbox.Size = new System.Drawing.Size(195, 124);
            this.palvelut_listbox.TabIndex = 68;
            // 
            // Varaukset_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.palvelut_listbox);
            this.Controls.Add(this.palvelut_label);
            this.Controls.Add(this.asiakas_textbox);
            this.Controls.Add(this.asiakas_label);
            this.Controls.Add(this.peruuta_button);
            this.Controls.Add(this.tallenna_button);
            this.Controls.Add(this.toimipiste_label);
            this.Controls.Add(this.toimipiste_combobox);
            this.Controls.Add(this.varattu_loppupvm_textbox);
            this.Controls.Add(this.varattu_loppupvm_label);
            this.Controls.Add(this.varattu_alkupvm_label);
            this.Controls.Add(this.varattu_alkupvm_textbox);
            this.Controls.Add(this.varaus_id_label);
            this.Controls.Add(this.varaus_id_textbox);
            this.Controls.Add(this.varaukset_dataGridView);
            this.Controls.Add(this.uusi_varaus_button);
            this.Name = "Varaukset_UserControl";
            this.Size = new System.Drawing.Size(1256, 711);
            this.Load += new System.EventHandler(this.Varaukset_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.varaukset_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uusi_varaus_button;
        private System.Windows.Forms.DataGridView varaukset_dataGridView;
        private System.Windows.Forms.Button peruuta_button;
        private System.Windows.Forms.Button tallenna_button;
        private System.Windows.Forms.Label toimipiste_label;
        private System.Windows.Forms.ComboBox toimipiste_combobox;
        private System.Windows.Forms.TextBox varattu_loppupvm_textbox;
        private System.Windows.Forms.Label varattu_loppupvm_label;
        private System.Windows.Forms.Label varattu_alkupvm_label;
        private System.Windows.Forms.TextBox varattu_alkupvm_textbox;
        private System.Windows.Forms.Label varaus_id_label;
        private System.Windows.Forms.TextBox varaus_id_textbox;
        private System.Windows.Forms.Label asiakas_label;
        private System.Windows.Forms.TextBox asiakas_textbox;
        private System.Windows.Forms.Label palvelut_label;
        private System.Windows.Forms.ListBox palvelut_listbox;
    }
}
