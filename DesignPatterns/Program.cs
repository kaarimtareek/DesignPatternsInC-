// See https://aka.ms/new-console-template for more information

using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;

Console.WriteLine("Hello World!");
//---Creational patterns---




// ---Factory Method---
// Dialog dialogA = new DialogA();
// dialogA.SomeOperation(); // Prints => Product A
// Dialog dialogB = new DialogB();
// dialogB.SomeOperation(); // Prints => Product B
// int numberA = dialogA.ReturnNumber(10); 
// Console.WriteLine($"numberA: {numberA}"); // Prints => 20 
// int numberB = dialogB.ReturnNumber(10);
// Console.WriteLine($"numberB: {numberB}"); // Prints => 0
// Dialog dialog = new Dialog();
// dialog.SomeOperation(); // Prints => Default product
// int number = dialog.ReturnNumber(10);
// Console.WriteLine($"number: {number}"); // Prints => 10
//--------------------

// ---Abstract Factory---
// var winFactory = new WinFactory();
// var button = winFactory.CreateButton();
// var checkBox = winFactory.CreateCheckBox();
// button.OnClick(); // Prints => winbutton clicked
// checkBox.OnClick(); // Prints => winbutton clicked

/*--------------------------------------------------------------
 * ---Difference between Abstract factory and factory method---
 * the factory method constructs and return a variation of the object
 * on the other hand, the abstract factory return a variation of related objects.
 *--------------------------------------------------------------
 */
 
// ---Builder--- 
// var director = new Director();
// var builder = new CarBuilder();
//
// director.BuildSportCar(builder);
// var car = builder.GetResult();
// var manualBuilder = new CarManualBuilder();
// director.BuildSuvCar(manualBuilder);
// var manual = manualBuilder.GetResult();
// Console.WriteLine(car);
// Console.WriteLine(manual);
//----------------

