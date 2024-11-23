namespace BloodBankManagement.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            btn_login = new Guna.UI2.WinForms.Guna2Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(138, 57);
            label1.Name = "label1";
            label1.Size = new Size(419, 31);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ NGÂN HÀNG MÁU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 53);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(76, 185);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(76, 254);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txt_email
            // 
            txt_email.BorderRadius = 8;
            txt_email.CustomizableEdges = customizableEdges1;
            txt_email.DefaultText = "";
            txt_email.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_email.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_email.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_email.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_email.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_email.Location = new Point(241, 178);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.PasswordChar = '\0';
            txt_email.PlaceholderText = "";
            txt_email.SelectedText = "";
            txt_email.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_email.Size = new Size(268, 35);
            txt_email.TabIndex = 4;
            txt_email.TextChanged += txt_email_TextChanged_1;
            // 
            // txt_pass
            // 
            txt_pass.BorderRadius = 8;
            txt_pass.CustomizableEdges = customizableEdges3;
            txt_pass.DefaultText = "";
            txt_pass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_pass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_pass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_pass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_pass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_pass.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_pass.Location = new Point(241, 247);
            txt_pass.Margin = new Padding(3, 4, 3, 4);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.PlaceholderText = "";
            txt_pass.SelectedText = "";
            txt_pass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_pass.Size = new Size(268, 35);
            txt_pass.TabIndex = 5;
            txt_pass.TextChanged += txt_pass_TextChanged;
            // 
            // btn_login
            // 
            btn_login.BorderRadius = 8;
            btn_login.BorderThickness = 1;
            btn_login.CustomizableEdges = customizableEdges5;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.FillColor = Color.FromArgb(255, 128, 128);
            btn_login.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(202, 303);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_login.Size = new Size(234, 35);
            btn_login.TabIndex = 6;
            btn_login.Text = "Đăng nhập";
            btn_login.Click += btn_login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.IndianRed;
            linkLabel1.Location = new Point(274, 353);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cancel";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 431);
            Controls.Add(linkLabel1);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private LinkLabel linkLabel1;
    }
}