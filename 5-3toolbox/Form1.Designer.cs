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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.coordXBox.Location = new System.Drawing.Point(32, 12);
            this.coordXBox.Name = "coordXBox";
            this.coordXBox.Size = new System.Drawing.Size(100, 23);
            this.coordXBox.TabIndex = 2;
            // 
            // teleportButton
            // 
            this.teleportButton.Location = new System.Drawing.Point(32, 99);
            this.teleportButton.Name = "teleportButton";
            this.teleportButton.Size = new System.Drawing.Size(100, 23);
            this.teleportButton.TabIndex = 3;
            this.teleportButton.Text = "Teleport!";
            this.teleportButton.UseVisualStyleBackColor = true;
            this.teleportButton.Click += new System.EventHandler(this.teleportButton_Click);
            // 
            // coordYBox
            // 
            this.coordYBox.Location = new System.Drawing.Point(32, 41);
            this.coordYBox.Name = "coordYBox";
            this.coordYBox.Size = new System.Drawing.Size(100, 23);
            this.coordYBox.TabIndex = 4;
            // 
            // coordZBox
            // 
            this.coordZBox.Location = new System.Drawing.Point(32, 70);
            this.coordZBox.Name = "coordZBox";
            this.coordZBox.Size = new System.Drawing.Size(100, 23);
            this.coordZBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}