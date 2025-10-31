namespace EjercicioAdministracion2
{
    partial class PCompras
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbProveedor = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbFecha = new System.Windows.Forms.DateTimePicker();
            this.tbComprobante = new System.Windows.Forms.TextBox();
            this.tbPuntoVenta = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbNeto = new System.Windows.Forms.TextBox();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.tbGravado = new System.Windows.Forms.TextBox();
            this.tbTributos = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoComprobanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntoVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGravadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosTributosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.95337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.04663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1169, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.tipoComprobanteDataGridViewTextBoxColumn,
            this.puntoVentaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.netoTotalDataGridViewTextBoxColumn,
            this.ivaTotalDataGridViewTextBoxColumn,
            this.noGravadoDataGridViewTextBoxColumn,
            this.otrosTributosDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comprasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 318);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1163, 129);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tbFecha);
            this.flowLayoutPanel2.Controls.Add(this.tbProveedor);
            this.flowLayoutPanel2.Controls.Add(this.tbComprobante);
            this.flowLayoutPanel2.Controls.Add(this.tbPuntoVenta);
            this.flowLayoutPanel2.Controls.Add(this.tbNumero);
            this.flowLayoutPanel2.Controls.Add(this.tbNeto);
            this.flowLayoutPanel2.Controls.Add(this.tbIva);
            this.flowLayoutPanel2.Controls.Add(this.tbGravado);
            this.flowLayoutPanel2.Controls.Add(this.tbTributos);
            this.flowLayoutPanel2.Controls.Add(this.tbUsuario);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1157, 41);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tbProveedor
            // 
            this.tbProveedor.ForeColor = System.Drawing.Color.DarkGray;
            this.tbProveedor.Location = new System.Drawing.Point(209, 3);
            this.tbProveedor.Name = "tbProveedor";
            this.tbProveedor.Size = new System.Drawing.Size(100, 20);
            this.tbProveedor.TabIndex = 1;
            this.tbProveedor.Text = "Proveedor";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Controls.Add(this.button6);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 50);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1157, 38);
            this.flowLayoutPanel3.TabIndex = 1;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.tbMin);
            this.flowLayoutPanel4.Controls.Add(this.tbMax);
            this.flowLayoutPanel4.Controls.Add(this.button4);
            this.flowLayoutPanel4.Controls.Add(this.button5);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1163, 34);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(3, 3);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 0;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(109, 3);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Filtrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Desfiltrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(3, 3);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(200, 20);
            this.tbFecha.TabIndex = 2;
            // 
            // tbComprobante
            // 
            this.tbComprobante.ForeColor = System.Drawing.Color.DarkGray;
            this.tbComprobante.Location = new System.Drawing.Point(315, 3);
            this.tbComprobante.Name = "tbComprobante";
            this.tbComprobante.Size = new System.Drawing.Size(100, 20);
            this.tbComprobante.TabIndex = 3;
            this.tbComprobante.Text = "Tipo comprobante";
            // 
            // tbPuntoVenta
            // 
            this.tbPuntoVenta.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPuntoVenta.Location = new System.Drawing.Point(421, 3);
            this.tbPuntoVenta.Name = "tbPuntoVenta";
            this.tbPuntoVenta.Size = new System.Drawing.Size(100, 20);
            this.tbPuntoVenta.TabIndex = 4;
            this.tbPuntoVenta.Text = "Punto venta";
            // 
            // tbNumero
            // 
            this.tbNumero.ForeColor = System.Drawing.Color.DarkGray;
            this.tbNumero.Location = new System.Drawing.Point(527, 3);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 5;
            this.tbNumero.Text = "Número";
            // 
            // tbNeto
            // 
            this.tbNeto.ForeColor = System.Drawing.Color.DarkGray;
            this.tbNeto.Location = new System.Drawing.Point(633, 3);
            this.tbNeto.Name = "tbNeto";
            this.tbNeto.Size = new System.Drawing.Size(100, 20);
            this.tbNeto.TabIndex = 6;
            this.tbNeto.Text = "Neto total";
            // 
            // tbIva
            // 
            this.tbIva.ForeColor = System.Drawing.Color.DarkGray;
            this.tbIva.Location = new System.Drawing.Point(739, 3);
            this.tbIva.Name = "tbIva";
            this.tbIva.Size = new System.Drawing.Size(100, 20);
            this.tbIva.TabIndex = 7;
            this.tbIva.Text = "Iva total";
            // 
            // tbGravado
            // 
            this.tbGravado.ForeColor = System.Drawing.Color.DarkGray;
            this.tbGravado.Location = new System.Drawing.Point(845, 3);
            this.tbGravado.Name = "tbGravado";
            this.tbGravado.Size = new System.Drawing.Size(100, 20);
            this.tbGravado.TabIndex = 8;
            this.tbGravado.Text = "No gravado";
            // 
            // tbTributos
            // 
            this.tbTributos.ForeColor = System.Drawing.Color.DarkGray;
            this.tbTributos.Location = new System.Drawing.Point(951, 3);
            this.tbTributos.Name = "tbTributos";
            this.tbTributos.Size = new System.Drawing.Size(100, 20);
            this.tbTributos.TabIndex = 9;
            this.tbTributos.Text = "Otros tributos";
            // 
            // tbUsuario
            // 
            this.tbUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUsuario.Location = new System.Drawing.Point(1057, 3);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 10;
            this.tbUsuario.Text = "Usuario";
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(Modelos.Compras);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoComprobanteDataGridViewTextBoxColumn
            // 
            this.tipoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "tipoComprobante";
            this.tipoComprobanteDataGridViewTextBoxColumn.HeaderText = "tipoComprobante";
            this.tipoComprobanteDataGridViewTextBoxColumn.Name = "tipoComprobanteDataGridViewTextBoxColumn";
            this.tipoComprobanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puntoVentaDataGridViewTextBoxColumn
            // 
            this.puntoVentaDataGridViewTextBoxColumn.DataPropertyName = "puntoVenta";
            this.puntoVentaDataGridViewTextBoxColumn.HeaderText = "puntoVenta";
            this.puntoVentaDataGridViewTextBoxColumn.Name = "puntoVentaDataGridViewTextBoxColumn";
            this.puntoVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netoTotalDataGridViewTextBoxColumn
            // 
            this.netoTotalDataGridViewTextBoxColumn.DataPropertyName = "netoTotal";
            this.netoTotalDataGridViewTextBoxColumn.HeaderText = "netoTotal";
            this.netoTotalDataGridViewTextBoxColumn.Name = "netoTotalDataGridViewTextBoxColumn";
            this.netoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ivaTotalDataGridViewTextBoxColumn
            // 
            this.ivaTotalDataGridViewTextBoxColumn.DataPropertyName = "ivaTotal";
            this.ivaTotalDataGridViewTextBoxColumn.HeaderText = "ivaTotal";
            this.ivaTotalDataGridViewTextBoxColumn.Name = "ivaTotalDataGridViewTextBoxColumn";
            this.ivaTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noGravadoDataGridViewTextBoxColumn
            // 
            this.noGravadoDataGridViewTextBoxColumn.DataPropertyName = "noGravado";
            this.noGravadoDataGridViewTextBoxColumn.HeaderText = "noGravado";
            this.noGravadoDataGridViewTextBoxColumn.Name = "noGravadoDataGridViewTextBoxColumn";
            this.noGravadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otrosTributosDataGridViewTextBoxColumn
            // 
            this.otrosTributosDataGridViewTextBoxColumn.DataPropertyName = "otrosTributos";
            this.otrosTributosDataGridViewTextBoxColumn.HeaderText = "otrosTributos";
            this.otrosTributosDataGridViewTextBoxColumn.Name = "otrosTributosDataGridViewTextBoxColumn";
            this.otrosTributosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(246, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Ver detalle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PCompras";
            this.Text = "PCompras";
            this.Load += new System.EventHandler(this.PCompras_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox tbProveedor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker tbFecha;
        private System.Windows.Forms.TextBox tbComprobante;
        private System.Windows.Forms.TextBox tbPuntoVenta;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbNeto;
        private System.Windows.Forms.TextBox tbIva;
        private System.Windows.Forms.TextBox tbGravado;
        private System.Windows.Forms.TextBox tbTributos;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoComprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntoVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGravadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosTributosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.Button button6;
    }
}