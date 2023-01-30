using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class ProDocumentProgram : DocumentProgram
    {
        public void GetDocFormat()
        {
            Console.WriteLine(" Document Saved in doc format, for pdf format buy Expert packet");
        }
        public override void GetEditDocument()
        {
            base.GetEditDocument();
        }
        public override void GetSaveDocument()
        {
            base.GetSaveDocument();
        }

    }
}
