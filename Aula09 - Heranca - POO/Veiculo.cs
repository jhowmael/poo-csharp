using System;

namespace Aula09
{
    public abstract class Veiculo
    {
        public TipoVeiculo Tipo { get; set; }
        public string Nome {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}
        protected bool ligado;
        public int Rodas {get; set;}
        public string Cor {get; set;}
        public int VelMax {get; set;}
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

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }

        public int Acelerar(int velocidade, int aceleracao)
        {
            if ((velocidade + aceleracao) > VelMax)
            {
                return VelMax;
            }

            return velocidade + aceleracao;
        }

        public int Reduzir(int velocidade, int reducao)
        {
            if ((velocidade - reducao) < 0)
            {
                return 0;
            }
            
            return velocidade - reducao;
        }
    }
}
