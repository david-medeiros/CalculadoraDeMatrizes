namespace CalculadoraDeMatrizes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonMultiplicar = new System.Windows.Forms.Button();
            this.ButtonSubtrair = new System.Windows.Forms.Button();
            this.ButtonSomar = new System.Windows.Forms.Button();
            this.textBoxLeiDeFormação2 = new System.Windows.Forms.TextBox();
            this.textBoxLeiDeFormação1 = new System.Windows.Forms.TextBox();
            this.ColunasMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.ColunasMatriz1 = new System.Windows.Forms.NumericUpDown();
            this.LinhasMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.LinhasMatriz1 = new System.Windows.Forms.NumericUpDown();
            this.ButtonAplicar2 = new System.Windows.Forms.Button();
            this.ButtonAplicar1 = new System.Windows.Forms.Button();
            this.LabelLeiDeFormação2 = new System.Windows.Forms.Label();
            this.LabelMatriz2 = new System.Windows.Forms.Label();
            this.LabelLeiDeFormação1 = new System.Windows.Forms.Label();
            this.ButtonCriarMatriz2 = new System.Windows.Forms.Button();
            this.groupBoxMatrizResultante = new System.Windows.Forms.GroupBox();
            this.PanelMatrizResultante = new System.Windows.Forms.Panel();
            this.LabelMatriz1 = new System.Windows.Forms.Label();
            this.groupBoxMatriz2 = new System.Windows.Forms.GroupBox();
            this.PanelMatriz2 = new System.Windows.Forms.Panel();
            this.ButtonCriarMatriz1 = new System.Windows.Forms.Button();
            this.groupBoxMatriz1 = new System.Windows.Forms.GroupBox();
            this.PanelMatriz1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonDividir = new System.Windows.Forms.Button();
            this.ButtonEscalar = new System.Windows.Forms.Button();
            this.numericUpDownEscalar = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasMatriz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasMatriz1)).BeginInit();
            this.groupBoxMatrizResultante.SuspendLayout();
            this.groupBoxMatriz2.SuspendLayout();
            this.groupBoxMatriz1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscalar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDownEscalar);
            this.tabPage1.Controls.Add(this.ButtonEscalar);
            this.tabPage1.Controls.Add(this.ButtonDividir);
            this.tabPage1.Controls.Add(this.ButtonMultiplicar);
            this.tabPage1.Controls.Add(this.ButtonSubtrair);
            this.tabPage1.Controls.Add(this.ButtonSomar);
            this.tabPage1.Controls.Add(this.textBoxLeiDeFormação2);
            this.tabPage1.Controls.Add(this.textBoxLeiDeFormação1);
            this.tabPage1.Controls.Add(this.ColunasMatriz2);
            this.tabPage1.Controls.Add(this.ColunasMatriz1);
            this.tabPage1.Controls.Add(this.LinhasMatriz2);
            this.tabPage1.Controls.Add(this.LinhasMatriz1);
            this.tabPage1.Controls.Add(this.ButtonAplicar2);
            this.tabPage1.Controls.Add(this.ButtonAplicar1);
            this.tabPage1.Controls.Add(this.LabelLeiDeFormação2);
            this.tabPage1.Controls.Add(this.LabelMatriz2);
            this.tabPage1.Controls.Add(this.LabelLeiDeFormação1);
            this.tabPage1.Controls.Add(this.ButtonCriarMatriz2);
            this.tabPage1.Controls.Add(this.groupBoxMatrizResultante);
            this.tabPage1.Controls.Add(this.LabelMatriz1);
            this.tabPage1.Controls.Add(this.groupBoxMatriz2);
            this.tabPage1.Controls.Add(this.ButtonCriarMatriz1);
            this.tabPage1.Controls.Add(this.groupBoxMatriz1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matriz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonMultiplicar
            // 
            this.ButtonMultiplicar.Location = new System.Drawing.Point(619, 208);
            this.ButtonMultiplicar.Name = "ButtonMultiplicar";
            this.ButtonMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.ButtonMultiplicar.TabIndex = 13;
            this.ButtonMultiplicar.Text = "Multiplicar";
            this.ButtonMultiplicar.UseVisualStyleBackColor = true;
            this.ButtonMultiplicar.Click += new System.EventHandler(this.ButtonMultiplicar_Click);
            // 
            // ButtonSubtrair
            // 
            this.ButtonSubtrair.Location = new System.Drawing.Point(619, 161);
            this.ButtonSubtrair.Name = "ButtonSubtrair";
            this.ButtonSubtrair.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubtrair.TabIndex = 12;
            this.ButtonSubtrair.Text = "Subtrair";
            this.ButtonSubtrair.UseVisualStyleBackColor = true;
            this.ButtonSubtrair.Click += new System.EventHandler(this.ButtonSubtrair_Click);
            // 
            // ButtonSomar
            // 
            this.ButtonSomar.Location = new System.Drawing.Point(619, 113);
            this.ButtonSomar.Name = "ButtonSomar";
            this.ButtonSomar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSomar.TabIndex = 11;
            this.ButtonSomar.Text = "Somar";
            this.ButtonSomar.UseVisualStyleBackColor = true;
            this.ButtonSomar.Click += new System.EventHandler(this.ButtonSomar_Click);
            // 
            // textBoxLeiDeFormação2
            // 
            this.textBoxLeiDeFormação2.Location = new System.Drawing.Point(422, 55);
            this.textBoxLeiDeFormação2.Name = "textBoxLeiDeFormação2";
            this.textBoxLeiDeFormação2.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeiDeFormação2.TabIndex = 10;
            // 
            // textBoxLeiDeFormação1
            // 
            this.textBoxLeiDeFormação1.Location = new System.Drawing.Point(95, 55);
            this.textBoxLeiDeFormação1.Name = "textBoxLeiDeFormação1";
            this.textBoxLeiDeFormação1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeiDeFormação1.TabIndex = 10;
            // 
            // ColunasMatriz2
            // 
            this.ColunasMatriz2.Location = new System.Drawing.Point(427, 17);
            this.ColunasMatriz2.Name = "ColunasMatriz2";
            this.ColunasMatriz2.Size = new System.Drawing.Size(32, 20);
            this.ColunasMatriz2.TabIndex = 9;
            // 
            // ColunasMatriz1
            // 
            this.ColunasMatriz1.Location = new System.Drawing.Point(100, 17);
            this.ColunasMatriz1.Name = "ColunasMatriz1";
            this.ColunasMatriz1.Size = new System.Drawing.Size(32, 20);
            this.ColunasMatriz1.TabIndex = 9;
            // 
            // LinhasMatriz2
            // 
            this.LinhasMatriz2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LinhasMatriz2.Location = new System.Drawing.Point(381, 17);
            this.LinhasMatriz2.Name = "LinhasMatriz2";
            this.LinhasMatriz2.Size = new System.Drawing.Size(40, 20);
            this.LinhasMatriz2.TabIndex = 8;
            // 
            // LinhasMatriz1
            // 
            this.LinhasMatriz1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LinhasMatriz1.Location = new System.Drawing.Point(54, 17);
            this.LinhasMatriz1.Name = "LinhasMatriz1";
            this.LinhasMatriz1.Size = new System.Drawing.Size(40, 20);
            this.LinhasMatriz1.TabIndex = 8;
            // 
            // ButtonAplicar2
            // 
            this.ButtonAplicar2.Location = new System.Drawing.Point(528, 55);
            this.ButtonAplicar2.Name = "ButtonAplicar2";
            this.ButtonAplicar2.Size = new System.Drawing.Size(74, 23);
            this.ButtonAplicar2.TabIndex = 7;
            this.ButtonAplicar2.Text = "Aplicar";
            this.ButtonAplicar2.UseVisualStyleBackColor = true;
            // 
            // ButtonAplicar1
            // 
            this.ButtonAplicar1.Location = new System.Drawing.Point(201, 55);
            this.ButtonAplicar1.Name = "ButtonAplicar1";
            this.ButtonAplicar1.Size = new System.Drawing.Size(74, 23);
            this.ButtonAplicar1.TabIndex = 7;
            this.ButtonAplicar1.Text = "Aplicar";
            this.ButtonAplicar1.UseVisualStyleBackColor = true;
            // 
            // LabelLeiDeFormação2
            // 
            this.LabelLeiDeFormação2.AutoSize = true;
            this.LabelLeiDeFormação2.Location = new System.Drawing.Point(330, 55);
            this.LabelLeiDeFormação2.Name = "LabelLeiDeFormação2";
            this.LabelLeiDeFormação2.Size = new System.Drawing.Size(86, 13);
            this.LabelLeiDeFormação2.TabIndex = 5;
            this.LabelLeiDeFormação2.Text = "Lei de Formação";
            // 
            // LabelMatriz2
            // 
            this.LabelMatriz2.AutoSize = true;
            this.LabelMatriz2.Location = new System.Drawing.Point(331, 20);
            this.LabelMatriz2.Name = "LabelMatriz2";
            this.LabelMatriz2.Size = new System.Drawing.Size(44, 13);
            this.LabelMatriz2.TabIndex = 4;
            this.LabelMatriz2.Text = "Matriz 2";
            // 
            // LabelLeiDeFormação1
            // 
            this.LabelLeiDeFormação1.AutoSize = true;
            this.LabelLeiDeFormação1.Location = new System.Drawing.Point(3, 55);
            this.LabelLeiDeFormação1.Name = "LabelLeiDeFormação1";
            this.LabelLeiDeFormação1.Size = new System.Drawing.Size(86, 13);
            this.LabelLeiDeFormação1.TabIndex = 5;
            this.LabelLeiDeFormação1.Text = "Lei de Formação";
            // 
            // ButtonCriarMatriz2
            // 
            this.ButtonCriarMatriz2.Location = new System.Drawing.Point(465, 17);
            this.ButtonCriarMatriz2.Name = "ButtonCriarMatriz2";
            this.ButtonCriarMatriz2.Size = new System.Drawing.Size(75, 23);
            this.ButtonCriarMatriz2.TabIndex = 3;
            this.ButtonCriarMatriz2.Text = "Criar Matriz";
            this.ButtonCriarMatriz2.UseVisualStyleBackColor = true;
            this.ButtonCriarMatriz2.Click += new System.EventHandler(this.ButtonCriarMatriz2_Click);
            // 
            // groupBoxMatrizResultante
            // 
            this.groupBoxMatrizResultante.Controls.Add(this.PanelMatrizResultante);
            this.groupBoxMatrizResultante.Location = new System.Drawing.Point(694, 84);
            this.groupBoxMatrizResultante.Name = "groupBoxMatrizResultante";
            this.groupBoxMatrizResultante.Size = new System.Drawing.Size(301, 252);
            this.groupBoxMatrizResultante.TabIndex = 0;
            this.groupBoxMatrizResultante.TabStop = false;
            this.groupBoxMatrizResultante.Text = "Matriz Resultante";
            // 
            // PanelMatrizResultante
            // 
            this.PanelMatrizResultante.AutoScroll = true;
            this.PanelMatrizResultante.Location = new System.Drawing.Point(6, 16);
            this.PanelMatrizResultante.Name = "PanelMatrizResultante";
            this.PanelMatrizResultante.Size = new System.Drawing.Size(289, 236);
            this.PanelMatrizResultante.TabIndex = 8;
            // 
            // LabelMatriz1
            // 
            this.LabelMatriz1.AutoSize = true;
            this.LabelMatriz1.Location = new System.Drawing.Point(4, 20);
            this.LabelMatriz1.Name = "LabelMatriz1";
            this.LabelMatriz1.Size = new System.Drawing.Size(44, 13);
            this.LabelMatriz1.TabIndex = 4;
            this.LabelMatriz1.Text = "Matriz 1";
            // 
            // groupBoxMatriz2
            // 
            this.groupBoxMatriz2.Controls.Add(this.PanelMatriz2);
            this.groupBoxMatriz2.Location = new System.Drawing.Point(317, 84);
            this.groupBoxMatriz2.Name = "groupBoxMatriz2";
            this.groupBoxMatriz2.Size = new System.Drawing.Size(301, 252);
            this.groupBoxMatriz2.TabIndex = 0;
            this.groupBoxMatriz2.TabStop = false;
            this.groupBoxMatriz2.Text = "Matriz 2";
            // 
            // PanelMatriz2
            // 
            this.PanelMatriz2.AutoScroll = true;
            this.PanelMatriz2.Location = new System.Drawing.Point(6, 16);
            this.PanelMatriz2.Name = "PanelMatriz2";
            this.PanelMatriz2.Size = new System.Drawing.Size(289, 236);
            this.PanelMatriz2.TabIndex = 8;
            // 
            // ButtonCriarMatriz1
            // 
            this.ButtonCriarMatriz1.Location = new System.Drawing.Point(138, 17);
            this.ButtonCriarMatriz1.Name = "ButtonCriarMatriz1";
            this.ButtonCriarMatriz1.Size = new System.Drawing.Size(75, 23);
            this.ButtonCriarMatriz1.TabIndex = 3;
            this.ButtonCriarMatriz1.Text = "Criar Matriz";
            this.ButtonCriarMatriz1.UseVisualStyleBackColor = true;
            this.ButtonCriarMatriz1.Click += new System.EventHandler(this.ButtonCriarMatriz1_Click);
            // 
            // groupBoxMatriz1
            // 
            this.groupBoxMatriz1.Controls.Add(this.PanelMatriz1);
            this.groupBoxMatriz1.Location = new System.Drawing.Point(7, 84);
            this.groupBoxMatriz1.Name = "groupBoxMatriz1";
            this.groupBoxMatriz1.Size = new System.Drawing.Size(304, 245);
            this.groupBoxMatriz1.TabIndex = 0;
            this.groupBoxMatriz1.TabStop = false;
            this.groupBoxMatriz1.Text = "Matriz 1";
            // 
            // PanelMatriz1
            // 
            this.PanelMatriz1.AutoScroll = true;
            this.PanelMatriz1.Location = new System.Drawing.Point(6, 16);
            this.PanelMatriz1.Name = "PanelMatriz1";
            this.PanelMatriz1.Size = new System.Drawing.Size(292, 229);
            this.PanelMatriz1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonDividir
            // 
            this.ButtonDividir.Location = new System.Drawing.Point(619, 248);
            this.ButtonDividir.Name = "ButtonDividir";
            this.ButtonDividir.Size = new System.Drawing.Size(75, 23);
            this.ButtonDividir.TabIndex = 14;
            this.ButtonDividir.Text = "Dividir";
            this.ButtonDividir.UseVisualStyleBackColor = true;
            this.ButtonDividir.Click += new System.EventHandler(this.ButtonDividir_Click);
            // 
            // ButtonEscalar
            // 
            this.ButtonEscalar.Location = new System.Drawing.Point(13, 345);
            this.ButtonEscalar.Name = "ButtonEscalar";
            this.ButtonEscalar.Size = new System.Drawing.Size(75, 23);
            this.ButtonEscalar.TabIndex = 15;
            this.ButtonEscalar.Text = "Escalar";
            this.ButtonEscalar.UseVisualStyleBackColor = true;
            this.ButtonEscalar.Click += new System.EventHandler(this.ButtonEscalar_Click);
            // 
            // numericUpDownEscalar
            // 
            this.numericUpDownEscalar.Location = new System.Drawing.Point(100, 348);
            this.numericUpDownEscalar.Name = "numericUpDownEscalar";
            this.numericUpDownEscalar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEscalar.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 464);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de matrizes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColunasMatriz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasMatriz1)).EndInit();
            this.groupBoxMatrizResultante.ResumeLayout(false);
            this.groupBoxMatriz2.ResumeLayout(false);
            this.groupBoxMatriz1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEscalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxMatriz1;
        private System.Windows.Forms.Button ButtonCriarMatriz1;
        private System.Windows.Forms.Label LabelMatriz1;
        private System.Windows.Forms.Label LabelLeiDeFormação1;
        private System.Windows.Forms.Button ButtonAplicar1;
        private System.Windows.Forms.Panel PanelMatriz1;
        private System.Windows.Forms.NumericUpDown ColunasMatriz1;
        private System.Windows.Forms.NumericUpDown LinhasMatriz1;
        private System.Windows.Forms.TextBox textBoxLeiDeFormação1;
        private System.Windows.Forms.TextBox textBoxLeiDeFormação2;
        private System.Windows.Forms.NumericUpDown ColunasMatriz2;
        private System.Windows.Forms.NumericUpDown LinhasMatriz2;
        private System.Windows.Forms.Button ButtonAplicar2;
        private System.Windows.Forms.Label LabelLeiDeFormação2;
        private System.Windows.Forms.Label LabelMatriz2;
        private System.Windows.Forms.Button ButtonCriarMatriz2;
        private System.Windows.Forms.GroupBox groupBoxMatriz2;
        private System.Windows.Forms.Panel PanelMatriz2;
        private System.Windows.Forms.GroupBox groupBoxMatrizResultante;
        private System.Windows.Forms.Panel PanelMatrizResultante;
        private System.Windows.Forms.Button ButtonSomar;
        private System.Windows.Forms.Button ButtonSubtrair;
        private System.Windows.Forms.Button ButtonMultiplicar;
        private System.Windows.Forms.Button ButtonDividir;
        private System.Windows.Forms.Button ButtonEscalar;
        private System.Windows.Forms.NumericUpDown numericUpDownEscalar;
    }
}

