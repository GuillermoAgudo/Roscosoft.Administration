using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Roscosoft.Administration.Library.Entites
{
    [Table("New")]
    public class NewEntity
    {
        [Key]
        public int IdNew { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Language { get; set; }
        public DateTime PublishDate { get; set; }
        public string Category { get; set; }
    }
}
