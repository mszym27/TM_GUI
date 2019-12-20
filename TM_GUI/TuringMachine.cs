using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_GUI
{
    class TuringMachine
    {
        private List<State> states;

        public State currentState;

        public List<char> tape;

        // rosnaco od lewej do prawej
        public int head;

        public TuringMachine(string tapeSymbols)
        {
            states = new List<State>();
            tape = new List<char>();

            foreach (var symbol in tapeSymbols)
            {
                tape.Add(symbol);
            }

            tape.Add('#'); // dodanie sztucznego symbolu konczacego

            head = 0;

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

            q0.transitions = new Dictionary<char, string> { ['a'] = "qa", ['b'] = "q0", ['#'] = "q0" };
            qa.transitions = new Dictionary<char, string> { ['a'] = "q0", ['b'] = "q0", ['#'] = "qa" };

            states.Add(q0);
            states.Add(qa);

            currentState = q0;
        }

        public char GetCurrentSymbol()
        {
            return tape[head];
        }

        /// <summary>
        /// przechodzi do kolejnego stanu, na podstawie symbolu spod glowicy
        /// powoduje zapis na tasmie oraz przesuwa glowice
        /// </summary>
        public void transition()
        {
            var symbol = tape.ElementAt(head);

            currentState = GetStateByName(currentState.transitions[symbol]);
            tape[head] = currentState.transitionOutput[symbol];

            head += 1;
        }

        private State GetStateByName(string stateName)
        {
            return states.Where(q => q.stateName == stateName).First();
        }
    }
}
