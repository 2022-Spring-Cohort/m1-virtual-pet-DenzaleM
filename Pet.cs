using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {

        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }

        public int Boredom { get; set; }

        public int Health { get; set; }

        public Pet()
        {
            Hunger = 40;
            Boredom = 40;
            Health = 70;
        }


        public virtual void Feed()
        {

            Hunger -= 5;
        }

        public virtual void Play()
        {

            Boredom -= 5;
        }

        public virtual void Doctor()
        {
            Health += 5;

        }

        public virtual void Age()
        {

            this.Boredom++;
           this.Health--;
            this.Hunger++;
        }


        

        

    }
}
