
namespace SistemasContables.Views
{
    partial class ReporteDeVentasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableReporteDeVentas = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableReporteDeVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(171, 66);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(600, 37);
            this.lblPeriodo.TabIndex = 17;
            this.lblPeriodo.Text = "texto periodo";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(176, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(595, 33);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Reporte de Ventas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableReporteDeVentas
            // 
            this.tableReporteDeVentas.AllowUserToAddRows = false;
            this.tableReporteDeVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableReporteDeVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableReporteDeVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableReporteDeVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableReporteDeVentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableReporteDeVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableReporteDeVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableReporteDeVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableReporteDeVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableReporteDeVentas.ColumnHeadersHeight = 40;
            this.tableReporteDeVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFecha,
            this.Concepto,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReporteDeVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableReporteDeVentas.EnableHeadersVisualStyles = false;
            this.tableReporteDeVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReporteDeVentas.Location = new System.Drawing.Point(73, 158);
            this.tableReporteDeVentas.Name = "tableReporteDeVentas";
            this.tableReporteDeVentas.ReadOnly = true;
            this.tableReporteDeVentas.RowHeadersVisible = false;
            this.tableReporteDeVentas.RowHeadersWidth = 40;
            this.tableReporteDeVentas.RowTemplate.Height = 40;
            this.tableReporteDeVentas.RowTemplate.ReadOnly = true;
            this.tableReporteDeVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableReporteDeVentas.Size = new System.Drawing.Size(800, 467);
            this.tableReporteDeVentas.TabIndex = 18;
            this.tableReporteDeVentas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tableReporteDeVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableReporteDeVentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableReporteDeVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableReporteDeVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableReporteDeVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableReporteDeVentas.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableReporteDeVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReporteDeVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tableReporteDeVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableReporteDeVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableReporteDeVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableReporteDeVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableReporteDeVentas.ThemeStyle.HeaderStyle.Height = 40;
            this.tableReporteDeVentas.ThemeStyle.ReadOnly = true;
            this.tableReporteDeVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableReporteDeVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableReporteDeVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableReporteDeVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableReporteDeVentas.ThemeStyle.RowsStyle.Height = 40;
            this.tableReporteDeVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReporteDeVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.FillWeight = 60F;
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 65F;
            this.Total.HeaderText = "Total $";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // ReporteDeVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.tableReporteDeVentas);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReporteDeVentasForm";
            this.Text = "ReporteDeVentasForm";
            ((System.ComponentModel.ISupportInitialize)(this.tableReporteDeVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI.WinForms.GunaDataGridView tableReporteDeVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}