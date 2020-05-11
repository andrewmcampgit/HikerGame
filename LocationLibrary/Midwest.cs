using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace LocationLibrary
{
    public class Midwest : Location
    {
        private State _gameState;


        public State GameState
        {
            get
            { return _gameState; }
            set
            {
                if (value == State.North_Dakota || value == State.South_Dakota || value == State.Nebraska || value == State.Minnesota ||
                    value == State.Iowa || value == State.Missouri || value == State.Wisconsin || value == State.Illinois || value == State.Kansas
                    || value == State.Michigan || value == State.Indiana || value == State.Ohio)

                {

                    _gameState = value;
                }
            }
        }




        public Midwest(State gameState, string stateString, string description) : base(stateString, description)
        {
            GameState = gameState;
            
        }
    }
}
