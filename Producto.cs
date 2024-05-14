﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Boher
{
    public  class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public double Costo { get; set; }

        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }

    }


}

