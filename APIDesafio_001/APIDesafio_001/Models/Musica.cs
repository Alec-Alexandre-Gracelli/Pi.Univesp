using System;
using System.ComponentModel.DataAnnotations;

namespace ApiDesafio001.Models
{
    public class Musica
    {
        public void Main(string[] args)
        {
            Guid g = Guid.NewGuid();
            Console.WriteLine(g.ToString(Nome));
            Console.ReadLine();
        }
        [Key]
        public string MusicaId { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [Required, MaxLength(100)]
        public string Artista { get; set; }
        [MaxLength(100)]
        public int Ano { get; set; }
        [MaxLength(100)]
        public int AvaliaçaoMusicaId { get; set; }
    }
}

