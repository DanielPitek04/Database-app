namespace EdutageApp
{
    partial class edutageApp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hladat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nadpisEdutage
            // 
            this.nadpisEdutage.AutoSize = true;
            this.nadpisEdutage.BackColor = System.Drawing.Color.Aqua;
            this.nadpisEdutage.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisEdutage.ForeColor = System.Drawing.Color.DarkCyan;
            this.nadpisEdutage.Location = new System.Drawing.Point(15, 9);
            this.nadpisEdutage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nadpisEdutage.Name = "nadpisEdutage";
            this.nadpisEdutage.Size = new System.Drawing.Size(450, 106);
            this.nadpisEdutage.TabIndex = 1;
            this.nadpisEdutage.Text = "COVID Stats";
            // 
            // hladat
            // 
            this.hladat.BackColor = System.Drawing.Color.Turquoise;
            this.hladat.Font = new System.Drawing.Font("PhrasticMedium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hladat.Location = new System.Drawing.Point(595, 138);
            this.hladat.Name = "hladat";
            this.hladat.Size = new System.Drawing.Size(242, 427);
            this.hladat.TabIndex = 13;
            this.hladat.Text = "Info o stredisku";
            this.hladat.UseVisualStyleBackColor = false;
            this.hladat.Click += new System.EventHandler(this.hladat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 427);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // edutageApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::EdutageApp.Properties.Resources.covid1;
            this.ClientSize = new System.Drawing.Size(872, 592);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hladat);
            this.Controls.Add(this.nadpisEdutage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "edutageApp";
            this.Text = "COVID-19 Database";
            this.Load += new System.EventHandler(this.edutageApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nadpisEdutage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button hladat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}