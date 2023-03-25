namespace algoritmos_busca
{
    public static class ListExtensions
    {

        public static List<int> OrdenarLista(this List<int> lista)
            => lista.OrderBy(x => x).ToList();

        public static List<int> OrdenarListaBubbleSort(this List<int> lista)
        {
            int tamanho = lista.Count;
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
                }
            }

            return lista;
        }
    }
}
