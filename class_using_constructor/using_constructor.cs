using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_c_sharp_4
{
    internal class using_constructor
    {

        public String book_name;
        public String title;
        public String description;
        public int page;


        //one way
      /*  public using_constructor(string  book_name, string title, string description, int page)
        {
            this.book_name = book_name;
            this.title = title;
            this.description = description;
            this.page = page;
        }
      */
        //2nd way
        public using_constructor(string c_book_name, string c_title, string c_description, int c_page)
        {
            book_name = c_book_name;
            title = c_title;
            description = c_description;
            page = c_page;
        }

        public using_constructor(string book_name, int page)
        {
            this.book_name = book_name;
            this.page = page;
        }

        public using_constructor( string  c_description)
        {
            
            description = c_description;
            
        }

    }
}
