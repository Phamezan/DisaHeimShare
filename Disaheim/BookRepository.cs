//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Reflection.Metadata.BlobBuilder;

//namespace Disaheim
//{
//    public class BookRepository
//    {
//        private List<Book> books;

        
//        public void AddBook(Book book)
//        {
//            this.books.Add(book);
//        }

//        public Book GetBook(string itemId)
//        {
//            foreach (Book book in books)
//            {
//                if (book.ItemId == itemId)
//                {
//                    return book;
//                }
//            }
//            return null;
//        }

//        public double GetTotalValue()
//        {
//            Double total = 0;
//            foreach (Book book in books)
//            {
//                total += book.Price;
//            }
//            return total;
//        }
//        public BookRepository()
//        {
//            books = new List<Book>();
//        }
//    }
//}
