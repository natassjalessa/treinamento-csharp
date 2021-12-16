namespace KmLitros
{
    public partial class Form1 : Form
    {
        double n1, n2, n3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            double res;

            lerValor();

            res = (n2 - n1) / n3;

            lblRes.Text = $"A AUTONOMIA É: {res.ToString("0.00")} KM POR LITRO";
        }

        private void lerValor()
        {
            n1 = Convert.ToDouble(txtInit.Text);
            n2 = Convert.ToDouble(txtCheg.Text);
            n3 = Convert.ToDouble(txtLi.Text);
        }
    }
}