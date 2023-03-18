namespace algoritmos_busca
{
    static class Uteis
    {

        static IList<int> OrdenarLista(this IList<int> lista)
        {
            return lista.OrderBy(x => x).ToList();
        }

        static IList<int> DivideLista(this IList<int> lista, int elementoProcurado)
        {
            return lista;
        }
    }
}
