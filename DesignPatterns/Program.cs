// See https://aka.ms/new-console-template for more information

using System.Net.Security;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

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

// ---Singleton
// var instance = Database.Instance();
// instance.Query("SELECT * FROM Products");
// var result = instance.Execute();
// Console.WriteLine(result);
//--------------

//-------STRUCTURAL PATTERNS--------------

//---Adapter---

// var roundHole = new RoundHole(5);
// var roundPeg = new RoundPeg(3);
//
// Console.WriteLine(roundHole.Fits(roundPeg));// true
//
// var smallAdapter = new SquarePegAdapter(new SquarePeg(5));
// var largeAdapter = new SquarePegAdapter(new SquarePeg(20));
//
// Console.WriteLine(roundHole.Fits(smallAdapter));// true
// Console.WriteLine(roundHole.Fits(largeAdapter));// false
//-------------

//---Bridge---
// var tv = new TV();
// var remote = new Remote(tv);
//
// remote.TogglePower();
//
// var radio = new Radio();
// var radioRemote = new AdvancedRemote(radio);
//
// radioRemote.Mute();
//------------

//---Composite---
//
// var graphics = new CompoundGraphic();
//
// var dots =new List<Dot>(){ new Dot(1,2), new Dot(2,3), new Dot(3,4) };
// var circles = new List<Circle>(){ new Circle(1,2,4), new Circle(2,3,5) , new Circle(3,4,6) };
// graphics.AddGraphics(dots);
// graphics.AddGraphics(circles);
//
// graphics.Draw();
//---------------

//---Decorator---
//
// var fileData = new FileDataSource("somefile.txt");
// var compressionDecorator = new CompressDecorator(fileData);
//
// var encryptionDecorator = new EncryptionDecorator(compressionDecorator);
// encryptionDecorator.WriteData([]);
//---------------

//---Facade---

//var converter = new VideoConverter();
//converter.Convert("filename", "mp4");
//------------

//---Flyweight---

// var forest = new Forest();
// forest.PlantTree(1,2,"Tree1", "Red", "Smooth");
// forest.PlantTree(2,2,"Tree2", "Blue", "Rough");
// forest.PlantTree(1,1,"Tree2", "Blue", "Rough");
// forest.PlantTree(3,4,"Tree1", "Red", "Smooth");
//
// forest.PlantTree(3,3,"Tree2", "Blue", "Rough");
// forest.Draw();
//---------------

//---Proxy---

var youtubLib = new ThirdPartyYoutubeLib();
var proxy = new CachedYoutube(youtubLib);

var videos = proxy.ListVideos();
Console.WriteLine("Videos: " + string.Join(", ", videos));
//-----------