namespace algoritmos_busca
{
    public class Uteis
    {
        public List<int> GerarListaAleatoria(int minimo, int maximo, int quantidade)
        {
            List<int> lista = new List<int>();

            while (lista.Count < quantidade)
            {
                Random rand = new Random();
                var novoNumero = rand.Next(minimo, maximo);

                if (!lista.Contains(novoNumero))
                    lista.Add(novoNumero);
            }

            return lista;
        }

        public void ImprimirInformacoes(List<int> lista, int valorMinimo, int valorMaximo, int elementoProcurado)
        {
            Console.WriteLine($"Carga de {lista.Count} elementos, elemento procurado: {elementoProcurado}");
            Console.WriteLine($"Valor mínimo: {valorMinimo}, valor máximo: {valorMaximo}");
            Console.WriteLine($"Lista Gerada: {String.Join(",", lista)}");
            Console.WriteLine($"Lista Ordenada: {String.Join(",", lista.OrdenarLista())}\n");
        }
    }
}
