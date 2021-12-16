namespace MediaAluno
{
    public partial class Form1 : Form
    {
        double n1, n2, n3, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lerValor();

            res = (n1 + n2 + n3) / 3;

            if (res >= 7)
            {
                MessageBox.Show($"Você foi aprovado, sua nota foi: {res.ToString("0.00")}", "AVALIAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((res > 4)&&(res < 7))
            {
                MessageBox.Show($"Você está de prova final, sua nota foi: {res.ToString("0.00")}", "AVALIAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (res <= 4)
            {
                MessageBox.Show($"Você foi reprovado, sua note foi: {res.ToString("0.00")}", "AVALIAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lerValor()
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);
        }
    }
}