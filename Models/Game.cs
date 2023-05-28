using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public Guid GameId { get; set; }
        public string Name { get; set; }

        public Game() { }

        public Game(string name)
        {
            GameId = new Guid();
            Name = name;
        }
    }
}
