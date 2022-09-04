namespace M6L4.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string AuthorFullName { get; set; }
        public double Price { get; set; }
        public int BooksSold { get; set; }
    }
}
