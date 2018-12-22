using System;
using System.Collections.Generic;
using System.Text;

namespace ToolKit
{
    public class NameOfExample
    {
        public string AuthorInfo()
        {
            Author author = new Author();
            author.Name = "Mushap";
            author.SurName = "KIRIM";

            String info = $"{nameof(author.FullName)}:{author.FullName}";
            return info;
        }

    }
}
