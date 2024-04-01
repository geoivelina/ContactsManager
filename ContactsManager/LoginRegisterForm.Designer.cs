namespace ContactsManager
{
    partial class LoginRegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.acountLoginLable = new System.Windows.Forms.Label();
            this.usernameLable = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.TextBox();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registerLastNameValue = new System.Windows.Forms.TextBox();
            this.registerFirstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.registerPasswordValue = new System.Windows.Forms.TextBox();
            this.registerUsernameValue = new System.Windows.Forms.TextBox();
            this.registerPasswordLable = new System.Windows.Forms.Label();
            this.registerUsernameLable = new System.Windows.Forms.Label();
            this.registerPictureBox = new System.Windows.Forms.PictureBox();
            this.registerPictureLable = new System.Windows.Forms.Label();
            this.registerUploadPictureBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.minimizePanel = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Panel();
            this.loginMinimizeBtn = new System.Windows.Forms.Button();
            this.loginCloseBtn = new System.Windows.Forms.Button();
            this.goToRegisterLable = new System.Windows.Forms.Label();
            this.goToLoginLable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureBox)).BeginInit();
            this.minimizePanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.closePanel);
            this.panel1.Controls.Add(this.minimizePanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.goToLoginLable);
            this.panel2.Controls.Add(this.goToRegisterLable);
            this.panel2.Controls.Add(this.registerBtn);
            this.panel2.Controls.Add(this.registerUploadPictureBtn);
            this.panel2.Controls.Add(this.registerPictureLable);
            this.panel2.Controls.Add(this.registerPictureBox);
            this.panel2.Controls.Add(this.registerPasswordValue);
            this.panel2.Controls.Add(this.registerUsernameValue);
            this.panel2.Controls.Add(this.registerPasswordLable);
            this.panel2.Controls.Add(this.registerUsernameLable);
            this.panel2.Controls.Add(this.registerLastNameValue);
            this.panel2.Controls.Add(this.registerFirstNameValue);
            this.panel2.Controls.Add(this.lastNameLable);
            this.panel2.Controls.Add(this.firstNameLable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.loginBtn);
            this.panel2.Controls.Add(this.passwordValue);
            this.panel2.Controls.Add(this.usernameValue);
            this.panel2.Controls.Add(this.passwordLable);
            this.panel2.Controls.Add(this.usernameLable);
            this.panel2.Controls.Add(this.acountLoginLable);
            this.panel2.Location = new System.Drawing.Point(-6, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 656);
            this.panel2.TabIndex = 0;
            // 
            // acountLoginLable
            // 
            this.acountLoginLable.AutoSize = true;
            this.acountLoginLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acountLoginLable.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acountLoginLable.ForeColor = System.Drawing.Color.White;
            this.acountLoginLable.Location = new System.Drawing.Point(87, 61);
            this.acountLoginLable.Name = "acountLoginLable";
            this.acountLoginLable.Size = new System.Drawing.Size(226, 34);
            this.acountLoginLable.TabIndex = 1;
            this.acountLoginLable.Text = "Account Login";
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLable.ForeColor = System.Drawing.Color.White;
            this.usernameLable.Location = new System.Drawing.Point(71, 198);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(117, 25);
            this.usernameLable.TabIndex = 2;
            this.usernameLable.Text = "Username:";
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLable.ForeColor = System.Drawing.Color.White;
            this.passwordLable.Location = new System.Drawing.Point(71, 265);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(113, 25);
            this.passwordLable.TabIndex = 3;
            this.passwordLable.Text = "Password:";
            // 
            // usernameValue
            // 
            this.usernameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameValue.Location = new System.Drawing.Point(205, 201);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(152, 30);
            this.usernameValue.TabIndex = 4;
            // 
            // passwordValue
            // 
            this.passwordValue.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordValue.Location = new System.Drawing.Point(205, 268);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.Size = new System.Drawing.Size(152, 30);
            this.passwordValue.TabIndex = 5;
            this.passwordValue.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(118, 406);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(176, 56);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create New Account";
            // 
            // registerLastNameValue
            // 
            this.registerLastNameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.registerLastNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLastNameValue.Location = new System.Drawing.Point(599, 198);
            this.registerLastNameValue.Name = "registerLastNameValue";
            this.registerLastNameValue.Size = new System.Drawing.Size(175, 30);
            this.registerLastNameValue.TabIndex = 11;
            // 
            // registerFirstNameValue
            // 
            this.registerFirstNameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.registerFirstNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerFirstNameValue.Location = new System.Drawing.Point(599, 137);
            this.registerFirstNameValue.Name = "registerFirstNameValue";
            this.registerFirstNameValue.Size = new System.Drawing.Size(175, 30);
            this.registerFirstNameValue.TabIndex = 10;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLable.ForeColor = System.Drawing.Color.White;
            this.lastNameLable.Location = new System.Drawing.Point(453, 198);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(128, 25);
            this.lastNameLable.TabIndex = 9;
            this.lastNameLable.Text = "Last Name:";
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLable.ForeColor = System.Drawing.Color.White;
            this.firstNameLable.Location = new System.Drawing.Point(451, 137);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(132, 25);
            this.firstNameLable.TabIndex = 8;
            this.firstNameLable.Text = "First Name:";
            // 
            // registerPasswordValue
            // 
            this.registerPasswordValue.BackColor = System.Drawing.Color.Gainsboro;
            this.registerPasswordValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerPasswordValue.Location = new System.Drawing.Point(599, 323);
            this.registerPasswordValue.Name = "registerPasswordValue";
            this.registerPasswordValue.Size = new System.Drawing.Size(175, 30);
            this.registerPasswordValue.TabIndex = 15;
            this.registerPasswordValue.UseSystemPasswordChar = true;
            // 
            // registerUsernameValue
            // 
            this.registerUsernameValue.BackColor = System.Drawing.Color.Gainsboro;
            this.registerUsernameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerUsernameValue.Location = new System.Drawing.Point(599, 263);
            this.registerUsernameValue.Name = "registerUsernameValue";
            this.registerUsernameValue.Size = new System.Drawing.Size(175, 30);
            this.registerUsernameValue.TabIndex = 14;
            // 
            // registerPasswordLable
            // 
            this.registerPasswordLable.AutoSize = true;
            this.registerPasswordLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswordLable.ForeColor = System.Drawing.Color.White;
            this.registerPasswordLable.Location = new System.Drawing.Point(466, 323);
            this.registerPasswordLable.Name = "registerPasswordLable";
            this.registerPasswordLable.Size = new System.Drawing.Size(113, 25);
            this.registerPasswordLable.TabIndex = 13;
            this.registerPasswordLable.Text = "Password:";
            // 
            // registerUsernameLable
            // 
            this.registerUsernameLable.AutoSize = true;
            this.registerUsernameLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsernameLable.ForeColor = System.Drawing.Color.White;
            this.registerUsernameLable.Location = new System.Drawing.Point(462, 263);
            this.registerUsernameLable.Name = "registerUsernameLable";
            this.registerUsernameLable.Size = new System.Drawing.Size(117, 25);
            this.registerUsernameLable.TabIndex = 12;
            this.registerUsernameLable.Text = "Username:";
            // 
            // registerPictureBox
            // 
            this.registerPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.registerPictureBox.Location = new System.Drawing.Point(599, 384);
            this.registerPictureBox.Name = "registerPictureBox";
            this.registerPictureBox.Size = new System.Drawing.Size(139, 113);
            this.registerPictureBox.TabIndex = 16;
            this.registerPictureBox.TabStop = false;
            // 
            // registerPictureLable
            // 
            this.registerPictureLable.AutoSize = true;
            this.registerPictureLable.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPictureLable.ForeColor = System.Drawing.Color.White;
            this.registerPictureLable.Location = new System.Drawing.Point(485, 384);
            this.registerPictureLable.Name = "registerPictureLable";
            this.registerPictureLable.Size = new System.Drawing.Size(93, 25);
            this.registerPictureLable.TabIndex = 17;
            this.registerPictureLable.Text = "Picture:";
            // 
            // registerUploadPictureBtn
            // 
            this.registerUploadPictureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerUploadPictureBtn.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUploadPictureBtn.Location = new System.Drawing.Point(748, 384);
            this.registerUploadPictureBtn.Name = "registerUploadPictureBtn";
            this.registerUploadPictureBtn.Size = new System.Drawing.Size(26, 113);
            this.registerUploadPictureBtn.TabIndex = 18;
            this.registerUploadPictureBtn.Text = "add";
            this.registerUploadPictureBtn.UseVisualStyleBackColor = true;
            this.registerUploadPictureBtn.Click += new System.EventHandler(this.registerUploadPictureBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(528, 525);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(176, 56);
            this.registerBtn.TabIndex = 19;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // minimizePanel
            // 
            this.minimizePanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.minimizePanel.Controls.Add(this.loginMinimizeBtn);
            this.minimizePanel.Location = new System.Drawing.Point(265, 12);
            this.minimizePanel.Name = "minimizePanel";
            this.minimizePanel.Size = new System.Drawing.Size(56, 46);
            this.minimizePanel.TabIndex = 1;
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.closePanel.Controls.Add(this.loginCloseBtn);
            this.closePanel.Location = new System.Drawing.Point(341, 12);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(56, 46);
            this.closePanel.TabIndex = 2;
            // 
            // loginMinimizeBtn
            // 
            this.loginMinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginMinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginMinimizeBtn.Location = new System.Drawing.Point(5, 2);
            this.loginMinimizeBtn.Name = "loginMinimizeBtn";
            this.loginMinimizeBtn.Size = new System.Drawing.Size(44, 44);
            this.loginMinimizeBtn.TabIndex = 3;
            this.loginMinimizeBtn.UseVisualStyleBackColor = false;
            this.loginMinimizeBtn.Click += new System.EventHandler(this.loginMinimizeBtn_Click);
            // 
            // loginCloseBtn
            // 
            this.loginCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginCloseBtn.Location = new System.Drawing.Point(4, 2);
            this.loginCloseBtn.Name = "loginCloseBtn";
            this.loginCloseBtn.Size = new System.Drawing.Size(44, 44);
            this.loginCloseBtn.TabIndex = 4;
            this.loginCloseBtn.UseVisualStyleBackColor = false;
            this.loginCloseBtn.Click += new System.EventHandler(this.loginCloseBtn_Click);
            // 
            // goToRegisterLable
            // 
            this.goToRegisterLable.AutoSize = true;
            this.goToRegisterLable.BackColor = System.Drawing.Color.DarkSlateGray;
            this.goToRegisterLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToRegisterLable.Font = new System.Drawing.Font("Modern No. 20", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToRegisterLable.ForeColor = System.Drawing.Color.White;
            this.goToRegisterLable.Location = new System.Drawing.Point(9, 609);
            this.goToRegisterLable.Name = "goToRegisterLable";
            this.goToRegisterLable.Size = new System.Drawing.Size(348, 21);
            this.goToRegisterLable.TabIndex = 20;
            this.goToRegisterLable.Text = "Don`t have an account yet? Sign up now >>";
            this.goToRegisterLable.Click += new System.EventHandler(this.goToRegisterLable_Click);
            // 
            // goToLoginLable
            // 
            this.goToLoginLable.AutoSize = true;
            this.goToLoginLable.BackColor = System.Drawing.Color.DarkSlateGray;
            this.goToLoginLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLoginLable.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLoginLable.ForeColor = System.Drawing.Color.White;
            this.goToLoginLable.Location = new System.Drawing.Point(429, 609);
            this.goToLoginLable.Name = "goToLoginLable";
            this.goToLoginLable.Size = new System.Drawing.Size(365, 22);
            this.goToLoginLable.TabIndex = 21;
            this.goToLoginLable.Text = "<< You have an account already? Log In";
            this.goToLoginLable.Click += new System.EventHandler(this.goToLoginLable_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LoginRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginRegisterForm";
            this.Text = "Login/Register Form";
            this.Load += new System.EventHandler(this.LoginRegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerPictureBox)).EndInit();
            this.minimizePanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel minimizePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button registerUploadPictureBtn;
        private System.Windows.Forms.Label registerPictureLable;
        private System.Windows.Forms.PictureBox registerPictureBox;
        private System.Windows.Forms.TextBox registerPasswordValue;
        private System.Windows.Forms.TextBox registerUsernameValue;
        private System.Windows.Forms.Label registerPasswordLable;
        private System.Windows.Forms.Label registerUsernameLable;
        private System.Windows.Forms.TextBox registerLastNameValue;
        private System.Windows.Forms.TextBox registerFirstNameValue;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordValue;
        private System.Windows.Forms.TextBox usernameValue;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.Label acountLoginLable;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Button loginCloseBtn;
        private System.Windows.Forms.Button loginMinimizeBtn;
        private System.Windows.Forms.Label goToLoginLable;
        private System.Windows.Forms.Label goToRegisterLable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}