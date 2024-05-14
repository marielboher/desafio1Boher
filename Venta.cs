using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Boher
{
    public class Venta
    {
        public int Id {  get; set; }
        public string Comentarios { get; set; }

        public int IdUsuario { get; set; }

        public  Venta(int id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.IdUsuario = idUsuario;
            this.Comentarios = comentarios;
        }
    }
   
}
