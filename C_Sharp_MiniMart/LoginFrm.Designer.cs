namespace C_Sharp_MiniMart
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.Guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guna2Panel1
            // 
            this.Guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Panel1.BorderRadius = 30;
            this.Guna2Panel1.Controls.Add(this.guna2TileButton1);
            this.Guna2Panel1.Controls.Add(this.guna2ImageCheckBox1);
            this.Guna2Panel1.Controls.Add(this.Guna2Button1);
            this.Guna2Panel1.Controls.Add(this.txtPassword);
            this.Guna2Panel1.Controls.Add(this.Guna2TextBox1);
            this.Guna2Panel1.Controls.Add(this.Label4);
            this.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(52)))), ((int)(((byte)(147)))), ((int)(((byte)(179)))));
            this.Guna2Panel1.Location = new System.Drawing.Point(381, 117);
            this.Guna2Panel1.Name = "Guna2Panel1";
            this.Guna2Panel1.Size = new System.Drawing.Size(362, 456);
            this.Guna2Panel1.TabIndex = 1;
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.BackColor = System.Drawing.Color.White;
            this.guna2ImageCheckBox1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageCheckBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageCheckBox1.Image")));
            this.guna2ImageCheckBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox1.ImageRotate = 0F;
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(264, 233);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageCheckBox1.TabIndex = 7;
            this.guna2ImageCheckBox1.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
            // 
            // Guna2Button1
            // 
            this.Guna2Button1.Animated = true;
            this.Guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button1.BorderRadius = 8;
            this.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button1.ForeColor = System.Drawing.Color.White;
            this.Guna2Button1.Location = new System.Drawing.Point(63, 287);
            this.Guna2Button1.Name = "Guna2Button1";
            this.Guna2Button1.Size = new System.Drawing.Size(237, 43);
            this.Guna2Button1.TabIndex = 8;
            this.Guna2Button1.Text = "Đăng nhập ";
            this.Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.txtPassword.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.txtPassword.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.Location = new System.Drawing.Point(63, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.txtPassword.PlaceholderText = "Mật khẩu ";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(237, 36);
            this.txtPassword.TabIndex = 7;
            // 
            // Guna2TextBox1
            // 
            this.Guna2TextBox1.Animated = true;
            this.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2TextBox1.BorderColor = System.Drawing.Color.White;
            this.Guna2TextBox1.BorderRadius = 8;
            this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2TextBox1.DefaultText = "";
            this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Guna2TextBox1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Guna2TextBox1.Location = new System.Drawing.Point(63, 174);
            this.Guna2TextBox1.Name = "Guna2TextBox1";
            this.Guna2TextBox1.PasswordChar = '\0';
            this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Guna2TextBox1.PlaceholderText = "Tên đăng nhập";
            this.Guna2TextBox1.SelectedText = "";
            this.Guna2TextBox1.Size = new System.Drawing.Size(237, 36);
            this.Guna2TextBox1.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Label4.Location = new System.Drawing.Point(103, 100);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(167, 40);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Đăng nhập";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guna2ControlBox1
            // 
            this.Guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.Guna2ControlBox1.BorderRadius = 4;
            this.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(112)))));
            this.Guna2ControlBox1.Location = new System.Drawing.Point(1084, 3);
            this.Guna2ControlBox1.Name = "Guna2ControlBox1";
            this.Guna2ControlBox1.Size = new System.Drawing.Size(38, 28);
            this.Guna2ControlBox1.TabIndex = 6;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2TileButton1.Location = new System.Drawing.Point(175, 336);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(125, 22);
            this.guna2TileButton1.TabIndex = 9;
            this.guna2TileButton1.Text = "Quên mật khẩu";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 691);
            this.Controls.Add(this.Guna2ControlBox1);
            this.Controls.Add(this.Guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrm";
            this.Text = "LoginFrm";
            this.Guna2Panel1.ResumeLayout(false);
            this.Guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Panel Guna2Panel1;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox1;
        internal System.Windows.Forms.Label Label4;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
    }
}