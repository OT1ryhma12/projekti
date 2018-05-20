namespace VillagePeople
{
    partial class toimipisteet_UserControl
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
            this.puhelinnro_textbox = new System.Windows.Forms.TextBox();
            this.puhelinnro_label = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.postinumero_textbox = new System.Windows.Forms.TextBox();
            this.postinumero_label = new System.Windows.Forms.Label();
            this.postitoimipaikka_textbox = new System.Windows.Forms.TextBox();
            this.postitoimipaikka_label = new System.Windows.Forms.Label();
            this.päivitä_button = new System.Windows.Forms.Button();
            this.poista_toimipiste_button = new System.Windows.Forms.Button();
            this.osoite_label = new System.Windows.Forms.Label();
            this.osoite_textbox = new System.Windows.Forms.TextBox();
            this.nimi_label = new System.Windows.Forms.Label();
            this.nimi_textbox = new System.Windows.Forms.TextBox();
            this.toimipisteet_dataGridView = new System.Windows.Forms.DataGridView();
            this.Lisää_toimipiste_button = new System.Windows.Forms.Button();
            this.peruuta_button = new System.Windows.Forms.Button();
            this.tallenna_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteet_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // puhelinnro_textbox
            // 
            this.puhelinnro_textbox.Location = new System.Drawing.Point(141, 307);
            this.puhelinnro_textbox.Name = "puhelinnro_textbox";
            this.puhelinnro_textbox.Size = new System.Drawing.Size(120, 26);
            this.puhelinnro_textbox.TabIndex = 39;
            // 
            // puhelinnro_label
            // 
            this.puhelinnro_label.AutoSize = true;
            this.puhelinnro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinnro_label.Location = new System.Drawing.Point(17, 310);
            this.puhelinnro_label.Name = "puhelinnro_label";
            this.puhelinnro_label.Size = new System.Drawing.Size(99, 20);
            this.puhelinnro_label.TabIndex = 38;
            this.puhelinnro_label.Text = "Puhelin nro";
            this.puhelinnro_label.Click += new System.EventHandler(this.puhelinnro_label_Click);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(141, 253);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(120, 26);
            this.email_textbox.TabIndex = 37;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(17, 256);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(99, 20);
            this.email_label.TabIndex = 36;
            this.email_label.Text = "Sähköposti";
            // 
            // postinumero_textbox
            // 
            this.postinumero_textbox.Location = new System.Drawing.Point(141, 199);
            this.postinumero_textbox.Name = "postinumero_textbox";
            this.postinumero_textbox.Size = new System.Drawing.Size(120, 26);
            this.postinumero_textbox.TabIndex = 35;
            this.postinumero_textbox.TextChanged += new System.EventHandler(this.postinumero_textbox_TextChanged);
            // 
            // postinumero_label
            // 
            this.postinumero_label.AutoSize = true;
            this.postinumero_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postinumero_label.Location = new System.Drawing.Point(17, 202);
            this.postinumero_label.Name = "postinumero_label";
            this.postinumero_label.Size = new System.Drawing.Size(109, 20);
            this.postinumero_label.TabIndex = 34;
            this.postinumero_label.Text = "Postinumero";
            this.postinumero_label.Click += new System.EventHandler(this.postinumero_label_Click);
            // 
            // postitoimipaikka_textbox
            // 
            this.postitoimipaikka_textbox.Location = new System.Drawing.Point(141, 145);
            this.postitoimipaikka_textbox.Name = "postitoimipaikka_textbox";
            this.postitoimipaikka_textbox.Size = new System.Drawing.Size(120, 26);
            this.postitoimipaikka_textbox.TabIndex = 33;
            // 
            // postitoimipaikka_label
            // 
            this.postitoimipaikka_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postitoimipaikka_label.Location = new System.Drawing.Point(17, 148);
            this.postitoimipaikka_label.Name = "postitoimipaikka_label";
            this.postitoimipaikka_label.Size = new System.Drawing.Size(127, 26);
            this.postitoimipaikka_label.TabIndex = 32;
            this.postitoimipaikka_label.Text = "Postitoimipaikka";
            this.postitoimipaikka_label.Click += new System.EventHandler(this.postitoimipaikka_label_Click);
            // 
            // päivitä_button
            // 
            this.päivitä_button.AutoSize = true;
            this.päivitä_button.BackColor = System.Drawing.SystemColors.Control;
            this.päivitä_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.päivitä_button.Location = new System.Drawing.Point(21, 484);
            this.päivitä_button.Name = "päivitä_button";
            this.päivitä_button.Size = new System.Drawing.Size(240, 58);
            this.päivitä_button.TabIndex = 31;
            this.päivitä_button.Text = "Päivitä";
            this.päivitä_button.UseVisualStyleBackColor = false;
            this.päivitä_button.Click += new System.EventHandler(this.päivitä_button_Click);
            // 
            // poista_toimipiste_button
            // 
            this.poista_toimipiste_button.AutoSize = true;
            this.poista_toimipiste_button.BackColor = System.Drawing.SystemColors.Control;
            this.poista_toimipiste_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.poista_toimipiste_button.Location = new System.Drawing.Point(21, 416);
            this.poista_toimipiste_button.Name = "poista_toimipiste_button";
            this.poista_toimipiste_button.Size = new System.Drawing.Size(240, 58);
            this.poista_toimipiste_button.TabIndex = 30;
            this.poista_toimipiste_button.Text = "Poista toimipiste";
            this.poista_toimipiste_button.UseVisualStyleBackColor = false;
            this.poista_toimipiste_button.Click += new System.EventHandler(this.poista_Toimipiste_button_Click);
            // 
            // osoite_label
            // 
            this.osoite_label.AutoSize = true;
            this.osoite_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osoite_label.Location = new System.Drawing.Point(17, 94);
            this.osoite_label.Name = "osoite_label";
            this.osoite_label.Size = new System.Drawing.Size(61, 20);
            this.osoite_label.TabIndex = 29;
            this.osoite_label.Text = "Osoite";
            // 
            // osoite_textbox
            // 
            this.osoite_textbox.Location = new System.Drawing.Point(141, 91);
            this.osoite_textbox.Name = "osoite_textbox";
            this.osoite_textbox.Size = new System.Drawing.Size(120, 26);
            this.osoite_textbox.TabIndex = 28;
            // 
            // nimi_label
            // 
            this.nimi_label.AutoSize = true;
            this.nimi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimi_label.Location = new System.Drawing.Point(17, 40);
            this.nimi_label.Name = "nimi_label";
            this.nimi_label.Size = new System.Drawing.Size(43, 20);
            this.nimi_label.TabIndex = 25;
            this.nimi_label.Text = "Nimi";
            // 
            // nimi_textbox
            // 
            this.nimi_textbox.Location = new System.Drawing.Point(141, 37);
            this.nimi_textbox.Name = "nimi_textbox";
            this.nimi_textbox.Size = new System.Drawing.Size(120, 26);
            this.nimi_textbox.TabIndex = 24;
            // 
            // toimipisteet_dataGridView
            // 
            this.toimipisteet_dataGridView.AllowUserToAddRows = false;
            this.toimipisteet_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toimipisteet_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.toimipisteet_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toimipisteet_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toimipisteet_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.toimipisteet_dataGridView.Location = new System.Drawing.Point(267, 37);
            this.toimipisteet_dataGridView.Name = "toimipisteet_dataGridView";
            this.toimipisteet_dataGridView.RowTemplate.Height = 28;
            this.toimipisteet_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toimipisteet_dataGridView.Size = new System.Drawing.Size(746, 505);
            this.toimipisteet_dataGridView.TabIndex = 23;
            this.toimipisteet_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.toimipisteet_dataGridView_CellClick);
            // 
            // Lisää_toimipiste_button
            // 
            this.Lisää_toimipiste_button.BackColor = System.Drawing.SystemColors.Control;
            this.Lisää_toimipiste_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lisää_toimipiste_button.Location = new System.Drawing.Point(21, 352);
            this.Lisää_toimipiste_button.Name = "Lisää_toimipiste_button";
            this.Lisää_toimipiste_button.Size = new System.Drawing.Size(240, 58);
            this.Lisää_toimipiste_button.TabIndex = 22;
            this.Lisää_toimipiste_button.Text = "Lisää uusi toimipiste";
            this.Lisää_toimipiste_button.UseVisualStyleBackColor = false;
            this.Lisää_toimipiste_button.Click += new System.EventHandler(this.Lisää_Toimipiste_button_Click);
            // 
            // peruuta_button
            // 
            this.peruuta_button.BackColor = System.Drawing.SystemColors.Control;
            this.peruuta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.peruuta_button.Location = new System.Drawing.Point(442, 559);
            this.peruuta_button.Name = "peruuta_button";
            this.peruuta_button.Size = new System.Drawing.Size(155, 58);
            this.peruuta_button.TabIndex = 41;
            this.peruuta_button.Text = "Peruuta";
            this.peruuta_button.UseVisualStyleBackColor = false;
            this.peruuta_button.Click += new System.EventHandler(this.peruuta_button_Click);
            // 
            // tallenna_button
            // 
            this.tallenna_button.BackColor = System.Drawing.SystemColors.Control;
            this.tallenna_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tallenna_button.Location = new System.Drawing.Point(267, 559);
            this.tallenna_button.Name = "tallenna_button";
            this.tallenna_button.Size = new System.Drawing.Size(155, 58);
            this.tallenna_button.TabIndex = 40;
            this.tallenna_button.Text = "Tallenna\r\n";
            this.tallenna_button.UseVisualStyleBackColor = false;
            this.tallenna_button.Click += new System.EventHandler(this.tallenna_button_Click);
            // 
            // toimipisteet_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.Controls.Add(this.poista_toimipiste_button);
            this.Controls.Add(this.osoite_label);
            this.Controls.Add(this.osoite_textbox);
            this.Controls.Add(this.nimi_label);
            this.Controls.Add(this.nimi_textbox);
            this.Controls.Add(this.toimipisteet_dataGridView);
            this.Controls.Add(this.Lisää_toimipiste_button);
            this.Name = "toimipisteet_UserControl";
            this.Size = new System.Drawing.Size(1039, 700);
            this.Load += new System.EventHandler(this.toimipisteet_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toimipisteet_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox puhelinnro_textbox;
        private System.Windows.Forms.Label puhelinnro_label;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox postinumero_textbox;
        private System.Windows.Forms.Label postinumero_label;
        private System.Windows.Forms.TextBox postitoimipaikka_textbox;
        private System.Windows.Forms.Label postitoimipaikka_label;
        private System.Windows.Forms.Button päivitä_button;
        private System.Windows.Forms.Button poista_toimipiste_button;
        private System.Windows.Forms.Label osoite_label;
        private System.Windows.Forms.TextBox osoite_textbox;
        private System.Windows.Forms.Label nimi_label;
        private System.Windows.Forms.TextBox nimi_textbox;
        private System.Windows.Forms.DataGridView toimipisteet_dataGridView;
        private System.Windows.Forms.Button Lisää_toimipiste_button;
        private System.Windows.Forms.Button peruuta_button;
        private System.Windows.Forms.Button tallenna_button;
    }
}
