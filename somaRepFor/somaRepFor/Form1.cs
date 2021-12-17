namespace somaRepFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int n1, n2, res = 0;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            if (n1 < n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    res += i;
                }
            }
            else
            {
                MessageBox.Show("O primeiro numero deve ser menor do que o segundo");
            }
            
            lblRes.Text = res.ToString();
        }
    }
}