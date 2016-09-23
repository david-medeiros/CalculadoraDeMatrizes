using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;

namespace CalculadoraDeMatrizes
{
    static class Matriz
    {
        /// <summary>
        /// Cria matriz de ordem escolhida pelo usuário.
        /// </summary>
        /// <param name="linhas">Número de linhas da matriz que será criada.</param>
        /// <param name="colunas">Número de colunas da matriz que será criada.</param>
        /// <param name="painel">Painel em que a matriz será criada.</param>
        public static void CriarMatriz(int linhas, int colunas, Panel painel)
        {
            TextBox[,] Matriz = new TextBox[linhas, colunas];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Size = new Size(painel.Width / colunas, painel.Height / linhas);
                    Matriz[i, j].Location = new Point(j * Matriz[i, j].Width, i * Matriz[i, j].Height);
                    painel.Controls.Add(Matriz[i, j]);
                }
            }
                
            
        }

    }
}
