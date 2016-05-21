using System.ComponentModel.DataAnnotations.Schema;

namespace Xen.DataLayer.Entities
{
    [Table("Blog")]
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string FullBlog { get; set; }
        public string ShortBlog { get; set; }
        public string MainImage { get; set; }
    }
}