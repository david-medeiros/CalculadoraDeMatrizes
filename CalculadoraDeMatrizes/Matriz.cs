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
            painel.Controls.Clear();
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
        public static float[,] GuardarMatriz(Panel painel, int linhas, int colunas)
        {
            float[,] matrix = new float[linhas, colunas];
            int i = 0;
            int j = 0;
            foreach (TextBox M in painel.Controls)
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
        /// Desenha uma matriz em um painel
        /// </summary>
        /// <param name="Painel a ser desenhado">Painel onde a matriz será desenhada</param>
        /// <param name="matrix">Matriz a ser desenhada no painel</param>
        public static void DesenhaMatrixText(Panel painel, float[,] matrix)
        {
            painel.Controls.Clear();
            TextBox[,] M = new TextBox[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    M[i, j] = new TextBox();
                    M[i, j].Text = ((float)matrix[i, j]).ToString();
                    M[i, j].Size = new Size(painel.Width / 2, painel.Height / 2);
                    M[i, j].Location = new Point(j * M[i, j].Width, i * M[i, j].Height);
                    painel.Controls.Add(M[i, j]);
                }
            }
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
            int linhas = matrix1.GetLength(0);
            int colunas = matrix1.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrixfinal[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrixfinal;
        }

        public static float [,] SubtrairMatrizes(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            int linhas = matrix1.GetLength(0);
            int colunas = matrix1.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrixfinal[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrixfinal;
        }

        public static float[,] MultiplicarMatrizes(float[,] matrix1, float[,] matrix2)
        {
        
        }
    }
}
