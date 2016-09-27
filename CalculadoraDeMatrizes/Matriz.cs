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
        public static void CriarMatriz(Panel painel, int linhas, int colunas)
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
        /// <summary>
        /// Guarda a matriz de um painel em um array float[,]
        /// </summary>
        /// <param name="panel">Painel da matriz que será guardada</param>
        /// <param name="linhas">Número de linhas da matriz que será guardada</param>
        /// <param name="colunas">Número de colunas da matriz que será guardada</param>
        /// <returns>Retorna um float[,] com os numeros preenchidos nos numericUpDowns da matriz</returns>
        public static float[,] GuardarMatriz(Panel panel, int linhas, int colunas)
        {
            float[,] matrix = new float[linhas, colunas];
            int i = 0;
            int j = 0;
            foreach (TextBox M in panel.Controls)
            {
                matrix[i, j] = float.Parse(M.Text);
                if (j == colunas - 1)
                {
                    j = 0;
                    i++;
                }
                else j++;
            }
            return matrix;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static float[,] SomarMatrizes(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            int lin = matrix1.GetLength(0);
            int col = matrix1.GetLength(1);
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixfinal[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrixfinal;
        }
    }
}
