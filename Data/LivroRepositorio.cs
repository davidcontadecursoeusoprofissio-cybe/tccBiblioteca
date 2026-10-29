using tccBiblioteca.Models;
using tccBiblioteca.Data;
namespace tccBiblioteca.Data;

public class LivroRepositorio
{
    private readonly AppDbContext _context;

    public LivroRepositorio(AppDbContext context)
    {
        _context=context;
    }
    public List<Livro> puxarLivros()
    {
        return _context.Livros.ToList();
    }
    public void Adicionar(Livro livro)
    {
        _context.Livros.Add(livro);
        _context.SaveChanges();
    }
    public void Deletar(int id)
    {
        var livro = _context.Livros.Find(id);
        if (livro != null)
        {
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }
    }
}
