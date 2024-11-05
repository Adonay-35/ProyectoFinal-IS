using SistemasContables.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class AgregarLibroDiarioForm : Form
    {
        private LibroDiariosController libroDiarioController;
        private string periodo;
        private string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre","Octubre", "Noviembre", "Diciembre"};

        public AgregarLibroDiarioForm(int idLibroDiario)
        {
            InitializeComponent();
            libroDiarioController = new LibroDiariosController();

            idLibroDiario++;
            lblNumLibro.Text += idLibroDiario;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

            llenarPeriodo();

            
            if(!string.IsNullOrEmpty(periodo))
            {
                bool resultado = libroDiarioController.insert(periodo);

                if (resultado)
                {
                    MessageBox.Show("Se ingreso el libro diario con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se logro ingresar el libro diario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            } else
            {
                MessageBox.Show("La fecha desde tiene que ser mayor a la fecha hasta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void llenarPeriodo()
        {

            int dayDesde = dpDesde.Value.Day;
            int monthDesde = dpDesde.Value.Month;
            int yearDesde = dpDesde.Value.Year;

            int dayHasta = dpHasta.Value.Day;
            int monthHasta = dpHasta.Value.Month;
            int yearHasta = dpHasta.Value.Year;

            if(yearDesde < yearHasta)
            {
                periodo = $"Del {dayDesde} de {meses[monthDesde - 1]} del {yearDesde} Al {dayHasta} de  {meses[monthHasta - 1]} del {yearHasta}";
            }
            else if(monthDesde < monthHasta && yearDesde == yearHasta)
            {
                periodo = $"Del {dayDesde} de {meses[monthDesde - 1]} del {yearDesde} Al {dayHasta} de  {meses[monthHasta - 1]} del {yearHasta}";
            }
            else if(dayDesde < dayHasta && monthDesde == monthHasta && yearDesde == yearHasta)
            {
                periodo = $"Del {dayDesde} de {meses[monthDesde - 1]} del {yearDesde} Al {dayHasta} de  {meses[monthHasta - 1]} del {yearHasta}";
            }
            else
            {
                periodo = null;
            }


        }

    }
}
