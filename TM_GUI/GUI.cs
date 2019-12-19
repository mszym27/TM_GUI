﻿using System;
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
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        public void initTape(string symbols)
        {
            foreach(var symbol in symbols)
            {
                this.listViewMachineTape.Items.Add(symbol.ToString());
            }

            this.listViewMachineTape.Items.Add("#");
        }

        public void addTapeElement(string symbol)
        {
            //// dodanie indeksu elementu
            //this.listViewMachineTape.Columns.Add(
            //    (listViewMachineTape.Columns.Count + 1).ToString(), 
            //    1000
            //);

            // dodanie samego elementu
            this.listViewMachineTape.Items.Add(symbol);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }
    }
}
