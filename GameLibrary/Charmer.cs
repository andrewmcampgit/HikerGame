using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Charmer: Character
    {

        public State CharmerState { get; set; }

        public Charmer(State charmerState)
        {
            CharmerState = charmerState;

        }
    }
}
