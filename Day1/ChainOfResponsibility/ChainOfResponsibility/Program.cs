// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");

HomeConfiguration config = new HomeConfiguration();
config.LocksOn = false;

LightsHanldler lights = new LightsHanldler();
LocksHandler locks = new LocksHandler();
AlarmHanlder alarm = new AlarmHanlder();

lights.SucceedWith(locks);
locks.SucceedWith(alarm);

lights.Handle(config);

Console.WriteLine( "Safe for trip ");


