using System;

class Carro
{
    public string Marca { get; set; }
    public int Ano { get; set; }
    public int Cilindradas { get; set; }
    private int rodas = 4;
    private int portas = 4;
    private double Velocidade 
    { 
        get;
        set => field = value < 0 ? 0: value;
    }

    private bool Ligado { get; set; }

    // Construtor
    public Carro(string marca, int ano, int cilindradas)
    {
        this.Marca = marca;
        this.Ano = ano;
        this.Cilindradas = cilindradas;

        Console.WriteLine($"Carro criado: {this.Marca}, Ano: {this.Ano}, {this.Cilindradas}cc");    
    }

    private void Ligar()
    {
        this.Ligado = true;
        Console.WriteLine("Carro ligado: " + this.Ligado);
    }

    public void Desligar()
    {
        this.Ligado = false;
        Console.WriteLine("Carro ligado: " + this.Ligado);
    }

    private void Acelerar(double aceleracao)
    {
        Velocidade += aceleracao; 
        Console.WriteLine("Velocidade atual: " + this.Velocidade + " km/h");
    }


}