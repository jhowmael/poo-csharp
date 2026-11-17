using System;

class Carro
{
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Cilindradas { get; set; }
    private int rodas = 4;
    private int portas = 4;
    private double velocidade;
    public bool ligado = false; 

    // Construtor
    public Carro(string marca, int ano, int cilindradas)
    {
        this.Marca = marca;
        this.Ano = ano;
        this.Cilindradas = cilindradas;

        Console.WriteLine($"Carro criado: {this.Marca}, Ano: {this.Ano}, {this.Cilindradas}cc");    
    }

    public void Ligar()
    {
        ligado = true;
        Console.WriteLine("Carro ligado: " + ligado);
    }

    public void Desligar()
    {
        ligado = false;
        Console.WriteLine("Carro ligado: " + ligado);
    }

    public void Acelerar(double aceleracao)
    {
        velocidade += aceleracao; 
        Console.WriteLine("Velocidade atual: " + velocidade + " km/h");
    }
}