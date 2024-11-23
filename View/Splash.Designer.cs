namespace BloodBankManagement.View
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Myprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(386, 28);
            label1.TabIndex = 1;
            label1.Text = "HỆ THỐNG QUẢN LÝ NGÂN HÀNG MÁU";
            // 
            // Myprogress
            // 
            Myprogress.BackColor = Color.Transparent;
            Myprogress.Controls.Add(pictureBox1);
            Myprogress.FillColor = Color.FromArgb(200, 213, 218, 223);
            Myprogress.FillThickness = 15;
            Myprogress.Font = new Font("Segoe UI", 12F);
            Myprogress.ForeColor = Color.White;
            Myprogress.Location = new Point(152, 60);
            Myprogress.Minimum = 0;
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressColor = Color.IndianRed;
            Myprogress.ProgressColor2 = Color.IndianRed;
            Myprogress.ProgressThickness = 15;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogress.Size = new Size(162, 162);
            Myprogress.TabIndex = 2;
            Myprogress.Text = "guna2CircleProgressBar1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(204, 239);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "NHÓM 4";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 263);
            Controls.Add(label3);
            Controls.Add(Myprogress);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Form1_Load;
            Myprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private PictureBox pictureBox1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}