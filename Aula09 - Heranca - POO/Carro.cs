namespace Aula09
{
    public class Carro: Veiculo
    {
        public int Portas {get; set;}
        public int VelAtual {get; set;}

        public Carro(string marca, string modelo, int ano, string cor, int velMax)
        {
            Tipo = TipoVeiculo.Carro;
            Nome = $"{marca} {modelo} {ano}";
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Rodas = 4;
            Portas = 4;
            Cor = cor;
            VelMax = velMax;


            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Rodas: " + Rodas);
            Console.WriteLine("Portas: " + Portas);
            Console.WriteLine("Cor: " + Cor);


       
            Console.WriteLine("Velocidade Atual: " + VelAtual);
            Console.WriteLine("VelMax: " + VelMax);
        }

        public void Correr(int velocidade)
        {
        PegarStatusCarro();
            if(ligado == true){
                VelAtual = Acelerar(VelAtual, velocidade);
                Console.WriteLine("Acelerando..." );
            }
        }

        public void Freiar(int velocidade)
        {
            VelAtual = Reduzir(VelAtual, velocidade);
            Console.WriteLine("Reduzindo..." );
        }

        public void PegarStatusCarro(){
            if(this.ligado == true)
            {
                Console.WriteLine(Tipo + " Ligado.");
            }else{
                Console.WriteLine(Tipo + " Desligado.");
            }
        }
    }
}