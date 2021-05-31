using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Books
    {
  
            //Fields
            private string bookName;
            private double price;
            private string isbn;
            private string author;
            private int publishedYear;
            private List<string> similarBooks = new List<string>(); // why list ??

            //properties
            public string BookName { get => bookName; set => bookName = value; }
            public double Price { get => price; set => price = value; }
            public string Isbn { get => isbn; set => isbn = value; }
            public string Author { get => author; set => author = value; }

            public int PublishedYear { get => publishedYear; set => publishedYear = value; }

            //Question : Why you need extra work for ‘similarBooks’ filed ?? 
            public string SimiBooks
            {
                set
                {
                    // try n understand what is happening here--ask Manish.

                    StringBuilder sb = new StringBuilder(value);

                    sb.Length--;
                    sb.Remove(0, 1);

                    string[] otherbooks = sb.ToString().Split(';');
                    similarBooks = new List<string>(otherbooks);
                    similarBooks.Sort();
                }
            }

            public List<string> SimilarBooks
            {
                get
                {
                    similarBooks.Sort();
                    return similarBooks;
                }
            }


        }

    }
