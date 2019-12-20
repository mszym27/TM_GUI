using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_GUI
{
    public partial class TM_GUI : Form
    {
        private const int MAX_LIST_VISIBILITY = 5;

        private TuringMachine TM;

        public TM_GUI()
        {
            InitializeComponent();

            //TM = new TuringMachine("ababbabaaaaaabbbabbba");
            TM = new TuringMachine("0123456789abcdefg");

            refreshGui();
        }

        public void showTape()
        {
            listViewMachineTape.Items.Clear();

            //TM.head <= 5 ? 0 ; 
            for (int i = (TM.head <= MAX_LIST_VISIBILITY ? 0 : (TM.head - MAX_LIST_VISIBILITY)); i < TM.tape.Count; i++)
            {
                // na liscie miesci sie 6 itemow,  
                listViewMachineTape.Items.Add(TM.tape[i].ToString());

            }

            //foreach(var symbol in TM.tape)
            //{
            //}

            //listViewMachineTape.Items[(TM.head <= MAX_LIST_VISIBILITY ? TM.head : (TM.head - MAX_LIST_VISIBILITY))].ForeColor = Color.Red;
        }

        public void showCurrentStateName()
        {
            textBoxCurrentState.Text = TM.currentState.stateName;
        }

        /// <summary>
        /// uzupelnia gui o aktualny stan oraz odswieza tasme
        /// </summary>
        private void refreshGui()
        {
            showTape();
            showCurrentStateName();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            TM.transition();

            refreshGui();
        }
    }
}
