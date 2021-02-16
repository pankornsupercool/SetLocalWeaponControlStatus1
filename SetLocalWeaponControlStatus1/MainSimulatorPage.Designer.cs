
namespace SetLocalWeaponControlStatus1
{
    partial class MainSimulatorPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLocalWeaponControlStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lolToolStripMenuItem
            // 
            this.lolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setLocalWeaponControlStatusToolStripMenuItem});
            this.lolToolStripMenuItem.Name = "lolToolStripMenuItem";
            this.lolToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.lolToolStripMenuItem.Text = "Lol";
            // 
            // setLocalWeaponControlStatusToolStripMenuItem
            // 
            this.setLocalWeaponControlStatusToolStripMenuItem.Name = "setLocalWeaponControlStatusToolStripMenuItem";
            this.setLocalWeaponControlStatusToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.setLocalWeaponControlStatusToolStripMenuItem.Text = "SetLocalWeaponControlStatus";
            this.setLocalWeaponControlStatusToolStripMenuItem.Click += new System.EventHandler(this.setLocalWeaponControlStatusToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jaddin Main ";
            // 
            // MainSimulatorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainSimulatorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSimulatorPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLocalWeaponControlStatusToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}