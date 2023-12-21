using System.Security.Cryptography;

namespace For
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

        private void button1_Click(object sender, EventArgs e)
        {
            int num_final = Convert.ToInt32(textBox1.Text);
            int num_inicial = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Clear();
            for (int i = num_inicial; i <= num_final; i++)
            {

                listBox1.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }

       
        
    }
}