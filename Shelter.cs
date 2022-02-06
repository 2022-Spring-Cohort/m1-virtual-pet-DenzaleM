using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
   public class Shelter
    {
        public List<Pet>listsofpet { get; set; }


        public Shelter()
        {

            listsofpet = new List<Pet>();

        }

        public void Add(Pet newPet )
        {
            listsofpet.Add(newPet);

        }


        public void Remove(int i)
        {
            listsofpet.RemoveAt(i);

        }

        public int SelectPet()
        {
            Console.WriteLine("Select a pet to work with:");
            int index = 1;
            foreach(Pet pet in listsofpet)
            {
                Console.WriteLine(index + "  " + pet.Name + "  " + pet.Species);

            }

            return Convert.ToInt32(Console.ReadLine());
        }

        public  void Print()
        {
            int index = 1;
            foreach( Pet pet in listsofpet)
            {

                Console.WriteLine(index + "Pet name :" + pet.Name + "\nHunger: " + pet.Hunger + "\nBoredom: " + pet.Boredom + " \nHealth: " + pet.Health + "\nSpecies: " + pet.Species + "\n");
            }

        }

    }


}
