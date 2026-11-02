using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tccBiblioteca.Data;
using tccBiblioteca.Models;


namespace tccBiblioteca.Pages;

public class CadastroLivrosModel(LivroRepositorio repositorio): PageModel
{
    public IActionResult OnPost(int id, string titulo, string capa)
    {
        var livro = new Livro
        {
            Id = id,
            Titulo = titulo,
            CapaUrl = capa
        };
        repositorio.Adicionar(livro);
        return RedirectToPage("/Index");
    }
    
}
