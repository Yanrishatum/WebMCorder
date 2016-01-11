namespace WebMCCorder
{
    partial class PositioningWindow
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
      System.Windows.Forms.Label xLabel;
      System.Windows.Forms.Label yLabel;
      System.Windows.Forms.Label wLabel;
      System.Windows.Forms.Label label1;
      this.saveButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.xInput = new System.Windows.Forms.NumericUpDown();
      this.yInput = new System.Windows.Forms.NumericUpDown();
      this.wInput = new System.Windows.Forms.NumericUpDown();
      this.hInput = new System.Windows.Forms.NumericUpDown();
      this.applyButton = new System.Windows.Forms.Button();
      this.refreshListButton = new System.Windows.Forms.Button();
      this.processList = new System.Windows.Forms.ListBox();
      this.snapToWindowButton = new System.Windows.Forms.Button();
      xLabel = new System.Windows.Forms.Label();
      yLabel = new System.Windows.Forms.Label();
      wLabel = new System.Windows.Forms.Label();
      label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.wInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hInput)).BeginInit();
      this.SuspendLayout();
      // 
      // xLabel
      // 
      xLabel.AutoSize = true;
      xLabel.Location = new System.Drawing.Point(12, 14);
      xLabel.Name = "xLabel";
      xLabel.Size = new System.Drawing.Size(17, 13);
      xLabel.TabIndex = 6;
      xLabel.Text = "X:";
      // 
      // yLabel
      // 
      yLabel.AutoSize = true;
      yLabel.Location = new System.Drawing.Point(12, 40);
      yLabel.Name = "yLabel";
      yLabel.Size = new System.Drawing.Size(17, 13);
      yLabel.TabIndex = 7;
      yLabel.Text = "Y:";
      // 
      // wLabel
      // 
      wLabel.AutoSize = true;
      wLabel.Location = new System.Drawing.Point(161, 14);
      wLabel.Name = "wLabel";
      wLabel.Size = new System.Drawing.Size(21, 13);
      wLabel.TabIndex = 8;
      wLabel.Text = "W:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(164, 40);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(18, 13);
      label1.TabIndex = 9;
      label1.Text = "H:";
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(13, 380);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(75, 23);
      this.saveButton.TabIndex = 0;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(234, 380);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // xInput
      // 
      this.xInput.Location = new System.Drawing.Point(35, 12);
      this.xInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.xInput.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
      this.xInput.Name = "xInput";
      this.xInput.Size = new System.Drawing.Size(120, 20);
      this.xInput.TabIndex = 2;
      // 
      // yInput
      // 
      this.yInput.Location = new System.Drawing.Point(35, 38);
      this.yInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.yInput.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
      this.yInput.Name = "yInput";
      this.yInput.Size = new System.Drawing.Size(120, 20);
      this.yInput.TabIndex = 3;
      // 
      // wInput
      // 
      this.wInput.Location = new System.Drawing.Point(188, 12);
      this.wInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.wInput.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
      this.wInput.Name = "wInput";
      this.wInput.Size = new System.Drawing.Size(120, 20);
      this.wInput.TabIndex = 4;
      // 
      // hInput
      // 
      this.hInput.Location = new System.Drawing.Point(188, 38);
      this.hInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
      this.hInput.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
      this.hInput.Name = "hInput";
      this.hInput.Size = new System.Drawing.Size(120, 20);
      this.hInput.TabIndex = 5;
      // 
      // applyButton
      // 
      this.applyButton.Location = new System.Drawing.Point(94, 380);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(75, 23);
      this.applyButton.TabIndex = 10;
      this.applyButton.Text = "Apply";
      this.applyButton.UseVisualStyleBackColor = true;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
      // 
      // refreshListButton
      // 
      this.refreshListButton.Location = new System.Drawing.Point(15, 64);
      this.refreshListButton.Name = "refreshListButton";
      this.refreshListButton.Size = new System.Drawing.Size(140, 23);
      this.refreshListButton.TabIndex = 11;
      this.refreshListButton.Text = "Refresh window list";
      this.refreshListButton.UseVisualStyleBackColor = true;
      this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
      // 
      // processList
      // 
      this.processList.Location = new System.Drawing.Point(15, 97);
      this.processList.Name = "processList";
      this.processList.Size = new System.Drawing.Size(293, 277);
      this.processList.TabIndex = 12;
      // 
      // snapToWindowButton
      // 
      this.snapToWindowButton.Location = new System.Drawing.Point(164, 64);
      this.snapToWindowButton.Name = "snapToWindowButton";
      this.snapToWindowButton.Size = new System.Drawing.Size(144, 23);
      this.snapToWindowButton.TabIndex = 13;
      this.snapToWindowButton.Text = "Snap to window";
      this.snapToWindowButton.UseVisualStyleBackColor = true;
      this.snapToWindowButton.Click += new System.EventHandler(this.snapToWindowButton_Click);
      // 
      // PositioningWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(323, 413);
      this.ControlBox = false;
      this.Controls.Add(this.snapToWindowButton);
      this.Controls.Add(this.processList);
      this.Controls.Add(this.refreshListButton);
      this.Controls.Add(this.applyButton);
      this.Controls.Add(label1);
      this.Controls.Add(wLabel);
      this.Controls.Add(yLabel);
      this.Controls.Add(xLabel);
      this.Controls.Add(this.hInput);
      this.Controls.Add(this.wInput);
      this.Controls.Add(this.yInput);
      this.Controls.Add(this.xInput);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.saveButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "PositioningWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Positioning";
      ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.wInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hInput)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown xInput;
        private System.Windows.Forms.NumericUpDown yInput;
        private System.Windows.Forms.NumericUpDown wInput;
        private System.Windows.Forms.NumericUpDown hInput;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button refreshListButton;
        private System.Windows.Forms.ListBox processList;
        private System.Windows.Forms.Button snapToWindowButton;
    }
}