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
        private TuringMachine TM;

        public TM_GUI()
        {
            InitializeComponent();

            TM = new TuringMachine("ababbaba");

            refreshGui();
        }

        public void showTape()
        {
            foreach(var symbol in TM.tape)
            {
                listViewMachineTape.Items.Add(symbol.ToString());
            }

            listViewMachineTape.Items[TM.head].ForeColor = Color.Red;
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
