namespace Text_to_Speech_Convertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enterLabel = new System.Windows.Forms.Label();
            this.synthLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.speakButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Text Files(*.txt) |*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(27, 42);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(1002, 449);
            this.inputBox.TabIndex = 1;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(13, 13);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(353, 13);
            this.enterLabel.TabIndex = 1;
            this.enterLabel.Text = "Enter text into the area below, or click the \"Load\" button to load a text file";
            this.enterLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // synthLabel
            // 
            this.synthLabel.AutoSize = true;
            this.synthLabel.Location = new System.Drawing.Point(42, 626);
            this.synthLabel.Name = "synthLabel";
            this.synthLabel.Size = new System.Drawing.Size(97, 13);
            this.synthLabel.TabIndex = 9;
            this.synthLabel.Text = "Synthesiser Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(146, 626);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(24, 13);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Idle";
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.exitpng;
            this.exitButton.Location = new System.Drawing.Point(752, 526);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(179, 107);
            this.exitButton.TabIndex = 8;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.clearpng;
            this.clearButton.Location = new System.Drawing.Point(621, 527);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 94);
            this.clearButton.TabIndex = 7;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.stoppng;
            this.stopButton.Location = new System.Drawing.Point(490, 541);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(96, 72);
            this.stopButton.TabIndex = 6;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.resumepng_revised;
            this.resumeButton.Location = new System.Drawing.Point(216, 526);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(253, 102);
            this.resumeButton.TabIndex = 5;
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.pausepng;
            this.pauseButton.Location = new System.Drawing.Point(118, 526);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 95);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // speakButton
            // 
            this.speakButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.playpng2;
            this.speakButton.Location = new System.Drawing.Point(26, 538);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(70, 71);
            this.speakButton.TabIndex = 3;
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Image = global::Text_to_Speech_Convertor.Properties.Resources.uploadpng;
            this.loadButton.Location = new System.Drawing.Point(1035, 29);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(180, 178);
            this.loadButton.TabIndex = 2;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1239, 648);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.synthLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.inputBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Text to Speech Convertor © Adam Fitzpatrick 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label synthLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

