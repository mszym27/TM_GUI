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

        private State currentState;

        private List<char> tape;

        // rosnaco od lewej do prawej
        private int head;

        private GUI gui;

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

            q0.transitions = new Dictionary<char, State> { ['a'] = qa, ['b'] = q0, ['#'] = q0 };
            qa.transitions = new Dictionary<char, State> { ['a'] = q0, ['b'] = q0, ['#'] = qa };

            states.Add(q0);
            states.Add(qa);

            currentState = q0;
        }

        /// <summary>
        /// inicjalizuje interfejs graficzny, uzupelniajac go od razu
        /// </summary>
        public void initGui()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            gui = new GUI();

            refreshGui();

            Application.Run(gui);
        }

        /// <summary>
        /// przechodzi do kolejnego stanu, na podstawie symbolu spod glowicy
        /// powoduje zapis na tasmie oraz przesuwa glowice
        /// </summary>
        private void transition()
        {
            head += 1;

            refreshGui();
        }

        /// <summary>
        /// uzupelnia gui o aktualny stan oraz odswieza tasme
        /// </summary>
        private void refreshGui()
        {
            gui.showTape(tape, head);
            gui.showCurrentStateName(currentState.stateName);
        }
    }
}
