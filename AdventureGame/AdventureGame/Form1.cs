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
        public static int TurnNumber { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ProgramData.LoadData();
            PlayerData.Name = "Nemo";
            PlayerData.MaxHealth = 10;
            PlayerData.Health = 10;
            TurnNumber = 1;
            RefreshDisplay();
        }
        private void RefreshDisplay() { 
            RefreshStatusBar();
            lblDisplay.Text = ProgramData.CurrentLocation.display();
            numChoices.Maximum = ProgramData.CurrentLocation.GetCommandAmount();
        }
        private void RefreshStatusBar()
        {
            lblStatusBar.Text = $"{PlayerData.Name} | Health: {PlayerData.Health}/{PlayerData.MaxHealth} | Turn: {TurnNumber}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TurnNumber++;
            InputHandler.roomAction(Convert.ToInt32(numChoices.Value));
            RefreshDisplay();
        }

    }
}
