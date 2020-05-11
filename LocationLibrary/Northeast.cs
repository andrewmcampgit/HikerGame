using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace LocationLibrary
{
    public class Northeast : Location
    {
        private State _gameState;


        public State GameState
        {
            get
            { return _gameState; }
            set
            {
                if (value == State.Delaware || value == State.Connecticut || value == State.Maine || value == State.Massachusetts
                    || value == State.Maryland || value == State.New_Hampshire || value == State.New_Jersey || value == State.New_York
                    || value == State.Pennsylvania || value == State.Rhode_Island || value == State.Vermont)

                {

                    _gameState = value;
                }
            }
        }




        public Northeast(State gameState, string stateString, string description) : base(stateString, description)
        {
            GameState = gameState;
            
        }
    }
}
