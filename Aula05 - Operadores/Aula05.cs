using System;

class Aula05
{

    public Aula05(double numA, double numB)
    {
        double soma = numA + numB;
        double mutiplicacao = numA * numB;
        double divisao = numA / numB;
        bool numAMaior = numA > numB;


        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resultado soma: " + soma);
        Console.WriteLine("Resultado multiplicacao: " + mutiplicacao);
        Console.WriteLine("Resultado divisao: " + divisao);
        Console.WriteLine("Resultado comparação se primeiro numero é maior que o segundo: " + numAMaior);
        Console.WriteLine("Resultado incremento: " + (++numA));
        Console.WriteLine("Resultado decremento: " + (--numA));
    }
}