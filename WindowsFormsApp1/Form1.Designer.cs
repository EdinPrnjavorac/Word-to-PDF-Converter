namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtusernamelogin = new System.Windows.Forms.TextBox();
            this.txtpasswordlogin = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnlogin.Location = new System.Drawing.Point(273, 208);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(95, 32);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // txtusernamelogin
            // 
            this.txtusernamelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtusernamelogin.Location = new System.Drawing.Point(239, 73);
            this.txtusernamelogin.Name = "txtusernamelogin";
            this.txtusernamelogin.Size = new System.Drawing.Size(164, 26);
            this.txtusernamelogin.TabIndex = 1;
            this.txtusernamelogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusernamelogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpasswordlogin
            // 
            this.txtpasswordlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpasswordlogin.Location = new System.Drawing.Point(239, 136);
            this.txtpasswordlogin.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtpasswordlogin.Name = "txtpasswordlogin";
            this.txtpasswordlogin.PasswordChar = '*';
            this.txtpasswordlogin.Size = new System.Drawing.Size(164, 26);
            this.txtpasswordlogin.TabIndex = 2;
            this.txtpasswordlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpasswordlogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernametxt
            // 
            this.usernametxt.AutoSize = true;
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernametxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usernametxt.Location = new System.Drawing.Point(78, 76);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(83, 20);
            this.usernametxt.TabIndex = 3;
            this.usernametxt.Text = "Username";
            // 
            // passwordtxt
            // 
            this.passwordtxt.AutoSize = true;
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordtxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.passwordtxt.Location = new System.Drawing.Point(78, 139);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(78, 20);
            this.passwordtxt.TabIndex = 4;
            this.passwordtxt.Text = "Password";
            this.passwordtxt.Click += new System.EventHandler(this.passwordtxt_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Nina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(448, 315);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.LightBlue;
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Nina", 9F, System.Drawing.FontStyle.Bold);
            this.btnregister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnregister.Location = new System.Drawing.Point(64, 315);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(80, 23);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.registerbtn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(579, 366);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.txtpasswordlogin);
            this.Controls.Add(this.txtusernamelogin);
            this.Controls.Add(this.btnlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtusernamelogin;
        private System.Windows.Forms.TextBox txtpasswordlogin;
        private System.Windows.Forms.Label usernametxt;
        private System.Windows.Forms.Label passwordtxt;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnregister;
    }
}

