using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Controller;


namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        ClienteController _controllerCliente;
        public Form1(ClienteController controllerCliente)
        {
            InitializeComponent();
            _controllerCliente = controllerCliente;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            Cliente found;
            found = _controllerCliente.BuscarCliente(TxtDni.Text);
            if(found != null)
            {
                lblName.Text = found.NombreCompleto.ToString();
                lblDni.Text = found.Dni;
                lblEmail.Text = found.Email;
                lblSocio.Text = found.Tipo.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CrearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
