namespace SistemasContables.Views
{
    partial class LibroVentasAContibuyentesForm
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
            this.panelTabla = new System.Windows.Forms.Panel();
            this.tableLibroVentasContribuyentes = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLibroVentasContribuyentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(169, 70);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(600, 35);
            this.lblPeriodo.TabIndex = 21;
            this.lblPeriodo.Text = "texto periodo";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(223, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(512, 33);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Libro de Ventas a Contribuyentes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTabla
            // 
            this.panelTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabla.Controls.Add(this.tableLibroVentasContribuyentes);
            this.panelTabla.Location = new System.Drawing.Point(68, 200);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(800, 400);
            this.panelTabla.TabIndex = 19;
            // 
            // tableLibroVentasContribuyentes
            // 
            this.tableLibroVentasContribuyentes.AllowUserToAddRows = false;
            this.tableLibroVentasContribuyentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableLibroVentasContribuyentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableLibroVentasContribuyentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableLibroVentasContribuyentes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableLibroVentasContribuyentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLibroVentasContribuyentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableLibroVentasContribuyentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableLibroVentasContribuyentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableLibroVentasContribuyentes.ColumnHeadersHeight = 40;
            this.tableLibroVentasContribuyentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDetalle,
            this.ColumnDebe,
            this.ColumnHaber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableLibroVentasContribuyentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableLibroVentasContribuyentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLibroVentasContribuyentes.EnableHeadersVisualStyles = false;
            this.tableLibroVentasContribuyentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableLibroVentasContribuyentes.Location = new System.Drawing.Point(0, 0);
            this.tableLibroVentasContribuyentes.Name = "tableLibroVentasContribuyentes";
            this.tableLibroVentasContribuyentes.ReadOnly = true;
            this.tableLibroVentasContribuyentes.RowHeadersVisible = false;
            this.tableLibroVentasContribuyentes.RowHeadersWidth = 40;
            this.tableLibroVentasContribuyentes.RowTemplate.Height = 40;
            this.tableLibroVentasContribuyentes.RowTemplate.ReadOnly = true;
            this.tableLibroVentasContribuyentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableLibroVentasContribuyentes.Size = new System.Drawing.Size(800, 400);
            this.tableLibroVentasContribuyentes.TabIndex = 35;
            this.tableLibroVentasContribuyentes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tableLibroVentasContribuyentes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableLibroVentasContribuyentes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableLibroVentasContribuyentes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableLibroVentasContribuyentes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableLibroVentasContribuyentes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableLibroVentasContribuyentes.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableLibroVentasContribuyentes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableLibroVentasContribuyentes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tableLibroVentasContribuyentes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableLibroVentasContribuyentes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLibroVentasContribuyentes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableLibroVentasContribuyentes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableLibroVentasContribuyentes.ThemeStyle.HeaderStyle.Height = 40;
            this.tableLibroVentasContribuyentes.ThemeStyle.ReadOnly = true;
            this.tableLibroVentasContribuyentes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableLibroVentasContribuyentes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableLibroVentasContribuyentes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableLibroVentasContribuyentes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableLibroVentasContribuyentes.ThemeStyle.RowsStyle.Height = 40;
            this.tableLibroVentasContribuyentes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableLibroVentasContribuyentes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnDetalle
            // 
            this.ColumnDetalle.FillWeight = 50F;
            this.ColumnDetalle.HeaderText = "Operacion";
            this.ColumnDetalle.Name = "ColumnDetalle";
            this.ColumnDetalle.ReadOnly = true;
            // 
            // ColumnDebe
            // 
            this.ColumnDebe.FillWeight = 150F;
            this.ColumnDebe.HeaderText = "Cuenta";
            this.ColumnDebe.Name = "ColumnDebe";
            this.ColumnDebe.ReadOnly = true;
            // 
            // ColumnHaber
            // 
            this.ColumnHaber.HeaderText = "Totales";
            this.ColumnHaber.Name = "ColumnHaber";
            this.ColumnHaber.ReadOnly = true;
            // 
            // LibroVentasAContibuyentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibroVentasAContibuyentesForm";
            this.Text = "LibroVentasAContibuyentesForm";
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLibroVentasContribuyentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTabla;
        private Guna.UI.WinForms.GunaDataGridView tableLibroVentasContribuyentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHaber;
    }
}