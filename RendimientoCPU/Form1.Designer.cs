namespace RendimientoCPU
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtgDatosHistoricos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBtnSplineCubico = new System.Windows.Forms.RadioButton();
            this.RBtnRegresionLineal = new System.Windows.Forms.RadioButton();
            this.LblSpline = new System.Windows.Forms.Label();
            this.LblRegresion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtgIteraciones = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTolerancia = new System.Windows.Forms.TextBox();
            this.TxtAproximacion = new System.Windows.Forms.TextBox();
            this.BtnCalcularRaiz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RchTxtConclusion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosHistoricos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtgDatosHistoricos);
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(337, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Datos Históricos";
            // 
            // DtgDatosHistoricos
            // 
            this.DtgDatosHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosHistoricos.Location = new System.Drawing.Point(7, 33);
            this.DtgDatosHistoricos.Margin = new System.Windows.Forms.Padding(4);
            this.DtgDatosHistoricos.Name = "DtgDatosHistoricos";
            this.DtgDatosHistoricos.RowHeadersWidth = 51;
            this.DtgDatosHistoricos.Size = new System.Drawing.Size(322, 213);
            this.DtgDatosHistoricos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBtnSplineCubico);
            this.groupBox2.Controls.Add(this.RBtnRegresionLineal);
            this.groupBox2.Controls.Add(this.LblSpline);
            this.groupBox2.Controls.Add(this.LblRegresion);
            this.groupBox2.Location = new System.Drawing.Point(29, 323);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(337, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Modelos Calculados";
            // 
            // RBtnSplineCubico
            // 
            this.RBtnSplineCubico.AutoSize = true;
            this.RBtnSplineCubico.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.RBtnSplineCubico.Location = new System.Drawing.Point(32, 134);
            this.RBtnSplineCubico.Margin = new System.Windows.Forms.Padding(4);
            this.RBtnSplineCubico.Name = "RBtnSplineCubico";
            this.RBtnSplineCubico.Size = new System.Drawing.Size(171, 34);
            this.RBtnSplineCubico.TabIndex = 3;
            this.RBtnSplineCubico.TabStop = true;
            this.RBtnSplineCubico.Text = "Spline Cúbico";
            this.RBtnSplineCubico.UseVisualStyleBackColor = true;
            // 
            // RBtnRegresionLineal
            // 
            this.RBtnRegresionLineal.AutoSize = true;
            this.RBtnRegresionLineal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.RBtnRegresionLineal.Location = new System.Drawing.Point(32, 45);
            this.RBtnRegresionLineal.Margin = new System.Windows.Forms.Padding(4);
            this.RBtnRegresionLineal.Name = "RBtnRegresionLineal";
            this.RBtnRegresionLineal.Size = new System.Drawing.Size(203, 34);
            this.RBtnRegresionLineal.TabIndex = 2;
            this.RBtnRegresionLineal.TabStop = true;
            this.RBtnRegresionLineal.Text = "Regresión Lineal:";
            this.RBtnRegresionLineal.UseVisualStyleBackColor = true;
            // 
            // LblSpline
            // 
            this.LblSpline.AutoSize = true;
            this.LblSpline.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblSpline.Location = new System.Drawing.Point(60, 167);
            this.LblSpline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSpline.Name = "LblSpline";
            this.LblSpline.Size = new System.Drawing.Size(321, 28);
            this.LblSpline.TabIndex = 1;
            this.LblSpline.Text = "S2(x) = 60 + 13.5(x-5) - 2.25(x-5)² ...";
            // 
            // LblRegresion
            // 
            this.LblRegresion.AutoSize = true;
            this.LblRegresion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblRegresion.Location = new System.Drawing.Point(61, 84);
            this.LblRegresion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegresion.Name = "LblRegresion";
            this.LblRegresion.Size = new System.Drawing.Size(229, 28);
            this.LblRegresion.TabIndex = 0;
            this.LblRegresion.Text = "y(x) = 6.7334 + 10.4571x";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.DtgIteraciones);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtTolerancia);
            this.groupBox3.Controls.Add(this.TxtAproximacion);
            this.groupBox3.Controls.Add(this.BtnCalcularRaiz);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(393, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(740, 441);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Método Newton-Raphson";
            // 
            // DtgIteraciones
            // 
            this.DtgIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgIteraciones.Location = new System.Drawing.Point(25, 218);
            this.DtgIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.DtgIteraciones.Name = "DtgIteraciones";
            this.DtgIteraciones.RowHeadersWidth = 51;
            this.DtgIteraciones.Size = new System.Drawing.Size(702, 199);
            this.DtgIteraciones.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tabla de Iteraciones: ";
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Location = new System.Drawing.Point(290, 74);
            this.TxtTolerancia.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(154, 39);
            this.TxtTolerancia.TabIndex = 4;
            // 
            // TxtAproximacion
            // 
            this.TxtAproximacion.Location = new System.Drawing.Point(28, 74);
            this.TxtAproximacion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAproximacion.Name = "TxtAproximacion";
            this.TxtAproximacion.Size = new System.Drawing.Size(217, 39);
            this.TxtAproximacion.TabIndex = 3;
            // 
            // BtnCalcularRaiz
            // 
            this.BtnCalcularRaiz.BackColor = System.Drawing.Color.LightGray;
            this.BtnCalcularRaiz.FlatAppearance.BorderSize = 0;
            this.BtnCalcularRaiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.BtnCalcularRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcularRaiz.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCalcularRaiz.Location = new System.Drawing.Point(477, 57);
            this.BtnCalcularRaiz.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalcularRaiz.Name = "BtnCalcularRaiz";
            this.BtnCalcularRaiz.Size = new System.Drawing.Size(174, 51);
            this.BtnCalcularRaiz.TabIndex = 2;
            this.BtnCalcularRaiz.Text = "Calcular Raíz";
            this.BtnCalcularRaiz.UseVisualStyleBackColor = false;
            this.BtnCalcularRaiz.Click += new System.EventHandler(this.BtnCalcularRaiz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.Location = new System.Drawing.Point(285, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tolerancia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aproximación Inicial (X0):";
            // 
            // RchTxtConclusion
            // 
            this.RchTxtConclusion.Location = new System.Drawing.Point(393, 495);
            this.RchTxtConclusion.Margin = new System.Windows.Forms.Padding(4);
            this.RchTxtConclusion.Name = "RchTxtConclusion";
            this.RchTxtConclusion.Size = new System.Drawing.Size(740, 89);
            this.RchTxtConclusion.TabIndex = 2;
            this.RchTxtConclusion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor sugerido automáticamente. \r\nPuedes modificarlo si lo deseas\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 597);
            this.Controls.Add(this.RchTxtConclusion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Predicción de Colapso de CPU - Método Numéricos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosHistoricos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgIteraciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgDatosHistoricos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnSplineCubico;
        private System.Windows.Forms.RadioButton RBtnRegresionLineal;
        private System.Windows.Forms.Label LblSpline;
        private System.Windows.Forms.Label LblRegresion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTolerancia;
        private System.Windows.Forms.TextBox TxtAproximacion;
        private System.Windows.Forms.Button BtnCalcularRaiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DtgIteraciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RchTxtConclusion;
        private System.Windows.Forms.Label label1;
    }
}

