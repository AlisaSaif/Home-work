namespace WinFormsApp2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button_ravno_Click(object sender, EventArgs e)
        {
            string primer = textBox2.Text;
            int res = 0; 
            string[] num = primer.Split(' ');
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] == "+")
                {
                    res = Convert.ToInt32(num[i - 1]) + Convert.ToInt32(num[i + 1]);
                }
                if (num[i] == "-")
                {
                    res = Convert.ToInt32(num[i - 1]) - Convert.ToInt32(num[i + 1]);
                }
                if (num[i] == "*")
                {
                    res = Convert.ToInt32(num[i - 1]) * Convert.ToInt32(num[i + 1]);
                }
                if (num[i] == "/")
                {
                    res = Convert.ToInt32(num[i - 1]) / Convert.ToInt32(num[i + 1]);
                }
                textBox2.Text = res.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            textBox2.Text += " + ";
        }

        private void button_minys_Click(object sender, EventArgs e)
        {
            textBox2.Text += " - ";
        }

        private void button_ymno_Click(object sender, EventArgs e)
        {
            textBox2.Text += " * ";
        }

        private void button_razdel_Click(object sender, EventArgs e)
        {
            textBox2.Text += " / ";
        }



        int Plus1, Plus2, Minys1, Munys2, Ymno1, Ymno2;
        double Del1, Del2;
        private void button_Start_Click_1(object sender, EventArgs e)
        {
            Random num = new Random();
            Plus1 = num.Next(0,100);
            Plus2 = num.Next(0, 100);
            Minys1 = num.Next(0, 100);
            Munys2 = num.Next(0, 100);
            Ymno1  = num.Next(0, 100);
            Ymno2 = num.Next(0, 100);
            Del1 = num.Next(1, 100);
            Del2 = num.Next(1, 100);
            pl1.Text = Convert.ToString(Plus1);
            pl2.Text = Convert.ToString(Plus2);
            min1.Text = Convert.ToString(Minys1);
            min2.Text = Convert.ToString(Munys2);
            ym1.Text = Convert.ToString(Ymno1);
            ym2.Text = Convert.ToString(Ymno2);
            del1.Text = Convert.ToString(Del1);
            del2.Text = Convert.ToString(Del2);
            pl3.BackColor = Color.White;
            pl3.Text = "";
            min3.BackColor = Color.White;
            min3.Text = "";
            ym3.BackColor = Color.White;
            ym3.Text = "";
            del3.BackColor = Color.White;
            del3.Text = "";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Plus1 + Plus2 != Convert.ToInt32(pl3.Text) || pl3.Text == null)
            {
                pl3.BackColor = Color.Red;
            }
            else
            {
                pl3.BackColor = Color.Green;
            }
            if (Minys1 - Munys2 != Convert.ToInt32(min3.Text) || min3.Text == null)
            {
                min3.BackColor = Color.Red;
            }
            else
            {
                min3.BackColor = Color.Green;
            }
            if (Ymno1 * Ymno2 != Convert.ToInt32(ym3.Text) || ym3.Text == null)
            {
                ym3.BackColor = Color.Red;
            }
            else
            {
                ym3.BackColor = Color.Green;
            }
            if (Del1 / Del2 != Convert.ToDouble(del3.Text) || del3.Text == null)
            {
                del3.BackColor = Color.Red;
            }
            else
            {
                del3.BackColor = Color.Green;
            }
        }
    }
}