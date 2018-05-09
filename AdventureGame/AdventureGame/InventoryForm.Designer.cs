namespace AdventureGame
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSlot1 = new System.Windows.Forms.Label();
            this.btnSlot1 = new System.Windows.Forms.Button();
            this.btnSlot2 = new System.Windows.Forms.Button();
            this.lblSlot2 = new System.Windows.Forms.Label();
            this.btnSlot3 = new System.Windows.Forms.Button();
            this.lblSlot3 = new System.Windows.Forms.Label();
            this.btnSlot4 = new System.Windows.Forms.Button();
            this.lblSlot4 = new System.Windows.Forms.Label();
            this.btnSlot5 = new System.Windows.Forms.Button();
            this.lblSlot5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSlot1
            // 
            this.lblSlot1.AutoSize = true;
            this.lblSlot1.Location = new System.Drawing.Point(12, 18);
            this.lblSlot1.Name = "lblSlot1";
            this.lblSlot1.Size = new System.Drawing.Size(35, 13);
            this.lblSlot1.TabIndex = 0;
            this.lblSlot1.Text = "label1";
            // 
            // btnSlot1
            // 
            this.btnSlot1.Location = new System.Drawing.Point(119, 12);
            this.btnSlot1.Name = "btnSlot1";
            this.btnSlot1.Size = new System.Drawing.Size(75, 23);
            this.btnSlot1.TabIndex = 1;
            this.btnSlot1.Text = "Use";
            this.btnSlot1.UseVisualStyleBackColor = true;
            // 
            // btnSlot2
            // 
            this.btnSlot2.Location = new System.Drawing.Point(119, 41);
            this.btnSlot2.Name = "btnSlot2";
            this.btnSlot2.Size = new System.Drawing.Size(75, 23);
            this.btnSlot2.TabIndex = 3;
            this.btnSlot2.Text = "Use";
            this.btnSlot2.UseVisualStyleBackColor = true;
            // 
            // lblSlot2
            // 
            this.lblSlot2.AutoSize = true;
            this.lblSlot2.Location = new System.Drawing.Point(12, 47);
            this.lblSlot2.Name = "lblSlot2";
            this.lblSlot2.Size = new System.Drawing.Size(35, 13);
            this.lblSlot2.TabIndex = 2;
            this.lblSlot2.Text = "label1";
            // 
            // btnSlot3
            // 
            this.btnSlot3.Location = new System.Drawing.Point(119, 70);
            this.btnSlot3.Name = "btnSlot3";
            this.btnSlot3.Size = new System.Drawing.Size(75, 23);
            this.btnSlot3.TabIndex = 5;
            this.btnSlot3.Text = "Use";
            this.btnSlot3.UseVisualStyleBackColor = true;
            // 
            // lblSlot3
            // 
            this.lblSlot3.AutoSize = true;
            this.lblSlot3.Location = new System.Drawing.Point(12, 76);
            this.lblSlot3.Name = "lblSlot3";
            this.lblSlot3.Size = new System.Drawing.Size(35, 13);
            this.lblSlot3.TabIndex = 4;
            this.lblSlot3.Text = "label1";
            // 
            // btnSlot4
            // 
            this.btnSlot4.Location = new System.Drawing.Point(119, 99);
            this.btnSlot4.Name = "btnSlot4";
            this.btnSlot4.Size = new System.Drawing.Size(75, 23);
            this.btnSlot4.TabIndex = 7;
            this.btnSlot4.Text = "Use";
            this.btnSlot4.UseVisualStyleBackColor = true;
            // 
            // lblSlot4
            // 
            this.lblSlot4.AutoSize = true;
            this.lblSlot4.Location = new System.Drawing.Point(12, 105);
            this.lblSlot4.Name = "lblSlot4";
            this.lblSlot4.Size = new System.Drawing.Size(35, 13);
            this.lblSlot4.TabIndex = 6;
            this.lblSlot4.Text = "label1";
            // 
            // btnSlot5
            // 
            this.btnSlot5.Location = new System.Drawing.Point(119, 128);
            this.btnSlot5.Name = "btnSlot5";
            this.btnSlot5.Size = new System.Drawing.Size(75, 23);
            this.btnSlot5.TabIndex = 9;
            this.btnSlot5.Text = "Use";
            this.btnSlot5.UseVisualStyleBackColor = true;
            // 
            // lblSlot5
            // 
            this.lblSlot5.AutoSize = true;
            this.lblSlot5.Location = new System.Drawing.Point(12, 134);
            this.lblSlot5.Name = "lblSlot5";
            this.lblSlot5.Size = new System.Drawing.Size(35, 13);
            this.lblSlot5.TabIndex = 8;
            this.lblSlot5.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(418, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 165);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSlot5);
            this.Controls.Add(this.lblSlot5);
            this.Controls.Add(this.btnSlot4);
            this.Controls.Add(this.lblSlot4);
            this.Controls.Add(this.btnSlot3);
            this.Controls.Add(this.lblSlot3);
            this.Controls.Add(this.btnSlot2);
            this.Controls.Add(this.lblSlot2);
            this.Controls.Add(this.btnSlot1);
            this.Controls.Add(this.lblSlot1);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlot1;
        private System.Windows.Forms.Button btnSlot1;
        private System.Windows.Forms.Button btnSlot2;
        private System.Windows.Forms.Label lblSlot2;
        private System.Windows.Forms.Button btnSlot3;
        private System.Windows.Forms.Label lblSlot3;
        private System.Windows.Forms.Button btnSlot4;
        private System.Windows.Forms.Label lblSlot4;
        private System.Windows.Forms.Button btnSlot5;
        private System.Windows.Forms.Label lblSlot5;
        private System.Windows.Forms.Button btnExit;
    }
}