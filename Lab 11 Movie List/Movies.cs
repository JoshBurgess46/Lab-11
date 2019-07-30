using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_Movie_List
{
    public class Movies
    {
        
        public string title { get; set; }
        public string category { get; set; }

        public Movies(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
        
    }

}
