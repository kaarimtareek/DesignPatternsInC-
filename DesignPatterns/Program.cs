// See https://aka.ms/new-console-template for more information

using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;

Console.WriteLine("Hello World!");

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
