using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_GUI
{
    class TuringMachine
    {
        private List<State> states;

        private State currentState;

        private List<char> tape;

        // rosnaco od lewej do prawej
        int currentTapePosition;

        TuringMachine(string tapeSymbols)
        {
            tape = new List<char>();

            foreach (var symbol in tapeSymbols)
            {
                tape.Add(symbol);
            }

            currentTapePosition = 0;

            // inicjalizacja na podstawie tablicy przejsc

            var q0 = new State()
            {
                stateName = "q0",
                transitionOutput = new Dictionary<char, char> { ['a'] = 'a', ['b'] = 'a', ['#'] = '#' }
            };

            var qa = new State()
            {
                stateName = "qa",
                transitionOutput = new Dictionary<char, char> { ['a'] = 'b', ['b'] = 'a', ['#'] = '#' }
            };

            q0.transitions = new Dictionary<char, State> { ['a'] = qa, ['b'] = q0, ['#'] = q0 };
            qa.transitions = new Dictionary<char, State> { ['a'] = q0, ['b'] = q0, ['#'] = qa };

            states.Add(q0);
            states.Add(qa);
        }

        // metody do obslugi interfejsu graficznego maszyny
    }
}
