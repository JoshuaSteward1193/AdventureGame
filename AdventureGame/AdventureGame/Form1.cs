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
            NameRequestForm nameRequestForm = new NameRequestForm();
            nameRequestForm.ShowDialog();
            MessageBox.Show($"Welcome to your adventure, {PlayerData.Name}.");
            ProgramData.LoadData();
            PlayerData.LoadData();
            TurnNumber = 1;
            RefreshDisplay();
            MessageBox.Show("You awaken inside a dark and murky prison cell, with no memory how you got there.");
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
