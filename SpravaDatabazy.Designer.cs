
namespace EdutageApp
{
    partial class SpravaDatabazy
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
            this.nadpisReg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nadpisReg
            // 
            this.nadpisReg.AutoSize = true;
            this.nadpisReg.BackColor = System.Drawing.Color.Aqua;
            this.nadpisReg.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisReg.Location = new System.Drawing.Point(219, 19);
            this.nadpisReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nadpisReg.Name = "nadpisReg";
            this.nadpisReg.Size = new System.Drawing.Size(451, 85);
            this.nadpisReg.TabIndex = 66;
            this.nadpisReg.Text = "Prepínanie modu";
            this.nadpisReg.Click += new System.EventHandler(this.nadpisReg_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 51);
            this.button1.TabIndex = 79;
            this.button1.Text = "Prepnúť do registrácie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpravaDatabazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::EdutageApp.Properties.Resources.covid1;
            this.ClientSize = new System.Drawing.Size(866, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nadpisReg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpravaDatabazy";
            this.Text = "COVID-19 Database";
            this.Load += new System.EventHandler(this.SpravaProjektov_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nadpisReg;
        private System.Windows.Forms.Button button1;
    }
}