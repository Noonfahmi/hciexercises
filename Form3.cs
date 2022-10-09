using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace واجبات_hci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            String name, passord;
            name=textBox1.Text;
            passord=textBox2.Text;
            if (name == "noonfahmi" && passord == "12345")
            {

                MessageBox.Show("تم تسجيل الدخول بنجاح", "شاشة تسجيل الدخول", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                Form2 f = new Form2();
                f.Show();


            }
            else {
                MessageBox.Show("هناك خطا في اسم المستخدم او كلمة المرور", "شاشة تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count++;
                if (count == 3)
                {
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
