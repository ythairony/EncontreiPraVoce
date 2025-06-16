using EncontreiPraVoce.Models;
using Microsoft.EntityFrameworkCore;

namespace EncontreiPraVoce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Cada DbSet representa uma tabela no banco de dados.
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<AcheiNaRuaPost> AcheiNaRuaPosts { get; set; }
        public DbSet<PerdiNaRuaPost> PerdiNaRuaPosts { get; set; }
        public DbSet<PerguntaConfirmacao> PerguntasConfirmacao { get; set; }
        public DbSet<OpcaoResposta> OpcoesResposta { get; set; }
    }
}