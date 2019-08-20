using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //Conversión implícita

            // Se encarga de hacerlo el compilador, no casteamos nada
            int i = 10;
            double e = i;
            
            // Program lo tiro a object, por lo tanto o es Object, 
            // perdiendo las cualidades de Program
            Object o = new Program();
            var q = new Program();

            // Conversión explícita

            // Cuando no podemos convertir de un tipo a otro, lo hacemos manualmente
            // Se puede perder información

            double dbl = 3.1467;
            // tenemos que especificar el tipo entre paréntesis
            int castedDouble = (int)dbl;
            // en éste caso se pierden los decimales
            
            string twelve = "22.2222";
            double doce = double.Parse(twelve);
            // Todo tpo de dato primitivo tiene su método Parse que convierte 
            // un string al tipo de dato primitivo que se indica
            
            // var es un tipo de dato implícito
            // El tipo de dato es definido en tiempo de compilación
            // var siempre tiene que ser inicializado
            try
            {
                var ten = "10";
                int diez = int.Parse(ten);
                // Console.Write(diez);
            }
            catch (System.Exception)
            {
                Console.Write("ERROR");
            }

            // Array es una colección de elementos los cualess pueden ser accedidos por índice
            // Hay tres tipos de arrays


            // Unidimesionales
            //string[] friends = new string[3]{ "a", 1.ToString(), "c" };
            string[] friends = { "a", 1.ToString(), "c" };
            
            int[] delimitado = new int[2];
            delimitado[0] = 1;
            delimitado[1] = 2;

            Console.Write(delimitado[1]);

            // Multidimensionales

            // int[,] multi = { {1}, {1,2} };
            // el primer valor indíca CANTIDAD DE FILAS (o cantidad de arrays) y el segundo CANTIDAD DE COLUMNAS (o cantidad de valores por array)
            int[,] multiD = new int[2,3] { {1,2,3}, {1,2,3} };
            Console.Write(multiD);
        }
    }
}
