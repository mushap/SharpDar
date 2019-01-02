using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit.Models
{
    class Author
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public string FullName => $"{Name} {SurName}";
    }
}
