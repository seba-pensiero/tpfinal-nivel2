using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Pensiero
{
    public partial class frmDetalles : Form

    {
        private Articulos articulo;
        public frmDetalles()
        {
            InitializeComponent();
        }

        public frmDetalles(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            txtDetCodArt.Text = articulo.Codigo;
            txtDetDesc.Text = articulo.Descripcion;
            txtDetCat.Text = articulo.Categoria.ToString();
            txtDetNombre.Text = articulo.Nombre;
            txtDetMarca.Text = articulo.Marca.ToString();
            txtDetPrecio.Text = articulo.Precio.ToString();
            cargarimagen(articulo.ImagenUrl);
        }

         private void cargarimagen(string imagen)
        {
            try
            {
                pbxDetalles.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxDetalles.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnDetallesSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
