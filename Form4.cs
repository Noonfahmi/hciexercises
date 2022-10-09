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

namespace واجبات_hci
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
         
            
            }

        private void button5_Click(object sender, EventArgs e)
        {
        
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter="Text Files | *.TXT";
            saveFileDialog1.InitialDirectory = "C:\\";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK){
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            
            }
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files | *.TXT";
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Text = openFileDialog1.FileName;
                

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
          richTextBox1.Font = fontDialog1.Font;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void toolStripLabel2_Click(object sender, EventArgs e)

        {
            if (richTextBox1.SelectionFont.Bold == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
            else {

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
            else
            {

                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }

        }
        }
    }

