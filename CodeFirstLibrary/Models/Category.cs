using System.Collections.Generic;

namespace CodeFirstLibrary.Models
{
    public class Category
    {


        public int Id { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public string Name { get; set; }


    }
}