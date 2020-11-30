using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookFactories
{
    public class ComicBook
    {
        public int BookID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Designer { get; set; }

        public DateTime PublishDate { get; set; }

        public string GenreID { get; set; }

        public string RatingID { get; set; }

        public string PublisherID { get; set; }
    }
}
