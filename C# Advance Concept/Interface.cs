using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class Interface
    {
        public string Note(string author)
        {
            string note = string.Empty;
            switch (author)
            {
                case "Code_Monkey":
                    note = "Interface allow us to define function and property without any implementation\n" +
                        "The interface works as a contract, it ensures when a class implement that interface, it must implement those function\n" +
                        "This allow you to have several different class that can be used the same way by using a common interface\n" +
                        "And you don't care what else that class is doing\n" +
                        "When you use it as an interface you can guarantee that it have those functions regardless what the rest of class is doing"
                        
                        ;
                    break;
                case 1:

            }
            


            return note;
        }



    }
}
    