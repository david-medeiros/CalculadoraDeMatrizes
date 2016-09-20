using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMatrizes
{
    public partial class Form1 : Form
    {
        private TextBox[,] Matriz1;
        private NumericUpDown[,] Matriz2;
        private TextBox[,] MatrizResultante;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCriarMatriz1_Click(object sender, EventArgs e)
        {
            PanelMatriz1.Controls.Clear();
            int i1 = Convert.ToInt32(LinhasMatriz1.Text);
            int j1 = Convert.ToInt32(ColunasMatriz1.Text);
            //int Lei = Convert.ToInt32(textBoxLeiDeFormação1.Text);
            Matriz1 = new TextBox[i1, j1];
            int TamanhoLinhas1 = PanelMatriz1.Width / j1;
            int TamanhoColunas1 = PanelMatriz1.Height / i1;
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y] = new TextBox();
                    Matriz1[x, y].Text = "0";
                    //Matriz1[x, y].DecimalPlaces = 1;
                    Matriz1[x, y].Width = TamanhoLinhas1;
                    Matriz1[x, y].Height = TamanhoColunas1;
                    Matriz1[x, y].Top = x * Matriz1[x, y].Height;
                    Matriz1[x, y].Left = y * TamanhoLinhas1;
                    PanelMatriz1.Controls.Add(Matriz1[x, y]);
                }
            }
        }

        private void ButtonCriarMatriz2_Click(object sender, EventArgs e)
        {
            PanelMatriz2.Controls.Clear();
            int i2 = Convert.ToInt32(LinhasMatriz2.Text);
            int j2 = Convert.ToInt32(ColunasMatriz2.Text);
            Matriz2 = new NumericUpDown[i2, j2];
            int TamanhoColunas2 = PanelMatriz1.Height / i2;
            int TamanhoLinhas2 = PanelMatriz1.Width / j2;
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    Matriz2[x, y] = new NumericUpDown();
                    Matriz2[x, y].Text = "0";
                    Matriz2[x, y].DecimalPlaces = 1;
                    Matriz2[x, y].Width = TamanhoLinhas2;
                    Matriz2[x, y].Height = TamanhoColunas2;
                    Matriz2[x, y].Top = x * Matriz2[x, y].Height;
                    Matriz2[x, y].Left = y * TamanhoLinhas2;
                    PanelMatriz2.Controls.Add(Matriz2[x, y]);
                }
            }
        }

        private void ButtonSomar_Click(object sender, EventArgs e)
        {
            PanelMatrizResultante.Controls.Clear();
            /*if(i1 != i2 || j1 != j2)
            {

            }*/
            int iResultado = Convert.ToInt32(LinhasMatriz2.Text);
            int jResultado = Convert.ToInt32(ColunasMatriz2.Text);
            MatrizResultante = new TextBox[iResultado, jResultado];
            int TamanhoColunas2 = PanelMatrizResultante.Height / iResultado;
            int TamanhoLinhas2 = PanelMatrizResultante.Width / jResultado;
            for (int x = 0; x < Matriz2.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz2.GetLength(1); y++)
                {
                    MatrizResultante[x, y] = new TextBox();
                    MatrizResultante[x, y].Text = Convert.ToString(Convert.ToInt32(Matriz1[x, y].Text) + Convert.ToInt32(Matriz2[x, y].Text));
                    //MatrizResultante[x, y].DecimalPlaces = 1;
                    MatrizResultante[x, y].Height = TamanhoColunas2;
                    MatrizResultante[x, y].Width = TamanhoLinhas2;
                    MatrizResultante[x, y].Top = x * Matriz2[x, y].Height;
                    MatrizResultante[x, y].Left = y * TamanhoLinhas2;
                    PanelMatriz2.Controls.Add(MatrizResultante[x, y]);
                }
            }
        }
    }
}
