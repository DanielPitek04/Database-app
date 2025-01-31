namespace EdutageApp
{
    partial class Admin
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
            this.nadpisEdutage = new System.Windows.Forms.Label();
            this.spravaProjektov = new System.Windows.Forms.Button();
            this.pridatUcitela = new System.Windows.Forms.Button();
            this.odstranitRolu = new System.Windows.Forms.Button();
            this.menitUdaje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtSmerCislo = new System.Windows.Forms.TextBox();
            this.btnPridat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nadpisEdutage
            // 
            this.nadpisEdutage.AutoSize = true;
            this.nadpisEdutage.BackColor = System.Drawing.Color.Aqua;
            this.nadpisEdutage.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisEdutage.ForeColor = System.Drawing.Color.DarkCyan;
            this.nadpisEdutage.Location = new System.Drawing.Point(31, 22);
            this.nadpisEdutage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nadpisEdutage.Name = "nadpisEdutage";
            this.nadpisEdutage.Size = new System.Drawing.Size(425, 80);
            this.nadpisEdutage.TabIndex = 1;
            this.nadpisEdutage.Text = "Správa systému";
            // 
            // spravaProjektov
            // 
            this.spravaProjektov.BackColor = System.Drawing.Color.Turquoise;
            this.spravaProjektov.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spravaProjektov.Location = new System.Drawing.Point(574, 133);
            this.spravaProjektov.Name = "spravaProjektov";
            this.spravaProjektov.Size = new System.Drawing.Size(243, 65);
            this.spravaProjektov.TabIndex = 4;
            this.spravaProjektov.Text = "Pridávať";
            this.spravaProjektov.UseVisualStyleBackColor = false;
            this.spravaProjektov.Click += new System.EventHandler(this.spravaProjektov_Click);
            // 
            // pridatUcitela
            // 
            this.pridatUcitela.BackColor = System.Drawing.Color.DarkCyan;
            this.pridatUcitela.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pridatUcitela.Location = new System.Drawing.Point(574, 523);
            this.pridatUcitela.Name = "pridatUcitela";
            this.pridatUcitela.Size = new System.Drawing.Size(243, 57);
            this.pridatUcitela.TabIndex = 5;
            this.pridatUcitela.Text = "Pridať účet";
            this.pridatUcitela.UseVisualStyleBackColor = false;
            this.pridatUcitela.Click += new System.EventHandler(this.pridatUcitela_Click);
            // 
            // odstranitRolu
            // 
            this.odstranitRolu.BackColor = System.Drawing.Color.Teal;
            this.odstranitRolu.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odstranitRolu.Location = new System.Drawing.Point(574, 462);
            this.odstranitRolu.Name = "odstranitRolu";
            this.odstranitRolu.Size = new System.Drawing.Size(243, 55);
            this.odstranitRolu.TabIndex = 6;
            this.odstranitRolu.Text = "Odstrániť účet";
            this.odstranitRolu.UseVisualStyleBackColor = false;
            this.odstranitRolu.Click += new System.EventHandler(this.odstranitRolu_Click);
            // 
            // menitUdaje
            // 
            this.menitUdaje.BackColor = System.Drawing.Color.Turquoise;
            this.menitUdaje.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menitUdaje.Location = new System.Drawing.Point(574, 24);
            this.menitUdaje.Name = "menitUdaje";
            this.menitUdaje.Size = new System.Drawing.Size(243, 99);
            this.menitUdaje.TabIndex = 7;
            this.menitUdaje.Text = "Meniť údaje";
            this.menitUdaje.UseVisualStyleBackColor = false;
            this.menitUdaje.Click += new System.EventHandler(this.menitUdaje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(516, 450);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(614, 243);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(100, 20);
            this.txtMesto.TabIndex = 12;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(614, 284);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 13;
            // 
            // txtSmerCislo
            // 
            this.txtSmerCislo.Location = new System.Drawing.Point(614, 326);
            this.txtSmerCislo.Name = "txtSmerCislo";
            this.txtSmerCislo.Size = new System.Drawing.Size(100, 20);
            this.txtSmerCislo.TabIndex = 14;
            // 
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(607, 372);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(75, 23);
            this.btnPridat.TabIndex = 15;
            this.btnPridat.Text = "Pridať údaj";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::EdutageApp.Properties.Resources.covid1;
            this.ClientSize = new System.Drawing.Size(874, 594);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.txtSmerCislo);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menitUdaje);
            this.Controls.Add(this.odstranitRolu);
            this.Controls.Add(this.pridatUcitela);
            this.Controls.Add(this.spravaProjektov);
            this.Controls.Add(this.nadpisEdutage);
            this.Name = "Admin";
            this.Text = "COVID-19 Database";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nadpisEdutage;
        private System.Windows.Forms.Button spravaProjektov;
        private System.Windows.Forms.Button pridatUcitela;
        private System.Windows.Forms.Button odstranitRolu;
        private System.Windows.Forms.Button menitUdaje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtSmerCislo;
        private System.Windows.Forms.Button btnPridat;
    }
}