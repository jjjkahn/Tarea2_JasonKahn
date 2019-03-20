using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class carro
    {

        private string Marca ="";
        private char Transmision;
        private char Transaccion;
        private decimal Precio=0;

        //Constructor de la clase Carro con todos los detalles que debe tener cada venta de carro

        public carro(string _Marca, char _Transmision, char _Transaccion, decimal _Precio)
        {
            Marca = _Marca;
            Transmision = _Transmision;
            Transaccion = _Transaccion;
            Precio = _Precio;
        }


        //Setters and Getters
        public string Amarca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public char Atransmision
        {
            get { return Transmision; }
            set { Transmision = value; }
        }

        public char Atransaccion
        {
            get { return Transaccion; }
            set { Transaccion = value; }
        }

        public decimal Aprecio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        public string Printcarro()
        {
            string printCarro = "";

            printCarro = this.Transmision + ";" + this.Marca + ";" + this.Transaccion + ";" + this.Precio;

            return printCarro;
        }


    
}
}
