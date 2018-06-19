namespace AdventureGame
{
    partial class CombatForm
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
            this.lblNameA = new System.Windows.Forms.Label();
            this.lblHealthA = new System.Windows.Forms.Label();
            this.lblStaminaA = new System.Windows.Forms.Label();
            this.btnAction1A = new System.Windows.Forms.Button();
            this.btnAction2A = new System.Windows.Forms.Button();
            this.btnAction3A = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameA
            // 
            this.lblNameA.AutoSize = true;
            this.lblNameA.Location = new System.Drawing.Point(12, 9);
            this.lblNameA.Name = "lblNameA";
            this.lblNameA.Size = new System.Drawing.Size(35, 13);
            this.lblNameA.TabIndex = 0;
            this.lblNameA.Text = "label1";
            // 
            // lblHealthA
            // 
            this.lblHealthA.AutoSize = true;
            this.lblHealthA.Location = new System.Drawing.Point(12, 22);
            this.lblHealthA.Name = "lblHealthA";
            this.lblHealthA.Size = new System.Drawing.Size(35, 13);
            this.lblHealthA.TabIndex = 1;
            this.lblHealthA.Text = "label1";
            // 
            // lblStaminaA
            // 
            this.lblStaminaA.AutoSize = true;
            this.lblStaminaA.Location = new System.Drawing.Point(12, 35);
            this.lblStaminaA.Name = "lblStaminaA";
            this.lblStaminaA.Size = new System.Drawing.Size(35, 13);
            this.lblStaminaA.TabIndex = 2;
            this.lblStaminaA.Text = "label1";
            // 
            // btnAction1A
            // 
            this.btnAction1A.Location = new System.Drawing.Point(13, 78);
            this.btnAction1A.Name = "btnAction1A";
            this.btnAction1A.Size = new System.Drawing.Size(137, 23);
            this.btnAction1A.TabIndex = 3;
            this.btnAction1A.Text = "button1";
            this.btnAction1A.UseVisualStyleBackColor = true;
            // 
            // btnAction2A
            // 
            this.btnAction2A.Location = new System.Drawing.Point(12, 107);
            this.btnAction2A.Name = "btnAction2A";
            this.btnAction2A.Size = new System.Drawing.Size(137, 23);
            this.btnAction2A.TabIndex = 4;
            this.btnAction2A.Text = "button2";
            this.btnAction2A.UseVisualStyleBackColor = true;
            // 
            // btnAction3A
            // 
            this.btnAction3A.Location = new System.Drawing.Point(12, 136);
            this.btnAction3A.Name = "btnAction3A";
            this.btnAction3A.Size = new System.Drawing.Size(137, 23);
            this.btnAction3A.TabIndex = 5;
            this.btnAction3A.Text = "button3";
            this.btnAction3A.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "VS";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction3A);
            this.Controls.Add(this.btnAction2A);
            this.Controls.Add(this.btnAction1A);
            this.Controls.Add(this.lblStaminaA);
            this.Controls.Add(this.lblHealthA);
            this.Controls.Add(this.lblNameA);
            this.Name = "CombatForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Combat!";
            this.Load += new System.EventHandler(this.CombatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameA;
        private System.Windows.Forms.Label lblHealthA;
        private System.Windows.Forms.Label lblStaminaA;
        private System.Windows.Forms.Button btnAction1A;
        private System.Windows.Forms.Button btnAction2A;
        private System.Windows.Forms.Button btnAction3A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}