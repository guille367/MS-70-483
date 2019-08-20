using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Named arguments
            // Permiten llamar a los métodos con los parámetros en el orden que querramos
            var resDivision = division(4,2);
            var resNamedDivision = division(divisor: 2, dividendo: 4);

            // Console.WriteLine(resDivision == resNamedDivision);

            // Optional argument
            var resOptionalDivision = division(4);
            var resOptionalDivisionArgumentado = division(4, 3);
            // Console.WriteLine(resOptionalDivision);
            // Console.WriteLine(resOptionalDivisionArgumentado);

            // Pasar parámetros por referencia
            // cuando se pasa un valor por referencia, cualquier cambio del parámetro que se haga dentro del método
            // se va a ver reflejado en el valor

            var referencia = 2;
            // Console.WriteLine(referencia);
            modificarRef(ref referencia);
            // Console.WriteLine(referencia);

            // También podemos usar la keyword out, que es lo mismo que el ref pero con un argumento no inicializado
            // se usa también para devolver más de un valor
            int j;
            int d;

            devolverConOut(out j,out d);
            // Console.WriteLine("Los valores se modificaron y fueron {0} y {1}", j, d);

            // Array Params
            // Se pueden pamrametrizar un array de argumentos si son más de uno e indefinidos
            var suma = undefinedSumParams(1,2,3,4,5);
            // Console.WriteLine(suma);

            // no debería haber más de un argumento si se recibe este tipo de parámetros
            // en el caso de que ocurra, el array de parámetros debería ser el último de la lista
            var probando = pruebaVar(3);
            // Console.WriteLine(probando);

            Console.WriteLine(isNull(null));
        }

        static bool isNull(string name)
        {
            return name == null ? true : false;
        }

        static double division(int dividendo, int divisor = 2) 
        {
            double res = (double)(dividendo / divisor);
            return res;
        }

        static void modificarRef(ref int d)
        {
            d += 2;
        }

        static void devolverConOut(out int d, out int q)
        {
            d = 2;
            q = 1;
        }

        static int undefinedSumParams(params int[] args)
        {
            var res = 0;
            foreach (var item in args)
            {
                res += item;
            }
            return res;
        }

        static dynamic pruebaVar(int arg)
        {
            if(arg == 1)
            {
                int res = 10;
                return res;
            }
            else if(arg == 2)
            {
                float res = 10.5f;
                return res;
            }
            else 
            {
                string res = "resultado";
                return res;
            }
        }
    }
}
