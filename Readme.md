# OOP Zoo

It's a simple console application with the goal to address principles of OOP.


## Classes diagram

![image](https://raw.githubusercontent.com/al1s/Zoo/master/class diagram.png)

## Requirements 
Using all 4 of the Object Oriented Principles (OOPs): 

- Build out the hierarchical class structure of a zoo within Visual Studio and a digital diagram. 
- There should be at least 3 layers of inheritance with at least 6 different types of animals.
- Prove that the OOP principles are being used by returning strings as necessary to prove that a methods were property implemented or inherited.
  - Examples include: Eat() Sleep() Sound() etc…
  - Other non-listed methods.

## Getting started

- Clone the repo;
- Build with `dotnet build --configuration Release`;
- Find the dll in `bin/Release` folder;
- Start with `dotnet Lab05_OOP-Zoo.dll`;

## Specs
The program (should) contain the following

- Have at least 3 different abstract classes
- Have at least 3 layers of inheritance
- Have at least 5 concrete animals
- Have at least 2 abstract methods (make sure you override them)
- Have at least 2 abstract Properties (make sure you override them)
- Have at least 2 virtual methods (make sure you override at least one of them)
- Have at least 2 virtual properties (make sure you override at least one of them)
- Test that each of your concrete animals exhibit the at least 2 appropriate behaviors given to them from a base class.

## OOP principles

- Encapsulation - hide implementation details, communicate by actions; `NameYourself()` hides the `Name` implementation and demonstrate just what was required.   
- Abstraction - expose only what is necessary to communicate with the object; `Eat()` is responsible for allowing to be eat eaten what supposed to be by an animals - turtles doesn't eat elephants.
- Inheritance - define the common behavior or state on the highest available level of abstraction, don't repeat yourself in concrete objects implementations. Abstract `Eatable` class combines every object that could be eaten by other animals.
- Polymorphism - group objects by upper class and invoke required behavior for every member of such group; The app groups all zoo animals into one group to feed them. 
- Interfaces - define a contract for objects to communicate with each other. `IScare` and `ICanBeScared` are defined in the app. First allows animals to scare visitors. Second defines the ability of the visitors to be scared.
