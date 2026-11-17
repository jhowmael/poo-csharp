using System;

class Aula06
{
    public Aula06(double numA, double numB, double numC)
    {
        // ESTRUTURAS CONDICIONAIS (If / Else if / Else)
        if (numA > numB)
        {
            Console.WriteLine("Primeiro if: NumA é maior que numB");
        }

        if (numA < numB)
        {
            Console.WriteLine("Segundo if: NumA é menor que numB");
        }
        else
        {
            Console.WriteLine("Segundo if: NumA é maior ou igual a numB");
        }

        if (numC > numA && numC > numB)
        {
            Console.WriteLine("Terceiro if: NumC é o maior de todos");
        }
        else if (numC == numA || numC == numB)
        {
            Console.WriteLine("Else if: NumC é igual a um dos outros números");
        }
        else
        {
            Console.WriteLine("Else: NumC é menor que os demais (ou está no meio)");
        }

        // ==========================================
        // SWITCH CASE (Múltiplas escolhas)
        // ==========================================
        int opcao = (int)numA; // Convertendo para int para usar no switch
        Console.WriteLine($"\n--- Testando Switch (Baseado em numA = {opcao}) ---");
        switch (opcao)
        {
            case 0:
                Console.WriteLine("Switch: O valor inteiro de numA é 0.");
                break;
            case 1:
                Console.WriteLine("Switch: O valor inteiro de numA é 1.");
                break;
            default:
                Console.WriteLine("Switch: O valor inteiro de numA é outro número.");
                break;
        }

        // FOR (Loop contado)
        Console.WriteLine("\n--- Testando For ---");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"For - Contagem atual: {i}");
        }

        // FOREACH (Loop para percorrer coleções/arrays)
        Console.WriteLine("\n--- Testando Foreach ---");
        double[] meusNumeros = { numA, numB, numC };
        foreach (double numeroAtual in meusNumeros)
        {
            Console.WriteLine($"Foreach - Elemento do array: {numeroAtual}");
        }

        // WHILE (Loop com teste no início)
        Console.WriteLine("\n--- Testando While ---");
        int contadorWhile = 0;
        while (contadorWhile < 2)
        {
            Console.WriteLine($"While - Contador: {contadorWhile}");
            contadorWhile++; // Incrementa para evitar loop infinito
        }

        // DO-WHILE (Loop com teste no final)
        Console.WriteLine("\n--- Testando Do-While ---");
        int contadorDoWhile = 0;
        do
        {
            Console.WriteLine($"Do-While - Executa ao menos uma vez. Contador: {contadorDoWhile}");
            contadorDoWhile++;
        } while (contadorDoWhile < 1);
    }
}