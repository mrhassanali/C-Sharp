using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace TexttoSpeech
{
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        SpeechSynthesizer sp = new SpeechSynthesizer(); //creating Object
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gender.Text == "Male")
            {
                sp.SelectVoiceByHints(VoiceGender.Male);
            }
            if (gender.Text == "Female")
            {
                sp.SelectVoiceByHints(VoiceGender.Female);
            }
            if (gender.Text == "Natural")
            {
                sp.SelectVoiceByHints(VoiceGender.Neutral);
            }
            sp.Speak(textBox1.Text);
        }

        private void textbox1_enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Type a Text..")
            {
                textBox1.Clear();
            }
        }

        private void textbox1_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Type a Text..";
            }
        }
    }
}
