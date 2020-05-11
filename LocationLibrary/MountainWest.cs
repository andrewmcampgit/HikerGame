using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace LocationLibrary
{
    public class MountainWest : Location
    {
        private State _gameState;


        public State GameState
        {
            get
            { return _gameState; }
            set
            {
                if (value == State.Arizona || value == State.Colorado || value == State.Idaho || value == State.Montana || value == State.Nevada|| value == State.Utah
                    || value == State.New_Mexico || value == State.Wyoming)

                {

                    _gameState = value;
                }
            }
        }




        public MountainWest(State gameState, string stateString, string description) : base(stateString, description)
        {
            GameState = gameState;
            
        }
    }
}
