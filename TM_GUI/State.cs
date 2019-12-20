using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_GUI
{
    struct State
    {
        // identyfikuje dany stan
        public string stateName;

        // przejscia - mapuje alfabet wejscia na stany, identyfikowane po nazwach
        public Dictionary<char, string> transitions;

        // odpowiada za mapowanie alfabetu wejscia na symbole wyjsciowe
        public Dictionary<char, char> transitionOutput;
    }
}
