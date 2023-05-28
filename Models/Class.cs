using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterManager.Models
{
    [Table("Classes")]
    public class Class
    {
        [Key]
        public Guid ClassId { get; set; }
        public string Name { get; set; }
        public int ClassLevel { get; set; }

        public Class() { }
        public Class(Guid classId, string name, int classLevel)
        {
            ClassId = new Guid();
            ClassId = classId;
            Name = name;
            ClassLevel = classLevel;
        }
    }
}
