namespace bancoSaldo
{
    public partial class Form1 : Form
    {
        double din, val, saq;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            switch (cmbOp.SelectedIndex)
            {
                case 0:
                    val = din + val;
                    din = double.Parse(txtDin.Text);
                    lblRes1.Text = ($"ATUAL: {val.ToString("0.00")}");
                    MessageBox.Show($"SELECIONADO: { cmbOp.SelectedItem.ToString()}");
                    break;
                case 1:
                    MessageBox.Show($"SELECIONADO: { cmbOp.SelectedItem.ToString()}");
                    saq = double.Parse(txtSaq.Text);
                    val = val - saq;
                    lblRes1.Text = ($"ATUAL: {val.ToString("0.00")}");
                    txtSaq.Clear();
                    txtSaq.Focus();
                    break;
                case 2:
                    MessageBox.Show($"SELECIONADO: { cmbOp.SelectedItem.ToString()}");
                    lblRes1.Text = ($"ATUAL: {val.ToString("0.00")}");
                    break;
                default:
                    MessageBox.Show("DIGITE UMA OPÇÃO CORRETA");
                    break;
            }
        }
    }
}