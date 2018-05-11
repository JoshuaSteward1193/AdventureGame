namespace AdventureGame
{
    partial class Form1
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
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.numChoices = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.BackColor = System.Drawing.Color.White;
            this.lblStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBar.Location = new System.Drawing.Point(13, 13);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(484, 23);
            this.lblStatusBar.TabIndex = 0;
            this.lblStatusBar.Text = "lblStatusBar";
            this.lblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(13, 56);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(484, 228);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "lblDisplay";
            // 
            // numChoices
            // 
            this.numChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChoices.Location = new System.Drawing.Point(377, 310);
            this.numChoices.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChoices.Name = "numChoices";
            this.numChoices.Size = new System.Drawing.Size(120, 22);
            this.numChoices.TabIndex = 2;
            this.numChoices.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Use the up or down arrows to make your selection:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(377, 338);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(503, 56);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(126, 23);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 401);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numChoices);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblStatusBar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.NumericUpDown numChoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnInventory;
    }
}

