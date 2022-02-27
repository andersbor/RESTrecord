using System;

namespace RESTrecord.Models
{
    public class Book : IBook
    {
        public Book() {} // TODO not good

        public Book(IBook b)
        {
            Id = b.Id;
            Author = b.Author;
            Title = b.Title;
            Price = b.Price;
        }

        private string _title;
        public int Id { get; set; }

        public string Title
        {
            get => _title;
            set
            {
                if (value == null) throw new ArgumentNullException("Title");
                if (value.Length < 1) throw new ArgumentException("title is empty");
                _title = value;
            }
        }

        public string Author { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Id + " " + Author + " " + Title + " " + Price;
        }
    }
}
