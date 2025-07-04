using System; 

  

public class NoAluno 

{ 

    public int Idade { get; set; } 

    public NoAluno Proximo { get; set; } 

  

    public NoAluno(int idade) 

    { 

        Idade = idade; 

        Proximo = null; 

    } 

} 

  

public class ListaIdadesAlunos 

{ 

    private NoAluno Cabeca; 

  

    public ListaIdadesAlunos() 

    { 

        Cabeca = null; 

    } 

    [cite_start]

    public void InserirNoInicio(int idade) 

    { 

        NoAluno novoNo = new NoAluno(idade); 

        novoNo.Proximo = Cabeca; 

        Cabeca = novoNo; 

        Console.WriteLine($"Idade {idade} inserida no início da lista."); 

    } 

  

    [cite_start]

    public void ImprimirLista() 

    { 

        if (Cabeca == null) 

        { 

            Console.WriteLine("A lista de idades está vazia."); 

            return; 

        } 

        Console.Write("Idades na lista: "); 

        NoAluno atual = Cabeca; 

        while (atual != null) 

        { 

            Console.Write($"{atual.Idade} "); 

            atual = atual.Proximo; 

        } 

        Console.WriteLine(); 

    } 

    [cite_start]

    public bool ConsultarIdade(int idadeBusca) 

    { 

        NoAluno atual = Cabeca; 

        while (atual != null) 

        { 

            if (atual.Idade == idadeBusca) 

            { 

                Console.WriteLine($"A idade {idadeBusca} foi encontrada na lista."); 

                return true; 

            } 

            atual = atual.Proximo; 

        } 

        Console.WriteLine($"A idade {idadeBusca} NÃO foi encontrada na lista."); 

        return false; 

    } 

} 