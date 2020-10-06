namespace Transcender
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.User_Field = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password_Field = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Show_Toggle = new System.Windows.Forms.CheckBox();
            this.DebugBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // User_Field
            // 
            this.User_Field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.User_Field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_Field.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_Field.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.User_Field.Location = new System.Drawing.Point(148, 331);
            this.User_Field.Name = "User_Field";
            this.User_Field.Size = new System.Drawing.Size(250, 54);
            this.User_Field.TabIndex = 0;
            this.User_Field.Text = "Username";
            this.User_Field.Click += new System.EventHandler(this.User_Field_Click);
            this.User_Field.TextChanged += new System.EventHandler(this.UsernameFieldHandler);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.panel1.Location = new System.Drawing.Point(148, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 1);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Password_Field
            // 
            this.Password_Field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Password_Field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_Field.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_Field.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Password_Field.Location = new System.Drawing.Point(148, 442);
            this.Password_Field.Name = "Password_Field";
            this.Password_Field.Size = new System.Drawing.Size(250, 54);
            this.Password_Field.TabIndex = 0;
            this.Password_Field.Text = "Password";
            this.Password_Field.Click += new System.EventHandler(this.Password_Field_Click);
            this.Password_Field.TextChanged += new System.EventHandler(this.PasswordFieldHandler);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.panel2.Location = new System.Drawing.Point(148, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 1);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Sign_In
            // 
            this.Sign_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_In.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sign_In.Location = new System.Drawing.Point(226, 981);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(188, 72);
            this.Sign_In.TabIndex = 2;
            this.Sign_In.Text = "Sign In";
            this.Sign_In.UseVisualStyleBackColor = false;
            this.Sign_In.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Show_Toggle
            // 
            this.Show_Toggle.AutoSize = true;
            this.Show_Toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Show_Toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Toggle.Location = new System.Drawing.Point(543, 465);
            this.Show_Toggle.Name = "Show_Toggle";
            this.Show_Toggle.Size = new System.Drawing.Size(28, 27);
            this.Show_Toggle.TabIndex = 3;
            this.Show_Toggle.UseVisualStyleBackColor = false;
            this.Show_Toggle.CheckedChanged += new System.EventHandler(this.Show_Toggle_CheckedChanged);
            // 
            // DebugBox
            // 
            this.DebugBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DebugBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebugBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DebugBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.DebugBox.Location = new System.Drawing.Point(148, 545);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(373, 390);
            this.DebugBox.TabIndex = 4;
            this.DebugBox.TextChanged += new System.EventHandler(this.DebugBox_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(681, 1167);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.Show_Toggle);
            this.Controls.Add(this.Sign_In);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Password_Field);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.User_Field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transcender";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User_Field;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Password_Field;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.CheckBox Show_Toggle;
        private System.Windows.Forms.TextBox DebugBox;
    }
}

