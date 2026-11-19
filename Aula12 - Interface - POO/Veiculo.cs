namespace Aula12
{
    public abstract class Veiculo
    {

        public TipoVeiculo Tipo { get; set; }
        public int Ligado { get; set; }
        public enum TipoVeiculo
        {
            Carro,
            Moto,
            Caminhao
        }
        
        protected Veiculo()
        {
            if (Tipo != TipoVeiculo.Carro && Tipo != TipoVeiculo.Moto && Tipo != TipoVeiculo.Caminhao)
            {
                throw new ArgumentException("Apenas carro e moto s'ao permitidos");
            }
        }
    }
}