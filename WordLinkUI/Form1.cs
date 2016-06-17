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
            //StateMachine.server.setServer("http://10.252.64.194:8080/");
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
            StateMachine.server.setServer(txtServer.Text);
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
            createGame();
        }

        void transitionFromLobbyToGame()
        {
            timerLobbyUpdate.Stop();
            btnLogOut.Visible = false;
            gbLobby.Visible = false;
            gbGame.Visible = true;
            timerGameUpdate.Start();
        }

        void transitionFromGameToLobby()
        {
            timerLobbyUpdate.Start();
            btnLogOut.Visible = true;
            gbLobby.Visible = true;
            gbGame.Visible = false;
            timerGameUpdate.Stop();
            hideCorrect();
        }

        void transitionFromSignInToLobby()
        {
            timerLobbyUpdate.Start();
            btnLogOut.Visible = true;
            gbLobby.Visible = true;
            gbLogin.Visible = false;
            setUpLobby();
        }

        void transitionFromLobbyToSignIn()
        {
            timerLobbyUpdate.Stop();
            btnLogOut.Visible = false;
            gbLobby.Visible = false;
            gbLogin.Visible = true;
            setUpSignIn();
        }

        void setUpLobby()
        {
            lblLobbyCurrentUser.Text = "Currently signed in as: " + StateMachine.server.getCurrentUser();
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
                int selectedIndex = lboxGameList.SelectedIndex;
                lboxGameList.Items.Clear();
                foreach(object o in gamesList)
                {
                    lboxGameList.Items.Add(o.ToString());
                }
                if(selectedIndex < gamesList.Count)
                {
                    lboxGameList.SelectedIndex = selectedIndex;
                }
            }
            else
                broadcastError(resp);
        }

        async void submitDirection()
        {
            string direction = rbFront.Checked ? "front" : "back";
            WLServerResponse resp = await StateMachine.server.submitDirection(direction);
            if (resp.worked)
            {
                changeToGuessMode();
                updateGame();
            }
            else
                broadcastError(resp);

        }

        async void submitGuess()
        {
            string guess = txtGuess.Text;
            WLServerResponse resp = await StateMachine.server.submitGuess(guess);
            if (resp.worked)
            {
                if (resp.info.isCorrect)
                {
                    showCorrect();
                }
                else
                {
                    showIncorrect();
                }
                changeToWatchMode();
                updateGame();
            }
            else
                broadcastError(resp);

        }

        void setUpSignIn()
        {

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

        async void updateGame()
        {
            WLServerResponse resp = await StateMachine.server.getGameSummary();
            if (resp.worked)
            {
                lblGameID.Text = "Game ID: " + resp.info.summary.gameid;
                List<dynamic> players = resp.info.summary.players;
                List<ListViewItem> newItems = new List<ListViewItem>();
                foreach (var eachPlayer in players)
                {
                    ListViewItem newItem = new ListViewItem(new string[] { eachPlayer["turn"]? ">":"" , eachPlayer["name"], eachPlayer["score"] + ""});
                    newItems.Add(newItem);
                }
                listViewPlayers.Items.Clear();
                listViewPlayers.Columns.Clear();
                listViewPlayers.Columns.Add("Turn");
                listViewPlayers.Columns.Add("Name");
                listViewPlayers.Columns.Add("Score");
                foreach (ListViewItem it in newItems)
                {
                    listViewPlayers.Items.Add(it);
                }
                lblCurrentPhrase.Text = resp.info.summary.phrase;
                List<dynamic> gameLogs = resp.info.summary.guesslog;
                txtGameLog.Text = "";
                int lineNum = 0;
                foreach (var eachLog in gameLogs)
                {
                    txtGameLog.Text += eachLog + Environment.NewLine;
                }

                if (resp.info.summary.isturn)
                {
                    if(isWatchMode())
                    {
                        changeToDirectionMode();
                    }
                }
                else
                {
                    if(!isWatchMode())
                    {
                        changeToWatchMode();
                    }
                }
            }
            else
                broadcastError(resp);
        }

        void changeToGuessMode()
        {
            gbTurn.Visible = true;
            rbBack.Enabled = false;
            rbFront.Enabled = false;
            txtGuess.Enabled = true;
            btnLeaveGame.Visible = false;
            btnSubmit.Text = "Guess!";
        }

        void changeToWatchMode()
        {
            gbTurn.Visible = false;
            rbBack.Enabled = false;
            rbFront.Enabled = false;
            txtGuess.Enabled = false;
            btnLeaveGame.Visible = false;
            btnSubmit.Text = "Watching";
        }

        void changeToDirectionMode()
        {
            gbTurn.Visible = true;
            rbBack.Enabled = true;
            rbFront.Enabled = true;
            txtGuess.Enabled = false;
            btnLeaveGame.Visible = true;
            btnSubmit.Text = "Submit";
        }

        void showCorrect()
        {
            lblCorrect.Visible = true;
            lblCorrect.ForeColor = Color.Green;
            lblCorrect.Text = "Correct!";
        }

        void showIncorrect()
        {
            lblCorrect.Visible = true;
            lblCorrect.ForeColor = Color.Red;
            lblCorrect.Text = "Wrong!";
        }

        void hideCorrect()
        {
            lblCorrect.Visible = false;
        }

        bool isGuessMode()
        {
            return gbTurn.Visible && txtGuess.Enabled;
        }

        bool isWatchMode()
        {
            return !gbTurn.Visible;
        }

        bool isDirectionMode ()
        {
            return gbTurn.Visible && !txtGuess.Enabled;
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

        private void timerGameUpdate_Tick(object sender, EventArgs e)
        {
            updateGame();
            hideCorrect();
        }

        private void btnJoinGame_Click(object sender, EventArgs e)
        {
            joinGame();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(isDirectionMode())
            {
                submitDirection();
            }
            if(isGuessMode())
            {
                submitGuess();
            }
        }

        async void leaveGame()
        {
            WLServerResponse resp = await StateMachine.server.leaveGame();
            if (resp.worked)
            {
                transitionFromGameToLobby();
            }
            else
                broadcastError(resp);
        }

        private void btnLeaveGame_Click(object sender, EventArgs e)
        {
            leaveGame();
        }
    }
}
