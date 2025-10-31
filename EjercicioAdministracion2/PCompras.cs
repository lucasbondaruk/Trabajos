using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioAdministracion2
{
    public partial class PCompras : Form
    {
        public PCompras()
        {
            InitializeComponent();
        }
        List<Compras> compras = new List<Compras>();
        Compras compraSeleciconada = new Compras();

        private void PCompras_Load(object sender, EventArgs e)
        {
            compras = NCompras.Get();
            comprasBindingSource.DataSource = compras;
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFecha.Text != "" && tbProveedor.Text != "" && tbComprobante.Text != "" && tbPuntoVenta.Text != "" && tbNumero.Text != "" && tbNeto.Text != "" && tbIva.Text != "" && tbGravado.Text != "" && tbTributos.Text != "" && tbUsuario.Text != "")
                {
                    DateTime fecha = tbFecha.Value;
                    int proveedor = int.Parse(tbProveedor.Text);
                    int tipoComprobante = int.Parse(tbComprobante.Text);
                    string puntoVenta = tbPuntoVenta.Text;
                    string numero = tbNumero.Text;
                    decimal netoTotal = decimal.Parse(tbNeto.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    decimal ivaTotal = decimal.Parse(tbIva.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    decimal noGravado = decimal.Parse(tbGravado.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    decimal otrosTributos = decimal.Parse(tbTributos.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    int usuario = int.Parse(tbUsuario.Text);


                    Compras c = new Compras
                    {
                        fecha = fecha,
                        proveedor = proveedor,
                        tipoComprobante = tipoComprobante,
                        puntoVenta = puntoVenta,
                        numero = numero,
                        netoTotal = netoTotal,
                        ivaTotal = ivaTotal,
                        noGravado = noGravado,
                        otrosTributos = otrosTributos,
                        usuario = usuario,

                    };
                    NCompras.Create(c);
                    compras.Add(c);
                    comprasBindingSource.DataSource = null;
                    comprasBindingSource.DataSource = compras;
                    MessageBox.Show("Registro agregado", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("No puede tener campos vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea borrar el registro?","Confirmacion Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes) {
                    NCompras.Delete(compraSeleciconada.id);
                    MessageBox.Show("Registro eliminado", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    compras.RemoveAll(c => c.id == compraSeleciconada.id);
                    comprasBindingSource.DataSource = null;
                    comprasBindingSource.DataSource = compras;
                
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                if (id != 0 && tbFecha.Text != "" && tbProveedor.Text != "" && tbComprobante.Text != "" &&
                    tbPuntoVenta.Text != "" && tbNumero.Text != "" && tbNeto.Text != "" && tbIva.Text != "" &&
                    tbGravado.Text != "" && tbTributos.Text != "" && tbUsuario.Text != "")
                {

                    
                    DateTime fecha = tbFecha.Value;
                    int proveedor = int.Parse(tbProveedor.Text);
                    int tipoComprobante = int.Parse(tbComprobante.Text);
                    string puntoVenta = tbPuntoVenta.Text;
                    string numero = tbNumero.Text;
                    decimal netoTotal = decimal.Parse(tbNeto.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    decimal ivaTotal = decimal.Parse(tbIva.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    decimal noGravado = decimal.Parse(tbGravado.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    decimal otrosTributos = decimal.Parse(tbTributos.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    int usuario = int.Parse(tbUsuario.Text);

                    Compras c = new Compras
                    {
                        id = id,
                        fecha = fecha,
                        proveedor = proveedor,
                        tipoComprobante = tipoComprobante,
                        puntoVenta = puntoVenta,
                        numero = numero,
                        netoTotal = netoTotal,
                        ivaTotal = ivaTotal,
                        noGravado = noGravado,
                        otrosTributos = otrosTributos,
                        usuario = usuario
                    };

                    NCompras.Update(c);
                    var index = compras.FindIndex(x => x.id == c.id);
                    if (index >= 0)
                    {
                        compras[index] = c;
                        comprasBindingSource.DataSource = null;
                        comprasBindingSource.DataSource = compras;
                    }

                    MessageBox.Show("Registro actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("No puede tener campos vacíos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PDetalleCompras pdetallecompras = new PDetalleCompras(compraSeleciconada);
            pdetallecompras.Show();
        }
    }
}
