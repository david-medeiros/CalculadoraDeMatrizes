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
            PanelMatriz1.Controls.Clear();
            LinhasM1 = (int)LinhasMatriz1.Value;
            ColunasM1 = (int)ColunasMatriz1.Value;
            Matriz.CriarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
        }
        
        private void ButtonCriarMatriz2_Click(object sender, EventArgs e)
        {
            PanelMatriz2.Controls.Clear();
            LinhasM2 = (int) LinhasMatriz2.Value;
            ColunasM2 = (int) ColunasMatriz2.Value;
            Matriz.CriarMatriz(PanelMatriz2, LinhasM2, ColunasM2);
        }

        private void ButtonSomar_Click(object sender, EventArgs e)
        {
            PanelMatrizResultante.Controls.Clear();
            float[,] matriz1 = new float[LinhasM1, ColunasM1];
            float[,] matriz2 = new float[LinhasM2, ColunasM2];
            float[,] resultado = new float[LinhasM2, ColunasM2];
            matriz1 = Matriz.GuardarMatriz(PanelMatriz1, LinhasM1, ColunasM1);
            matriz2 = Matriz.GuardarMatriz(PanelMatriz2, LinhasM2, ColunasM2);

        }
    }
}
