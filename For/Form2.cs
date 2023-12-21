using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numerocorreto = random.Next(1, 11);
            int tentativa = Convert.ToInt32(textBox1.Text);
            while (numerocorreto != tentativa)
            {
                MessageBox.Show("O número está errado, tente de novo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox1.Image = Image.FromFile("C:\\PictureBox\\sad.jpg");
                return;
            }
            if (numerocorreto == tentativa)
            {
                MessageBox.Show("Parabéns, acertou o número!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Image = Image.FromFile("C:\\PictureBox\\man.jpg");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
