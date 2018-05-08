using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgramData.LoadData();
            RefreshDisplay();
        }
        private void RefreshDisplay()
        {
            lblDisplay.Text = ProgramData.CurrentLocation.display();
            numChoices.Maximum = ProgramData.CurrentLocation.GetCommandAmount();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            InputHandler.roomAction(Convert.ToInt32(numChoices.Value));
            RefreshDisplay();
        }
    }
}
