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
        private NumericUpDown[,] Matriz1;
        private NumericUpDown[,] Matriz2;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCriarMatriz1_Click(object sender, EventArgs e)
        {
            PanelMatriz1.Controls.Clear();
            PanelMatriz2.Controls.Clear();
            int i1 = Convert.ToInt32(LinhasMatriz1.Text);
            int j1 = Convert.ToInt32(ColunasMatriz1.Text);
            int i2 = Convert.ToInt32(LinhasMatriz2.Text);
            int j2 = Convert.ToInt32(ColunasMatriz2.Text);
            Matriz1 = new NumericUpDown[i1, j1];
            Matriz2 = new NumericUpDown[i2, j2];
            int TamanhoLinhas = PanelMatriz1.Width / j1;
            int TamanhoColunas = PanelMatriz1.Height / i1;
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y] = new NumericUpDown();
                    Matriz1[x, y].Text = "0";
                    Matriz1[x, y].DecimalPlaces = 1;
                    Matriz1[x, y].Top = x * Matriz1[x, y].Height;
                    Matriz1[x, y].Left = y * TamanhoLinhas;
                    Matriz1[x, y].Width = TamanhoLinhas;
                    Matriz1[x, y].Height = TamanhoColunas;
                    PanelMatriz1.Controls.Add(Matriz1[x, y]);
                }
            }
        }
    }
}
