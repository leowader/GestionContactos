using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Presentacion
{
    public partial class FrmEmpresarial : Form
    {
        public FrmEmpresarial()
        {
            InitializeComponent();
        }
        ServicioContComercial servicio = new ServicioContComercial();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        FrmFamiliar FrmFamiliar =new FrmFamiliar();
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
        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarText(e);
        }
        public void Guardar()
        {
            if (txtNombre.Text==""||textNit.Text==""||textRazon.Text==""||textTel.Text==""||textCorreo.Text==""||textNit.Text=="")
            {
                MessageBox.Show("CUADRO DE TEXTO VACIO","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                var contactoComer = new ContactoComercial();
                contactoComer.Id = int.Parse(txtNombre.Text);
                contactoComer.Nombre = textName.Text;
                contactoComer.Telefono = textTel.Text;
                contactoComer.Nit = textNit.Text;
                contactoComer.RazonSocial = textRazon.Text;
                contactoComer.Correo = textCorreo.Text;
                var mensage = servicio.AgregarContacto(contactoComer);
                MessageBox.Show(mensage, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarList();
        }
        public void CargarList()
        {
            listaComercial.DataSource = servicio.MostrarContactos();
            listaComercial.DisplayMember = "Nombre";
            Nuevo();
        }

        private void listaComercial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrar(servicio.MostrarContactos()[listaComercial.SelectedIndex]);
        }
        void Mostrar(ContactoComercial contactoComercial)
        {
            txtNombre.Text = contactoComercial.Id.ToString();
            textName.Text = contactoComercial.Nombre;
            textTel.Text = contactoComercial.Telefono;
            textNit.Text = contactoComercial.Nit;
            textCorreo.Text = contactoComercial.Correo;
            textRazon.Text = contactoComercial.RazonSocial;
        }
        void Nuevo()
        {
            textName.Clear();
            txtNombre.Clear();
            textCorreo.Clear();
            textNit.Clear();
            textRazon.Clear();
            textTel.Clear();
        }
        public ContactoComercial ObtenerContacto()
        {
            Actualizar(servicio.MostrarContactos()[listaComercial.SelectedIndex]);
            var contactoViejo = new ContactoComercial();
            contactoViejo.Id = int.Parse(txtNombre.Text);
            contactoViejo.Nombre = textName.Text;
            contactoViejo.Telefono = textTel.Text;
            contactoViejo.Nit = textNit.Text;
            contactoViejo.Correo = textCorreo.Text;
            contactoViejo.RazonSocial = textRazon.Text;
            Nuevo();
            return contactoViejo;
        }

        private void FrmEmpresarial_Load(object sender, EventArgs e)
        {
            CargarList();
            CargarGrilla();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNum(e);
        }
        int indice;
        private void GrillaEmpresarial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
        void CargarGrilla()
        {
            GrillaEmpresarial.DataSource = servicio.MostrarContactos();
        }

        private void GrillaEmpresarial_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Mostrar(servicio.MostrarContactos()[e.RowIndex]);
            }
            catch (ArgumentOutOfRangeException Ar)
            {
                MessageBox.Show(Ar.Message);
            }
        }

        private void GrillaEmpresarial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar(servicio.MostrarContactos()[e.RowIndex]);
            tabPageDatos.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(textBuscar.Text);
        }
        void Buscar(string phone)
        {
            var lista = servicio.MostrarContactos();
            List<ContactoComercial> contactoComercials = new List<ContactoComercial>();
            foreach (var item in lista)
            {
                if (item.Telefono.Equals(phone))
                {
                    contactoComercials.Add(item);
                    GrillaEmpresarial.DataSource = contactoComercials;
                }
            }
            
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text == "")
            {
                CargarGrilla();
            }
        }
        public void Eliminar()
        {
            Entidad.ContactoComercial contacto = new ContactoComercial
            {
                Telefono = textTel.Text
            };
            var mesage = servicio.Eliminar(contacto.Telefono);
            MessageBox.Show(mesage, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Nuevo();
        }
        public void Actualizar(ContactoComercial contactoViejo)
        {
            var contactoNuevo = new ContactoComercial();
            contactoNuevo.Telefono = textTel.Text;
            contactoNuevo.Nombre = textName.Text;
            contactoNuevo.Id = int.Parse(txtNombre.Text);
            contactoNuevo.Nit =textNit.Text;
            contactoNuevo.RazonSocial = textRazon.Text;
            contactoNuevo.Correo = textCorreo.Text;
            var mesage = servicio.Editar(contactoViejo.Telefono, contactoViejo, contactoNuevo);
            MessageBox.Show(mesage, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EliminarStrip_Click(object sender, EventArgs e)
        {
            Eliminar();
            CargarGrilla();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerContacto();
            CargarGrilla();
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            CargarGrilla();
        }

        private void VerStrip_Click(object sender, EventArgs e)
        {
            tabPageDatos.Show();
        }
    }
}
