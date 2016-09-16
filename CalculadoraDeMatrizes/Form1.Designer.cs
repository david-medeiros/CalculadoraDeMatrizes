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
            this.ButtonCriarMatriz1 = new System.Windows.Forms.Button();
            this.ColunasMatriz1 = new System.Windows.Forms.TextBox();
            this.LinhasMatriz1 = new System.Windows.Forms.TextBox();
            this.groupBoxMatriz1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabelMatriz1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LabelMatriz1);
            this.tabPage1.Controls.Add(this.ButtonCriarMatriz1);
            this.tabPage1.Controls.Add(this.ColunasMatriz1);
            this.tabPage1.Controls.Add(this.LinhasMatriz1);
            this.tabPage1.Controls.Add(this.groupBoxMatriz1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonCriarMatriz1
            // 
            this.ButtonCriarMatriz1.Location = new System.Drawing.Point(93, 56);
            this.ButtonCriarMatriz1.Name = "ButtonCriarMatriz1";
            this.ButtonCriarMatriz1.Size = new System.Drawing.Size(75, 23);
            this.ButtonCriarMatriz1.TabIndex = 3;
            this.ButtonCriarMatriz1.Text = "Criar Matriz";
            this.ButtonCriarMatriz1.UseVisualStyleBackColor = true;
            this.ButtonCriarMatriz1.Click += new System.EventHandler(this.ButtonCriarMatriz1_Click);
            // 
            // ColunasMatriz1
            // 
            this.ColunasMatriz1.Location = new System.Drawing.Point(163, 17);
            this.ColunasMatriz1.Name = "ColunasMatriz1";
            this.ColunasMatriz1.Size = new System.Drawing.Size(100, 20);
            this.ColunasMatriz1.TabIndex = 1;
            // 
            // LinhasMatriz1
            // 
            this.LinhasMatriz1.Location = new System.Drawing.Point(57, 17);
            this.LinhasMatriz1.Name = "LinhasMatriz1";
            this.LinhasMatriz1.Size = new System.Drawing.Size(100, 20);
            this.LinhasMatriz1.TabIndex = 1;
            // 
            // groupBoxMatriz1
            // 
            this.groupBoxMatriz1.Location = new System.Drawing.Point(7, 116);
            this.groupBoxMatriz1.Name = "groupBoxMatriz1";
            this.groupBoxMatriz1.Size = new System.Drawing.Size(370, 270);
            this.groupBoxMatriz1.TabIndex = 0;
            this.groupBoxMatriz1.TabStop = false;
            this.groupBoxMatriz1.Text = "Matriz 1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 464);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de matrizes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxMatriz1;
        private System.Windows.Forms.TextBox ColunasMatriz1;
        private System.Windows.Forms.TextBox LinhasMatriz1;
        private System.Windows.Forms.Button ButtonCriarMatriz1;
        private System.Windows.Forms.Label LabelMatriz1;
    }
}

