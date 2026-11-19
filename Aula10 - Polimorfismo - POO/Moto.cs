namespace Aula10
{
    public class Moto: Veiculo
    {
    public int VelMax { get; set; }
    public int velAtual;

        public Moto()
        {
            Tipo = TipoVeiculo.Moto;
        }

        public override void Acelerar(int aceleracao)
        {
            Console.WriteLine("Acelerando...");
            velAtual = velAtual + aceleracao;

            if (velAtual >= VelMax)
            {
                Console.WriteLine("Velocidade maxima atingida...");
                velAtual = VelMax;
            }   
            
            Console.WriteLine("Velocidade atual: " + velAtual);
        }
    }
}