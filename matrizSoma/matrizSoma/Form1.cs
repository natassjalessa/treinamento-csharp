using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace matrizSoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] val = new int[2, 2];
            int total = 0;

            for (int linha = 0; linha < val.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < val.GetLength(1); coluna++)
                {
                    val[linha, coluna] = int.Parse(Interaction.InputBox($"Digite o elemento da posição{linha.ToString()}, {coluna.ToString()} da matriz"));

                    total += val[linha, coluna];

                }

                MessageBox.Show(total.ToString());
            }

        }
    }
}
