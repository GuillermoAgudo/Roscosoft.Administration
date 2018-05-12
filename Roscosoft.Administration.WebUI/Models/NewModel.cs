using System;

namespace Roscosoft.Administration.WebUI.Models
{
    public class NewModel
    {
        public int IdNew { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Language { get; set; }
        public DateTime PublishDate { get; set; }
        public string Category { get; set; }
    }
}
