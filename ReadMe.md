# Virtual Pets Re-Imagined
## Overview
Do you remember Cyberpet? Tamagotchi? Digimon? Petz? Virtual pets like these were born in 1996. With your help, they will be reborn. Virtual Toys, Inc. wants you to build the next iteration of virtual pets to market to adults who enjoy updated versions of the toys and games they played in their youth.  This game will be like the virtual pets of 1996...but so much more. It’s Virtual Pets Re-Imagined with your own personal touch!

## General Requirements

Your Virtual Pet program must be a console application. The application must have a main menu where a user can create a pet. The pet must have a name and species. The pet will also feature properties such as hunger, boredom, and health. A user should be able to view these properties from the main menu. A user should also be able to interact with the pet. The pet will be affected by time and certain property values will change ([Timer Class Constructors](https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer.-ctor?view=net-5.0)).

Your application must then be adapted to include a Shelter that will house multiple pets. You can move the create a pet function to the Shelter or leave it as a part of the main program. From the Shelter menu options you should be able to interact with 1 pet, or all pets. You should be able to check on the status of 1 pet as well as all pets simultaneously.

Your application should also make use of the Virtual-Pet-Tests project and test each of your models and methods. Additionally, it will be expected that you have used Git best practices, including appropriate feature branch creation. You must include User stories either in this ReadMe file or on your GitHub project board.


---- 

## Iteration 1

- An interactive user interface
- Ability for players to enter the game, play as long as they’d like, and leave the game when they want
- Ability for players to enter a name and species for a pet
- Ability for players to see the current status of a pet, such as hunger, boredom, and health
- Ability for players to interact with pet, such as feed, play, and take to doctor
- As players interact with pet, the pet’s status changes
- As "time" ticks by, the pet's status changes negatively

### User Stories

Use this are to keep track of your User Stories or track them in the GitHub project board.

## Iteration 2

- Ability for players to admit pets into the shelter or adopt them out of the shelter
- Ability for players to see a list of all pets in the shelter
- Ability for players to see the current status of all pets at once, such as hunger, boredom, and health
- Ability for players to choose to interact with one pet or multiple pets, such as feed, play, and take to doctor

### User Stories

Use this are to keep track of your User Stories or track them in the GitHub project board.


## Iteration 3

- Player’s choice of adding, interacting, or adopting either organic or robotic pets
- As players interact with pets, the pet’s status changes differently for organic and robotic pets (overriding methods)
- As "time" ticks by, the pets'' status changes negatively. The passing of time is measured by how often the player interacts with the program.
- Eventually rename this INSTRUCTIONS.md and create your own README.md file with instructions on how to play the game

### User Stories

Use this are to keep track of your User Stories or track them in the GitHub project board.


## Grading
The VirtualPet.Tests project includes a PetTests class with completed tests. These are the tests that will prove that the code you write in the Pet class is correct. Therefore, it is the logical starting point! The first test Pet_Constructor_Should_Instantiate_Pet_Object() has been written for you, and it passes because you already have a Pet class and can create a Pet object. The remaining tests have been written, but are commented out. Uncomment the code of the first test and add source code to the Pet class to pass the test. Continue with the tests, one by one, and add code until all the tests pass. 

You should write your code by writing tests first. If you do so, each public method you write should have a unit test that covers its behavior. The test classes should also be well maintained and follow the principles of clean code. In order to receive a PASSING grade, all of the following principles must be met:

- The addition of a test class in the VirtualPet. Tests test every new class you add to your VirtualPet project.
- 75% of the public methods you add to any of your classes should be covered by unit tests.
- Tests include appropriate Arrange, Act, and Assert sections.
- All tests pass.
