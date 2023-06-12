using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CharacterManager.Models
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public Guid GameId { get; set; }
        public string Name { get; set; }
        [AllowNull]
        [NotMapped]
        public virtual IList<Character> Characters { get; set; }

        public Game() {
            Name = string.Empty;
        }

        public Game(string name)
        {
            GameId = new Guid();
            Name = name;
        }
    }
}
