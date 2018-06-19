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
    public partial class CombatForm : Form
    {
        static Creature enemy;

        public CombatForm()
        {
            InitializeComponent();
        }

        private void CombatForm_Load(object sender, EventArgs e)
        {
            enemy = ProgramData.enemyCombatant;
            ProgramData.enemyCombatant = null;
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            lblHealthA.Text = $"Health: {PlayerData.Health}/{PlayerData.MaxHealth}";
            lblHealthB.Text = $"Health: {enemy.Health}/{enemy.MaxHealth}";
            lblNameA.Text = $"{PlayerData.Name}";
            lblNameB.Text = $"Lv. {enemy.Level} {enemy.Type}: {enemy.Name} {enemy.Title}";
            lblStaminaA.Text = $"Stamina: {PlayerData.Stamina}/{PlayerData.MaxStamina}";
            lblStaminaB.Text = $"Stamina: {enemy.Stamina}/{enemy.MaxStamina}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
