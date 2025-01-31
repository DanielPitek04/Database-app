namespace EdutageApp
{
    partial class Doktor
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
            this.zmenitUdajee = new System.Windows.Forms.Button();
            this.spravaProjektov = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nadpisEdutage
            // 
            this.nadpisEdutage.AutoSize = true;
            this.nadpisEdutage.BackColor = System.Drawing.Color.Aqua;
            this.nadpisEdutage.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nadpisEdutage.ForeColor = System.Drawing.Color.DarkCyan;
            this.nadpisEdutage.Location = new System.Drawing.Point(15, 9);
            this.nadpisEdutage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nadpisEdutage.Name = "nadpisEdutage";
            this.nadpisEdutage.Size = new System.Drawing.Size(568, 106);
            this.nadpisEdutage.TabIndex = 2;
            this.nadpisEdutage.Text = "Správa systému";
            // 
            // zmenitUdajee
            // 
            this.zmenitUdajee.BackColor = System.Drawing.Color.DarkCyan;
            this.zmenitUdajee.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zmenitUdajee.Location = new System.Drawing.Point(566, 387);
            this.zmenitUdajee.Name = "zmenitUdajee";
            this.zmenitUdajee.Size = new System.Drawing.Size(242, 193);
            this.zmenitUdajee.TabIndex = 11;
            this.zmenitUdajee.Text = "Zmena údajov";
            this.zmenitUdajee.UseVisualStyleBackColor = false;
            this.zmenitUdajee.Click += new System.EventHandler(this.zmenitUdajee_Click);
            // 
            // spravaProjektov
            // 
            this.spravaProjektov.BackColor = System.Drawing.Color.Turquoise;
            this.spravaProjektov.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spravaProjektov.Location = new System.Drawing.Point(566, 134);
            this.spravaProjektov.Name = "spravaProjektov";
            this.spravaProjektov.Size = new System.Drawing.Size(242, 190);
            this.spravaProjektov.TabIndex = 9;
            this.spravaProjektov.Text = "Prepínať";
            this.spravaProjektov.UseVisualStyleBackColor = false;
            this.spravaProjektov.Click += new System.EventHandler(this.spravaProjektov_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 446);
            this.dataGridView1.TabIndex = 17;
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImage = global::EdutageApp.Properties.Resources.covid1;
            this.ClientSize = new System.Drawing.Size(868, 592);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.zmenitUdajee);
            this.Controls.Add(this.spravaProjektov);
            this.Controls.Add(this.nadpisEdutage);
            this.Name = "Doktor";
            this.Text = "COVID-19 Database";
            this.Load += new System.EventHandler(this.Ucitel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nadpisEdutage;
        private System.Windows.Forms.Button zmenitUdajee;
        private System.Windows.Forms.Button spravaProjektov;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}