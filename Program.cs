using Pattern_3.Patterns.Adapter;
using Pattern_3.Patterns.Adapter.Types;
using Pattern_3.Patterns.Command;
using Pattern_3.Patterns.Command.Commands;
using Pattern_3.Patterns.Command.Receiver;
using Pattern_3.Patterns.Strategy;
using Pattern_3.Patterns.Strategy.Strategies;


//Adapter
//Original
IWriter writer = new Original();

TypeMain typeMain = new();
typeMain.mainName = "Name 1";

writer.Write(typeMain);
Console.WriteLine("\n\n");
//Adapter

FeatureAdapter featureAdapter = new FeatureAdapter();

featureAdapter.Write(typeMain);

//Strategy
Strategy strat = new Strat1();
strat.performTask();
Strategy strat2 = new Strat2();
strat2.performTask();
Console.WriteLine("\n\n");
//Command

Invoker invoker = new Invoker();
Document document = new Document("Message");
Fan fan = new Fan();
invoker.setCommand(new ReadCommand(document));

invoker.executeCommand();

invoker.setCommand(new ToggleFanCommand(fan));

invoker.executeCommand();