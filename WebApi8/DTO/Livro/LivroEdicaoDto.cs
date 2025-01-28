using WebApi8.DTO.Livro.Vinculo;
using WebApi8.Models;

namespace WebApi8.DTO.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
