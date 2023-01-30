using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
   public class DocumentProgram
    {
        public void GetOpenDocument ()
        {
            Console.WriteLine("Document Opened");
        }
        public virtual void GetEditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");

        }
        public virtual void GetSaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
}
