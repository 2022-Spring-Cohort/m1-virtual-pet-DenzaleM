using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    class Robot : Pet
    {
        public int Rust { get; set; }
        public Robot()
        {

            Rust = 7;

        }


        public override void Age()
        {
            base.Age();
            Rust++;

        }



    }    
}
