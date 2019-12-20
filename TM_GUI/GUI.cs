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
        // na liscie miesci sie 6 itemow
        private const int MAX_LIST_VISIBILITY = 5;

        private TuringMachine TM;

        public TM_GUI(string inputTape)
        {
            InitializeComponent();

            TM = new TuringMachine(inputTape);

            refreshGui();
        }

        public void showTape()
        {
            listViewMachineTape.Items.Clear();

            var listVisibleStart = (TM.head <= MAX_LIST_VISIBILITY ? 0 : (TM.head - MAX_LIST_VISIBILITY));

            for (int i = listVisibleStart; i < TM.tape.Count; i++)
            {
                listViewMachineTape.Items.Add(TM.tape[i].ToString());
            }

            var headVisiblePos = (TM.head <= MAX_LIST_VISIBILITY ? TM.head : MAX_LIST_VISIBILITY);

            listViewMachineTape.Items[headVisiblePos].ForeColor = Color.Red;
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

            if(TM.GetCurrentSymbol() == '#')
            {
                buttonNext.Enabled = false;
            }

            refreshGui();
        }
    }
}
