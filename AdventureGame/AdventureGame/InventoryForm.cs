using System;
using System.Linq;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class InventoryForm : Form
    {

        ToolTip itemDescription = new ToolTip();

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            itemDescription.AutoPopDelay = 5000;
            itemDescription.InitialDelay = 500;
            itemDescription.ReshowDelay = 400;

            itemDescription.ShowAlways = true;

            LoadInventory();
        }
        private void LoadInventory()
        {
            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                lbl.Text = "";
            }
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Enabled = false;
            }
            btnExit.Enabled = true;

            switch (Inventory.items.Count)
            {
                case 5:
                    lblSlot5.Text = Inventory.items[4].Name;
                    itemDescription.SetToolTip(lblSlot5, Inventory.items[4].Description);
                    btnSlot5.Enabled = true;
                    goto case 4;
                case 4:
                    lblSlot4.Text = Inventory.items[3].Name;
                    itemDescription.SetToolTip(lblSlot4, Inventory.items[3].Description);
                    btnSlot4.Enabled = true;
                    goto case 3;
                case 3:
                    lblSlot3.Text = Inventory.items[2].Name;
                    itemDescription.SetToolTip(lblSlot3, Inventory.items[2].Description);
                    btnSlot3.Enabled = true;
                    goto case 2;
                case 2:
                    lblSlot2.Text = Inventory.items[1].Name;
                    itemDescription.SetToolTip(lblSlot2, Inventory.items[1].Description);
                    btnSlot2.Enabled = true;
                    goto case 1;
                case 1:
                    lblSlot1.Text = Inventory.items[0].Name;
                    itemDescription.SetToolTip(lblSlot1, Inventory.items[0].Description);
                    btnSlot1.Enabled = true;
                    break;
                default:
                    break;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSlot1_Click(object sender, EventArgs e)
        {
            Inventory.Use(0);
            LoadInventory();
        }

        private void btnSlot2_Click(object sender, EventArgs e)
        {
            Inventory.Use(1);
            LoadInventory();
        }

        private void btnSlot3_Click(object sender, EventArgs e)
        {
            Inventory.Use(2);
            LoadInventory();
        }

        private void btnSlot4_Click(object sender, EventArgs e)
        {
            Inventory.Use(3);
            LoadInventory();
        }

        private void btnSlot5_Click(object sender, EventArgs e)
        {
            Inventory.Use(4);
            LoadInventory();
        }

        
    }
}
