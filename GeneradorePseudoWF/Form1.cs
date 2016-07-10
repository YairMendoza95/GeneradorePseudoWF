using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorePseudoWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int semilla, modulo, incremento, multiplicador, i;
            double numAlea = 0, resultado = 0;
            List<double> numAleaatorios = new List<double>();
            List<double> semillas = new List<double>();
            semilla = Convert.ToInt32(txtSemilla.Text);
            modulo = Convert.ToInt32(txtModulo.Text);
            incremento = Convert.ToInt32(txtIncremento.Text);
            multiplicador = Convert.ToInt32(txtMultiplicador.Text);
            for (i = 0; i < modulo; i++)
            {
                semillas.Add(semilla);
                numAleaatorios.Add(numAlea);
                resultado = ((multiplicador * semilla) + incremento) % modulo;
                numAlea = resultado / modulo;
                dgvTabla.Rows.Add(i, semilla, resultado, numAlea);
                semilla = Convert.ToInt32(resultado);
                if (semillas.Contains(semilla))
                    break;
            }
        }

        private void btnGenerarC_Click(object sender, EventArgs e)
        {
            string semS = "", quadS = "", newSem = "", numA = "";
            int longSem = 0, sem, longQuad = 0;
            double quad;
            List<int> Semillas = new List<int>();
            List<string> NumAlea = new List<string>();
            sem = Convert.ToInt32(txtSemillaC.Text);
            semS = sem.ToString();
            longSem = semS.Length;
            int i = 0;
            do
            {
                Semillas.Add(sem);
                semS = sem.ToString();
                longSem = semS.Length;
                sem = Convert.ToInt32(semS);
                quad = Math.Pow(sem, 2);
                quadS = quad.ToString();
                longQuad = quadS.Length;
                if (longQuad == (longSem * 2))
                {
                    newSem = quadS.Substring((longSem / 2), longSem);
                    numA = "0." + newSem;
                }
                else
                {
                    while (longQuad < (longSem * 2))
                    {
                        quadS = "0" + quadS;
                        longQuad = quadS.Length;
                    }
                    newSem = quadS.Substring((longSem / 2), longSem);
                    numA = "0." + newSem;

                }
                dgvCuadrados.Rows.Add(i, sem, newSem, numA);
                sem = Convert.ToInt32(newSem);
                if (Semillas.Contains(sem))
                    break;
                i++;
            } while (!Semillas.Contains(sem) || sem != 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            dgvCuadrados.Rows.Clear();
            dataGridView1.Rows.Clear();
            txtSemilla1.Clear();
            txtSemilla2.Clear();
            txtSemillaC.Clear();
            txtSemilla.Clear();
            txtModulo.Clear();
            txtMultiplicador.Clear();
            txtIncremento.Clear();
        }

        private void btnGenerarP_Click(object sender, EventArgs e)
        {
            List<int> PrimerasSemillas = new List<int>();
            List<int> SegundasSemillas = new List<int>();
            List<string> NumAleatorios = new List<string>();
            int sem1 = 0, sem2 = 0, nuevaSem = 0, longRes = 0, lon1 = 0, lon2 = 0;
            double resultado = 0;
            string res = "", num1 = "", num2 = "", numAlea = "", nuevaSemS = "";
            sem1 = Convert.ToInt32(txtSemilla1.Text);
            sem2 = Convert.ToInt32(txtSemilla2.Text);
            num1 = sem1.ToString();
            num2 = sem2.ToString();
            lon1 = num1.Length;
            lon2 = num2.Length;
            int i = 0;
            do
            {
                PrimerasSemillas.Add(sem1);
                SegundasSemillas.Add(sem2);
                resultado = sem1 * sem2;
                res = resultado.ToString();
                longRes = res.Length;
                numAlea = "0." + res;
                int longitudes = lon1 + lon2;
                if (longitudes == longRes)
                {
                    nuevaSemS = res.Substring(lon1 / 2, lon1);
                }
                else
                {
                    do
                    {
                        res = "0" + res;
                        longRes = res.Length;
                    } while (longitudes > longRes);
                    nuevaSemS = res.Substring(lon1 / 2, lon1);
                }
                NumAleatorios.Add(numAlea);
                nuevaSem = Convert.ToInt32(nuevaSemS);
                dataGridView1.Rows.Add(i, sem1, sem2, resultado, nuevaSem, numAlea);
                if (PrimerasSemillas.Contains(nuevaSem))
                    break;
                sem1 = sem2;
                sem2 = nuevaSem;
                i++;
            } while (!PrimerasSemillas.Contains(nuevaSem) || sem1 != 0 || sem2 != 0);
        }
    }
}
