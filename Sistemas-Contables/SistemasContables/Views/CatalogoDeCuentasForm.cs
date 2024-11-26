using Guna.UI.WinForms;
using SistemasContables.DataBase;
using SistemasContables.controller;
using SistemasContables.Models;
using SpreadsheetLight;
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
    public partial class CatalogoDeCuentasForm : Form
    {
        private CuentasController cuentaController;
        private List<Cuenta> listaCuentas;

        private List<Cuenta> listaCuentasAdd = new List<Cuenta>();

        private int idCuentaSelect = -1;
        private bool isEdit = false;

        //Variables auxiliares para establecer nivel y tipo de cuenta
        private int nivelAux = 0;
        private string tipoCuentaAux = "";

        public CatalogoDeCuentasForm()
        {
            InitializeComponent();

            cuentaController = new CuentasController();
            cargarTablaCatalogo();
        }


        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            string codigoCuenta = textCodigoCuenta.Text;
            string nombreCuenta = textNombreCuenta.Text;
            string tipo = cbTipoCuenta.SelectedItem.ToString();

            bool isValidCodigo = isValidInput(codigoCuenta, "Codigo de Cuenta");
            bool isValidCuenta = isValidInput(nombreCuenta.ToString(), "Nombre de Cuenta");
            bool isValidTipo = isValidInput(tipo, "Tipo de Cuenta");

            if (isValidCodigo && isValidCuenta && isValidTipo)
            {
                //int codigoCuenta = Convert.ToInt32(textCodigoCuenta.Text.ToString());
            
                int nivel = establecerNivel(Convert.ToInt32(codigoCuenta));

                if(nivel == 0)
                {
                    MessageBox.Show(null, "El codigo de la cuenta solo puede ser de 1, 2, 3 y 5 cifras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                bool success = false;

                if(!isEdit)
                {
                    success = cuentaController.insert(new Cuenta(0, nombreCuenta, codigoCuenta, nivel, tipo));

                    MessageBox.Show(null, "Se guardo la cuenta con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    restorerButtonTextBox();
                    cargarTablaCatalogo();
                }
                else
                {
                   success = cuentaController.update(new Cuenta(idCuentaSelect, nombreCuenta, codigoCuenta, nivel, tipo));

                    MessageBox.Show(null, "Se actualizo la cuenta con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    restorerButtonTextBox();
                    cargarTablaCatalogo();
                }

                /*if (success)
                {
                    MessageBox.Show(null, "Se guardo la cuenta con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    restorerButtonTextBox();
                    cargarTablaCatalogo();
                }*/

            }

            
        }

        private void btnCargarCatalogo_Click(object sender, EventArgs e)
        {
            string direccion = textSeleccionarArchivo.Text;

            bool isValidDireccion = isValidInput(direccion, "Archivo que cargar");

            if (isValidDireccion)
            {
                cargarExel();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows = tableCatalogoDeCuentas.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["ColumnSelect"].Value) == true).ToList();

            if (rows.Count > 0)
            {
                DialogResult dialogQuestion = MessageBox.Show("¿Estas seguro de que quieres eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogQuestion == DialogResult.Yes)
                {

                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataGridViewRow row = rows[i];

                        cuentaController.delete(Convert.ToInt32(row.Cells[0].Value));

                        restorerButtonTextBox();

                        cargarTablaCatalogo();
                    }

                }
            }
        }

        private void textCodigoCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tableCatalogoDeCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableCatalogoDeCuentas.Columns[e.ColumnIndex].Name == "ColumnEdit")
            {

                int indexFila = e.RowIndex;

                idCuentaSelect = Convert.ToInt32(tableCatalogoDeCuentas.Rows[indexFila].Cells[0].Value.ToString());
                textCodigoCuenta.Text = tableCatalogoDeCuentas.Rows[indexFila].Cells[1].Value.ToString();
                textNombreCuenta.Text = tableCatalogoDeCuentas.Rows[indexFila].Cells[2].Value.ToString();

                int indexComboBox = cbTipoCuenta.FindString(tableCatalogoDeCuentas.Rows[indexFila].Cells[4].Value.ToString());
                cbTipoCuenta.SelectedIndex = indexComboBox;

                btnAgregarCuenta.BackColor = Color.FromArgb(243, 156, 18);
                btnAgregarCuenta.Text = "Editar Cuenta";
                btnAgregarCuenta.IconChar = FontAwesome.Sharp.IconChar.Edit;


                isEdit = true;
            }
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogCatalogo;

            openFileDialogCatalogo = new OpenFileDialog()
            {
                FileName = "Seleccione el archivo de catalogo",
                Filter = "Exel Files (*.xlsx)|*.xlsx",
                Title = "Abrir archivo de catalogo de cuentas"
            };

            if (openFileDialogCatalogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //var sr = new StreamReader(openFileDialog1.FileName);
                    string sr = openFileDialogCatalogo.FileName;
                    textSeleccionarArchivo.Text = sr;
                }
                catch (System.Security.SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void cargarTablaCatalogo()
        {
            if (tableCatalogoDeCuentas.RowCount > 0)
            {
                tableCatalogoDeCuentas.Rows.Clear();
                listaCuentas.Clear();
            }

            listaCuentas = cuentaController.getList();
            //listaCuentas = cuentaController.listaNivelTipo(3, "PATRIMONIO");
            //listaCuentas = cuentaController.listaNivel(2);

            foreach (Cuenta cuenta in listaCuentas)
            {
                tableCatalogoDeCuentas.Rows.Add(cuenta.IdCuenta, cuenta.Codigo, cuenta.Nombre, cuenta.Nivel, cuenta.TipoSaldo);
            }
        }

        private void cargarExel()
        {
            try
            {
                SLDocument sl = new SLDocument(textSeleccionarArchivo.Text.ToString());
                string[] info = new string[5];

                int valor = 1;
                int codigoAux;
                string tipoAux = "";

                if (listaCuentasAdd != null)
                {
                    listaCuentasAdd.Clear();
                }

                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(valor, 1)))
                {
                    codigoAux = Int32.Parse(sl.GetCellValueAsString(valor, 1));
                    tipoAux = establecerTipo(codigoAux, sl.GetCellValueAsString(valor, 2));

                    listaCuentasAdd.Add(new Cuenta(0, sl.GetCellValueAsString(valor, 2), sl.GetCellValueAsString(valor, 1), establecerNivel(codigoAux), tipoAux));

                    valor++;
                }

                bool add = cuentaController.agregarListaDeCuentas(listaCuentasAdd);
                if (add)
                {
                    MessageBox.Show(null, "Se cargo el catalogo con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textSeleccionarArchivo.Text = "";
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(null, exception.Message, "Error al cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargarTablaCatalogo();
        }

        private bool isValidInput(String txtInput, string campo)
        {
            if (String.IsNullOrEmpty(txtInput) || txtInput == "0" || txtInput == "Tipo de Saldo")
            {
                MessageBox.Show(null,"Ingrese un " + campo, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            return true;
        }

        private int establecerNivel(int codigo)
        {
            if (codigo < 10)
            {
                return 1;
            }
            else if (codigo < 100)
            {
                return 2;
            }
            else if (codigo < 1000)
            {
                return 3;
            }

            else if(codigo < 10000 )
            {
                return 4;
            }

            else if (codigo < 100000000)
            {
                return 5;
            }

            else
            {
                return 0;
            }
        }

        private string establecerTipo(int codigo, string cuenta)
        {

            if (codigo < 10 && codigo > nivelAux)
            {
                nivelAux = codigo;
                tipoCuentaAux = cuenta;
            }

            return tipoCuentaAux;
        }

        public void restorerButtonTextBox()
        {
            btnAgregarCuenta.BackColor = Color.FromArgb(39, 174, 96);
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;

            isEdit = false;

            textCodigoCuenta.Text = "";
            textNombreCuenta.Text = "";
        }

    }
}
