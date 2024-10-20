namespace CashierApplicationEx2
{
    partial class frmLoginAccount
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
            label1 = new Label();
            TBUsername = new TextBox();
            label2 = new Label();
            TBPassword = new TextBox();
            BLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 37);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(94, 67);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(232, 23);
            TBUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 121);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(94, 152);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(232, 23);
            TBPassword.TabIndex = 3;
            // 
            // BLogin
            // 
            BLogin.BackColor = SystemColors.ActiveCaption;
            BLogin.Location = new Point(94, 209);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(232, 38);
            BLogin.TabIndex = 4;
            BLogin.Text = "Login";
            BLogin.UseVisualStyleBackColor = false;
            BLogin.Click += button1_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(448, 291);
            Controls.Add(BLogin);
            Controls.Add(TBPassword);
            Controls.Add(label2);
            Controls.Add(TBUsername);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "User Login";
            Load += frmLoginAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBUsername;
        private Label label2;
        private TextBox TBPassword;
        private Button BLogin;
    }
}