using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public List<Amulet> Amulets;
        public List<Book> Books;
        public List<Course> Course;
        public Controller()
        {
            Amulets = new List<Amulet>();
            Books = new List<Book>();
            Course = new List<Course>();
        }

        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }

        public void AddToList(Course course)
        {
            Course.Add(course);
        }

    }
}
