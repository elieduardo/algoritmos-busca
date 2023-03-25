using System.Diagnostics;

namespace algoritmos_busca
{
    delegate void MetodoDelegate(List<int> lista, int elementoProcurado);

    class Program
    {
        const int VALOR_MINIMO = 0;
        const int VALOR_MAXIMO = 2000;
        const int QUANTIDADE_ELEMENTOS = 1000;
        const int ELEMENTO_PROCURADO = 520;
        static void Main()
        {
            Uteis uteis = new Uteis();
            MetodosDeBusca metodosDeBusca = new MetodosDeBusca();
            Stopwatch stopwatch = new Stopwatch();

            List<int> lista = uteis.GerarListaAleatoria(VALOR_MINIMO, VALOR_MAXIMO, QUANTIDADE_ELEMENTOS);
            List<int> listaOrdenada = lista.OrdenarLista();

            uteis.ImprimirInformacoes(lista, VALOR_MINIMO, VALOR_MAXIMO, ELEMENTO_PROCURADO);
            AnalisarTempoMetodo(metodosDeBusca.BuscaLinear, lista, ELEMENTO_PROCURADO);
            AnalisarTempoMetodo(metodosDeBusca.BuscaLinearOrdenada, listaOrdenada, ELEMENTO_PROCURADO);
            AnalisarTempoMetodo(metodosDeBusca.BuscaBinaria, listaOrdenada, ELEMENTO_PROCURADO);
        }

        public static void AnalisarTempoMetodo(MetodoDelegate metodo, List<int> lista, int elementoProcurado)
        {
            Console.WriteLine($"{metodo.Method.Name}");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            metodo(lista, elementoProcurado);
            stopwatch.Stop();

            long tempo = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            Console.WriteLine($"tempo de execução: {tempo} us\n");
        }
    }
}
