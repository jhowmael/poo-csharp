namespace Aula12
{
    public class CarroEletrico: Veiculo, IEletrico
    {
        public CarroEletrico()
        {
            Tipo = TipoVeiculo.Carro;
        }
        public int Bateria {get; set;}
        public void CarregarBateria(int carga)
        {
            if (Bateria + carga >= 100)
            {
                Bateria = 100;
            }
            else
            {
                Bateria = Bateria + carga;
            }
        }
    }
}