using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.Windows.Controls.Primitives;


namespace Text_to_Speech_Convertor
{
    /// <summary>
    /// TODO: Describe methods 
    /// </summary>
    public partial class Form1 : Form
    {
        SpeechSynthesizer reader;
        private EventHandler<SpeakCompletedEventArgs> reader_SpeakCompleted;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reader = new SpeechSynthesizer();
            pauseButton.Enabled = false;
            resumeButton.Enabled = false;
            stopButton.Enabled = false;
            inputBox.ScrollBars = ScrollBars.Both;




        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            inputBox.Text = File.ReadAllText(openFileDialog1.FileName.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            reader.Dispose();
            if (inputBox.Text != "")
            {
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(inputBox.Text);
                statusLabel.Text = "Speaking";
                pauseButton.Enabled = true;
                stopButton.Enabled = true;
                reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(Reader_SpeakCompleted);

            }
            else
            {
                MessageBox.Show("Please enter some text in the textbox", "Message", MessageBoxButtons.OK);

            }
        }

        void Reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            statusLabel.Text = "Idle";
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                    statusLabel.Text = "Paused";
                    resumeButton.Enabled = true;
                }
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                    statusLabel.Text = "Speaking";
                }
                resumeButton.Enabled = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
                statusLabel.Text = "Idle";
                pauseButton.Enabled = false;
                resumeButton.Enabled = false;
                stopButton.Enabled = false;

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}




