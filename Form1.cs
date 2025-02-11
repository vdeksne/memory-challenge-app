namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int a = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
            button2.Text = "restart";
            a = 0;
            textBox1.Text = a.ToString();
            MessageBox.Show("Game starts now");
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = a - 1;
            textBox1.Text = a.ToString();
            MessageBox.Show("Nope, think harder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                a = a + 1;
                textBox1.Text = a.ToString();
                button3.BackColor = Color.Black;
                button3.Enabled = false;
                CheckAllButtonsClicked();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled)
            {
                a = a + 1;
                textBox1.Text = a.ToString();
                button5.BackColor = Color.Black;
                button5.Enabled = false;
                CheckAllButtonsClicked();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Enabled)
            {
                a = a + 1;
                textBox1.Text = a.ToString();
                button6.BackColor = Color.Black;
                button6.Enabled = false;
                CheckAllButtonsClicked();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Enabled)
            {
                a = a + 1;
                textBox1.Text = a.ToString();
                button7.BackColor = Color.Black;
                button7.Enabled = false;
                CheckAllButtonsClicked();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Enabled)
            {
                a = a + 1;
                textBox1.Text = a.ToString();
                button12.BackColor = Color.Black;
                button12.Enabled = false;
                CheckAllButtonsClicked();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Enabled)
            {
                a = a + 1;
                textBox1.Text = a.ToString();
                button15.BackColor = Color.Black;
                button15.Enabled = false;
                CheckAllButtonsClicked();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Enabled)
            {
                a = a + 1;
                textBox1.Text = a.ToString();
                button16.BackColor = Color.Black;
                button16.Enabled = false;
                CheckAllButtonsClicked();
            }
        }

        private void CheckAllButtonsClicked()
        {
            if (button3.BackColor == Color.Black &&
                button5.BackColor == Color.Black &&
                button6.BackColor == Color.Black &&
                button7.BackColor == Color.Black &&
                button12.BackColor == Color.Black &&
                button15.BackColor == Color.Black &&
                button16.BackColor == Color.Black)
            {
                MessageBox.Show("You won!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a = 0;
                textBox1.Text = a.ToString();
                MessageBox.Show("Game starts now");
                button1.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
                button11.BackColor = Color.White;
                button12.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button13.BackColor = Color.White;
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
            }
        }
    }
}