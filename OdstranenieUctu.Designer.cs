
namespace EdutageApp
{
    partial class OdstranenieUctu
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
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.menohlg = new System.Windows.Forms.Label();
            this.účetDELETE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nadpisReg
            // 
            this.nadpisReg.AutoSize = true;
            this.nadpisReg.BackColor = System.Drawing.Color.Aqua;
            this.nadpisReg.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisReg.Location = new System.Drawing.Point(217, 35);
            this.nadpisReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nadpisReg.Name = "nadpisReg";
            this.nadpisReg.Size = new System.Drawing.Size(452, 85);
            this.nadpisReg.TabIndex = 66;
            this.nadpisReg.Text = "Odstránenie účtu";
            // 
            // usernameTBox
            // 
            this.usernameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTBox.Location = new System.Drawing.Point(424, 171);
            this.usernameTBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(206, 35);
            this.usernameTBox.TabIndex = 58;
            // 
            // menohlg
            // 
            this.menohlg.AutoSize = true;
            this.menohlg.BackColor = System.Drawing.Color.LightBlue;
            this.menohlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menohlg.Location = new System.Drawing.Point(256, 175);
            this.menohlg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menohlg.Name = "menohlg";
            this.menohlg.Size = new System.Drawing.Size(148, 29);
            this.menohlg.TabIndex = 56;
            this.menohlg.Text = "Používateľ :";
            // 
            // účetDELETE
            // 
            this.účetDELETE.BackColor = System.Drawing.Color.Turquoise;
            this.účetDELETE.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.účetDELETE.Location = new System.Drawing.Point(298, 269);
            this.účetDELETE.Margin = new System.Windows.Forms.Padding(2);
            this.účetDELETE.Name = "účetDELETE";
            this.účetDELETE.Size = new System.Drawing.Size(296, 111);
            this.účetDELETE.TabIndex = 55;
            this.účetDELETE.Text = "Odstrániť";
            this.účetDELETE.UseVisualStyleBackColor = false;
            this.účetDELETE.Click += new System.EventHandler(this.účetDELETE_Click);
            // 
            // OdstranenieUctu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImage = global::EdutageApp.Properties.Resources.covid1;
            this.ClientSize = new System.Drawing.Size(879, 439);
            this.Controls.Add(this.nadpisReg);
            this.Controls.Add(this.usernameTBox);
            this.Controls.Add(this.menohlg);
            this.Controls.Add(this.účetDELETE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdstranenieUctu";
            this.Text = "COVID-19 Database";
            this.Load += new System.EventHandler(this.OdstranenieUctu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nadpisReg;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.Label menohlg;
        private System.Windows.Forms.Button účetDELETE;
    }
}