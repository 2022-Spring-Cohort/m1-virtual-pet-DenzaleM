using System;
using System.Timers;

namespace template_csharp_virtual_pet

{
     class Program
    {
        static Shelter shelter = new Shelter();
        static Timer Timer;
        static Pet currentPet = new Pet();
       public static void Main(string[] args)
       {
          


            Console.WriteLine("Welcome to Virtual Pet.");

            bool isthinking = true;
            while (isthinking)
            {
                Console.WriteLine("pick an option");
                Console.WriteLine("1. Create a pet.");
            Console.WriteLine("2. Remove a pet.");
            Console.WriteLine("3. Interact with a pet");
            Console.WriteLine("4. View all pets.");
            Console.WriteLine("5. Quit");

          
            


            int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("What type of pet do you want?");
                        Console.WriteLine("1. a Organic pet");
                        Console.WriteLine("2. a virtual pet ");
                        int petpicker = Convert.ToInt32(Console.ReadLine());
                        switch (petpicker)
                        {
                            case 1:
                                shelter.Add(CreateOrganic());
                                break;
                            case 2:
                                shelter.Add(CreateRobot());
                                break;


                        }
                        break;
                    case 2:
                        int petToremove = shelter.SelectPet();
                        shelter.Remove(petToremove - 1);
                        break;
                    case 3:
                        int selectedPet = shelter.SelectPet();
                        currentPet = shelter.listsofpet[selectedPet - 1];
                        Interact();
                        break;
                    case 4:
                        shelter.Print();
                        break;
                    case 5:
                        isthinking = false;
                        break;



                }
            }




        }

        public static Organic CreateOrganic()
        {
            Console.WriteLine("What is the name of your pet?");
            string name = Console.ReadLine();


            Console.WriteLine("What is the species of your pet?");
            string species = Console.ReadLine();

            Console.WriteLine("how many grey hairs does your pet have? Numbers 1-10");

            int greyhairs = Convert.ToInt32(Console.ReadLine());

            return new Organic()  { Name = name, Species = species, Greyhairs=greyhairs };

        }

       public static void Life(Object source, ElapsedEventArgs e)
        {

            foreach (Pet pet in shelter.listsofpet)
                pet.Age();
        }

       
        public static void Interact()

        {
            
            bool isrunning = true;

            while (isrunning == true)

            {
                Timer = new System.Timers.Timer();
                Timer.Interval = 3000;

                Timer.Elapsed += Life;


                Timer.Start();

                Timer.AutoReset = true;

                Console.WriteLine("\n");

                Console.WriteLine("What would you like to do with the pet?");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Play with the pet");
                Console.WriteLine("3. Take the pet to the doctor");
                Console.WriteLine("4. quit");

                int activity = Convert.ToInt32(Console.ReadLine());

                switch (activity)
                {
                    case 1:
                        currentPet.Feed();
                        break;
                    case 2:
                        currentPet.Play();
                        break;
                    case 3:
                        currentPet.Doctor();
                        break;
                    case 4:
                        isrunning = false;
                        break;
                        
                        
                      

                }

                shelter.Print();

            }


           


        }


        public static Robot CreateRobot()
        {
            Console.WriteLine("What is the name of your pet?");
            string name = Console.ReadLine();


            Console.WriteLine("What is the species of your pet?");
            string species = Console.ReadLine();

           Console.WriteLine ("whats the amount of rust your robot has? Scale 1-10");
            int rust = Convert.ToInt32(Console.ReadLine());

            return new Robot() { Name = name, Species = species, Rust=rust};

            
        }

    }
}
