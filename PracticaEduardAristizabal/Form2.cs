/*
Planteamiento del problema:
El Almacén Superéxito, requiere realizar una aplicación para llevar el control de su inventario 
que contenga una interfaz gráfica de usuario que permita a través de opciones, registrar, eliminar
productos y salir de la aplicación. Para el registro de productos se requiere el código, el nombre,
la descripción, el precio y el tipo de producto ya sea este (electrodoméstico, electrónico, 
comestible o de hogar) estos tipos de productos se requiere que se seleccionen de una lista
desplegable al hacer el registro. La eliminación debe realizarse en el mismo orden de ingreso,
cumpliendo así con el comportamiento de una Cola, es decir el primero que ingresa es el primero
que sale, a través de la colección genérica Queue <T>. adicionalmente se requiere conocer el 
acumulado total del valor del inventario ingresado a la cola.
==========================================================================================
Autor: Eduard Fernando Aristizabal Giraldo
Fecha: Diciembre de 2017
Curso: Estructura de datos
===========================================================================================
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEduardAristizabal
{
    public partial class frmInventarios : Form
    {
        Queue<Producto> misProductos = new Queue<Producto>();  //Crear la cola

        public frmInventarios()
        {            
            InitializeComponent();
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmInventarios_Load(object sender, EventArgs e)
        {
            Totales();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidacionCodigo()) return;

            if (ExisteCodigo (txtCodigo.Text))
            {
                epvInventarios.SetError(txtCodigo, "Código ya fue adicionado.");
                txtCodigo.Focus();
                return;
            }

            if (cbxTipo.SelectedIndex == -1)
            {
                epvInventarios.SetError(cbxTipo, "Selecciona el tipo.");
                cbxTipo.Focus();
                return;
            }
            epvInventarios.SetError(cbxTipo, "");

            if (txtNombre.Text == "")
            {
                epvInventarios.SetError(txtNombre, "Ingresa el nombre del producto.");
                txtNombre.Focus();
                return;
            }
            epvInventarios.SetError(txtNombre, "");

            if (txtPrecio.Text == "")
            {
                epvInventarios.SetError(txtPrecio, "Ingresa el precio  del producto.");
                txtPrecio.Focus();
                return;
            }
            epvInventarios.SetError(txtPrecio, "");

            if (txtDescripcion.Text == "")
            {
                epvInventarios.SetError(txtDescripcion, "Ingresa la descripción del producto.");
                txtDescripcion.Focus();
                return;
            }
            epvInventarios.SetError(txtDescripcion, "");

            Int64 codigo;
            if (!Int64.TryParse(txtCodigo.Text, out codigo))
            {
                epvInventarios.SetError(txtCodigo, "Ingresar un valor numerico.");
                txtCodigo.Focus();
                return;
            }
            epvInventarios.SetError(txtCodigo, "");

            decimal precio;
            if (!Decimal.TryParse(txtPrecio.Text, out precio))
            {
                epvInventarios.SetError(txtPrecio, "Ingresar un valor numerico.");
                txtPrecio.Focus();
                return;
            }
            epvInventarios.SetError(txtPrecio, "");

            Producto miProducto = new Producto();
            miProducto.Codigo = txtCodigo.Text;
            miProducto.Tipo = cbxTipo.Text;
            miProducto.Nombre = txtNombre.Text;
            miProducto.Precio = Decimal.Parse(txtPrecio.Text);
            miProducto.Descripcion = txtDescripcion.Text;
            misProductos.Enqueue(miProducto);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misProductos.ToList();
            Limpiar();
            Totales();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (misProductos.Count != 0)
            {
                DialogResult opc = MessageBox.Show(this, "¿Desea eliminar el producto de la cola?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (opc == DialogResult.No) return;

                Producto miProducto = new Producto();
                miProducto = misProductos.Dequeue();
                txtCodigo.Text = miProducto.Codigo.ToString();
                cbxTipo.Text = miProducto.Tipo;
                txtNombre.Text = miProducto.Nombre;
                txtPrecio.Text = miProducto.Precio.ToString();
                txtDescripcion.Text = miProducto.Descripcion;
                dgvDatos.DataSource = misProductos.ToList();
                MessageBox.Show("¡El producto que estaba en cola fue eliminado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("La cola está vacia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
            }          
            Totales();
            txtCodigo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void Limpiar() 
        {
            txtCodigo.Clear();
            cbxTipo.SelectedIndex = -1;
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
        }

        public void Totales()
        {
            double Acumulado = 0;
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                Acumulado += Convert.ToDouble(row.Cells["Precio"].Value);
            }
            txtAcumulado.Text = Convert.ToString(Acumulado);
        }

        private bool ValidacionCodigo()
        {
            if (txtCodigo.Text == "" || Convert.ToDouble(txtCodigo.Text) <= 0)
            {
                epvInventarios.SetError(txtCodigo, "Ingresa un valor válido.");
                txtCodigo.Focus();
                return false;
            }
            epvInventarios.SetError(txtCodigo, "");
            return true;
        }

        private bool ExisteCodigo(string Codigo)    
        {
            foreach (Producto ExisteCodigo in misProductos)
            {
                if (ExisteCodigo.Codigo == Codigo) return true;
            }
            return false;
        }


        private Producto GetProducto(string Codigo)
        {
            foreach (Producto miProducto in misProductos)
            {
                if (miProducto.Codigo == Codigo) return miProducto;
            }
            return null;
        }

    }
}
