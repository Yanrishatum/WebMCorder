namespace WebMCCorder
{
    partial class Main
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
      this.components = new System.ComponentModel.Container();
      this.mainDisplay = new System.Windows.Forms.Panel();
      this.recordButton = new System.Windows.Forms.Button();
      this.positioningButton = new System.Windows.Forms.Button();
      this.soundCheckbox = new System.Windows.Forms.CheckBox();
      this.preShowTimer = new System.Windows.Forms.Timer(this.components);
      this.postShowTimer = new System.Windows.Forms.Timer(this.components);
      this.statusLabel = new System.Windows.Forms.Label();
      this.mp4_preset = new System.Windows.Forms.CheckBox();
      this.recordMouse = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // mainDisplay
      // 
      this.mainDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainDisplay.BackColor = System.Drawing.Color.Magenta;
      this.mainDisplay.Location = new System.Drawing.Point(0, 2);
      this.mainDisplay.Name = "mainDisplay";
      this.mainDisplay.Size = new System.Drawing.Size(452, 358);
      this.mainDisplay.TabIndex = 0;
      // 
      // recordButton
      // 
      this.recordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.recordButton.Location = new System.Drawing.Point(365, 366);
      this.recordButton.Name = "recordButton";
      this.recordButton.Size = new System.Drawing.Size(75, 23);
      this.recordButton.TabIndex = 1;
      this.recordButton.Text = "Record";
      this.recordButton.UseVisualStyleBackColor = true;
      this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
      // 
      // positioningButton
      // 
      this.positioningButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.positioningButton.Location = new System.Drawing.Point(284, 366);
      this.positioningButton.Name = "positioningButton";
      this.positioningButton.Size = new System.Drawing.Size(75, 23);
      this.positioningButton.TabIndex = 3;
      this.positioningButton.Text = "Positioning";
      this.positioningButton.UseVisualStyleBackColor = true;
      this.positioningButton.Click += new System.EventHandler(this.positioningButton_Click);
      // 
      // soundCheckbox
      // 
      this.soundCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.soundCheckbox.AutoSize = true;
      this.soundCheckbox.Checked = true;
      this.soundCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.soundCheckbox.Location = new System.Drawing.Point(221, 370);
      this.soundCheckbox.Name = "soundCheckbox";
      this.soundCheckbox.Size = new System.Drawing.Size(57, 17);
      this.soundCheckbox.TabIndex = 4;
      this.soundCheckbox.Text = "Sound";
      this.soundCheckbox.UseVisualStyleBackColor = true;
      this.soundCheckbox.CheckedChanged += new System.EventHandler(this.soundCheckbox_CheckedChanged);
      // 
      // preShowTimer
      // 
      this.preShowTimer.Interval = 1000;
      this.preShowTimer.Tick += new System.EventHandler(this.preShowSecond);
      // 
      // postShowTimer
      // 
      this.postShowTimer.Interval = 1000;
      this.postShowTimer.Tick += new System.EventHandler(this.postShowTimer_Tick);
      // 
      // statusLabel
      // 
      this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.statusLabel.AutoSize = true;
      this.statusLabel.Location = new System.Drawing.Point(0, 371);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(0, 13);
      this.statusLabel.TabIndex = 5;
      // 
      // mp4_preset
      // 
      this.mp4_preset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.mp4_preset.AutoSize = true;
      this.mp4_preset.Location = new System.Drawing.Point(167, 370);
      this.mp4_preset.Name = "mp4_preset";
      this.mp4_preset.Size = new System.Drawing.Size(48, 17);
      this.mp4_preset.TabIndex = 6;
      this.mp4_preset.Text = "MP4";
      this.mp4_preset.UseVisualStyleBackColor = true;
      this.mp4_preset.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // recordMouse
      // 
      this.recordMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.recordMouse.AutoSize = true;
      this.recordMouse.Checked = true;
      this.recordMouse.CheckState = System.Windows.Forms.CheckState.Checked;
      this.recordMouse.Location = new System.Drawing.Point(103, 370);
      this.recordMouse.Name = "recordMouse";
      this.recordMouse.Size = new System.Drawing.Size(58, 17);
      this.recordMouse.TabIndex = 7;
      this.recordMouse.Text = "Mouse";
      this.recordMouse.UseVisualStyleBackColor = true;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(452, 389);
      this.Controls.Add(this.recordMouse);
      this.Controls.Add(this.mp4_preset);
      this.Controls.Add(this.statusLabel);
      this.Controls.Add(this.soundCheckbox);
      this.Controls.Add(this.positioningButton);
      this.Controls.Add(this.recordButton);
      this.Controls.Add(this.mainDisplay);
      this.MinimumSize = new System.Drawing.Size(100, 100);
      this.Name = "Main";
      this.Text = "WebMCorder";
      this.TransparencyKey = System.Drawing.Color.Magenta;
      this.Load += new System.EventHandler(this.initDisplay);
      this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainDisplay;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button positioningButton;
        private System.Windows.Forms.CheckBox soundCheckbox;
        private System.Windows.Forms.Timer preShowTimer;
        private System.Windows.Forms.Timer postShowTimer;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox mp4_preset;
        private System.Windows.Forms.CheckBox recordMouse;
    }
}

