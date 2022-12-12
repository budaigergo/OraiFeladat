using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace OraiFeladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
            }
            if (string.IsNullOrEmpty(richTextBox_szoveg.Text))
            {
                MessageBox.Show("nem adott meg szoveget!");
            }
            saveFileDialog1.Filter = "Szöveg fájl|*.txt|Vesszővel tagolt szovegfájl(*.csv)|*csv|Minden fajl|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string szoveg = string.Join(";", textBox_Nev.Text, richTextBox_szoveg.Text,dateTimePicker1.Text);
                string kivFile = saveFileDialog1.FileName;
                File.WriteAllText(kivFile, szoveg);
                textBox_Nev.Text = "";
                richTextBox_szoveg.Text = "";
                dateTimePicker1.Text = "";
                
            }
            else
            {
                MessageBox.Show("nincs kivalasztva");
            }
           

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kivFile = openFileDialog1.FileName;
                string beolvasottszoveg = File.ReadAllText(kivFile);
                string[] adatok = beolvasottszoveg.Split(';');
                textBox_Nev.Text = adatok[0];
                richTextBox_szoveg.Text = adatok[1];
                dateTimePicker1.Text = adatok[2];
            }
            MessageBox.Show("asd");        }
    }
    }
