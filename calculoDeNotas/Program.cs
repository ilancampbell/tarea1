using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, tn, p;

            String e1, e2, e3, e4, e5;

            //primer estudiante
            Console.WriteLine("nombre del primer estudiante:");
            e1 = Console.ReadLine();

            Console.WriteLine("cual es la nota de " + e1 + "?");
            n1 = Convert.ToInt32(Console.ReadLine());

            //segundo estudiante
            Console.WriteLine("nombre del segundo estudiante:");
            e2 = Console.ReadLine();

            Console.WriteLine("cual es la nota de " + e2 + "?");
            n2 = Convert.ToInt32(Console.ReadLine());

            //tercer estudiante
            Console.WriteLine("nombre del tercer estudiante:");
            e3 = Console.ReadLine();

            Console.WriteLine("cual es la nota de " + e3 + "?");
            n3 = Convert.ToInt32(Console.ReadLine());

            //cuarto estudiante
            Console.WriteLine("nombre del cuarto estudiante:");
            e4 = Console.ReadLine();

            Console.WriteLine("cual es la nota de " + e4 + "?");
            n4 = Convert.ToInt32(Console.ReadLine());

            //quinto estudiante
            Console.WriteLine("nombre del quinto estudiante:");
            e5 = Console.ReadLine();

            Console.WriteLine("cual es la nota de " + e5 + "?");
            n5 = Convert.ToInt32(Console.ReadLine());

            tn = n1 + n2 + n3 + n4 + n5;
            p = tn / 5;


            Console.WriteLine("el promedio de las notas es {0}", p);

            //calculos para ver cual nota es mayor

            if (n1 > n2) ;
            if (n1 > n3) ;
            if (n1 > n4) ;
            if (n1 > n5) ;
            { Console.WriteLine("la nota mas alta es de " + e1 + " con nota de " + n1); }

                if (n2 > n1) ;
                if (n2 > n3) ;
                if (n2 > n4) ;
                if (n2 > n5) ;
                { Console.WriteLine("la nota mas alta es de " + e2 + " con nota de " + n2); }



                if (n3 > n1) ;
                if (n3 > n2) ;
                if (n3 > n4) ;
                if (n3 > n5) ;
                { Console.WriteLine("la nota mas alta es de " + e3 + " con nota de " + n3); }



                if (n4 > n1) ;
                if (n4 > n2) ;
                if (n4 > n3) ;
                if (n4 > n5) ;
                { Console.WriteLine("la nota mas alta es de " + e4 + " con nota de " + n4); }



                if (n5 > n1) ;
                if (n5 > n2) ;
                if (n5 > n3) ;
                if (n5 > n4) ;
                { Console.WriteLine("la nota mas alta es de " + e5 + " con nota de " + n5); }



                Console.ReadKey();
            }

        }
    }
