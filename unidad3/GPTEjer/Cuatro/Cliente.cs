using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatro
{
    internal class Cliente
    {
        //atributos
        private int idCliente;
        private string nombre;
        private int edad;
        private int cantidadPRealizados;
        private Pedido pp;
        private List<Pedido> pedidos ; //CLAVE creo una lista con los pedidos


        //constructor
        public Cliente(int idclienteInicial)
        {
            idCliente = idclienteInicial;
            pedidos = new List<Pedido>();   //instanceo la lista para que no tirre erro y creo la referencia al objeto
        }


        //propiedades
        public Pedido Pp { get { return pp; } set { pp = value; } }
        public IReadOnlyList<Pedido> Pedidos { get { return pedidos; } } //CLAVE
        public int IdCliente { get { return idCliente; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
       
        public int Edad { get { return edad; } }
        public bool TryEdad(string input)
        {
            int aux;
            if (!int.TryParse(input, out aux)) { return false; }
            edad = aux;
            return true;

        }
        public int CanPedidos { get { return cantidadPRealizados; } }
        public bool TryCanPedidos (string input)
        {
            int aux;
            if (!int.TryParse(input, out aux)) return false;
            if (aux <0 || aux > 6) return false;

             cantidadPRealizados = aux;
            return true;
        }


        //metodos
        public void RealizarPedido(Pedido p)
        {
            
            pedidos.Add(p);
        }
        public void OrdenarPedidos()
        {
            pedidos.Sort();
        }
    }
}
