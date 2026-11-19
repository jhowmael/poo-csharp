using Aula09;

Carro c1 = new Carro("Toyota", "Corolla", 2023, "Vermelho", 400);

c1.Ligar();

c1.Correr(200);
Console.WriteLine(c1.VelAtual);

c1.Freiar(50);
Console.WriteLine(c1.VelAtual);

