namespace kokeilu
{
    partial class Laskut_UserControl
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
            this.lbVarausID = new System.Windows.Forms.Label();
            this.lbAsiakasID = new System.Windows.Forms.Label();
            this.lbNimi = new System.Windows.Forms.Label();
            this.lbOsoite = new System.Windows.Forms.Label();
            this.lbPostitoimipaikka = new System.Windows.Forms.Label();
            this.lbPostinro = new System.Windows.Forms.Label();
            this.lbSumma = new System.Windows.Forms.Label();
            this.laskut_dataGridView = new System.Windows.Forms.DataGridView();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.txtVarausID = new System.Windows.Forms.TextBox();
            this.txtAsiakasID = new System.Windows.Forms.TextBox();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.txtOsoite = new System.Windows.Forms.TextBox();
            this.txtPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txtPostinro = new System.Windows.Forms.TextBox();
            this.btnLisää = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPäivitä = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.laskut_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVarausID
            // 
            this.lbVarausID.AutoSize = true;
            this.lbVarausID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVarausID.Location = new System.Drawing.Point(3, 56);
            this.lbVarausID.Name = "lbVarausID";
            this.lbVarausID.Size = new System.Drawing.Size(83, 16);
            this.lbVarausID.TabIndex = 1;
            this.lbVarausID.Text = "Varaus nro";
            // 
            // lbAsiakasID
            // 
            this.lbAsiakasID.AutoSize = true;
            this.lbAsiakasID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsiakasID.Location = new System.Drawing.Point(3, 90);
            this.lbAsiakasID.Name = "lbAsiakasID";
            this.lbAsiakasID.Size = new System.Drawing.Size(90, 16);
            this.lbAsiakasID.TabIndex = 2;
            this.lbAsiakasID.Text = "Asiakas nro";
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNimi.Location = new System.Drawing.Point(4, 124);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(39, 16);
            this.lbNimi.TabIndex = 3;
            this.lbNimi.Text = "Nimi";
            // 
            // lbOsoite
            // 
            this.lbOsoite.AutoSize = true;
            this.lbOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOsoite.Location = new System.Drawing.Point(3, 157);
            this.lbOsoite.Name = "lbOsoite";
            this.lbOsoite.Size = new System.Drawing.Size(53, 16);
            this.lbOsoite.TabIndex = 4;
            this.lbOsoite.Text = "Osoite";
            // 
            // lbPostitoimipaikka
            // 
            this.lbPostitoimipaikka.AutoSize = true;
            this.lbPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostitoimipaikka.Location = new System.Drawing.Point(4, 192);
            this.lbPostitoimipaikka.Name = "lbPostitoimipaikka";
            this.lbPostitoimipaikka.Size = new System.Drawing.Size(123, 16);
            this.lbPostitoimipaikka.TabIndex = 5;
            this.lbPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // lbPostinro
            // 
            this.lbPostinro.AutoSize = true;
            this.lbPostinro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostinro.Location = new System.Drawing.Point(3, 228);
            this.lbPostinro.Name = "lbPostinro";
            this.lbPostinro.Size = new System.Drawing.Size(94, 16);
            this.lbPostinro.TabIndex = 6;
            this.lbPostinro.Text = "Postinumero";
            // 
            // lbSumma
            // 
            this.lbSumma.AutoSize = true;
            this.lbSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumma.Location = new System.Drawing.Point(3, 23);
            this.lbSumma.Name = "lbSumma";
            this.lbSumma.Size = new System.Drawing.Size(59, 16);
            this.lbSumma.TabIndex = 7;
            this.lbSumma.Text = "Summa";
            // 
            // laskut_dataGridView
            // 
            this.laskut_dataGridView.AutoGenerateColumns = false;
            this.laskut_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.laskut_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laskut_dataGridView.Location = new System.Drawing.Point(252, 23);
            this.laskut_dataGridView.Name = "laskut_dataGridView";
            this.laskut_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.laskut_dataGridView.Size = new System.Drawing.Size(422, 297);
            this.laskut_dataGridView.TabIndex = 5;
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(131, 22);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.Size = new System.Drawing.Size(115, 20);
            this.txtSumma.TabIndex = 9;
            // 
            // txtVarausID
            // 
            this.txtVarausID.Location = new System.Drawing.Point(131, 56);
            this.txtVarausID.Name = "txtVarausID";
            this.txtVarausID.Size = new System.Drawing.Size(115, 20);
            this.txtVarausID.TabIndex = 10;
            // 
            // txtAsiakasID
            // 
            this.txtAsiakasID.Location = new System.Drawing.Point(131, 90);
            this.txtAsiakasID.Name = "txtAsiakasID";
            this.txtAsiakasID.Size = new System.Drawing.Size(115, 20);
            this.txtAsiakasID.TabIndex = 11;
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(131, 124);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(115, 20);
            this.txtNimi.TabIndex = 12;
            // 
            // txtOsoite
            // 
            this.txtOsoite.Location = new System.Drawing.Point(131, 156);
            this.txtOsoite.Name = "txtOsoite";
            this.txtOsoite.Size = new System.Drawing.Size(115, 20);
            this.txtOsoite.TabIndex = 13;
            // 
            // txtPostitoimipaikka
            // 
            this.txtPostitoimipaikka.Location = new System.Drawing.Point(131, 191);
            this.txtPostitoimipaikka.Name = "txtPostitoimipaikka";
            this.txtPostitoimipaikka.Size = new System.Drawing.Size(115, 20);
            this.txtPostitoimipaikka.TabIndex = 14;
            // 
            // txtPostinro
            // 
            this.txtPostinro.Location = new System.Drawing.Point(131, 224);
            this.txtPostinro.Name = "txtPostinro";
            this.txtPostinro.Size = new System.Drawing.Size(115, 20);
            this.txtPostinro.TabIndex = 15;
            // 
            // btnLisää
            // 
            this.btnLisää.Location = new System.Drawing.Point(6, 284);
            this.btnLisää.Name = "btnLisää";
            this.btnLisää.Size = new System.Drawing.Size(75, 36);
            this.btnLisää.TabIndex = 16;
            this.btnLisää.Text = "Lisää";
            this.btnLisää.UseVisualStyleBackColor = true;
            this.btnLisää.Click += new System.EventHandler(this.btnLisää_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(87, 284);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 36);
            this.btnPoista.TabIndex = 17;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnPäivitä
            // 
            this.btnPäivitä.Location = new System.Drawing.Point(168, 284);
            this.btnPäivitä.Name = "btnPäivitä";
            this.btnPäivitä.Size = new System.Drawing.Size(75, 36);
            this.btnPäivitä.TabIndex = 18;
            this.btnPäivitä.Text = "Päivitä";
            this.btnPäivitä.UseVisualStyleBackColor = true;
            this.btnPäivitä.Click += new System.EventHandler(this.btnPäivitä_Click);
            // 
            // Laskut_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPäivitä);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisää);
            this.Controls.Add(this.txtPostinro);
            this.Controls.Add(this.txtPostitoimipaikka);
            this.Controls.Add(this.txtOsoite);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.txtAsiakasID);
            this.Controls.Add(this.txtVarausID);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.laskut_dataGridView);
            this.Controls.Add(this.lbSumma);
            this.Controls.Add(this.lbPostinro);
            this.Controls.Add(this.lbPostitoimipaikka);
            this.Controls.Add(this.lbOsoite);
            this.Controls.Add(this.lbNimi);
            this.Controls.Add(this.lbAsiakasID);
            this.Controls.Add(this.lbVarausID);
            this.Name = "Laskut_UserControl";
            this.Size = new System.Drawing.Size(693, 391);
            this.Load += new System.EventHandler(this.Laskut_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laskut_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbVarausID;
        private System.Windows.Forms.Label lbAsiakasID;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.Label lbOsoite;
        private System.Windows.Forms.Label lbPostitoimipaikka;
        private System.Windows.Forms.Label lbPostinro;
        private System.Windows.Forms.Label lbSumma;
        private System.Windows.Forms.DataGridView laskut_dataGridView;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.TextBox txtVarausID;
        private System.Windows.Forms.TextBox txtAsiakasID;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.TextBox txtOsoite;
        private System.Windows.Forms.TextBox txtPostitoimipaikka;
        private System.Windows.Forms.TextBox txtPostinro;
        private System.Windows.Forms.Button btnLisää;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPäivitä;
        private System.Windows.Forms.BindingSource villageDataSet1BindingSource;
    }
}
