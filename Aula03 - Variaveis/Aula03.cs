using System;

class Aula03 {
    
    static void Main()
    {
        //Variáveis explicitas
        //Tipos primitivos
        string texto = "Jonatan";
        int numeroInteiro = 25;
        double numeroQuebrado = 90.500;

        //Variaveis compiler-interface
        var nome = "Jonatan";
        var idade = 25;
        var peso = 90.500;

        Console.WriteLine($"Olá {texto} você tem {numeroInteiro} anos e pesa {numeroQuebrado} kilos");
        Console.WriteLine("Olá " + texto + " você tem " + numeroInteiro + " anos e pesa " + numeroQuebrado + " kilos");
        Console.WriteLine($"Olá {nome} você tem {idade} anos e pesa {peso} kilos");
        Console.WriteLine("Olá " + nome + " você tem " + idade + " anos e pesa " + peso + " kilos");
    }
}