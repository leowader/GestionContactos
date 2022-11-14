using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmFamiliar : Form
    {
        public FrmFamiliar()
        {
            InitializeComponent();
        }
        int indice;
        Logica.ServicioContPersonal ServicioContPersonal = new Logica.ServicioContPersonal();
        public void ValidarText(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 130 && e.KeyChar <= 235))
            {
                MessageBox.Show("SOLO SE PERMITEN LETRAS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        public void ValidarNum(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNum(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarText(e);
        }
        public void Eliminar()
        {
            Entidad.ContactoPersonal contacto = new ContactoPersonal
            {
                Telefono = txtTelefono.Text
            };
            var mesage =ServicioContPersonal.Eliminar(contacto.Telefono);
            MessageBox.Show(mesage,"INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Nuevo();
        }
        public void Actualizar(ContactoPersonal contactoViejo)
        {
            var contactoNuevo = new ContactoPersonal();
            contactoNuevo.Telefono = txtTelefono.Text;
            contactoNuevo.Nombre = txtNombre.Text;
            contactoNuevo.Id = int.Parse(textId.Text);
            contactoNuevo.FechaNacimiento = DateTime.Parse(dtiFecha.Text);
            var mesage=ServicioContPersonal.Editar(contactoViejo.Telefono, contactoViejo, contactoNuevo);
            MessageBox.Show(mesage, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Guardar()
        {
            if (txtNombre.Text == ""|| txtTelefono.Text == ""|| textId.Text == "")
            {
                MessageBox.Show("CUADRO DE TEXTO VACIO", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var contacto = new ContactoPersonal();
                contacto.Id = int.Parse(textId.Text);
                contacto.Nombre = txtNombre.Text;
                contacto.Telefono = txtTelefono.Text;
                contacto.FechaNacimiento = DateTime.Parse(dtiFecha.Text);
                var Mesage = ServicioContPersonal.AgregarContacto(contacto);
                MessageBox.Show(Mesage, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public ContactoPersonal obtenerContacto()
        {
            Actualizar(ServicioContPersonal.MostrarContactos()[lista.SelectedIndex]);
            var contactoViejo = new ContactoPersonal();
            contactoViejo.Id = int.Parse(textId.Text);
            contactoViejo.Nombre = txtNombre.Text;
            contactoViejo.Telefono = txtTelefono.Text;
            contactoViejo.FechaNacimiento = DateTime.Parse(dtiFecha.Text);
            Nuevo();
            return contactoViejo;
        }
        void CargarGrilla()
        {
            GrillaFamiliar.Rows.Clear();
            var contactos = ServicioContPersonal.MostrarContactos();
            foreach (var item in contactos)
            {
                int n = GrillaFamiliar.Rows.Add();
                GrillaFamiliar.Rows[n].Cells[0].Value = item.Id;
                GrillaFamiliar.Rows[n].Cells[1].Value = item.Nombre;
                GrillaFamiliar.Rows[n].Cells[2].Value = item.Telefono;
                GrillaFamiliar.Rows[n].Cells[3].Value = item.FechaNacimiento;
            }
        }
        void CargarBuscar(string telefono)
        {
            var lista = ServicioContPersonal.MostrarContactos();
            foreach (var item in lista)
            {
                if (item.Telefono.Equals(telefono))
                {
                    int n=GrillaFamiliar.Rows.Add();
                    GrillaFamiliar.Rows[n].Cells[0].Value = item.Id;
                    GrillaFamiliar.Rows[n].Cells[1].Value = item.Nombre;
                    GrillaFamiliar.Rows[n].Cells[2].Value = item.Telefono;
                    GrillaFamiliar.Rows[n].Cells[3].Value = item.FechaNacimiento;
                }
            }
        }
        public void Mostrar(Entidad.ContactoPersonal contactoPersonal)
        {
            textId.Text= contactoPersonal.Id.ToString();
            txtNombre.Text = contactoPersonal.Nombre;
            txtTelefono.Text = contactoPersonal.Telefono;
            dtiFecha.Value = contactoPersonal.FechaNacimiento;
        }
        void CargarLista()
        {
            lista.DataSource = ServicioContPersonal.MostrarContactos();
            lista.DisplayMember = "Nombre";
            Nuevo();
        }
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrar(ServicioContPersonal.MostrarContactos()[lista.SelectedIndex]);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {

            Guardar();
            CargarLista();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarLista();
            Nuevo();
        }

        private void FrmFamiliar_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarGrilla();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        void Nuevo()
        {
            textId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            dtiFecha.Text="";
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            obtenerContacto();
            CargarLista();
        }
        private void GrillaFamiliar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar(ServicioContPersonal.MostrarContactos()[e.RowIndex]);
            tabPageDatos.Show();
        }
        private void GrillaFamiliar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
        private void GrillaFamiliar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Mostrar(ServicioContPersonal.MostrarContactos()[e.RowIndex]);
        }
        private void EliminarClick_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarGrilla();
        }
        private void tabControl_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void ActualizarClic_Click(object sender, EventArgs e)
        {
            tabPageDatos.Show();
            //Actualizar(ServicioContPersonal.MostrarContactos()[lista.SelectedIndex]);
            CargarGrilla();
        }
        private void VerClick_Click(object sender, EventArgs e)
        {
            tabPageDatos.Show();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaFamiliar.Rows.Clear();
            CargarBuscar(textFiltro.Text);
        }
        private void textFiltro_TextChanged(object sender, EventArgs e)
        {
            if (textFiltro.Text=="")
            {
                CargarGrilla();
            }
        }
    }
}
