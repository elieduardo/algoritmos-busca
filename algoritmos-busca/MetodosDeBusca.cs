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
            var listaAux = lista.OrdenarLista();

            for (int i = 0; i < listaAux.Count; i++)
            {
                if (listaAux[i] == elementoProcurado)
                {
                    Console.WriteLine($"Encotrou {elementoProcurado} na posição {i}");
                    return;
                }
                else if (elementoProcurado < listaAux[i])
                {
                    Console.WriteLine($"Não encontrou {elementoProcurado} na lista");
                    return;
                }
            }
            Console.WriteLine($"Não encontrou {elementoProcurado} na lista");
        }

        public void BuscaBinaria(List<int> lista, int elementoProcurado)
        {
            var listaAux = lista.OrdenarLista();

            int inicio, meio, fim;
            inicio = 0;
            fim = listaAux.Count - 1;

            while (inicio <= fim)
            {
                meio = (inicio + fim) / 2;

                if (elementoProcurado < listaAux[meio])
                {
                    fim = meio - 1;
                }
                else
                {
                    if (elementoProcurado > listaAux[meio])
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
