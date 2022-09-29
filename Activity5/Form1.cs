using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        String str;
        int max_val = 0, max_index = 0, vow_count = 0, vow_index;



        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                str = System.IO.File.ReadAllText(openFileDialog1.FileName); 
                txtdisplay.Text = str.ToLower();
                string[] array = str.Split(' ');
                txtfirstword.Text = array[0];
                txtlastword.Text = array[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (max_val < array[i].Length)
                    {
                        max_val = array[i].Length;
                        max_index = i;
                    }
                    if (vow_count < VowelCount(array[i]))
                    {
                        vow_count = VowelCount(array[i]);
                        vow_index = i;
                    }
                }
                txtlongest.Text = array[max_index];
                mostVowel.Text = array[vow_index];
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\write.txt");
                sw.WriteLine("Converting in Lower ::" + txtdisplay.Text);
                sw.WriteLine("First Word ::" + txtfirstword.Text);
                sw.WriteLine("Last Word ::" + txtlastword.Text);
                sw.WriteLine("Longest word ::" + txtlongest.Text);
                sw.WriteLine("Longest Vowel Word ::" + mostVowel.Text);
                sw.Close();
                MessageBox.Show("Text file is Created");
            }

        }
        public int VowelCount(string sentence)
        {
            int vowels = 0;
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u') || (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
                'I' || sentence[i] == 'O' || sentence[i] == 'U'))
                {
                    vowels = vowels + 1;
                }

            }
            return vowels;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
