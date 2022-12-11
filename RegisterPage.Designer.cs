
namespace GoFinApp
{
    partial class RegisterPage
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
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textNewPassord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textnewEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error_first_name = new System.Windows.Forms.Label();
            this.error_last_name = new System.Windows.Forms.Label();
            this.error_password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(585, 677);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 37);
            this.label9.TabIndex = 70;
            this.label9.Text = "Already have an Account?  Login!";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(502, 610);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(572, 65);
            this.button1.TabIndex = 69;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(486, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 32);
            this.label6.TabIndex = 68;
            this.label6.Text = "Password:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textNewPassord
            // 
            this.textNewPassord.BackColor = System.Drawing.Color.White;
            this.textNewPassord.Font = new System.Drawing.Font("Arial", 12F);
            this.textNewPassord.ForeColor = System.Drawing.Color.Black;
            this.textNewPassord.Location = new System.Drawing.Point(674, 499);
            this.textNewPassord.Margin = new System.Windows.Forms.Padding(2);
            this.textNewPassord.Name = "textNewPassord";
            this.textNewPassord.PasswordChar = '*';
            this.textNewPassord.Size = new System.Drawing.Size(400, 40);
            this.textNewPassord.TabIndex = 67;
            this.textNewPassord.UseSystemPasswordChar = true;
            this.textNewPassord.TextChanged += new System.EventHandler(this.textNewPassord_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(486, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 66;
            this.label5.Text = "Email:";
            // 
            // textnewEmail
            // 
            this.textnewEmail.BackColor = System.Drawing.Color.White;
            this.textnewEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.textnewEmail.ForeColor = System.Drawing.Color.Black;
            this.textnewEmail.Location = new System.Drawing.Point(674, 406);
            this.textnewEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textnewEmail.Name = "textnewEmail";
            this.textnewEmail.Size = new System.Drawing.Size(400, 40);
            this.textnewEmail.TabIndex = 65;
            this.textnewEmail.TextChanged += new System.EventHandler(this.textnewEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(486, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 62;
            this.label2.Text = "Last Name:";
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.Color.White;
            this.textLastName.Font = new System.Drawing.Font("Arial", 12F);
            this.textLastName.ForeColor = System.Drawing.Color.Black;
            this.textLastName.Location = new System.Drawing.Point(674, 318);
            this.textLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(400, 40);
            this.textLastName.TabIndex = 61;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(493, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 32);
            this.label4.TabIndex = 60;
            this.label4.Text = "First Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.Color.White;
            this.textFirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.textFirstName.ForeColor = System.Drawing.Color.Black;
            this.textFirstName.Location = new System.Drawing.Point(674, 219);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(400, 40);
            this.textFirstName.TabIndex = 59;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(528, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 115);
            this.label1.TabIndex = 58;
            this.label1.Text = "GoFinance";
            // 
            // error_first_name
            // 
            this.error_first_name.AutoSize = true;
            this.error_first_name.ForeColor = System.Drawing.Color.White;
            this.error_first_name.Location = new System.Drawing.Point(678, 177);
            this.error_first_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_first_name.Name = "error_first_name";
            this.error_first_name.Size = new System.Drawing.Size(0, 25);
            this.error_first_name.TabIndex = 73;
            // 
            // error_last_name
            // 
            this.error_last_name.AutoSize = true;
            this.error_last_name.ForeColor = System.Drawing.Color.White;
            this.error_last_name.Location = new System.Drawing.Point(678, 279);
            this.error_last_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_last_name.Name = "error_last_name";
            this.error_last_name.Size = new System.Drawing.Size(0, 25);
            this.error_last_name.TabIndex = 74;
            this.error_last_name.Click += new System.EventHandler(this.error_last_name_Click);
            // 
            // error_password
            // 
            this.error_password.AutoSize = true;
            this.error_password.ForeColor = System.Drawing.Color.White;
            this.error_password.Location = new System.Drawing.Point(678, 461);
            this.error_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_password.Name = "error_password";
            this.error_password.Size = new System.Drawing.Size(0, 25);
            this.error_password.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(810, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 78;
            this.label3.Text = "Clear Fields ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // error_email
            // 
            this.error_email.AutoSize = true;
            this.error_email.ForeColor = System.Drawing.Color.White;
            this.error_email.Location = new System.Drawing.Point(678, 370);
            this.error_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_email.Name = "error_email";
            this.error_email.Size = new System.Drawing.Size(0, 25);
            this.error_email.TabIndex = 77;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1476, 836);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.error_email);
            this.Controls.Add(this.error_password);
            this.Controls.Add(this.error_last_name);
            this.Controls.Add(this.error_first_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNewPassord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textnewEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPage";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNewPassord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textnewEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_first_name;
        private System.Windows.Forms.Label error_last_name;
        private System.Windows.Forms.Label error_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error_email;
    }
}