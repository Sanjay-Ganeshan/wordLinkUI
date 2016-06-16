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
            this.lblCurrentPhrase = new System.Windows.Forms.Label();
            this.rbFront = new System.Windows.Forms.RadioButton();
            this.rbBack = new System.Windows.Forms.RadioButton();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.timerGameUpdate = new System.Windows.Forms.Timer(this.components);
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.gbTurn = new System.Windows.Forms.GroupBox();
            this.txtGameLog = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnLeaveGame = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbLobby.SuspendLayout();
            this.gbGame.SuspendLayout();
            this.gbTurn.SuspendLayout();
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
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
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
            this.timerLobbyUpdate.Interval = 4000;
            this.timerLobbyUpdate.Tick += new System.EventHandler(this.timerLobbyUpdate_Tick);
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.lblCorrect);
            this.gbGame.Controls.Add(this.txtGameLog);
            this.gbGame.Controls.Add(this.gbTurn);
            this.gbGame.Controls.Add(this.listViewPlayers);
            this.gbGame.Controls.Add(this.lblCurrentPhrase);
            this.gbGame.Controls.Add(this.lblGameID);
            this.gbGame.Location = new System.Drawing.Point(703, 28);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(445, 488);
            this.gbGame.TabIndex = 2;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            this.gbGame.Visible = false;
            // 
            // lblGameID
            // 
            this.lblGameID.Location = new System.Drawing.Point(21, 27);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(418, 18);
            this.lblGameID.TabIndex = 0;
            this.lblGameID.Text = "Game ID: ";
            this.lblGameID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentPhrase
            // 
            this.lblCurrentPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPhrase.Location = new System.Drawing.Point(6, 61);
            this.lblCurrentPhrase.Name = "lblCurrentPhrase";
            this.lblCurrentPhrase.Size = new System.Drawing.Size(433, 34);
            this.lblCurrentPhrase.TabIndex = 1;
            this.lblCurrentPhrase.Text = "lblCurrentPhrase";
            this.lblCurrentPhrase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbFront
            // 
            this.rbFront.AutoSize = true;
            this.rbFront.Enabled = false;
            this.rbFront.Location = new System.Drawing.Point(6, 19);
            this.rbFront.Name = "rbFront";
            this.rbFront.Size = new System.Drawing.Size(49, 17);
            this.rbFront.TabIndex = 2;
            this.rbFront.TabStop = true;
            this.rbFront.Text = "Front";
            this.rbFront.UseVisualStyleBackColor = true;
            // 
            // rbBack
            // 
            this.rbBack.AutoSize = true;
            this.rbBack.Enabled = false;
            this.rbBack.Location = new System.Drawing.Point(6, 42);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(50, 17);
            this.rbBack.TabIndex = 3;
            this.rbBack.TabStop = true;
            this.rbBack.Text = "Back";
            this.rbBack.UseVisualStyleBackColor = true;
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(66, 41);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(145, 20);
            this.txtGuess.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(18, 67);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 28);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(124, 19);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(37, 13);
            this.lblGuess.TabIndex = 6;
            this.lblGuess.Text = "Guess";
            // 
            // timerGameUpdate
            // 
            this.timerGameUpdate.Interval = 3000;
            this.timerGameUpdate.Tick += new System.EventHandler(this.timerGameUpdate_Tick);
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Location = new System.Drawing.Point(103, 138);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(229, 97);
            this.listViewPlayers.TabIndex = 7;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            // 
            // gbTurn
            // 
            this.gbTurn.Controls.Add(this.btnLeaveGame);
            this.gbTurn.Controls.Add(this.btnSubmit);
            this.gbTurn.Controls.Add(this.txtGuess);
            this.gbTurn.Controls.Add(this.rbBack);
            this.gbTurn.Controls.Add(this.lblGuess);
            this.gbTurn.Controls.Add(this.rbFront);
            this.gbTurn.Location = new System.Drawing.Point(103, 241);
            this.gbTurn.Name = "gbTurn";
            this.gbTurn.Size = new System.Drawing.Size(217, 115);
            this.gbTurn.TabIndex = 8;
            this.gbTurn.TabStop = false;
            this.gbTurn.Text = "Your Turn";
            this.gbTurn.Visible = false;
            // 
            // txtGameLog
            // 
            this.txtGameLog.AcceptsReturn = true;
            this.txtGameLog.Location = new System.Drawing.Point(14, 372);
            this.txtGameLog.Multiline = true;
            this.txtGameLog.Name = "txtGameLog";
            this.txtGameLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGameLog.Size = new System.Drawing.Size(424, 109);
            this.txtGameLog.TabIndex = 9;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(326, 280);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(35, 13);
            this.lblCorrect.TabIndex = 7;
            this.lblCorrect.Text = "label1";
            this.lblCorrect.Visible = false;
            // 
            // btnLeaveGame
            // 
            this.btnLeaveGame.Location = new System.Drawing.Point(159, 67);
            this.btnLeaveGame.Name = "btnLeaveGame";
            this.btnLeaveGame.Size = new System.Drawing.Size(52, 28);
            this.btnLeaveGame.TabIndex = 7;
            this.btnLeaveGame.Text = "Leave";
            this.btnLeaveGame.UseVisualStyleBackColor = true;
            this.btnLeaveGame.Click += new System.EventHandler(this.btnLeaveGame_Click);
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
            this.gbTurn.ResumeLayout(false);
            this.gbTurn.PerformLayout();
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
        private System.Windows.Forms.Label lblCurrentPhrase;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.RadioButton rbBack;
        private System.Windows.Forms.RadioButton rbFront;
        private System.Windows.Forms.Timer timerGameUpdate;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.GroupBox gbTurn;
        private System.Windows.Forms.TextBox txtGameLog;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnLeaveGame;
    }
}

