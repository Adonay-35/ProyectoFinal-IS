using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class LibroDiarioForm : Form
    {
        private PartidasController partidasController;
        private List<Partida> lista;
        private Partida partidaAux = null;
        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", formatoDecimales)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;

        private int numeroPartidas;
        private int idLibroDiario;
        private string accion;
        private Paragraph title;
        private Paragraph periodo;


        public LibroDiarioForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            idLibroDiario = libroDiario.IdLibroDiario;
            lblPeriodo.Text = libroDiario.Periodo;

            partidasController = new PartidasController();

            llenarTabla();
            Totales();

            partidaAux = new Partida();
            partidaAux.ListaCuentasPartida = new List<CuentaPartida>();

            disableButtons();

            // texto para el documento en pdf
            Font titleFont = FontFactory.GetFont("Arial", 22);
            Font periodoFont = FontFactory.GetFont("Arial", 16);
            
            title = new Paragraph(lblTitulo.Text, titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20;

            periodo = new Paragraph(lblPeriodo.Text, periodoFont);
            periodo.Alignment = Element.ALIGN_CENTER;
            periodo.SpacingAfter = 20;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "ingresar";

            using(AgregarPartidaForm agregarPartidaForm = new AgregarPartidaForm(this.partidasController, idLibroDiario, numeroPartidas, accion))
            {
                this.Parent.Parent.Parent.Visible = false;
                agregarPartidaForm.ShowDialog();
                this.Parent.Parent.Parent.Visible = true;
                llenarTabla();
                Totales();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indexFila = tableLibroDiario.CurrentRow.Index;

            string celdaPartida = tableLibroDiario.Rows[indexFila].Cells["ColumnDetalle"].Value.ToString();

            if (celdaPartida.Contains("Partida"))
            {
                string[] partidaString = celdaPartida.Split(' ');
                int numeroPartida = Convert.ToInt32(partidaString[2]);


                accion = "editar";

                using (AgregarPartidaForm agregarPartidaForm = new AgregarPartidaForm(this.partidasController, idLibroDiario, numeroPartida, accion))
                {
                    this.Parent.Parent.Parent.Visible = false;
                    agregarPartidaForm.ShowDialog();
                    this.Parent.Parent.Parent.Visible = true;
                    llenarTabla();
                    Totales();
                }

            }
            else
            {
                MessageBox.Show("Para editar una partida Selecciona la fila que corresponda\n a la partidano, no seleccione una fila de cuenta o detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = tableLibroDiario.CurrentRow.Index;

            string celdaPartida = tableLibroDiario.Rows[indexFila].Cells["ColumnDetalle"].Value.ToString();

            if (celdaPartida.Contains("Partida"))
            {

                DialogResult res = MessageBox.Show("¿Desea eliminar la partida seleccionada?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    string[] partidaString = celdaPartida.Split(' ');
                    int numeroPartida = Convert.ToInt32(partidaString[2]);

                    partidasController.delete(numeroPartida, idLibroDiario);

                    llenarTabla();
                    Totales();

                }

            }
            else
            {
                MessageBox.Show("Para eliminar una partida Selecciona la fila que corresponda\n a la partida, no seleccione una fila de cuenta o detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAjusteIva_Click(object sender, EventArgs e)
        {
            bool existeAjusteIVA = partidasController.VerificarAjusteIVA(idLibroDiario);

            if (!existeAjusteIVA)
            {
                CalcularAjusteIVA();
            }
            else
            {
                MessageBox.Show("Elimina la partida de ajuste iva actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        // el metodo exporta el balance general en un documento pdf
        private void btnExportar_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "Libro Diario.pdf";
                bool fileError = false;

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);
                        } catch (Exception exception)
                        {
                            fileError = true;
                            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(tableLibroDiario.Columns.Count);

                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in tableLibroDiario.Columns)
                            {
                                PdfPHeaderCell pdfCell = new PdfPHeaderCell() 
                                {
                                    Phrase=   new Phrase(column.HeaderText) 
                                };
                                pdfTable.AddCell(pdfCell);
                            }

                            foreach (DataGridViewRow row in tableLibroDiario.Rows)
                            {
                                foreach(DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                            {
                                using(Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 20f, 20f))
                                {
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(title);
                                    pdfDoc.Add(periodo);
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }

            }
        }

        //el metodo llena la tabla del libro diario
        private void llenarTabla()
        {
            if (tableLibroDiario.Rows.Count > 0 && lista.Count > 0)
            {
                tableLibroDiario.Rows.Clear();
                lista.Clear();
            }

            lista = partidasController.getList(idLibroDiario);

            numeroPartidas = lista.Count;

            if(lista.Count > 0)
            {
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                btnAjusteIva.Visible = true;
                btnExportar.Visible = true;
            } else
            {
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnAjusteIva.Visible = false;
                btnExportar.Visible = false;
            }

            foreach (Partida partida in lista)
            {
                tableLibroDiario.Rows.Add(partida.Fecha, "","Partida No " + partida.N_Partida, "", "");

                foreach (CuentaPartida cuentaPartida in partida.ListaCuentasPartida)
                {
                    tableLibroDiario.Rows.Add("", cuentaPartida.Codigo, cuentaPartida.Nombre, redondear(cuentaPartida.Debe), redondear(cuentaPartida.Haber), null, null);
                }

                tableLibroDiario.Rows.Add("", "",partida.Detalle, "", "");
            }

        }

        // ingreso los totales del debe y haber en sus respectivos labels
        private void Totales()
        {
            double totalDebe = TotalDebe();
            double totalHaber = TotalHaber();

            lblDebe.Text = "$ " + redondear(totalDebe);
            lblHaber.Text = "$ " + redondear(totalHaber);
        }

        // el metodo retorna la suma de todas cuentas en de la columna Debe
        private double TotalDebe()
        {
            double total = 0;

            for (int i = 0; i < tableLibroDiario.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tableLibroDiario.Rows[i].Cells["ColumnDebe"].Value.ToString()))
                {
                    total += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnDebe"].Value.ToString());
                }

            }

            total = Math.Round(total, 2);

            return total;
        }

        // el metodo retorna la suma de todas cuentas en de la columna Haber
        private double TotalHaber()
        {
            double total = 0;

            for (int i = 0; i < tableLibroDiario.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tableLibroDiario.Rows[i].Cells["ColumnHaber"].Value.ToString()))
                {
                    total += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnHaber"].Value.ToString());
                }

            }

            total = Math.Round(total, 2);

            return total;
        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

        // el metodo verifica que halla un libro y que este tenga al menos una partida
        private void disableButtons()
        {
            if(idLibroDiario == -1)
            {
                btnAgregar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnAjusteIva.Visible = false;
                btnExportar.Visible = false;
            }
            else if(tableLibroDiario.Rows.Count < 1)
            {
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnAjusteIva.Visible = false;
                btnExportar.Visible = false;
            } 
        }

        // el metodo calcula y crea una partida del ajuste de iva del libro diario
        private void CalcularAjusteIVA()
        {
            if (partidaAux.ListaCuentasPartida.Count > 0)
            {
                partidaAux.ListaCuentasPartida.Clear();
            }

            double totalDebito = partidasController.total(idLibroDiario, "debito_total");
            double totalCredito = partidasController.total(idLibroDiario, "credito_total");
            double totalDebitoDebe = partidasController.total(idLibroDiario, "debito_debe");
            double totalDebitoHaber = partidasController.total(idLibroDiario, "debito_haber");
            double totalCreditoDebe = partidasController.total(idLibroDiario, "credito_debe");
            double totalCreditoHaber = partidasController.total(idLibroDiario, "credito_haber");

            bool IVAremanente = false;
            bool IVAimpuesto = false;


            //ahora vamos a realizar las T para el Debito Fiscal IVA y Credito Fiscal Iva
            if (totalDebitoDebe > totalDebitoHaber)
            {
                totalDebito = totalDebitoDebe - totalDebitoHaber;
            }
            else if (totalDebitoDebe < totalDebitoHaber)
            {
                totalDebito = totalDebitoHaber - totalDebitoDebe;
            }

            if (totalCreditoDebe > totalCreditoHaber)
            {
                totalCredito = totalCreditoDebe - totalCreditoHaber;
            }
            else if (totalCreditoDebe < totalCreditoHaber)
            {
                totalCredito = totalCreditoHaber - totalCreditoDebe;
            }

            if (totalDebito > 0 || totalCredito > 0)
            {
                double remanente = 0.0;
                double impuesto = 0.0;

                if (totalCredito > totalDebito)
                {
                    remanente = totalCredito - totalDebito;
                    IVAremanente = true;
                }
                else if (totalCredito < totalDebito)
                {
                    impuesto = totalDebito - totalCredito;
                    IVAimpuesto = true;
                }

                DateTime dateTime = DateTime.Now;
                string today = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;

                partidaAux.Fecha = today;
                partidaAux.Detalle = "Ajuste de IVA";
                partidaAux.IdLibro = idLibroDiario;
                partidaAux.N_Partida = numeroPartidas + 1;

                totalCredito = Math.Round(totalCredito, 2);
                totalDebito = Math.Round(totalDebito, 2);
                remanente = Math.Round(remanente, 2);
                impuesto = Math.Round(impuesto, 2);


                if (IVAremanente)
                {
                    if (totalDebitoDebe > totalDebitoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = totalCredito, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Percepciones y retenciones de IVA", Codigo = "110602", Debe = remanente, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Debe = 0, Haber = totalDebito });
                    }
                    else if (totalDebitoDebe < totalDebitoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Debe = totalDebito, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Percepciones y retenciones de IVA", Codigo = "110602", Debe = remanente, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = 0, Haber = totalCredito });
                    }

                }
                else if (IVAimpuesto)
                {
                    if (totalDebitoDebe > totalDebitoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = totalCredito, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "RETENCIONES Y DESCUENTOS", Codigo = "2105", Haber = impuesto });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Haber = totalDebito });
                    }
                    else if (totalDebitoDebe < totalDebitoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Debe = totalDebito, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "RETENCIONES Y DESCUENTOS", Codigo = "2105", Debe = 0, Haber = impuesto });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = 0, Haber = totalCredito });
                    }
                }

                bool resultado = partidasController.insert(partidaAux);

                if (!resultado)
                {
                    MessageBox.Show("Ha ourrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                llenarTabla();
                Totales();
            }

            else
            {
                MessageBox.Show("No se encontraron cuentas de Debito Fiscal IVA o Credito Fiscal IVA\nen las partidas del libro actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
