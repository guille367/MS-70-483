using System;

namespace FirstProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Junp statements

            // GOTO: Salta a una sentencia etoqietada (o labeled)

            int [] arr = {1,2,3,4,5,6,7,8,9,10};
            foreach (var item in arr)
            {
                if(item == 8)
                    // Si va al bloque especificado, sale del bucle
                    goto asdasd;
                else {
                    // Console.WriteLine(item);
                }
            }

            asdasd:
            {
                // Console.WriteLine("asdasd");
                // Console.WriteLine("Esto es un bloque asdasd");
            }


            // goto en switchs
            // var consonante = "e";
            // switch(consonante)
            // {
            //     case "a":
            //         Console.Write("es consonante");
            //         break;
            //     case "e":
            //         goto case "a";
            //     case "i":
            //         goto case "a";
            //     case "o":
            //         goto case "a";
            //     case "u":
            //         goto case "a";
            //     case "p":
            //         Console.Write("es vocal");
            //         break;
            //     default:
            //         goto case "p";
            // }

            // break
            // corta la sentencia donde está siendo ejecutado

            foreach (var item in arr)
            {
                if(item == 3)
                    break;
                
                // Console.Write(item);
            }

            // continue
            // a diferencia del break, salta el bloque donde esta siendo ejecutado pero continua la sentencia

            foreach (var item in arr)
            {
                if(item == 3)
                    continue;
                
                // Console.Write(item);
            }

            // break
            // también es un salto de sentencia que vuelve al control de donde es llamado el método. 
            // Devuelve o no un valor dependiendo de la naturaleza del método
            
            var age = getAge();
            Console.WriteLine("La edad es {0}", age);

            // En este caso el finally se ejecutará igual
            try
            {
                Console.Write("try");
                return;
            }
            catch(Exception) 
            {
                Console.Write("e");
            }
            finally
            {
                Console.Write("Finally");
            }
        }

        static int getAge()
        {
            return 20;
        }
    }
}
