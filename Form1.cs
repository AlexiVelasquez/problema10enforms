namespace problema10enforms
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

            double consumo = double.Parse(txtnum1.Text);
            double dscto, total;
            if (consumo <= 100)
            {
                dscto = consumo * 0.10;


                double igv = 0.18 * dscto;

                
                total = dscto + igv;
                lbl1.Text=("Total a pagar:" + total + "$");
            }
            else if (consumo >= 100)
            {

                dscto = consumo * 0.20;
                double igv = 0.18 * dscto;
                total = dscto + igv;
                lbl1.Text=("Total a pagar:" + total + "$");

            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}