using System;
class Aula_3
{
  static void Main(string[] args)
   {
     //DESENVOLVER UM FORMULARIO DE CADASTRO. O USUARIO DEVE INFORMAR NOME COMPLETO, TELEFONE, IDADE E REFEIÇÃO FAVORITA.
     //APOS ISSO, PROGRAMA DEVERA EXIBIR NA TELA TODAS A INFORMAÇÕES QUE O USUARIO DIGITOU.

     string apelido, nome, telefone, refeicao, ddd;
     int idade;

     

     Console.WriteLine("COMO DESEJA SER CHAMADO ?");
        apelido = Console.ReadLine();
     
     Console.WriteLine("INFORME SEU NOME COMPLETO:");
        nome =  Console.ReadLine();

     Console.WriteLine("INFORME SEU TELEFONE:");
        telefone =  Console.ReadLine();

        Console.WriteLine("QUAL O SEU DDD:");
         ddd = Console.ReadLine();   

     Console.WriteLine("QUAL SUA REFEIÇÃO FAVORITA ?");
        refeicao =  Console.ReadLine();

      Console.WriteLine($"Olá {apelido}, seu nome completo é {nome},");
      Console.WriteLine($"Sua refeição favorita é {refeicao}");         
      Console.WriteLine($"Entraremos em contatos com você atraves do número:({ddd}) {telefone}");

      Console.ReadLine();
       
      Console.Write("AGORA INFORME SUA IDADE:");
      idade = int.Parse(Console.ReadLine());

      if(idade == 60)
      {
         Console.WriteLine("Você é idoso.");
      }
      else if(idade >= 18)
      {
         Console.WriteLine("Você é maior de idade.");
      }
      else if(idade >= 25)
      {
         Console.WriteLine("Você é um adulto");
      }
      else
      {
        Console.WriteLine("Você não tem idade suficiente para poder prosseguir!"); 
      }





   }
}
