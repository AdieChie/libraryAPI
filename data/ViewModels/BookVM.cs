using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Authour { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
    }
}
