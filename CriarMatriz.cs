using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Class1
{
	public Class1()
	{
	}

    public void CriarMatriz()
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
}
