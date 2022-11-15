namespace _5_3toolbox
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
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.coordXBox = new System.Windows.Forms.TextBox();
            this.teleportButton = new System.Windows.Forms.Button();
            this.coordYBox = new System.Windows.Forms.TextBox();
            this.coordZBox = new System.Windows.Forms.TextBox();
            this.xPosLabel = new System.Windows.Forms.Label();
            this.yPosLabel = new System.Windows.Forms.Label();
            this.zPosLabel = new System.Windows.Forms.Label();
            this.ModifySpeedButton = new System.Windows.Forms.Button();
            this.speedbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentSpeedLabel = new System.Windows.Forms.Label();
            this.AlwaysOnTopCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Location = new System.Drawing.Point(681, 426);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(107, 15);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "Process Not Found";
            this.ProcOpenLabel.TextChanged += new System.EventHandler(this.ProcOpenLabel_TextChanged);
            // 
            // coordXBox
            // 
            this.coordXBox.Location = new System.Drawing.Point(113, 9);
            this.coordXBox.Name = "coordXBox";
            this.coordXBox.Size = new System.Drawing.Size(100, 23);
            this.coordXBox.TabIndex = 2;
            // 
            // teleportButton
            // 
            this.teleportButton.Location = new System.Drawing.Point(113, 99);
            this.teleportButton.Name = "teleportButton";
            this.teleportButton.Size = new System.Drawing.Size(100, 23);
            this.teleportButton.TabIndex = 3;
            this.teleportButton.Text = "Teleport!";
            this.teleportButton.UseVisualStyleBackColor = true;
            this.teleportButton.Click += new System.EventHandler(this.teleportButton_Click);
            // 
            // coordYBox
            // 
            this.coordYBox.Location = new System.Drawing.Point(113, 41);
            this.coordYBox.Name = "coordYBox";
            this.coordYBox.Size = new System.Drawing.Size(100, 23);
            this.coordYBox.TabIndex = 4;
            // 
            // coordZBox
            // 
            this.coordZBox.Location = new System.Drawing.Point(113, 70);
            this.coordZBox.Name = "coordZBox";
            this.coordZBox.Size = new System.Drawing.Size(100, 23);
            this.coordZBox.TabIndex = 5;
            // 
            // xPosLabel
            // 
            this.xPosLabel.AutoSize = true;
            this.xPosLabel.Location = new System.Drawing.Point(12, 12);
            this.xPosLabel.Name = "xPosLabel";
            this.xPosLabel.Size = new System.Drawing.Size(14, 15);
            this.xPosLabel.TabIndex = 6;
            this.xPosLabel.Text = "X";
            // 
            // yPosLabel
            // 
            this.yPosLabel.AutoSize = true;
            this.yPosLabel.Location = new System.Drawing.Point(12, 41);
            this.yPosLabel.Name = "yPosLabel";
            this.yPosLabel.Size = new System.Drawing.Size(14, 15);
            this.yPosLabel.TabIndex = 7;
            this.yPosLabel.Text = "Y";
            // 
            // zPosLabel
            // 
            this.zPosLabel.AutoSize = true;
            this.zPosLabel.Location = new System.Drawing.Point(12, 70);
            this.zPosLabel.Name = "zPosLabel";
            this.zPosLabel.Size = new System.Drawing.Size(14, 15);
            this.zPosLabel.TabIndex = 8;
            this.zPosLabel.Text = "Z";
            // 
            // ModifySpeedButton
            // 
            this.ModifySpeedButton.Location = new System.Drawing.Point(232, 99);
            this.ModifySpeedButton.Name = "ModifySpeedButton";
            this.ModifySpeedButton.Size = new System.Drawing.Size(100, 23);
            this.ModifySpeedButton.TabIndex = 9;
            this.ModifySpeedButton.Text = "Apply Change";
            this.ModifySpeedButton.UseVisualStyleBackColor = true;
            this.ModifySpeedButton.Click += new System.EventHandler(this.ModifySpeedButton_Click);
            // 
            // speedbox
            // 
            this.speedbox.Location = new System.Drawing.Point(232, 70);
            this.speedbox.Name = "speedbox";
            this.speedbox.Size = new System.Drawing.Size(100, 23);
            this.speedbox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Change Speed     ";
            // 
            // CurrentSpeedLabel
            // 
            this.CurrentSpeedLabel.AutoSize = true;
            this.CurrentSpeedLabel.Location = new System.Drawing.Point(232, 49);
            this.CurrentSpeedLabel.Name = "CurrentSpeedLabel";
            this.CurrentSpeedLabel.Size = new System.Drawing.Size(95, 15);
            this.CurrentSpeedLabel.TabIndex = 12;
            this.CurrentSpeedLabel.Text = "Current speed is:";
            // 
            // AlwaysOnTopCB
            // 
            this.AlwaysOnTopCB.AutoSize = true;
            this.AlwaysOnTopCB.Location = new System.Drawing.Point(681, 395);
            this.AlwaysOnTopCB.Name = "AlwaysOnTopCB";
            this.AlwaysOnTopCB.Size = new System.Drawing.Size(104, 19);
            this.AlwaysOnTopCB.TabIndex = 13;
            this.AlwaysOnTopCB.Text = "Always On Top";
            this.AlwaysOnTopCB.UseVisualStyleBackColor = true;
            this.AlwaysOnTopCB.CheckedChanged += new System.EventHandler(this.AlwaysOnTopCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlwaysOnTopCB);
            this.Controls.Add(this.CurrentSpeedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speedbox);
            this.Controls.Add(this.ModifySpeedButton);
            this.Controls.Add(this.zPosLabel);
            this.Controls.Add(this.yPosLabel);
            this.Controls.Add(this.xPosLabel);
            this.Controls.Add(this.coordZBox);
            this.Controls.Add(this.coordYBox);
            this.Controls.Add(this.teleportButton);
            this.Controls.Add(this.coordXBox);
            this.Controls.Add(this.ProcOpenLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private Label ProcOpenLabel;
        private TextBox coordXBox;
        private Button teleportButton;
        private TextBox coordYBox;
        private TextBox coordZBox;
        private Label xPosLabel;
        private Label yPosLabel;
        private Label zPosLabel;
        private Button ModifySpeedButton;
        private TextBox speedbox;
        private Label label4;
        private Label CurrentSpeedLabel;
        private CheckBox AlwaysOnTopCB;
    }
}