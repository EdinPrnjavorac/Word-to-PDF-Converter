namespace WindowsFormsApp1
{
    partial class mailAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailAuth));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrecipient = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(81, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(254, 47);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(144, 20);
            this.txtemail.TabIndex = 2;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(254, 125);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(144, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.IndianRed;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnsend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsend.Location = new System.Drawing.Point(277, 262);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(83, 27);
            this.btnsend.TabIndex = 4;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(81, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recipient";
            // 
            // txtrecipient
            // 
            this.txtrecipient.Location = new System.Drawing.Point(254, 191);
            this.txtrecipient.Name = "txtrecipient";
            this.txtrecipient.Size = new System.Drawing.Size(144, 20);
            this.txtrecipient.TabIndex = 6;
            this.txtrecipient.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.back_icon;
            this.button2.Location = new System.Drawing.Point(-10, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mailAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(578, 332);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtrecipient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mailAuth";
            this.Text = "Mail authentication";
            this.Load += new System.EventHandler(this.mailAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrecipient;
        private System.Windows.Forms.Button button2;
    }
}