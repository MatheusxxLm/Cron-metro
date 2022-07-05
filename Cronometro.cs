using System;
using System.Globalization;
using System.Threading;

class Program
{

    
    static void Main(string[] args)
    {
        Menu();
    }
    
    static void Iniciar()
    {
        Console.WriteLine("****************");
        Console.WriteLine("escolha o tempo: ");
        
        int time = int.Parse(Console.ReadLine());
        int FinalTime = 0;

        while(FinalTime != time)
        {
            Console.Clear();
            FinalTime++;
            Console.WriteLine(FinalTime);
            Thread.Sleep(1000);
            
            if (FinalTime == time) { break; }
        }

        Console.Clear();
        Console.WriteLine("Cronômetro finalizado.");
        
        
    }
    static void Menu()
    {
        
        Console.WriteLine("Coloque a opção que deseja: ");
        Console.WriteLine("Opção 1: Iniciar.");
        Console.WriteLine("Opção 2: Fechar.");
        
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1: 
                Iniciar(); 
                break;

            case 2: 
                Console.WriteLine("Fim do Aplicativo."); 
                Environment.Exit(0);
                break;
        }
        

    }
    


}




