namespace contaBancaria
{
    public partial class Form1 : Form
    {
        double valor, saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
                lerValor();
            

            switch (cmbBox.SelectedIndex)
            {
                case 0://DEPÓSITO

                    depositoBanco();

                    break;
                case 1://SAQUE

                    saqueBanco();

                    break;
                case 2://SALDO

                    saldoBanco();

                    break;
                default:
                    MessageBox.Show("DIGITE UMA OPÇÃO CORRETA", "BANCO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void depositoBanco()
        {
            valor += saldo;
            lblRealizar.Text = ("DEPÓSITO REALIZADO");
            txtValor.Clear();
            txtValor.Focus();
        }

        private void saqueBanco()
        {
            valor -= saldo;
            lblRealizar.Text = ("SAQUE REALIZADO");
            txtValor.Clear();
            txtValor.Focus();
        }

        private void saldoBanco()
        {
            MessageBox.Show($"SEU SALDO ATUAL É DE: R${valor.ToString("0.00")}");
        }
        private void lerValor()
        {
            if (!(cmbBox.SelectedIndex == 2))
            {
                if (double.TryParse(txtValor.Text, out saldo) == false)
                {
                    MessageBox.Show("Digite um valor válido");
                    return;
                }
            }
        }
    }
}