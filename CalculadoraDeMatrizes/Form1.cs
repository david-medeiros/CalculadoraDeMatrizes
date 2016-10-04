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
        static int LinhasM1, ColunasM1, LinhasM2, ColunasM2;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCriarMatriz1_Click(object sender, EventArgs e)
        {
            LinhasM1 = (int)LinhasMatriz1.Value;
            ColunasM1 = (int)ColunasMatriz1.Value;
            Matriz.CriarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
        }
        
        private void ButtonCriarMatriz2_Click(object sender, EventArgs e)
        {
            LinhasM2 = (int) LinhasMatriz2.Value;
            ColunasM2 = (int) ColunasMatriz2.Value;
            Matriz.CriarMatriz(PanelMatriz2, LinhasM2, ColunasM2);
        }

        private void ButtonSomar_Click(object sender, EventArgs e)
        {
            
                float[,] matriz1 = new float[LinhasM1, ColunasM1];
                float[,] matriz2 = new float[LinhasM2, ColunasM2];
                float[,] Resultado = new float[LinhasM2, ColunasM2];
                matriz1 = Matriz.GuardarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
                matriz2 = Matriz.GuardarMatriz(PanelMatriz2, LinhasM2, ColunasM2);
                Resultado = Matriz.SomarMatrizes(matriz1, matriz2);
                if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
                {
                    try
                    {
                        Resultado = Matriz.SomarMatrizes(matriz1, matriz2);
                        Matriz.DesenhaMatrixText(PanelMatrizResultante, Resultado);
                    }
                    catch
                    {
                        MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void ButtonSubtrair_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LinhasM1, ColunasM1];
            float[,] matriz2 = new float[LinhasM2, ColunasM2];
            float[,] Resultado = new float[LinhasM2, ColunasM2];
            matriz1 = Matriz.GuardarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
            matriz2 = Matriz.GuardarMatriz(PanelMatriz2, LinhasM2, ColunasM2);
            Resultado = Matriz.SubtrairMatrizes(matriz1, matriz2);
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                try
                {
                    Resultado = Matriz.SubtrairMatrizes(matriz1, matriz2);
                    Matriz.DesenhaMatrixText(PanelMatrizResultante, Resultado);
                }
                catch
                {
                    MessageBox.Show("O número de linhas e colunas das matrizes são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("O número de linhas e colunas das matrizes são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonMultiplicar_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LinhasM1, ColunasM1];
            float[,] matriz2 = new float[LinhasM2, ColunasM2];
            float[,] Resultado = new float[LinhasM2, ColunasM2];
            matriz1 = Matriz.GuardarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
            matriz2 = Matriz.GuardarMatriz(PanelMatriz2, LinhasM2, ColunasM2);
            Resultado = Matriz.MultiplicarMatrizes(matriz1, matriz2);
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                try
                {
                    Resultado = Matriz.MultiplicarMatrizes(matriz1, matriz2);
                    Matriz.DesenhaMatrixText(PanelMatrizResultante, Resultado);
                }
                catch
                {
                    MessageBox.Show("O número de colunas da primeira matriz e o número de linhas da segunda matriz são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("O número de colunas da primeira matriz e o número de linhas da segunda matriz são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDividir_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LinhasM1, ColunasM1];
            float[,] matriz2 = new float[LinhasM2, ColunasM2];
            float[,] Resultado = new float[LinhasM2, ColunasM2];
            matriz1 = Matriz.GuardarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
            matriz2 = Matriz.GuardarMatriz(PanelMatriz2, LinhasM2, ColunasM2);
            Resultado = Matriz.DividirMatrizes(matriz1, matriz2);
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                try
                {
                    Resultado = Matriz.DividirMatrizes(matriz1, matriz2);
                    Matriz.DesenhaMatrixText(PanelMatrizResultante, Resultado);
                }
                catch
                {
                    MessageBox.Show("O número de colunas da primeira matriz e o número de linhas da segunda matriz são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("O número de colunas da primeira matriz e o número de linhas da segunda matriz são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonEscalar_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LinhasM1, ColunasM1];
            float[,] resultado = new float[LinhasM1, ColunasM1];
            matriz1 = Matriz.GuardarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
            resultado = Matriz.MultiplicarMatrizesEscalar(matriz1, (float)numericUpDown.Value);
            Matriz.DesenhaMatrixText(PanelMatriz1, resultado);
        }

        private void ButtonElevar_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = Matriz.GuardarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
            try
            {
                float[,] resultado = Matriz.ElevarMatriz(matriz1, (int)numericUpDown.Value);
                Matriz.DesenhaMatrixText(PanelMatriz1, resultado);
            }
            catch (QuadradaException ex)
            {
                MessageBox.Show("A matriz precisa ser quadrada para ser elevada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
