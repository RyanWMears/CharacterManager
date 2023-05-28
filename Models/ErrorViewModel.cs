using System.ComponentModel.DataAnnotations;

namespace CharacterManager.Models
{
    public class ErrorViewModel
    {
        [Key]
        public string? ErrorId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(ErrorId);
    }
}