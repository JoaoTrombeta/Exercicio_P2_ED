using System;

public class NoCarro
{
    public string NomeModelo { get; set; }
    public string FabricanteMontadora { get; set; }
    public DateTime DataFabricacao { get; set; }
    public double Preco { get; set; }
    public NoCarro Proximo { get; set; }

    public NoCarro(string nomeModelo, string fabricanteMontadora, DateTime dataFabricacao, double preco)
    {
        NomeModelo = nomeModelo;
        FabricanteMontadora = fabricanteMontadora;
        DataFabricacao = dataFabricacao;
        Preco = preco;
        Proximo = null;
    }
}

public class ListaCarros
{
    private NoCarro Cabeca;

    public ListaCarros()
    {
        Cabeca = null;
    }

    [cite_start]// d) Inserção de um elemento pelo fim [cite: 27]
    public void InserirNoFim(NoCarro novoCarro)
    {
        if (Cabeca == null)
        {
            Cabeca = novoCarro;
        }
        else
        {
            NoCarro atual = Cabeca;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo;
            }
            atual.Proximo = novoCarro;
        }
        Console.WriteLine($"Carro '{novoCarro.NomeModelo}' inserido no fim da lista.");
    }

    [cite_start]// e) Consulta (busca) de um elemento por nome do modelo do carro [cite: 28]
    public bool ConsultarCarroPorModelo(string nomeModeloBusca)
    {
        NoCarro atual = Cabeca;
        while (atual != null)
        {
            if (atual.NomeModelo.Equals(nomeModeloBusca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Carro '{nomeModeloBusca}' encontrado na lista:");
                Console.WriteLine($"  Fabricante: {atual.FabricanteMontadora}");
                Console.WriteLine($"  Data Fabricação: {atual.DataFabricacao.ToShortDateString()}");
                Console.WriteLine($"  Preço: R${atual.Preco:F2}");
                return true;
            }
            atual = atual.Proximo;
        }
        Console.WriteLine($"Carro '{nomeModeloBusca}' NÃO foi encontrado na lista.");
        return false;
    }

    [cite_start]// f) Remoção de um elemento pelo fim [cite: 29]
    public void RemoverNoFim()
    {
        if (Cabeca == null)
        {
            Console.WriteLine("A lista de carros está vazia. Nada para remover.");
            return;
        }

        if (Cabeca.Proximo == null) // Apenas um elemento na lista
        {
            Console.WriteLine($"Carro '{Cabeca.NomeModelo}' removido do fim da lista.");
            Cabeca = null;
            return;
        }

        NoCarro atual = Cabeca;
        NoCarro anterior = null;
        while (atual.Proximo != null)
        {
            anterior = atual;
            atual = atual.Proximo;
        }

        if (anterior != null)
        {
            anterior.Proximo = null;
            Console.WriteLine($"Carro '{atual.NomeModelo}' removido do fim da lista.");
        }
    }

    [cite_start]// g) Percurso (impressão) de todos os elementos e seus respectivos dados [cite: 30]
    public void ImprimirLista()
    {
        if (Cabeca == null)
        {
            Console.WriteLine("A lista de carros está vazia.");
            return;
        }

        Console.WriteLine("\n--- Carros na Lista ---");
        NoCarro atual = Cabeca;
        while (atual != null)
        {
            Console.WriteLine($"Modelo: {atual.NomeModelo}");
            Console.WriteLine($"  Fabricante: {atual.FabricanteMontadora}");
            Console.WriteLine($"  Data Fabricação: {atual.DataFabricacao.ToShortDateString()}");
            Console.WriteLine($"  Preço: R${atual.Preco:F2}");
            Console.WriteLine("-----------------------");
            atual = atual.Proximo;
        }
        Console.WriteLine("-----------------------\n");
    }
}
