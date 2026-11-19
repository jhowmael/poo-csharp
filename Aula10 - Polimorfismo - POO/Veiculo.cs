using System;

namespace Aula10
{
    public abstract class Veiculo
    {
        public TipoVeiculo Tipo { get; set; }
        public int VelAtual { get; set; }
        public enum TipoVeiculo
        {
            Carro,
            Moto
        }
        
        protected Veiculo()
        {
            if (Tipo != TipoVeiculo.Carro && Tipo != TipoVeiculo.Moto)
            {
                throw new ArgumentException("Apenas carro e moto s'ao permitidos");
            }
        }

        public virtual void Acelerar(int aceleracao)
        {
            VelAtual = VelAtual + aceleracao;
        }
    }
}
