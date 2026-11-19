using System;

namespace Aula14
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

        public abstract void Ligar();

        public abstract void Desligar();
    }
}
