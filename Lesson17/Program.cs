using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson17
{
 

    internal class Program
    {
       
        static void Main(string[] args)
        {
            
        }
    }
    class Book: ILibraryManager
    {
        List<Book> BookList = new List<Book>();
       
        public string Name { get; set; }
        public string Author { get; set; }

        public int PageCount { get; set; }
         
        public string Genre { get; set; }
     

        void ILibraryManager.BookSelect(string name, string Genre, string author, int Page)
        {
            Console.WriteLine(name + " " + Genre + " " + " " + author + " " + Page);
        }

       
        public void Add(string name, string Genre, string author, int Page)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Name != name)
                {
                    BookList[i].Add(name, Genre, author, Page);
                }
            }
        }

        public void  Show(string name)
        {
         
         for(int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Name != name)
                {
                    Console.WriteLine(name+" Adinda Kitab Yoxdur");
                }
                else
                {
                    Console.WriteLine(BookList[i]);
                }
            }
           
        }

        public void Search(string search)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Name == search)
                {
                    Console.WriteLine(BookList[i]);
                }
            }
        }

        public void Filter(string filter, string genre)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Genre==filter|| BookList[i].Genre==genre)
                {
                    Console.WriteLine(BookList[i]);
                }
            }
        }
    }

    interface ILibraryManager
    {
        void BookSelect(string name, string Genre, string author, int Page);
        void Add(string name, string Genre, string author, int Page);
        void Show(string name);
        void Search(string search);
        void Filter(string filter,string genre);

    }
}
