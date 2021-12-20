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

namespace matrizSoma4x4
{
    public partial class Form1 : Form
    {
        int linha, coluna;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] val = new int[4, 4];
            int soma = 0;
            int media = 0;
            int mult0 = 0, mult1 = 0, mult2 = 0, mult3 = 0; 

            for (linha = 0; linha < val.GetLength(0); linha++)
            {
                for (coluna = 0; coluna < val.GetLength(1); coluna++)
                {
                    val[linha, coluna] = (int.Parse(Interaction.InputBox($"Digite o elemento da posição{linha.ToString()},{coluna.ToString()} da matriz")));

                    soma = val[0,0] + val[0,1] + val[0,2] + val[0,3];
                }

                media = (val[1, 0] + val[1, 1] + val[1, 2] + val[1, 3]) / 4;

                mult0 = val[2, 0] * val[3, 0];
                mult1 = val[2,1] * val[3, 1];
                mult2 = val[2,2] * val[3,2];
                mult3 = val[2,3] * val[3,3];
            }
            MessageBox.Show($"SOMA DA LINHA 1: {soma.ToString()}");
            MessageBox.Show($"MEDIA DA LINHA 2: {media.ToString()}");
            MessageBox.Show($"MULTIPLICAÇÃO: {mult0.ToString()} - {mult1.ToString()} - {mult2.ToString()} - {mult3.ToString()}");
        }
    }
}
