using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Json;
using System.Diagnostics;
using System.Threading;
using System.Dynamic;

namespace WordLinkUI
{
    class WordLinkServer
    {
        HttpClient client;
        string Username;
        string Password;
        bool authenticated;
        string serverAddress;
        string apiEndpoint;

        public WordLinkServer()
        {
            this.Username = "";
            this.Password = "";
            this.client = new HttpClient();
            this.authenticated = false;
            serverAddress = "";
            apiEndpoint = "api/";
        }

        public string getCurrentUser()
        {
            return this.Username;
        }

        private async Task<dynamic> doGetRequest(string actionname)
        {
            HttpResponseMessage response = await client.GetAsync(apiEndpoint + actionname);
            Task<string> readTask = response.Content.ReadAsStringAsync();
            bool worked = response.IsSuccessStatusCode;
            string responseContent = await readTask;
            dynamic responseParsed = JsonParser.Deserialize(responseContent);
            if (worked)
            {
                return responseParsed;
            }
            else
            {
                throw new Exception(responseParsed.error);
            }
        }

        private async Task<dynamic> doPostRequest(string actionName, Dictionary<string,string> inputs, bool addPlayerAuthentication)
        {
            if(addPlayerAuthentication)
            {
                inputs["username"] = this.Username;
                inputs["password"] = this.Password;
            }
            FormUrlEncodedContent content = new FormUrlEncodedContent(inputs);
            HttpResponseMessage response = await client.PostAsync(apiEndpoint + actionName, content);
            Task<string> readTask = response.Content.ReadAsStringAsync();
            bool worked = response.IsSuccessStatusCode;
            string responseContent = await readTask;
            dynamic responseParsed = JsonParser.Deserialize(responseContent);            
            if(worked)
            {
                return responseParsed;
            }
            else
            {
                throw new Exception(responseParsed.error);
            }            
        }

        public void setServer(string newAddress)
        {
            if(!newAddress.EndsWith("/"))
            {
                newAddress += "/";
            }
            this.serverAddress = newAddress;
            this.client.BaseAddress = new Uri(this.serverAddress);
        }
        
        public void setLoginInfo(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.authenticated = false;
        }

        #region Login Actions

        public async Task<WLServerResponse> logIn()
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "userValid";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            postTask = doPostRequest(actionName, theParams, true);
            try { 
                postTaskResult = await postTask;
                newInfo.playerId = postTaskResult.playerid;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to log in: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        public async Task<WLServerResponse> signUp()
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "createPlayer";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            postTask = doPostRequest(actionName, theParams, true);
            try
            {
                postTaskResult = await postTask;
                newInfo.playerId = postTaskResult.playerid;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to sign up: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        #endregion

        #region Lobby Actions

        public async Task<WLServerResponse> getGamesList()
        {
            dynamic getTask;
            dynamic getTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "listGames";
            getTask = doGetRequest(actionName);
            try
            {
                getTaskResult = await getTask;
                newInfo.gamesList = getTaskResult.gameslist;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to fetch games list: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        public async Task<WLServerResponse> joinGame(string gameId)
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "joinGame";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            theParams.Add("gameId", gameId);
            postTask = doPostRequest(actionName, theParams, true);
            try
            {
                postTaskResult = await postTask;
                newInfo.gameId = postTaskResult.gameid;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to join game: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }


        public async Task<WLServerResponse> createGame()
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "createGame";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            postTask = doPostRequest(actionName, theParams, true);
            try
            {
                postTaskResult = await postTask;
                newInfo.gameId = postTaskResult.gameid;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to create game: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        #endregion

        #region Game Actions

        public async Task<WLServerResponse> leaveGame()
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "leaveGame";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            postTask = doPostRequest(actionName, theParams, true);
            try
            {
                postTaskResult = await postTask;
                newInfo.gameId = postTaskResult.gameid;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to leave game: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        public async Task<WLServerResponse> getGameSummary()
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "getGameSummary";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            postTask = doPostRequest(actionName, theParams, true);
            try
            {
                postTaskResult = await postTask;
                newInfo.summary = postTaskResult.summary;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to get game info: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        public async Task<WLServerResponse> submitDirection(string direction)
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "submitDirection";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            theParams.Add("direction", direction);
            postTask = doPostRequest(actionName, theParams, true);
            try
            {
                postTaskResult = await postTask;
                newInfo.success = postTaskResult.success;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to submit direction: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        public async Task<WLServerResponse> submitGuess(string guess)
        {
            dynamic postTask;
            dynamic postTaskResult;
            dynamic newInfo = new ExpandoObject();
            WLServerResponse myResponse;
            string actionName = "submitGuess";
            Dictionary<string, string> theParams = new Dictionary<string, string>();
            theParams.Add("guess", guess);
            postTask = doPostRequest(actionName, theParams, true);
            try
            {
                postTaskResult = await postTask;
                newInfo.isCorrect = postTaskResult.iscorrect;
                myResponse = new WLServerResponse(true, newInfo);
                this.authenticated = true;
            }
            catch (Exception e)
            {
                newInfo.error = "Failed to submit guess: " + e.Message;
                myResponse = new WLServerResponse(false, newInfo);
            }
            return myResponse;
        }

        #endregion

    }
}
