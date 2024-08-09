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

namespace testspeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                Console.WriteLine(voice.VoiceInfo.Name);
            }
            //synthesizer.SelectVoice();
            synthesizer.Speak("1");
        }
    }
}
