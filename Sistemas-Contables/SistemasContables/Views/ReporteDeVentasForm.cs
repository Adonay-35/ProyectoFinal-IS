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
    public partial class ReporteDeVentasForm : Form
    {
        private ReportesController reporteDeventasControler;
        private List<string> listaCodigos;
        private List<Partida> listaPartidas;
        private Partida partida;
        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", formatoDecimales)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;
        private string nivel3;
        

        public ReporteDeVentasForm(LibroDiario libroDiario)
        {
            InitializeComponent();
            lblPeriodo.Text = libroDiario.Periodo;

            reporteDeventasControler = new ReportesController();
            llenarReporte(libroDiario.IdLibroDiario);
        }

        private void llenarReporte(int idLibroDiario)
        {
            nivel3 = "";
            double totalMontos = 0;
            List<string> conceptos = new List<string>();

            listaCodigos = reporteDeventasControler.getListCodigos(idLibroDiario);

            foreach (string codigo in listaCodigos)
            {
                for (int i = 0; i < 4; i++)
                {
                    nivel3 += codigo[i];
                }

                partida = reporteDeventasControler.getPartida(nivel3);

                if (partida != null)
                {
                    listaPartidas = reporteDeventasControler.getListPartida(nivel3, idLibroDiario);


                    if (conceptos.Count > 0)
                    {
                        int index = 0;
                        bool existe = false;

                        while (index < conceptos.Count)
                        {
                            if (conceptos[index] == partida.ListaCuentasPartida[0].Nombre)
                            {
                                existe = true;
                                break;
                            }

                            index++;
                        }


                        if (!existe)
                        {
                            conceptos.Add(partida.ListaCuentasPartida[0].Nombre);
                            llenarRegistros(totalMontos);
                        }

                    }
                    else
                    {
                        conceptos.Add(partida.ListaCuentasPartida[0].Nombre);
                        llenarRegistros(totalMontos);
                    }
                }

                nivel3 = "";

            }
        }

        public void llenarRegistros(double totalMontos)
        {
            foreach (Partida partidaAux in listaPartidas)
            {
                if (partida.ListaCuentasPartida[0].TipoSaldo == "Acreedor" )
                {
                    tableReporteDeVentas.Rows.Add(partidaAux.Fecha, partidaAux.Detalle, redondear(partidaAux.ListaCuentasPartida[0].Haber));
                }
            }
        }

        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }
    }
}
