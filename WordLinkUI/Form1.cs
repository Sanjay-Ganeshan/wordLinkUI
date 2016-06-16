using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WordLinkUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StateMachine.server = new WordLinkServer();
            StateMachine.server.setServer("http://10.252.64.194:8080/");
        }

        private void rbSignUp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSignIn_CheckedChanged(object sender, EventArgs e)
        {
            lblConfirmPassword.Visible = !lblConfirmPassword.Visible;
            txtConfirm.Visible = !txtConfirm.Visible;
            if(rbSignIn.Checked)
            {
                btnSignIn.Text = "Sign In";
                lblConfirmPassError.Visible = false;
            }
            else if(rbSignUp.Checked)
            {
                btnSignIn.Text = "Sign Up";
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            StateMachine.server.setLoginInfo(this.txtUsername.Text, this.txtPassword.Text);
            lblConfirmPassError.Visible = false;
            if(rbSignIn.Checked)
                signIn();
            else if(rbSignUp.Checked)
            {
                if(!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    lblConfirmPassError.Visible = true;
                }
                else
                {
                    signUp();
                }
            }
        }

        async void signIn()
        {
            WLServerResponse resp = await StateMachine.server.logIn();
            if (resp.worked)
                transitionFromSignInToLobby();
            else
                broadcastError(resp);
        }

        public void broadcastError(WLServerResponse resp)
        {
            string s = resp.info.error;
            MessageBox.Show(s);
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {

        }

        void transitionFromLobbyToGame()
        {

        }

        void transitionFromGameToLobby()
        {

        }

        void transitionFromSignInToLobby()
        {
            btnLogOut.Visible = true;
            gbLobby.Visible = true;
            gbLogin.Visible = false;
            setUpLobby();
        }

        void transitionFromLobbyToSignIn()
        {
            btnLogOut.Visible = false;
            gbLobby.Visible = false;
            gbLogin.Visible = true;
            setUpSignIn();
        }

        void setUpLobby()
        {
            lblLobbyCurrentUser.Text = "Currently signed in as: " + StateMachine.server.getCurrentUser();
            timerLobbyUpdate.Start();
        }

        async void createGame()
        {
            WLServerResponse resp = await StateMachine.server.createGame();
            if (resp.worked)
            {
                transitionFromLobbyToGame();
            }
            else
                broadcastError(resp);
        }

        async void joinGame()
        {
            string gameId = "";
            gameId = lboxGameList.SelectedItem.ToString();
            WLServerResponse resp = await StateMachine.server.joinGame(gameId);
            if (resp.worked)
            {
                transitionFromLobbyToGame();
            }
            else
                broadcastError(resp);
        }

        async void updateLobby()
        {
            WLServerResponse resp = await StateMachine.server.getGamesList();
            if (resp.worked)
            {
                List<object> gamesList = resp.info.gamesList;
                lboxGameList.Items.Clear();
                foreach(object o in gamesList)
                {
                    lboxGameList.Items.Add(o.ToString());
                }
            }
            else
                broadcastError(resp);
        }

        void setUpSignIn()
        {
            timerLobbyUpdate.Stop();
        }


        async void signUp()
        {
            WLServerResponse resp = await StateMachine.server.signUp();
            if (resp.worked)
            {
                MessageBox.Show("You're good to go! Try logging in now.");
                rbSignIn.Checked = true;
            }
            else
                broadcastError(resp);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            transitionFromLobbyToSignIn();
        }

        private void timerLobbyUpdate_Tick(object sender, EventArgs e)
        {
            updateLobby();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateLobby();
        }
    }
}
