namespace algoritmos_busca
{
    public class MetodosDeBusca
    {
        public void BuscaLinear(List<int> lista, int elementoProcurado)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == elementoProcurado)
                {
                    Console.WriteLine($"Encontrou {elementoProcurado} na posição {i}");
                    return;
                }
            }
            Console.WriteLine($"Não encontrou {elementoProcurado} na lista");

        }

        public void BuscaLinearOrdenada(List<int> lista, int elementoProcurado)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == elementoProcurado)
                {
                    Console.WriteLine($"Encotrou {elementoProcurado} na posição {i}");
                    return;
                }
                else if (elementoProcurado < lista[i])
                {
                    Console.WriteLine($"Não encontrou {elementoProcurado} na lista");
                    return;
                }
            }
            Console.WriteLine($"Não encontrou {elementoProcurado} na lista");
        }

        public void BuscaBinaria(List<int> lista, int elementoProcurado)
        {
            int inicio, meio, fim;
            inicio = 0;
            fim = lista.Count - 1;

            while (inicio <= fim)
            {
                meio = (inicio + fim) / 2;

                if (elementoProcurado < lista[meio])
                {
                    fim = meio - 1;
                }
                else
                {
                    if (elementoProcurado > lista[meio])
                    {
                        inicio = meio + 1;
                    }
                    else
                    {
                        Console.WriteLine($"Encontrou {elementoProcurado} na posição {meio}");
                        return;
                    }
                }
            }
            Console.WriteLine($"Não encontrou {elementoProcurado} na lista");
        }
    }
}
