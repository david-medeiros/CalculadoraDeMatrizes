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
        /// Cria matriz de ordem escolhida pelo usuário
        /// </summary>
        /// <param name="linhas">Número de linhas da matriz que será criada</param>
        /// <param name="colunas">Número de colunas da matriz que será criada</param>
        /// <param name="painel">Painel em que a matriz será criada</param>
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
        /// Soma as matrizes de 2 arrays float[,]
        /// </summary>
        /// <param name="matrix1">Matriz a ser somada</param>
        /// <param name="matrix2">Matriz a ser somada</param>
        /// <returns>Retorna um float[,] da soma de duas matrizes</returns>
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
        /// <summary>
        /// Subtrai as matrizes de 2 arrays float[,]
        /// </summary>
        /// <param name="matrix1">Matriz a ser subtraida</param>
        /// <param name="matrix2">Matriz a ser subtraida</param>
        /// <returns>Retorna um float[,] da subtração de duas matrizes</returns>
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
        /// <summary>
        /// Multiplica as matrizes de 2 arrays float[,]
        /// </summary>
        /// <param name="matrix1">Matriz a ser multiplicada</param>
        /// <param name="matrix2">Matriz a ser multiplicada</param>
        /// <returns>Retorna um float[,] da multiplicação de duas matrizes</returns>
        public static float[,] MultiplicarMatrizes(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix2.GetLength(1)];
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new MultiplyException();
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int c = 0; c < matrix1.GetLength(1); c++)
                    {
                        matrixfinal[i, j] += matrix1[i, c] * matrix2[c, j];
                    }
                    if (Math.Round(matrixfinal[i, j]) == 1)
                        matrixfinal[i, j] = 1;
                    else if (Math.Round(matrixfinal[i, j]) == 0)
                    {
                        matrixfinal[i, j] = 0;
                    }
                    else matrixfinal[i, j] = matrixfinal[i, j];
                }
            }
            return matrixfinal;
        }
        /// <summary>
        /// Divide as matrizes de 2 arrays float[,]
        /// </summary>
        /// <param name="matrix1">Matriz a ser dividida</param>
        /// <param name="matrix2">Matriz a ser dividida</param>
        /// <returns>Retorna um float[,] da multiplicação de duas matrizes</returns>
        public static float[,] DividirMatrizes(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix2.GetLength(1)];
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new MultiplyException();
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int c = 0; c < matrix1.GetLength(1); c++)
                    {
                        matrixfinal[i, j] += matrix1[i, c] / matrix2[c, j];
                    }
                    if (Math.Round(matrixfinal[i, j]) == 1)
                        matrixfinal[i, j] = 1;
                    else if (Math.Round(matrixfinal[i, j]) == 0)
                    {
                        matrixfinal[i, j] = 0;
                    }
                    else matrixfinal[i, j] = matrixfinal[i, j];
                }
            }
            return matrixfinal;
        }
        /// <summary>
        /// Multiplica uma matriz por um numero escalar
        /// </summary>
        /// <param name="matriz">Matriz a ser multiplicada por um número</param>
        /// <param name="valor">Número para multiplicar a matriz</param>
        /// <returns>A matriz multiplicada pelo numero escalar</returns>
        public static float[,] MultiplicarMatrizesEscalar(float[,] matriz, float valor)
        {
            float[,] matrixfinal = new float[matriz.GetLength(0), matriz.GetLength(1)];
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrixfinal[i, j] = matriz[i, j] * valor;
                }
            }
            return matrixfinal;
        }
        /// <summary>
        /// Elevar Matrizes a determinada potência
        /// </summary>
        /// <param name="matriz">Matriz a ser elevada</param>
        /// <param name="exp">Potência que elevará a matriz</param>
        /// <returns>Resultado da matriz elevada a determinada potência</returns>
        public static float[,] ElevarMatriz(float[,] matriz, int exp)
        {
            if (matriz.GetLength(0) != matriz.GetLength(1))
            {
                throw new QuadradaException();
            }
            float[,] result = matriz;
            for (int i = 1; i < exp; i++)
            {
                result = MultiplicarMatrizes(result, matriz);
            }
            return result;
        }
    }
}
