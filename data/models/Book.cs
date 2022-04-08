using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.data.models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Authour { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string  Category { get; set; }
        public bool isBorrowed { get; set; }
    }
}
