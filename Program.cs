namespace livraria;

class Livro {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public double Preco { get; set; }

    public Livro(string titulo, string autor, int anoPublicacao, double preco) {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        Preco = preco;
    }
}

class Livraria {
    private List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro) {
        livros.Add(livro);
    }

    public void ListarLivros() {
        foreach (var livro in livros) {
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano de Publicação: {livro.AnoPublicacao}, Preço: R${livro.Preco}");
        }
    }
}

class Program {
    static void Main(string[] args) {
        Livraria livraria = new Livraria();

        // Adicionando alguns livros à livraria
        livraria.AdicionarLivro(new Livro("Dom Casmurro", "Machado de Assis", 1899, 25.99));
        livraria.AdicionarLivro(new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 35.50));
        livraria.AdicionarLivro(new Livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 1997, 29.90));

        // Listando os livros da livraria
        Console.WriteLine("Livros disponíveis na livraria:");
        livraria.ListarLivros();
    }
}
