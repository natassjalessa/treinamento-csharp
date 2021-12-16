namespace trianguloLados
{
    public partial class Form1 : Form
    {
        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lerValor();

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    lblTipo.Text = ("� um triangulo equil�tero");
                }
                else if (a == b || b == c || a == c)
                {
                    lblTipo.Text = ("� um tri�ngulo is�sceles");
                }
                else
                {
                    lblTipo.Text = ("� um triangulo escaleno");
                }
            }
            else
            {
                MessageBox.Show("N�o � um triangulo", "Triangulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void lerValor()
        {
            a = int.Parse(txtX.Text);
            b = int.Parse(txtY.Text);
            c = int.Parse(txtZ.Text);
        }
    }
}