using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance_Concept
{
    internal class OOP
    {
        private void definition()
        {
            string BasicConcepts = "" +
                "So, to start with object oriented we must understand what is an object, and what is oriented is about" +
                "OBJECT IS A THING IN A REAL WORLD is that chair, that table, you, me anything could be an object" +
                "so, what is oriented mean, oriente means to direct something towards something" +
                "so the first thing is our code, or program, we direct it towards our object" +
                "so it basically mean programming focus on the object, the object here is a thing that our software interest in" +
                "it's the thing we want to store and process its data" +
                "it's an ENTITY" +
                "that is the meaning of object oriented in general";

            //  So this lead us to the four fundamental concepts of object oriented programming ;
            // Let's start with the first two, abstraction and encapsulation

            // a class is a blueprint, a class is a type, and we create an object from a class, an object is an instance of a class 

            string Abstraction_Encapsulation = "" +
                "the word abstraction means simplify reality, it means displaying only essential information, what is necessary" +
                "encapsulation is group related variable and function that operate on them into an object, and hide complexity" +

                "let say you have an employee class, we have the name and address public, and a function call validate() to validate the identity of that employee" +
                "so inside that employee, we create 2 more private complex function " +
                "that do the validate name, address for that employee and call it inside the validate() function" +
                "and so we can use that validation() function inside that class without needing to know how exactly they work " +
                //
                "abstraction happens during the design phase, and during execution phase, " +
                "encapsulation is used to to implement abstraction" +
                "encapsulation implement abstraction" +
                "" +
                "encapsulation and abstraction complement each other"+ 

                //
                "for example, a person can be represented as an object in a program. " +
                "We don't need to know all the details about a person, " +
                "like their blood type, their biological processes, their personal life etc... " +
                "Instead, we focus on the essential attributes and behaviors that define a person in the context of our software"
                ;

            string polymorphism = " " +
                "object can act differently under different condition"
                ;

            string inheritance = " " +
                ""
                ;
            /*
             
           "In the world of object-oriented programming, abstraction allows us to model real-world entities by capturing their essential characteristics and interactions. 
            It helps us create a simplified representation of complex systems, making it easier to understand and work with."

           "Take the concept of a 'Car' as another example. In an object-oriented program, a car can be an object with properties like 'color,' 'model,' and 'speed,' as well as behaviors like 'accelerate,' 'brake,' and 'turn.' We abstract away the internal complexities of how these actions are performed, focusing on the aspects relevant to our software."

           "By employing abstraction, we can create models that mirror the structure and behavior of real-world entities without getting bogged down in unnecessary details. This simplification not only enhances the clarity of our code but also facilitates the design and maintenance of complex systems."

      Encapsulation
           "Another key concept in object-oriented programming is encapsulation. It involves bundling the data (attributes) and the methods (functions) that operate on the data into a single unit known as a 'class.' A class serves as a blueprint for creating objects."

           "Encapsulation provides a way to organize and structure code, promoting modularity and reusability. It also helps protect the internal state of an object by restricting access to certain data and methods. This concept aligns with the idea of information hiding, where the implementation details are hidden from the external world, and only a well-defined interface is exposed."

           "For instance, consider a 'BankAccount' class. It encapsulates attributes like 'accountNumber' and 'balance,' along with methods like 'deposit' and 'withdraw.' Users interacting with this class only need to know how to use these methods and are not concerned with the underlying implementation details, fostering a clear separation of concerns."

           "In summary, encapsulation allows us to bundle data and methods together, providing a way to structure code, enhance security, and promote code reuse."

      Inheritance
           "Inheritance is a powerful mechanism in object-oriented programming that enables a new class (subclass or derived class) to inherit properties and behaviors from an existing class (superclass or base class). This promotes code reuse and establishes a relationship between classes."

           "Consider a 'Vehicle' class that includes common properties like 'speed' and 'fuel efficiency' as well as methods like 'start' and 'stop.' Using inheritance, we can create subclasses like 'Car' and 'Motorcycle' that inherit these attributes and methods. This avoids the need to duplicate code and allows us to extend or customize the functionality as needed."

           "Inheritance facilitates the creation of a hierarchy of classes, with each level inheriting from the one above. This hierarchy promotes code organization, enhances maintainability, and supports the concept of polymorphism, where objects of different classes can be treated interchangeably."

           "In summary, inheritance is a fundamental concept that enables code reuse and establishes relationships between classes in an object-oriented program."

      Polymorphism
           "Polymorphism, meaning 'many forms,' is a concept in object-oriented programming that allows objects of different classes to be treated as objects of a common base class. This flexibility enables code to work with objects in a more generalized manner, accommodating a variety of types."

           "An example of polymorphism is a program that operates on a 'Shape' class. The program can work with different shapes like 'Circle' or 'Rectangle' without knowing the specific type. Each shape class provides its own implementation of methods like 'calculateArea,' allowing for dynamic dispatch at runtime."

           "Polymorphism is often achieved through the use of interfaces or abstract classes, providing a way to define a common interface that multiple classes can implement. This promotes flexibility, extensibility, and code that can adapt to changing requirements without modification."

           "In summary, polymorphism enables objects of different types to be treated uniformly, enhancing code flexibility and supporting the creation of more adaptable and scalable systems."

      These fundamental concepts—abstraction, encapsulation, inheritance, and polymorphism—form the pillars of object-oriented programming, providing a framework for designing and building software that is modular, reusable, and adaptable to change."
             */
        }
    }
}
