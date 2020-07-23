using System.ComponentModel.DataAnnotations;

namespace CCSS.CORE.MODEL
{
    public class Technology : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
