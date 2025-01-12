// See https://aka.ms/new-console-template for more information

using System.Net.Security;
using DesignPatterns.Behavioral.ChainOfReponsibility;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
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
using Microsoft.VisualBasic.FileIO;
using Dialog = DesignPatterns.Behavioral.ChainOfReponsibility.Dialog;

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

// var youtubeLib = new ThirdPartyYoutubeLib();
// var proxy = new CachedYoutube(youtubeLib);
//
// var videos = proxy.ListVideos();
// Console.WriteLine("Videos: " + string.Join(", ", videos));
//-----------


//---Chain of Responsibility---

// var dialog = new Dialog("HelpDialog.Com");
// var panel = new Panel("Help Panel");
// var okButton = new Button("Ok");
// var cancelButton = new Button("Cancel");
// panel.AddChild(okButton);
// panel.AddChild(cancelButton);
// dialog.AddChild(panel);
// F1KeyPress();
// return;
//
//  void F1KeyPress()
// {
//     List<Component> componentsList = [dialog, panel, okButton, cancelButton];
//     
//     //simulating getting the component that is clicked
//     var component = componentsList[(new Random()).Next(componentsList.Count)]; 
//     component.ShowHelp();
// }

//---------------------------

//---Command---

//-------------

//---Iterator---
//
// ISocialNetwork socialNetwork = new Facebook();
// string profileId = "1234";
// SpamToFriends(socialNetwork, profileId, "Hello everyone!");
// return;
// void SpamToFriends(ISocialNetwork socialNetwork, string profileId, string message)
// {
//     var iterator = socialNetwork.CreateCoworkersIterator(profileId);
//     SocialSpammer.Send(iterator, message);
// }
//
// void SpamToCoworkers(ISocialNetwork socialNetwork, string profileId, string message)
// {
//     var iterator = socialNetwork.CreateCoworkersIterator(profileId);
//     SocialSpammer.Send(iterator, message);
// }
//--------------

//---Memento---


//-------------

//---Observer---

// Editor editor = new Editor();
// var emailListener = new EmailAlertListener();
// var loggingListener = new LoggingListener();
// editor.Subscribe(EventManager.SAVED, emailListener);
// editor.Subscribe(EventManager.OPENED, loggingListener);
//
// editor.OpenFile("file.txt");
// editor.SaveFile("file.txt");

//--------------

//---Strategy---

// var context = new Context(new AddStrategy());
//
// Console.WriteLine(context.Execute(1,3));
//
// context.SetStrategy(new MultiplyStrategy());
// Console.WriteLine(context.Execute(1,3));

//--------------