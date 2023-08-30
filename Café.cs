using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraG2_2024_1
{
    internal class Café : Expendedora

    {

        #region Propiedades
        public override byte Temperatura {
            get => base.Temperatura;
            set
            {
                if(50 < value && value < 60)
                    temperatura = value; //limites de escritura
                else
                    temperatura = 60;


            }
                
                
                }
       
        
        #endregion
        public Café()
        {
            Saludar();
            Temperatura = 60;
            Console.WriteLine("Temperatura: {0}",Temperatura);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            Precio = 10;
            MostrarPrecio(codigo);
        }

        public Café (bool Mantenmiento)
        {
            if(Mantenmiento)    
            Console.WriteLine("Entrando a modo mantenimiento");
            else
                Saludar();
        }
        public Café(int CantidadProductos)
        {
            Console.WriteLine("La expendedora de café contiene {0}", CantidadProductos);

        }

        #region Metodos
        public override string MostrarProducto()
        {
            Console.WriteLine("AC: Americano \n 4D: Expresso");
            string codigo = Console.ReadLine();

            return codigo;
        }

        public override void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "4C":
                    Console.WriteLine("Precio ${0}",Precio+3);
                    break;

                case "4D":
                    Console.WriteLine("Precio ${0}", Precio+6);
                    break;

            }
        }

        #endregion


    }
}
