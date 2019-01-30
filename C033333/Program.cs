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
            Countryside blue = new Countryside();
            blue.Launch();
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
        Village Temp;
       
        public void Launch()
        {
            First = Maple;
            Last = Ajax;
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousVillage = Maple; 
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null; 
            Ajax.nextVillage = Toronto;

            Console.WriteLine(this.displayMap());
        }

        public string displayMap()
        {
            string listOfCities = "";
            // we need to print ALL the cities in our Area
            
            listOfCities = listOfCities + First.VillageName + " ----- " ;
            Temp = First.nextVillage;
            listOfCities = listOfCities + Temp.VillageName+ " ----- ";

            return listOfCities;
        }
    }
}
