using System;

namespace PruebaTecnica
{
    public class Class1
    {
        public int MenorValor(int[] arreglo) {

            //En Visual Studio, construya una solución que contenga dos proyectos,
            //el primero una biblioteca de clases y el segundo uno de pruebas unitarias.
            //En el de clases, desarrolle una función que reciba un arreglo de enteros y
            //retorne el número consecutivo de menor valor, que sea mayor a cero y que no
            //exista en dicho arreglo.Por ejemplo, tenemos un arreglo = [7, 9, 5, 3, 2, 1, 3, 1],
            //la función debería retornar 4.
            //En el proyecto de prueba unitaria se debe validar que la función cumpla con lo requerido. Para ello, se debe validar con los siguientes arreglos: 

            Array.Sort(arreglo);
            int flagMaximo = arreglo[arreglo.Length - 1];
            if (flagMaximo < 0) 
            {
                return 1;
            }
            for (int i = 1; i < flagMaximo; i++)
            {
                if (Array.IndexOf(arreglo, i) == -1) 
                {
                    Console.WriteLine(i);
                    return i;
                }
                
                
            }
            return 0;
        
        }
    }
}
