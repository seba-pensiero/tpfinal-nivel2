using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public Marcas Marca { get; set; }
        public Categorias Categoria { get; set; }
        public int IdCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public float Precio { get; set; }
    }
}
