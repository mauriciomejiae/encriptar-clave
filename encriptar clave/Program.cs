using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encriptar_clave
{

    class Program
    {
        static void Main(string[] args)//funcion principal
        {
            int clave, dig1, dig2, dig3, dig4;  //declaración de variable tipo int
            Console.Title = "Punto 1: fase 2";//Esta instruccion es para ponerle titulo a la ventana de la consola.
            do
            {
                Console.Write("\n       UNIVERSIDAD NACIONAL ABIERTA Y A DISTANCIA");//la funcion Write basicamente lo que hace es mostrar en la consola la cadena de caracteres.
                Console.Write("\n              Trabajo colaborativo: Fase 2");
                Console.Write("\n                       Algorítmos");
                Console.Write("\n                      Problema:1");
                Console.Write("\n\n\n\n Bienvenido a un sencillo programa para encriptar la clave ");
                Console.Write("\n\n\n\tDigite su clave de 4 digitos: ");
                clave = int.Parse(Console.ReadLine()); //almacena valor en variable, la funcion Parse convierte el valor tipo caracter a numero entero.
                if (clave > 9999 || clave < 999)
                {
                    Console.Write("\n\t ¡La clave Debe ser de 4 digitos!");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                    Console.Clear();//Clear es la funcion para limpiar pantalla.
                }
            }
            while (clave > 9999 || clave < 999);
            //Encriptando
            dig1 = clave / 1000;
            dig2 = (clave - dig1 * 1000) / 100;
            dig3 = (clave - dig1 * 1000 - dig2 * 100) / 10;
            dig4 = clave - dig1 * 1000 - dig2 * 100 - dig3 * 10;
            Console.Write("\n\n\n\t\t La clave encriptada es: {0}", dig4 * 1000 + dig3 * 100 + dig2 * 10 + dig1);//{0} es una directiva para decirle a la consola donde debe mostrar el resultado.
            Console.Write("\n\t Presione una tecla para continuar...");
            Console.ReadKey();

        }
    }
}
