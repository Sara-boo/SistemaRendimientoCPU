using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RendimientoCPU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarTablas();
        }
        private void ConfigurarTablas()
        {
            DtgDatosHistoricos.Columns.Clear();
            DtgDatosHistoricos.Columns.Add("Mes", "Mes (x)");
            DtgDatosHistoricos.Columns.Add("CPU", "CPU % (y)");
            DtgDatosHistoricos.AllowUserToAddRows = false;
            DtgDatosHistoricos.Rows.Add(1, 20);
            DtgDatosHistoricos.Rows.Add(2, 28);
            DtgDatosHistoricos.Rows.Add(3, 35);
            DtgDatosHistoricos.Rows.Add(4, 45);
            DtgDatosHistoricos.Rows.Add(5, 60);
            DtgDatosHistoricos.Rows.Add(6, 72);

            DtgIteraciones.Columns.Clear();
            DtgIteraciones.Columns.Add("Iter", "Iter.");
            DtgIteraciones.Columns.Add("Xk", "X_k");
            DtgIteraciones.Columns.Add("fXk", "f(X_k)");
            DtgIteraciones.Columns.Add("fpXk", "f'(X_k)");
            DtgIteraciones.Columns.Add("Xk1", "X_k+1");
            DtgIteraciones.Columns.Add("Error", "Error");
            DtgIteraciones.AllowUserToAddRows = false;
            DtgIteraciones.ReadOnly = true; // El usuario no debe editar los resultados
        }
        private void BtnCalcularRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Limpiar resultados anteriores
                DtgIteraciones.Rows.Clear();
                RchTxtConclusion.Clear();
                List<double> xDatos = new List<double>();
                List<double> yDatos = new List<double>();

                foreach (DataGridViewRow row in DtgDatosHistoricos.Rows)
                {
                    xDatos.Add(Convert.ToDouble(row.Cells[0].Value));
                    yDatos.Add(Convert.ToDouble(row.Cells[1].Value));
                }
                double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
                int n = xDatos.Count;

                for (int i = 0; i < n; i++)
                {
                    sumX += xDatos[i];
                    sumY += yDatos[i];
                    sumXY += (xDatos[i] * yDatos[i]);
                    sumX2 += (Math.Pow(xDatos[i], 2));
                }

                double b = (n * sumXY - sumX * sumY) / (n * sumX2 - Math.Pow(sumX, 2));
                double a = (sumY - b * sumX) / n;
                LblRegresion.Text = $"y(x) = {Math.Round(a, 4)} + {Math.Round(b, 4)}x";
                double x1 = xDatos[3], x2 = xDatos[4], x3 = xDatos[5];
                double y1 = yDatos[3], y2 = yDatos[4], y3 = yDatos[5];

                double h1 = x2 - x1;
                double h2 = x3 - x2;

                double dy1 = y2 - y1;
                double dy2 = y3 - y2;

                double M1 = 6 * ((dy2 / h2) - (dy1 / h1)) / (2 * (h1 + h2));

                double a_spline = y2;
                double b_spline = (dy2 / h2) - h2 * (2 * M1) / 6;
                double c_spline = M1 / 2;
                double d_spline = (0 - M1) / (6 * h2);

                LblSpline.Text = $"S2(x) = {Math.Round(a_spline, 4)} + {Math.Round(b_spline, 4)}(x-5) {(c_spline < 0 ? "-" : "+")} {Math.Abs(Math.Round(c_spline, 4))}(x-5)² {(d_spline < 0 ? "-" : "+")} {Math.Abs(Math.Round(d_spline, 4))}(x-5)³";

                Func<double, double> funcionObjetivo = null;
                Func<double, double> funcionDerivada = null;

                if (RBtnRegresionLineal.Checked)
                {
                    funcionObjetivo = (x) => (b * x) + a - 100;
                    funcionDerivada = (x) => b;
                }
                else if (RBtnSplineCubico.Checked)
                {
                    funcionObjetivo = (x) => d_spline * Math.Pow(x - x2, 3) + c_spline * Math.Pow(x - x2, 2) + b_spline * (x - x2) + a_spline - 100;
                    funcionDerivada = (x) => 3 * d_spline * Math.Pow(x - x2, 2) + 2 * c_spline * (x - x2) + b_spline;
                }
                else
                {
                    MessageBox.Show("Seleccione un modelo matemático.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double xk = Convert.ToDouble(TxtAproximacion.Text);
                double tolerancia = Convert.ToDouble(TxtTolerancia.Text);
                double error = 100;
                int iteracion = 0;
                int maxIter = 50;

                while (error > tolerancia && iteracion < maxIter)
                {
                    double fxk = funcionObjetivo(xk);
                    double fpxk = funcionDerivada(xk);

                    if (fpxk == 0)
                    {
                        MessageBox.Show("La derivada se volvió cero. El método falla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    double xk_next = xk - (fxk / fpxk);
                    error = Math.Abs(xk_next - xk);

                    DtgIteraciones.Rows.Add(
                        iteracion,
                        Math.Round(xk, 6),
                        Math.Round(fxk, 6),
                        Math.Round(fpxk, 6),
                        Math.Round(xk_next, 6),
                        Math.Round(error, 6)
                    );

                    xk = xk_next;
                    iteracion++;
                }
                int mesEntero = (int)Math.Floor(xk);
                int diaAproximado = (int)Math.Round((xk - mesEntero) * 30);
                string modeloUsado = RBtnRegresionLineal.Checked ? "Regresión Lineal" : "Spline Cúbico";

                RchTxtConclusion.SelectionFont = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
                RchTxtConclusion.SelectionColor = System.Drawing.Color.FromArgb(0, 64, 128);
                RchTxtConclusion.AppendText($"Resultado Encontrado: x ≈ {Math.Round(xk, 4)}\n");

                RchTxtConclusion.SelectionFont = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Italic);
                RchTxtConclusion.SelectionColor = System.Drawing.Color.Black;
                RchTxtConclusion.AppendText("Conclusión: ");

                RchTxtConclusion.SelectionFont = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
                RchTxtConclusion.AppendText($"Según el modelo de {modeloUsado}, el servidor colapsará en el mes {mesEntero}, aproximadamente en el día {diaAproximado}.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en los cálculos. Verifique que los datos ingresados sean correctos.\n\n" + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
