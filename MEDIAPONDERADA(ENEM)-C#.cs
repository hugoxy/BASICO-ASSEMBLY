using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            float notapt, notamat, notacinatu,notacihuma,notared,pesopt, pesomat, pesocinatu, pesocihuma,pesored, mediaponderada, mediaponderadapt1, mediaponderadapt2;
            Console.WriteLine("Calcule sua media do ENEM em universidades que tem um maior peso em determinada materia!\n");

            Console.WriteLine("Qual sua nota em Linguagens, Códigos e suas Tecnologias:");
            notapt = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesopt = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota em Matemática e suas Tecnologias:");
            notamat = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesomat = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota em Ciências da Natureza e suas Tecnologias:");
            notacinatu = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesocinatu = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota em Ciências Humanas e suas Tecnologias:");
            notacihuma = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesocihuma = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua nota na redação:");
            notared = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o peso desta matéria?:");
            pesored = float.Parse(Console.ReadLine());

            mediaponderadapt1=(notapt*pesopt)+(notamat*pesomat)+(notacinatu*pesocinatu)+(notacihuma*pesocihuma)+(notared*pesored);
            mediaponderadapt2 = pesomat + pesopt + pesocinatu + pesocihuma + pesored;
            mediaponderada = mediaponderadapt1/mediaponderadapt2;
            Console.WriteLine("A sua média ponderada é:" + mediaponderada);
            Console.ReadKey();
        }
    }
}
