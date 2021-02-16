
namespace SetLocalWeaponControlStatus1
{
    partial class SetLocalWeaponControlStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unspecifiedRadio = new System.Windows.Forms.RadioButton();
            this.holdRadio = new System.Windows.Forms.RadioButton();
            this.tightRadio = new System.Windows.Forms.RadioButton();
            this.freeRadio = new System.Windows.Forms.RadioButton();
            this.batteryComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Battery ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status : ";
            // 
            // unspecifiedRadio
            // 
            this.unspecifiedRadio.AutoSize = true;
            this.unspecifiedRadio.Enabled = false;
            this.unspecifiedRadio.Location = new System.Drawing.Point(185, 101);
            this.unspecifiedRadio.Name = "unspecifiedRadio";
            this.unspecifiedRadio.Size = new System.Drawing.Size(114, 22);
            this.unspecifiedRadio.TabIndex = 2;
            this.unspecifiedRadio.TabStop = true;
            this.unspecifiedRadio.Text = "Unspecified";
            this.unspecifiedRadio.UseVisualStyleBackColor = true;
            // 
            // holdRadio
            // 
            this.holdRadio.AutoSize = true;
            this.holdRadio.Location = new System.Drawing.Point(185, 140);
            this.holdRadio.Name = "holdRadio";
            this.holdRadio.Size = new System.Drawing.Size(58, 22);
            this.holdRadio.TabIndex = 3;
            this.holdRadio.TabStop = true;
            this.holdRadio.Text = "Hold";
            this.holdRadio.UseVisualStyleBackColor = true;
            // 
            // tightRadio
            // 
            this.tightRadio.AutoSize = true;
            this.tightRadio.Location = new System.Drawing.Point(185, 181);
            this.tightRadio.Name = "tightRadio";
            this.tightRadio.Size = new System.Drawing.Size(66, 22);
            this.tightRadio.TabIndex = 4;
            this.tightRadio.TabStop = true;
            this.tightRadio.Text = "Tight";
            this.tightRadio.UseVisualStyleBackColor = true;
            // 
            // freeRadio
            // 
            this.freeRadio.AutoSize = true;
            this.freeRadio.Location = new System.Drawing.Point(185, 219);
            this.freeRadio.Name = "freeRadio";
            this.freeRadio.Size = new System.Drawing.Size(58, 22);
            this.freeRadio.TabIndex = 5;
            this.freeRadio.TabStop = true;
            this.freeRadio.Text = "Free";
            this.freeRadio.UseVisualStyleBackColor = true;
            // 
            // batteryComboBox
            // 
            this.batteryComboBox.FormattingEnabled = true;
            this.batteryComboBox.Location = new System.Drawing.Point(162, 44);
            this.batteryComboBox.Name = "batteryComboBox";
            this.batteryComboBox.Size = new System.Drawing.Size(219, 26);
            this.batteryComboBox.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(37, 263);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(156, 44);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(225, 263);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(156, 44);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SetLocalWeaponControlStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 319);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.batteryComboBox);
            this.Controls.Add(this.freeRadio);
            this.Controls.Add(this.tightRadio);
            this.Controls.Add(this.holdRadio);
            this.Controls.Add(this.unspecifiedRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetLocalWeaponControlStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Local Weapon Control Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton unspecifiedRadio;
        private System.Windows.Forms.RadioButton holdRadio;
        private System.Windows.Forms.RadioButton tightRadio;
        private System.Windows.Forms.RadioButton freeRadio;
        private System.Windows.Forms.ComboBox batteryComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

