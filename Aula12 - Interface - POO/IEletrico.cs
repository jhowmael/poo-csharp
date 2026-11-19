namespace Aula12
{
    public interface IEletrico
    {
        public int Bateria{get; set;}
        public void CarregarBateria(int carga);
    }
}