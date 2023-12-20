using System;

namespace autoescola
{
    internal class Program
    {

        static void Main(string[] args)
        {
          
            int respostaUm, respostaDois, respostaTres;
           
            

            Console.WriteLine("Responda com 1 ou 2 as questões a seguir: ");

            Console.WriteLine("O candidato passou no psicotécnico: ");
            respostaUm = int.Parse(Console.ReadLine());
            
            Console.WriteLine("O candidado passou na prova teorica:");
            respostaDois = int.Parse(Console.ReadLine());

            Console.WriteLine("O candidato passou na prova de direção:");
            respostaTres = int.Parse(Console.ReadLine());  

            if (respostaUm == 1 && respostaDois == 1 && respostaTres == 1)
            {
                Console.WriteLine("Candidato aprovado!!!");
            }
            else
            {
                Console.WriteLine("Candidato REPROVADO!!!!!!");
            }



        } 
    }
}
