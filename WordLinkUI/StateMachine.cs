using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLinkUI
{
    static class StateMachine
    {
        public enum PossibleStates
        {
            ChooseServer,
            ChooseSign,
            SignIn,
            SignUp,
            ChooseJoinOrCreate,
            CreateGame,
            ChooseGame,
            InGame,
            PlayingDirection,
            PlayingGuess
        }
        public static WordLinkServer server;
        public static PossibleStates currentState = PossibleStates.ChooseServer;
        public static void changeState(PossibleStates newState)
        {
            currentState = newState;
        }
    }
}
