using Industrial_Tools.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Atributos del Pedido del cliente
namespace Industrial_Tools.Models
{
    public class DetalleCompraModel
    {
        public Ventas Venta { get; set; }
        public List<CarritoModel> Productos { get; set; }

        public DetalleCompraModel()
        {
            Venta = new Ventas();
            Productos = new List<CarritoModel>();
        }

    }
}