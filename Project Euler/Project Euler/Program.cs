using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
        # region Problema 1 - Resolvido
        
            //int soma = 0;

            //for (int cont=0; cont < 1000; cont++) 
            //{
            //    if (cont % 3 == 0 || cont % 5 == 0)
            //    {
            //        soma += cont;
            //    }

                
            //}
            //Console.WriteLine(soma);
        #endregion
        #region Problema 2 - Aberto
            //int valor1 = 1;
            //int valor2 = 2;
            //int valor3;
            //int soma = 3;
            //do
            //{
            //    valor3 = valor1 + valor2;
            //    valor1 = valor2;
            //    valor2 = valor3;
            //    soma += valor3;
            //} while (valor3 < 21);

            //Console.WriteLine(soma);
            #endregion
        #region Problema 3 - Falta depurar
            //Int64 a = 600851475143;
            //Int64 b = 1;
            //Int64 cc = 0;
            //do
            //{


            //    if (a % b == 0)
            //    {
            //        cc = b;
            //        b++;
            //    }
            //    else
            //    {
            //        b++;
            //    }


            //} while (b < a);

            //Console.WriteLine(cc);
            #endregion
        #region Problema 5 - Resolvido
            //Int64 a = 1;
            //int contador = 0;
            //Int64 numero;

            //do
            //{
            //    if (a % 1 == 0 & a % 2 == 0 & a % 3 == 0 & a % 4 == 0 & a % 5 == 0 & a % 6 == 0 & a % 7 == 0 & a % 8 == 0 & a % 9 == 0 & a % 10 == 0 & a % 11 == 0 & a % 12 == 0 & a % 13 == 0 & a % 14 == 0 & a % 15 == 0 & a % 16 == 0 & a % 17 == 0 & a % 18 == 0 & a % 19 == 0 & a % 20 == 0)
            //    {
            //        contador = 1;
            //        numero = a;
            //    }
            //    else
            //        a++;

            //}while(contador != 1);

            //Console.WriteLine(a);
            #endregion
          for (int cont=1; cont <= 10; cont++) 
          {
              Console.WriteLine(cont);
          }
         
            

            Console.ReadKey();
        }
    }
}
