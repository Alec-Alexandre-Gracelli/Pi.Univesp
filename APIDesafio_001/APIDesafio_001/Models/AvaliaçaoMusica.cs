using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ApiDesafio001.Models
{
    public class AvaliaçaoMusica
    {
        public AvaliaçaoMusica()
        {
            Musicas = new Collection<Musica>();
        }
        [Key]
        public int AvaliaçaoMusicaId { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [Required, MaxLength(100)]
        public int Nota { get; set; }
        [MaxLength(5)]
        public Collection<Musica> Musicas { get; set; }
    }
}
