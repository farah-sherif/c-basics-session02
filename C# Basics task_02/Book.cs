using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics_task_02
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages} page";
        }
    }
}
