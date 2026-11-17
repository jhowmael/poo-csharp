using System;

class Aula04
{
    //Atributo da classe/Variável global
    int numero = 1;
    public Aula04()
    {
        int numero = 0;        
        Console.WriteLine(numero);

        teste();
    }

    void teste()
    {
        Console.WriteLine(numero);
    }
}