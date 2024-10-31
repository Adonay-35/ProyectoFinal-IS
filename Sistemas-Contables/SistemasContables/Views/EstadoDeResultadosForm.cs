using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SistemasContables.Views
{

    public partial class EstadoDeResultadosForm : Form
    {
        private EstadoDeResultadosController estadoDeResultadosController;
        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", formatoDecimales)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;

        private int idLibroDiario;

        public EstadoDeResultadosForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            idLibroDiario = libroDiario.IdLibroDiario;
            lblPeriodo.Text = libroDiario.Periodo;
            estadoDeResultadosController = new EstadoDeResultadosController();

            calcularEstadoDeResultados();
        }

        private void calcularEstadoDeResultados()
        {
            double ingresos = estadoDeResultadosController.getTotalIngresos(idLibroDiario);
            double costos = estadoDeResultadosController.getTotalCostos(idLibroDiario);
            double gastos = estadoDeResultadosController.getTotalGastos(idLibroDiario);
            double impuestosPorPagar = 0;
            double reservaLegal = 0;
            double utilidadNeta = 0;
            double gastosDeOperacion = 0;
            double utilidadDeOperacion = 0;
            double utilidadAntesdeimpuestos = 0;

            double ingresosMenosCostos = ingresos - costos;

            gastosDeOperacion = gastos;
            utilidadDeOperacion = ingresosMenosCostos - gastos;
            reservaLegal = (ingresosMenosCostos - gastos) * 0.07;
            utilidadAntesdeimpuestos = (utilidadDeOperacion) - ((utilidadDeOperacion) * 0.07);

            if (ingresos < 150000)
            {
                impuestosPorPagar = utilidadAntesdeimpuestos * 0.25;
            }
            else
            {
                impuestosPorPagar = utilidadAntesdeimpuestos * 0.3;
            }

            utilidadNeta = utilidadAntesdeimpuestos - impuestosPorPagar;

            llenarTablaEstadoDeResultados(ingresos, costos, ingresosMenosCostos, gastosDeOperacion, utilidadDeOperacion, reservaLegal, utilidadAntesdeimpuestos, impuestosPorPagar, utilidadNeta);
        }

        private void llenarTablaEstadoDeResultados(double ingresos, double costos, double ingresosMenosCostos, double gastosDeOperacion, double utilidadDeOperacion, double reservaLegal, double utilidadAntesDeImpuestos, double impuestosPorPagar, double utilidadNeta)
        {
            if (tableEstadoDeResultados.Rows.Count > 0)
            {
                tableEstadoDeResultados.Rows.Clear();
            }
            /* Agregando valores a la tabla*/
            tableEstadoDeResultados.Rows.Add("", "Ingresos", "$" + redondear(Math.Round(ingresos, 2)));
            tableEstadoDeResultados.Rows.Add("( - )", "Costos", "$ " + redondear(Math.Round(costos, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Bruta", "$ " + redondear(Math.Round(ingresosMenosCostos, 2)));
            tableEstadoDeResultados.Rows.Add("( - )", "Gastos de Operacion", "$ " + redondear(Math.Round(gastosDeOperacion, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad de Operación", "$ " + redondear(Math.Round(utilidadDeOperacion, 2)));
            tableEstadoDeResultados.Rows.Add("( - )", "Reserva Legal", "$ " + redondear(Math.Round(reservaLegal, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Antes de Impuestos", "$ " + Math.Round(utilidadAntesDeImpuestos, 2));
            tableEstadoDeResultados.Rows.Add("( - )", "Impuestos Por Pagar", "$ " + redondear(Math.Round(impuestosPorPagar, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Neta", "$ " + redondear(Math.Round(utilidadNeta, 2)));

        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

    }
}