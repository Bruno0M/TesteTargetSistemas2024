
static bool Fibonnaci(int sequencia)
{
    int numAnterior = 0, numPosterior = 1;

    for (int i = 0; i < sequencia; i++)
    {
        int auxiliar = numAnterior;
        numAnterior = numPosterior;
        numPosterior += auxiliar;

        if (sequencia == numPosterior)
        {
            return true;
        }
    }

    return numPosterior == sequencia;
}


int sequencia = 5;

if (Fibonnaci(sequencia))
{
    Console.WriteLine($"\nO numero {sequencia} pertence a sequencia");
}
else
{
    Console.WriteLine($"\nO numero {sequencia} nao pertence a sequencia");
}

Console.ReadKey();