using System;
using System.Collections.Generic;
using System.Text;

namespace ToolKit
{
  public class Interpolation
    {
       
        public string InterpolationExample()
        {
            Author author = new Author();
            author.Name = "Mushap";
            author.SurName = "KIRIM";

            string info = $"This code write by {author.Name} {author.SurName}";

            return info;
        }

        //use @, when u use string and u want use new line 
        public string InterpolationHtml()
        {
            Author author = new Author();
            author.Name = "Mushap";
            author.SurName = "KIRIM";

            string html = $@"<b> {author.Name} {author.SurName}</b>";

            return html;
        }
       

        public string InterpolationWithClassData()
        {
            Author author = new Author();
            author.Name = "Mushap";
            author.SurName = "KIRIM";

            return author.FullName;
        }

    }


    public class Author
    {
        public string Name { get; set; }
        public string  SurName { get; set; }

        public string FullName => $"{Name} {SurName}";

    }
}
