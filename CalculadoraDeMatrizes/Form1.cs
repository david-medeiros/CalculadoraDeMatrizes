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

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCriarMatriz1_Click(object sender, EventArgs e)
        {
            groupBoxMatriz1.Controls.Clear();
            int linhas1 = Convert.ToInt32(LinhasMatriz1.Text);
            int colunas1 = Convert.ToInt32(ColunasMatriz1.Text);
            Matriz1 = new TextBox[linhas1, colunas1];
            int TamanhoLinhas = groupBoxMatriz1.Width / colunas1;
            int TamanhoColunas = groupBoxMatriz1.Height / linhas1;
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y] = new TextBox();
                    Matriz1[x, y].Text = "0";
                    //Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                    Matriz1[x, y].Left = y * TamanhoLinhas;
                    Matriz1[x, y].Top = x * TamanhoColunas;

                    Matriz1[x, y].Width = TamanhoLinhas;
                    Matriz1[x, y].Height = TamanhoColunas;
                    groupBoxMatriz1.Controls.Add(Matriz1[x, y]);
                }
            }
        }
    }
}
