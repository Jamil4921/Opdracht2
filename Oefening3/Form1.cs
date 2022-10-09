namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            double britPound = Double.Parse(britishPound.Text);
            const double converter = 0.8805;
            britPound = britPound / converter;
            textBox1.Text = britPound.ToString();


        }

        private void converToEuro_Click(object sender, EventArgs e)
        {
            double euro = Double.Parse(Euro.Text);
            const double converter = 0.9827;
            euro = euro / converter;
            textBox2.Text = euro.ToString();
        }

        private void ConvertToYen_Click(object sender, EventArgs e)
        {
            double yen = Double.Parse(Yen.Text);
            const double converter = 144.54;
            yen = yen / converter;
            textBox3.Text = yen.ToString();
        }

        private void ConvertToSwiss_Click(object sender, EventArgs e)
        {
            double swiss = Double.Parse(Swiss.Text);
            const double converter = 0.92941;
            swiss = swiss / converter;
            textBox4.Text = swiss.ToString();
        }

        private void ConvertToIndianRupees_Click(object sender, EventArgs e)
        {
            double rupees = Double.Parse(Rupees.Text);
            const double converter = 76.293;
            rupees = rupees / converter;
            textBox5.Text = rupees.ToString();
        }

        private void ConvertToDollar_Click(object sender, EventArgs e)
        {
            double dollar = Double.Parse(Dollar.Text);
            textBox6.Text = dollar.ToString();
        }
    }
}