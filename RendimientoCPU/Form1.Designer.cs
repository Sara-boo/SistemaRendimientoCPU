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
            this.BtnCargarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RBtnRegresionLineal = new System.Windows.Forms.RadioButton();
            this.RBtnSplineCubico = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalcularRaiz = new System.Windows.Forms.Button();
            this.TxtAproximacion = new System.Windows.Forms.TextBox();
            this.TxtTolerancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtgIteraciones = new System.Windows.Forms.DataGridView();
            this.PanelResultado = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosHistoricos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgIteraciones)).BeginInit();
            this.PanelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCargarDatos);
            this.groupBox1.Controls.Add(this.DtgDatosHistoricos);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Datos Históricos";
            // 
            // DtgDatosHistoricos
            // 
            this.DtgDatosHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosHistoricos.Location = new System.Drawing.Point(6, 28);
            this.DtgDatosHistoricos.Name = "DtgDatosHistoricos";
            this.DtgDatosHistoricos.Size = new System.Drawing.Size(315, 319);
            this.DtgDatosHistoricos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBtnSplineCubico);
            this.groupBox2.Controls.Add(this.RBtnRegresionLineal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Modelos Calculados";
            // 
            // BtnCargarDatos
            // 
            this.BtnCargarDatos.Location = new System.Drawing.Point(194, 362);
            this.BtnCargarDatos.Name = "BtnCargarDatos";
            this.BtnCargarDatos.Size = new System.Drawing.Size(127, 32);
            this.BtnCargarDatos.TabIndex = 2;
            this.BtnCargarDatos.Text = "Cargar Datos";
            this.BtnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // RBtnRegresionLineal
            // 
            this.RBtnRegresionLineal.AutoSize = true;
            this.RBtnRegresionLineal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnRegresionLineal.Location = new System.Drawing.Point(26, 40);
            this.RBtnRegresionLineal.Name = "RBtnRegresionLineal";
            this.RBtnRegresionLineal.Size = new System.Drawing.Size(152, 25);
            this.RBtnRegresionLineal.TabIndex = 2;
            this.RBtnRegresionLineal.TabStop = true;
            this.RBtnRegresionLineal.Text = "Regresión Lineal:";
            this.RBtnRegresionLineal.UseVisualStyleBackColor = true;
            // 
            // RBtnSplineCubico
            // 
            this.RBtnSplineCubico.AutoSize = true;
            this.RBtnSplineCubico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnSplineCubico.Location = new System.Drawing.Point(26, 125);
            this.RBtnSplineCubico.Name = "RBtnSplineCubico";
            this.RBtnSplineCubico.Size = new System.Drawing.Size(128, 25);
            this.RBtnSplineCubico.TabIndex = 3;
            this.RBtnSplineCubico.TabStop = true;
            this.RBtnSplineCubico.Text = "Spline Cúbico";
            this.RBtnSplineCubico.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtgIteraciones);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtTolerancia);
            this.groupBox3.Controls.Add(this.TxtAproximacion);
            this.groupBox3.Controls.Add(this.BtnCalcularRaiz);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(384, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 427);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Método Newton-Raphson";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aproximación Inicial (X0):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tolerancia";
            // 
            // BtnCalcularRaiz
            // 
            this.BtnCalcularRaiz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcularRaiz.Location = new System.Drawing.Point(390, 48);
            this.BtnCalcularRaiz.Name = "BtnCalcularRaiz";
            this.BtnCalcularRaiz.Size = new System.Drawing.Size(142, 43);
            this.BtnCalcularRaiz.TabIndex = 2;
            this.BtnCalcularRaiz.Text = "Calcular Raíz";
            this.BtnCalcularRaiz.UseVisualStyleBackColor = true;
            // 
            // TxtAproximacion
            // 
            this.TxtAproximacion.Location = new System.Drawing.Point(23, 62);
            this.TxtAproximacion.Name = "TxtAproximacion";
            this.TxtAproximacion.Size = new System.Drawing.Size(178, 29);
            this.TxtAproximacion.TabIndex = 3;
            // 
            // TxtTolerancia
            // 
            this.TxtTolerancia.Location = new System.Drawing.Point(241, 62);
            this.TxtTolerancia.Name = "TxtTolerancia";
            this.TxtTolerancia.Size = new System.Drawing.Size(127, 29);
            this.TxtTolerancia.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tabla de Iteraciones: ";
            // 
            // DtgIteraciones
            // 
            this.DtgIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgIteraciones.Location = new System.Drawing.Point(19, 148);
            this.DtgIteraciones.Name = "DtgIteraciones";
            this.DtgIteraciones.Size = new System.Drawing.Size(730, 255);
            this.DtgIteraciones.TabIndex = 6;
            // 
            // PanelResultado
            // 
            this.PanelResultado.Controls.Add(this.richTextBox1);
            this.PanelResultado.Controls.Add(this.label7);
            this.PanelResultado.Controls.Add(this.label6);
            this.PanelResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelResultado.Location = new System.Drawing.Point(386, 547);
            this.PanelResultado.Name = "PanelResultado";
            this.PanelResultado.Size = new System.Drawing.Size(777, 161);
            this.PanelResultado.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(203, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 62);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 758);
            this.Controls.Add(this.PanelResultado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.PanelResultado.ResumeLayout(false);
            this.PanelResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgDatosHistoricos;
        private System.Windows.Forms.Button BtnCargarDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnSplineCubico;
        private System.Windows.Forms.RadioButton RBtnRegresionLineal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTolerancia;
        private System.Windows.Forms.TextBox TxtAproximacion;
        private System.Windows.Forms.Button BtnCalcularRaiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DtgIteraciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelResultado;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

