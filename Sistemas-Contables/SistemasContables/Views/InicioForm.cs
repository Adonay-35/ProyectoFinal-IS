using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class InicioForm : Form
    {
        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", formatoDecimales)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;
        private LibroDiariosController libroDiarioController;
        List<LibroDiario> listaLibroDiario;

        public InicioForm(LibroDiariosController libroDiarioController, List<LibroDiario> listaLibroDiario, List<int> listaYears)
        {
            InitializeComponent();

            this.libroDiarioController = libroDiarioController;

            this.listaLibroDiario = listaLibroDiario;

            llenarCbFilterYear(listaYears);
            totalLibrosDiarios(listaLibroDiario);
        }

        // el metodo filtra los datos de las graficas cada vez que se cambia de año
        private void cbFilterYear_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbFilterYear.SelectedItem.ToString() != "Todos")
            {
                int year = Convert.ToInt32(cbFilterYear.SelectedItem);

                clearGraficos();
                totalYear(listaLibroDiario, year);
            } else
            {
                clearGraficos();
                totalLibrosDiarios(listaLibroDiario);
            }

        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

        private void totalLibrosDiarios(List<LibroDiario> listaLibroDiario)
        {
            if (listaLibroDiario.Count > 0)
            {

                double totalActivos = 0;
                double totalCapital = 0;
                double totalPasivos = 0;
                double totalIngresos = 0;
                double totalCostos = 0;
                double totalGastos = 0;
                double activos = 0;
                double capital = 0;
                double pasivos = 0;
                double ingresos = 0;
                double costos = 0;
                double gastos = 0;
                int year = getYear(listaLibroDiario[0]);
                int yearCurrent;

                for (int i = 0; i < listaLibroDiario.Count; i++)
                {
                    LibroDiario libroDiario = listaLibroDiario[i];

                    yearCurrent = getYear(libroDiario);

                    if (yearCurrent != year)
                    {
                        llenarGraficos(year.ToString(), activos, capital, pasivos, ingresos, costos, gastos);

                        activos = 0;
                        capital = 0;
                        pasivos = 0;
                        ingresos = 0;
                        costos = 0;
                        gastos = 0;

                        year = getYear(libroDiario);

                    }
                    else if ((i + 1) > listaLibroDiario.Count - 1)
                    {
                        llenarGraficos(year.ToString(), activos, capital, pasivos, ingresos, costos, gastos);
                    }

                    activos += libroDiarioController.total("activos", libroDiario.IdLibroDiario);
                    capital += libroDiarioController.total("capital", libroDiario.IdLibroDiario);
                    pasivos += libroDiarioController.total("pasivos", libroDiario.IdLibroDiario);
                    ingresos += libroDiarioController.total("ingresos", libroDiario.IdLibroDiario);
                    costos += libroDiarioController.total("costos", libroDiario.IdLibroDiario);
                    gastos += libroDiarioController.total("gastos", libroDiario.IdLibroDiario);

                    totalActivos += activos;
                    totalCapital += capital;
                    totalPasivos += pasivos;
                    totalIngresos += ingresos;
                    totalCostos += costos;
                    totalGastos += gastos;
                }


                lblActivos.Text = redondear(totalActivos);
                lblCapital.Text = redondear(totalCapital);
                lblPasivos.Text = redondear(totalPasivos);
                lblIngresos.Text = redondear(totalIngresos);
                lblCostos.Text = redondear(totalCostos);
                lblGastos.Text = redondear(totalGastos);

            }
        }

        private void totalYear(List<LibroDiario> listaLibroDiario, int year)
        {
            if (listaLibroDiario.Count > 0)
            {
                double totalActivos = 0;
                double totalCapital = 0;
                double totalPasivos = 0;
                double totalIngresos = 0;
                double totalCostos = 0;
                double totalGastos = 0;
                double activos = 0;
                double capital = 0;
                double pasivos = 0;
                double ingresos = 0;
                double costos = 0;
                double gastos = 0;

                for (int i = 0; i < listaLibroDiario.Count; i++)
                {
                    int yearCurrent = getYear(listaLibroDiario[i]);

                    if (yearCurrent == year)
                    {
                        string month = getMonth(listaLibroDiario[i]);

                        LibroDiario libroDiario = listaLibroDiario[i];

                        activos = libroDiarioController.total("activos", libroDiario.IdLibroDiario);
                        capital = libroDiarioController.total("capital", libroDiario.IdLibroDiario);
                        pasivos = libroDiarioController.total("pasivos", libroDiario.IdLibroDiario);
                        ingresos = libroDiarioController.total("ingresos", libroDiario.IdLibroDiario);
                        costos = libroDiarioController.total("costos", libroDiario.IdLibroDiario);
                        gastos = libroDiarioController.total("gastos", libroDiario.IdLibroDiario);

                        totalActivos += activos;
                        totalCapital += capital;
                        totalPasivos += pasivos;
                        totalIngresos += ingresos;
                        totalCostos += costos;
                        totalGastos += gastos;

                        llenarGraficos(month, activos, capital, pasivos, ingresos, costos, gastos);
                    }
                }

                lblActivos.Text = redondear(totalActivos);
                lblCapital.Text = redondear(totalCapital);
                lblPasivos.Text = redondear(totalPasivos);
                lblIngresos.Text = redondear(totalIngresos);
                lblCostos.Text = redondear(totalCostos);
                lblGastos.Text = redondear(totalGastos);

            }
        }

        // el metodo llena el combobox para filtrar la informacion por años
        private void llenarCbFilterYear(List<int> listaYears)
        {
            foreach(int year in listaYears)
            {
                cbFilterYear.Items.Add(year);
            }
        }

        // el metodo llena los graficos
        private void llenarGraficos(string yearOrMonth, double activos, double capital, double pasivos, double ingresos, double costos, double gastos)
        {
            chart.Series["Activos"].Points.AddXY(yearOrMonth, activos);
            chart.Series["Capital"].Points.AddXY(yearOrMonth, capital);
            chart.Series["Pasivos"].Points.AddXY(yearOrMonth, pasivos);
            chart.Series["Ingresos"].Points.AddXY(yearOrMonth, ingresos);
            chart.Series["Costos"].Points.AddXY(yearOrMonth, costos);
            chart.Series["Gastos"].Points.AddXY(yearOrMonth, gastos);

        }

        // el vacia las graficas
        private void clearGraficos()
        {
            chart.Series["Activos"].Points.Clear();
            chart.Series["Capital"].Points.Clear();
            chart.Series["Pasivos"].Points.Clear();
            chart.Series["Ingresos"].Points.Clear();
            chart.Series["Costos"].Points.Clear();
            chart.Series["Gastos"].Points.Clear();

        }

        // el metodo obtiene el año en que empieza del libro diario
        private int getYear(LibroDiario libroDiario)
        {
            string[] periodoTokens = libroDiario.Periodo.Split(' ');

            int year = Convert.ToInt32(periodoTokens[5]);

            return year;
        }

        // el metodo obtiene el mes en que empieza del libro diario
        private string getMonth(LibroDiario libroDiario)
        {
            string[] periodoTokens = libroDiario.Periodo.Split(' ');

            string month = periodoTokens[3];

            return month;
        }

    }
}
