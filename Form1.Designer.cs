namespace TrafficLightController
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            stopButton = new Button();
            redPanel = new Panel();
            yellowPanel = new Panel();
            greenPanel = new Panel();
            numericRed = new NumericUpDown();
            numericYellow = new NumericUpDown();
            numericGreen = new NumericUpDown();
            appTitle = new Label();
            redLabel = new Label();
            yellowLabel = new Label();
            greenLabel = new Label();
            redLightTime = new Label();
            yellowLightTime = new Label();
            greenLightTime = new Label();
            ((System.ComponentModel.ISupportInitialize)numericRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(301, 390);
            startButton.Name = "startButton";
            startButton.Size = new Size(101, 45);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(517, 390);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(94, 45);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // redPanel
            // 
            redPanel.BackColor = SystemColors.AppWorkspace;
            redPanel.Location = new Point(193, 139);
            redPanel.Name = "redPanel";
            redPanel.Size = new Size(100, 100);
            redPanel.TabIndex = 2;
            redPanel.Paint += redPanel_Paint;
            // 
            // yellowPanel
            // 
            yellowPanel.BackColor = SystemColors.AppWorkspace;
            yellowPanel.Location = new Point(406, 139);
            yellowPanel.Name = "yellowPanel";
            yellowPanel.Size = new Size(100, 100);
            yellowPanel.TabIndex = 3;
            yellowPanel.Paint += yellowPanel_Paint;
            // 
            // greenPanel
            // 
            greenPanel.BackColor = SystemColors.AppWorkspace;
            greenPanel.Location = new Point(605, 139);
            greenPanel.Name = "greenPanel";
            greenPanel.Size = new Size(100, 100);
            greenPanel.TabIndex = 4;
            greenPanel.Paint += greenPanel_Paint;
            // 
            // numericRed
            // 
            numericRed.Location = new Point(193, 305);
            numericRed.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericRed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRed.Name = "numericRed";
            numericRed.Size = new Size(100, 23);
            numericRed.TabIndex = 5;
            numericRed.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericRed.ValueChanged += numericRed_ValueChanged;
            // 
            // numericYellow
            // 
            numericYellow.Location = new Point(406, 305);
            numericYellow.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericYellow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericYellow.Name = "numericYellow";
            numericYellow.Size = new Size(100, 23);
            numericYellow.TabIndex = 6;
            numericYellow.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericYellow.ValueChanged += numericYellow_ValueChanged;
            // 
            // numericGreen
            // 
            numericGreen.Location = new Point(605, 305);
            numericGreen.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericGreen.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericGreen.Name = "numericGreen";
            numericGreen.Size = new Size(100, 23);
            numericGreen.TabIndex = 7;
            numericGreen.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericGreen.ValueChanged += numericGreen_ValueChanged;
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            appTitle.ForeColor = SystemColors.ControlDarkDark;
            appTitle.Location = new Point(276, 41);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(349, 45);
            appTitle.TabIndex = 8;
            appTitle.Text = "Traffic light controller";
            // 
            // redLabel
            // 
            redLabel.AutoSize = true;
            redLabel.Location = new Point(193, 121);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(54, 15);
            redLabel.TabIndex = 9;
            redLabel.Text = "Red light";
            // 
            // yellowLabel
            // 
            yellowLabel.AutoSize = true;
            yellowLabel.Location = new Point(406, 121);
            yellowLabel.Name = "yellowLabel";
            yellowLabel.Size = new Size(68, 15);
            yellowLabel.TabIndex = 10;
            yellowLabel.Text = "Yellow light";
            // 
            // greenLabel
            // 
            greenLabel.AutoSize = true;
            greenLabel.Location = new Point(605, 121);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(65, 15);
            greenLabel.TabIndex = 11;
            greenLabel.Text = "Green light";
            // 
            // redLightTime
            // 
            redLightTime.AutoSize = true;
            redLightTime.Location = new Point(193, 287);
            redLightTime.Name = "redLightTime";
            redLightTime.Size = new Size(81, 15);
            redLightTime.TabIndex = 12;
            redLightTime.Text = "Red light time";
            // 
            // yellowLightTime
            // 
            yellowLightTime.AutoSize = true;
            yellowLightTime.Location = new Point(406, 287);
            yellowLightTime.Name = "yellowLightTime";
            yellowLightTime.Size = new Size(95, 15);
            yellowLightTime.TabIndex = 13;
            yellowLightTime.Text = "Yellow light time";
            // 
            // greenLightTime
            // 
            greenLightTime.AutoSize = true;
            greenLightTime.Location = new Point(605, 287);
            greenLightTime.Name = "greenLightTime";
            greenLightTime.Size = new Size(92, 15);
            greenLightTime.TabIndex = 14;
            greenLightTime.Text = "Green light time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(899, 524);
            Controls.Add(greenLightTime);
            Controls.Add(yellowLightTime);
            Controls.Add(redLightTime);
            Controls.Add(greenLabel);
            Controls.Add(yellowLabel);
            Controls.Add(redLabel);
            Controls.Add(appTitle);
            Controls.Add(numericGreen);
            Controls.Add(numericYellow);
            Controls.Add(numericRed);
            Controls.Add(greenPanel);
            Controls.Add(yellowPanel);
            Controls.Add(redPanel);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)numericRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button stopButton;
        private Panel redPanel;
        private Panel yellowPanel;
        private Panel greenPanel;
        private NumericUpDown numericRed;
        private NumericUpDown numericYellow;
        private NumericUpDown numericGreen;
        private Label appTitle;
        private Label redLabel;
        private Label yellowLabel;
        private Label greenLabel;
        private Label redLightTime;
        private Label yellowLightTime;
        private Label greenLightTime;
    }
}
