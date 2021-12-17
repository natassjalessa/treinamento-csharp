namespace quantPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int n1, n2, QuantPares = 0;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            lblRes.Text = "";

            if (n1 < n2)
            {
                do
                {
                    if (n1 % 2 == 0)
                    {
                        QuantPares++;
                    }
                    n1++;
                } while (n1 < n2);
                lblRes.Text = QuantPares.ToString();
            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!");
            }

        }
    }
}