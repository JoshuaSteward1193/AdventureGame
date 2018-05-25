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
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();
            lstPrimary.SelectedValueChanged += new EventHandler(lstPrimary_SelectedValueChanged);
        }        

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            lstPrimary.Items.Clear();
            foreach(Equipment x in PlayerData.EquipmentList)
            {                
                lstPrimary.Items.Add(x.Name);
                lblPrimary.Text = PlayerData.PrimaryWeapon.Name;
            }
        }

        private void lstPrimary_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lstPrimary.SelectedIndex != -1)
            {
                PlayerData.PrimaryWeapon = PlayerData.EquipmentList[lstPrimary.SelectedIndex];
                lblPrimary.Text = PlayerData.PrimaryWeapon.Name;
                MessageBox.Show($"You equip a {PlayerData.PrimaryWeapon.Name} as your primary weapon");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
