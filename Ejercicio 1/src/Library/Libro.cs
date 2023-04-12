using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        // public string LibrarySector { get ; set; }
        // public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        } 
    }
}

// tanto public string LibrarySector { get ; set; }, como public string LibraryShelve { get ; set; }, no deberían de pertenecer a esta clase (book) , sino que debería de existir unas clases separadas para cada una de ellas. Esto es debido a que, según el SRP, cada clase debe tener responsabilidad sobre una parte de la funcionalidad específica proporcionada por el software 


