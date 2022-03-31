using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using busqueda_registros.DataAccessObject;

namespace busqueda_registros.UI
{
    public partial class FormClientes : Form
    {
        //PATRON SINGLETON
        private FormClientes()
        {
            InitializeComponent();
        }

        private static FormClientes Instancia = null;
        public static FormClientes ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FormClientes();
                Instancia.FormClosed += new FormClosedEventHandler(reset);
            }
            return Instancia;
        }
        // FIN SINGLETON
        private static void reset(object sender, FormClosedEventArgs e)
        {
            Instancia = null;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

            //MOSTRAR TODO
            VerRegistros("");
        }

        // CREAMOS METODO PARA MOSTRAR Y BUSCAR REGISTROS INSTANCIANDO LA CLASE ClienteDAO
        private void VerRegistros(string condicion)
        {
            ClienteDAO DAO = new ClienteDAO();
            dataGridView1.DataSource = DAO.VerRegistros(condicion);
        }

        // FILTRAR
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }
    }
}
