using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCSS.CORE.MODEL
{
    public class Knowledge : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Technology Tech { get; set; }

        [Required]
        public string Description { get; set; }

        public UInt16 Level { get; set; }

        public DateTime Since { get; set; }

        public bool active { get; set; }

        [ForeignKey("TechId")]
        public int TechId { get; set; }

    }
}
