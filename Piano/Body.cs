using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class Body : Form
    {
        public Body()
        {
            InitializeComponent();
        }

        private void Body_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//C
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.c4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(261, 500);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//D
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.d4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(294, 500);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//E
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.e4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(329, 500);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//F
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.f4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(349, 500);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//G
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.g4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(392, 500);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {//A
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.a4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(440, 500);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {//B
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.b4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(493, 500);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {//C
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.c5);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(523, 500);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {//D
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.d5);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(587, 500);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {//E
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.e5);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(659, 500);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {//F
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.f5);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(698, 500);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {//C#
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.cs4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(277, 500);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {//D#
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.ds4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(311, 500);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {//F#
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fs4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(370, 500);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {//G#
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.gs4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(415, 500);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {//A#
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.as4);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(466, 500);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {//C#
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.cs5);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(554, 500);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {//D#
            if (radioButton1.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.ds5);
                player.Load();
                player.PlaySync();
            }
            else
            {
                Console.Beep(622, 500);
            }
        }
    }
}
