namespace EdutageApp
{
    partial class edutageLogin
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
            this.usernameghs = new System.Windows.Forms.Label();
            this.passghs = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.registerr = new System.Windows.Forms.Button();
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.passTBox = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hesloOdkryt = new System.Windows.Forms.Button();
            this.hesloSchovat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nadpisEdutage
            // 
            this.nadpisEdutage.AutoSize = true;
            this.nadpisEdutage.BackColor = System.Drawing.Color.Cyan;
            this.nadpisEdutage.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nadpisEdutage.ForeColor = System.Drawing.Color.DarkCyan;
            this.nadpisEdutage.Location = new System.Drawing.Point(363, 9);
            this.nadpisEdutage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nadpisEdutage.Name = "nadpisEdutage";
            this.nadpisEdutage.Size = new System.Drawing.Size(514, 106);
            this.nadpisEdutage.TabIndex = 0;
            this.nadpisEdutage.Text = "Coronavirus1";
            // 
            // usernameghs
            // 
            this.usernameghs.AutoSize = true;
            this.usernameghs.BackColor = System.Drawing.Color.LightBlue;
            this.usernameghs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameghs.Location = new System.Drawing.Point(533, 270);
            this.usernameghs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameghs.Name = "usernameghs";
            this.usernameghs.Size = new System.Drawing.Size(130, 29);
            this.usernameghs.TabIndex = 1;
            this.usernameghs.Text = "Používateľ ";
            // 
            // passghs
            // 
            this.passghs.AutoSize = true;
            this.passghs.BackColor = System.Drawing.Color.LightBlue;
            this.passghs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passghs.Location = new System.Drawing.Point(533, 380);
            this.passghs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passghs.Name = "passghs";
            this.passghs.Size = new System.Drawing.Size(158, 29);
            this.passghs.TabIndex = 2;
            this.passghs.Text = "Zadajte heslo";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Turquoise;
            this.login.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(879, 574);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(272, 87);
            this.login.TabIndex = 3;
            this.login.Text = "Prihlásiť sa";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // registerr
            // 
            this.registerr.BackColor = System.Drawing.Color.Turquoise;
            this.registerr.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerr.Location = new System.Drawing.Point(12, 574);
            this.registerr.Name = "registerr";
            this.registerr.Size = new System.Drawing.Size(254, 87);
            this.registerr.TabIndex = 4;
            this.registerr.Text = "Registrovať sa";
            this.registerr.UseVisualStyleBackColor = false;
            this.registerr.Click += new System.EventHandler(this.registerr_Click);
            // 
            // usernameTBox
            // 
            this.usernameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTBox.Location = new System.Drawing.Point(731, 267);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(384, 32);
            this.usernameTBox.TabIndex = 5;
            // 
            // passTBox
            // 
            this.passTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTBox.Location = new System.Drawing.Point(731, 377);
            this.passTBox.Name = "passTBox";
            this.passTBox.PasswordChar = '*';
            this.passTBox.Size = new System.Drawing.Size(384, 32);
            this.passTBox.TabIndex = 6;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EdutageApp.Properties.Resources.ccc__1_;
            this.pictureBox1.Location = new System.Drawing.Point(38, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 272);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // hesloOdkryt
            // 
            this.hesloOdkryt.Image = global::EdutageApp.Properties.Resources.show1;
            this.hesloOdkryt.Location = new System.Drawing.Point(1131, 383);
            this.hesloOdkryt.Name = "hesloOdkryt";
            this.hesloOdkryt.Size = new System.Drawing.Size(25, 25);
            this.hesloOdkryt.TabIndex = 8;
            this.hesloOdkryt.UseVisualStyleBackColor = true;
            this.hesloOdkryt.Click += new System.EventHandler(this.hesloOdkryt_Click);
            // 
            // hesloSchovat
            // 
            this.hesloSchovat.Image = global::EdutageApp.Properties.Resources.hide1;
            this.hesloSchovat.Location = new System.Drawing.Point(1131, 382);
            this.hesloSchovat.Name = "hesloSchovat";
            this.hesloSchovat.Size = new System.Drawing.Size(25, 25);
            this.hesloSchovat.TabIndex = 9;
            this.hesloSchovat.UseVisualStyleBackColor = true;
            this.hesloSchovat.Click += new System.EventHandler(this.hesloSchovat_Click);
            // 
            // edutageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::EdutageApp.Properties.Resources.covid1;
            this.ClientSize = new System.Drawing.Size(1163, 673);
            this.Controls.Add(this.hesloSchovat);
            this.Controls.Add(this.hesloOdkryt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passTBox);
            this.Controls.Add(this.usernameTBox);
            this.Controls.Add(this.registerr);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passghs);
            this.Controls.Add(this.usernameghs);
            this.Controls.Add(this.nadpisEdutage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "edutageLogin";
            this.Text = "COVID-19 Database";
            this.Load += new System.EventHandler(this.edutageLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nadpisEdutage;
        private System.Windows.Forms.Label usernameghs;
        private System.Windows.Forms.Label passghs;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button registerr;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.TextBox passTBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hesloOdkryt;
        private System.Windows.Forms.Button hesloSchovat;
    }
}

