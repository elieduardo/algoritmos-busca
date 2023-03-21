namespace algoritmos_busca
{
    static class MetodosDeBusca
    {
        static int BuscaLinear(this IList<int> lista, int elementoProcurado)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == elementoProcurado)
                {
                    return i;
                }
            }

            return -1;
        }

        static int BuscaLinearOrdenada(this IList<int> lista, int elementoProcurado)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == elementoProcurado)
                {
                    return i;
                }
                else if (elementoProcurado < lista[i])
                {
                    return -1;
                }
            }

            return -1;
        }

        static int BuscaBinaria(this IList<int> lista, int elementoProcurado)
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
                    if (elementoProcurado < lista[meio])
                    {
                        inicio = meio + 1;
                    }
                    else
                    {
                        return meio;
                    }
                }
            }
            return -1;
        }
    }
}
