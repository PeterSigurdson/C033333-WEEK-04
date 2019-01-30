using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C033333
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Village
    {
        // Node is an ADT
        // what KIND of DATA do we need in a NODE?
        public Village nextVillage;
        public Village previousVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
    }
    class Countryside
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new Village();
        Village First;
        Village Last;
 
        public void Launch()
        {
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple; 
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null; 
            Ajax.nextVillage = Toronto;
        }
    }
}
