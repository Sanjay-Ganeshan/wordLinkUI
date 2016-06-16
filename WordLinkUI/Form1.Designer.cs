namespace WordLinkUI
{
    partial class Form1
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.rbSignIn = new System.Windows.Forms.RadioButton();
            this.rbSignUp = new System.Windows.Forms.RadioButton();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbLobby = new System.Windows.Forms.GroupBox();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConfirmPassError = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lboxGameList = new System.Windows.Forms.ListBox();
            this.lblLobbyCurrentUser = new System.Windows.Forms.Label();
            this.timerLobbyUpdate = new System.Windows.Forms.Timer(this.components);
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.lblGameID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.gbLogin.SuspendLayout();
            this.gbLobby.SuspendLayout();
            this.gbGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblConfirmPassError);
            this.gbLogin.Controls.Add(this.btnSignIn);
            this.gbLogin.Controls.Add(this.rbSignUp);
            this.gbLogin.Controls.Add(this.rbSignIn);
            this.gbLogin.Controls.Add(this.lblConfirmPassword);
            this.gbLogin.Controls.Add(this.txtConfirm);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblUsername);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Location = new System.Drawing.Point(31, 30);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(213, 195);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login Controls";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(80, 59);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(127, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(80, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(127, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(80, 112);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(127, 20);
            this.txtConfirm.TabIndex = 4;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 115);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(45, 13);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm:";
            this.lblConfirmPassword.Visible = false;
            // 
            // rbSignIn
            // 
            this.rbSignIn.AutoSize = true;
            this.rbSignIn.Checked = true;
            this.rbSignIn.Location = new System.Drawing.Point(28, 20);
            this.rbSignIn.Name = "rbSignIn";
            this.rbSignIn.Size = new System.Drawing.Size(57, 17);
            this.rbSignIn.TabIndex = 6;
            this.rbSignIn.TabStop = true;
            this.rbSignIn.Text = "Sign in";
            this.rbSignIn.UseVisualStyleBackColor = true;
            this.rbSignIn.CheckedChanged += new System.EventHandler(this.rbSignIn_CheckedChanged);
            // 
            // rbSignUp
            // 
            this.rbSignUp.AutoSize = true;
            this.rbSignUp.Location = new System.Drawing.Point(134, 20);
            this.rbSignUp.Name = "rbSignUp";
            this.rbSignUp.Size = new System.Drawing.Size(63, 17);
            this.rbSignUp.TabIndex = 7;
            this.rbSignUp.TabStop = true;
            this.rbSignUp.Text = "Sign Up";
            this.rbSignUp.UseVisualStyleBackColor = true;
            this.rbSignUp.CheckedChanged += new System.EventHandler(this.rbSignUp_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(28, 167);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(148, 21);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // gbLobby
            // 
            this.gbLobby.Controls.Add(this.lblLobbyCurrentUser);
            this.gbLobby.Controls.Add(this.lboxGameList);
            this.gbLobby.Controls.Add(this.btnLogOut);
            this.gbLobby.Controls.Add(this.button1);
            this.gbLobby.Controls.Add(this.btnCreateGame);
            this.gbLobby.Controls.Add(this.btnJoinGame);
            this.gbLobby.Location = new System.Drawing.Point(290, 28);
            this.gbLobby.Name = "gbLobby";
            this.gbLobby.Size = new System.Drawing.Size(384, 488);
            this.gbLobby.TabIndex = 1;
            this.gbLobby.TabStop = false;
            this.gbLobby.Text = "Lobby";
            this.gbLobby.Visible = false;
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Location = new System.Drawing.Point(243, 456);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(135, 26);
            this.btnJoinGame.TabIndex = 0;
            this.btnJoinGame.Text = "Join Game";
            this.btnJoinGame.UseVisualStyleBackColor = true;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(6, 456);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(135, 26);
            this.btnCreateGame.TabIndex = 1;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "↺";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConfirmPassError
            // 
            this.lblConfirmPassError.AutoSize = true;
            this.lblConfirmPassError.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPassError.Location = new System.Drawing.Point(82, 136);
            this.lblConfirmPassError.Name = "lblConfirmPassError";
            this.lblConfirmPassError.Size = new System.Drawing.Size(125, 13);
            this.lblConfirmPassError.TabIndex = 2;
            this.lblConfirmPassError.Text = "X Passwords must match";
            this.lblConfirmPassError.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(16, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lboxGameList
            // 
            this.lboxGameList.FormattingEnabled = true;
            this.lboxGameList.Location = new System.Drawing.Point(7, 55);
            this.lboxGameList.Name = "lboxGameList";
            this.lboxGameList.Size = new System.Drawing.Size(371, 381);
            this.lboxGameList.TabIndex = 3;
            // 
            // lblLobbyCurrentUser
            // 
            this.lblLobbyCurrentUser.AutoSize = true;
            this.lblLobbyCurrentUser.Location = new System.Drawing.Point(97, 27);
            this.lblLobbyCurrentUser.Name = "lblLobbyCurrentUser";
            this.lblLobbyCurrentUser.Size = new System.Drawing.Size(116, 13);
            this.lblLobbyCurrentUser.TabIndex = 4;
            this.lblLobbyCurrentUser.Text = "Currently Logged in As:";
            // 
            // timerLobbyUpdate
            // 
            this.timerLobbyUpdate.Interval = 2000;
            this.timerLobbyUpdate.Tick += new System.EventHandler(this.timerLobbyUpdate_Tick);
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.listBoxPlayers);
            this.gbGame.Controls.Add(this.label2);
            this.gbGame.Controls.Add(this.button2);
            this.gbGame.Controls.Add(this.textBox1);
            this.gbGame.Controls.Add(this.radioButton2);
            this.gbGame.Controls.Add(this.radioButton1);
            this.gbGame.Controls.Add(this.label1);
            this.gbGame.Controls.Add(this.lblGameID);
            this.gbGame.Location = new System.Drawing.Point(703, 28);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(445, 488);
            this.gbGame.TabIndex = 2;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // lblGameID
            // 
            this.lblGameID.AutoSize = true;
            this.lblGameID.Location = new System.Drawing.Point(139, 32);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(55, 13);
            this.lblGameID.TabIndex = 0;
            this.lblGameID.Text = "Game ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "lblCurrentPhrase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(79, 274);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Front";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(79, 298);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Back";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guess";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(79, 138);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(120, 95);
            this.listBoxPlayers.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 557);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbLobby);
            this.Controls.Add(this.gbLogin);
            this.Name = "Form1";
            this.Text = "WordLink";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbLobby.ResumeLayout(false);
            this.gbLobby.PerformLayout();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.RadioButton rbSignUp;
        private System.Windows.Forms.RadioButton rbSignIn;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbLobby;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConfirmPassError;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListBox lboxGameList;
        private System.Windows.Forms.Label lblLobbyCurrentUser;
        private System.Windows.Forms.Timer timerLobbyUpdate;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBoxPlayers;
    }
}

