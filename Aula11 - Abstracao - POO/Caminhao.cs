namespace Aula11
{
    public class Caminhao: Veiculo
    {
    public bool ligado;

      public Caminhao()
        {
            Tipo = TipoVeiculo.Caminhao;
        }

    public override void Ligar()
        {
            ligado = true;
        }
    
    public override void Desligar()
        {
            ligado = false;
        }
    
    }
}