using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatro
{
    internal class Pedido : IComparable<Pedido>
    {
        //constantes static
        private static int contador = 0;


        //atributos 
        private int numeroPedido;
        private double monto;
        private int prioridad;
        private Cliente clienteAsociado;   //Asociacion 
        private DateTime fechaCreacion;
        private string objeto;


        //constructores
        public Pedido(Cliente clienteinicial)

        {
            contador++;
            numeroPedido = contador;
            fechaCreacion = DateTime.Now;
            clienteAsociado = clienteinicial;
        }
        
        //propiedades
        public string Objeto { get { return objeto; } set { objeto = value; } }
        public int NumeroPedido { get { return numeroPedido; } }
        public double Monto { get { return monto; } }
        public bool TryMonto(string input)
        {
            double aux;
            if (!double.TryParse(input, out aux)) { return false; }

            monto = aux;
            return true;
            //Console...; while (!TryMonto(Console.ReadLine())){Console...;}
        }
        public int Prioridad { get { return prioridad; } }
        public bool TryPrioridad(string input)
        {
            int aux;
            if (!int.TryParse(input, out aux)) { return false; }
            if (aux < 1 || aux > 5) { return false; }

            prioridad = aux;
            return true;
        }//console..; while (!TryMonto(Console.ReadLine())){Console..;}


        public Cliente ClienteAsociado { get { return clienteAsociado; } }



        //metodos de interface
        public int CompareTo(Pedido other)
        {
            //compara por prioridad y lo guarda en resultado
            int resultado = this.Prioridad.CompareTo(other.Prioridad);
            //si empada compara por monto y lo guarda en resultado
            if (resultado == 0) { resultado = this.Monto.CompareTo(other.Monto); }
            //regresa el resultado de prioridad
            return resultado;
        }


        //metodo para mostarr informacion
        public string Mostrar()
        {
            return
        "El N° de pedidos es: " + numeroPedido.ToString() +
        "\n Con un monto de " + monto.ToString() +
        "\n Su prioridad es " + prioridad.ToString() +
        "\n que pedido: " + fechaCreacion.ToString() +
         "\n Es: " + objeto;


//            return
//$"Pedido #{numeroPedido}\n" +
//$"Cliente: {clienteAsociado.Nombre}\n" +
//$"Monto: {monto}\n" +
//$"Prioridad: {prioridad}\n" +
//$"Fecha: {fechaCreacion}\n" +
//$"Objeto: {objeto}";
        }
    }
}


  
