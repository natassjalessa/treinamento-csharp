namespace notaEscolar
{
    public partial class Form1 : Form
    {
        double n1, n2, freq, med, res, dada;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            lerValor();  

            med = (n1 + n2) / 2;
            res = (freq / dada) * 100;

            lblMed.Text = ($"SUA MÉDIA: {med.ToString("0.00")}");
            lblFreq.Text = ($"SUA FREQUENCIA: {freq.ToString("0.00")}");

            if (med >= 7 && res >= 75)
            {
                MessageBox.Show("VOCE FOI APROVADO", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("VOCE FOI REPROVADO", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void lerValor()
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            freq = double.Parse(txtFreq.Text);
            dada = double.Parse(txtDada.Text);
        }
    }
}