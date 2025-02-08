using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_3.models
{
    public class calculadora
    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
         public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
         public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x*y}");
        }
         public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void potencia(int x, int y)
        {
           double poten = Math.Pow(x, y);
           Console.WriteLine($"{x}^{y} = {poten}");
        }
        public void Sen(double angulo)
        {
            double radiano = angulo*Math.PI/180;
            double sen = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(sen, 4)}");
        }
         public void Cos(double angulo)
        {
            double radiano = angulo*Math.PI/180;
            double cos = Math.Cos(radiano);
            Console.WriteLine($"coseno de {angulo} = {Math.Round(cos, 4)}");
        }
         public void Tang(double angulo)
        {
            double radiano = angulo*Math.PI/180;
            double tang = Math.Tan(radiano);
            Console.WriteLine($"tangente de {angulo} = {Math.Round(tang, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A Raiz Quadrada de {x} é {raiz}");
        }
    }
}