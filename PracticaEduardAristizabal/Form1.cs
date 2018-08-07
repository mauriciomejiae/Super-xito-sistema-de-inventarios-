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
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "123")
            {
                epvIngresar.SetError(txtContraseña, "");
                MessageBox.Show("Bienvenido a Superéxito - Sistema de inventarios", "Ingreso satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmInventarios frm2 = new frmInventarios();
                this.Hide();
                frm2.Show();
            }
            else
            {
                epvIngresar.SetError(txtContraseña, "Contraseña incorrecta, intente nuevamente.");
                txtContraseña.Focus();
                return;
            }
            epvIngresar.SetError(txtContraseña, "");
        }

        private void tsmAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Eduard Fernando Aristizábal Giraldo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmPlanteamiento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Almacén Superéxito, requiere realizar una aplicación para llevar el control de su inventario que contenga una interfaz gráfica de usuario que permita a través de opciones, registrar, eliminar productos y salir de la aplicación. Para el registro de productos se estos tipos de productos se requiere que se seleccionen de una lista desplegable al hacer el registro. La eliminación debe realizarse en el mismo orden de ingreso, cumpliendo así con el comportamiento de una Cola, es decir el primero que ingresa es el primero que sale, a través de la colección genérica Queue <T>. adicionalmente se requiere conocer el acumulado total del valor del inventario ingresado a la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {

        }
    }
}
