using System.Media;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
            
        {
            InitializeComponent();
        }

        private void laatSpelen_Click(object sender, EventArgs e)
        {
           if(checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true)
            {
                MessageBox.Show("1 dier moet aangeclicked worden");

            }else
            {
                
                string toonObject = "";
                if(checkBox1.Checked == true)
                {

                    koe koe = new koe("Koe", 100, "boe", "C:\\Users\\furqa\\OneDrive - Erasmushogeschool Brussel\\Documenten\\sound\\cow\\cow-moo1.wav"); 
                    toonObject = toonObject + koe.Uitspraak + ", ";
                    SoundPlayer simpleSound = new SoundPlayer(koe.Geluid);
                    simpleSound.Play();
                }

                if (checkBox2.Checked == true)
                {
                    Slang slang = new Slang("slang", 30, "ssj", "C:\\Users\\furqa\\OneDrive - Erasmushogeschool Brussel\\Documenten\\sound\\snake\\Snake Strike 01.wav");
                    toonObject = toonObject + slang.Uitspraak + ", ";
                    SoundPlayer simpleSound = new SoundPlayer(slang.Geluid);
                    simpleSound.Play();
                }

                if (checkBox3.Checked == true)
                {
                    Varken varken = new Varken("varken", 130, "groink", "C:\\Users\\furqa\\OneDrive - Erasmushogeschool Brussel\\Documenten\\sound\\pig\\pig-1.wav");
                    toonObject = toonObject + varken.Uitspraak + ", ";
                    SoundPlayer simpleSound = new SoundPlayer(varken.Geluid);
                    simpleSound.Play();
                }

                MessageBox.Show(toonObject);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}