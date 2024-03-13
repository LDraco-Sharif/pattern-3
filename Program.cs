using Pattern_3.Patterns.Adapter;
using Pattern_3.Patterns.Adapter.Types;
using Pattern_3.Patterns.Strategy;
using Pattern_3.Patterns.Strategy.Strategies;


//Adapter
//Original
IWriter writer = new Original();

TypeMain typeMain = new();
typeMain.mainName = "Name 1";

writer.Write(typeMain);

//Adapter

FeatureAdapter featureAdapter = new FeatureAdapter();

featureAdapter.Write(typeMain);

//Strategy
Strategy strat = new Strat1();
strat.performTask();
Strategy strat2 = new Strat2();
strat2.performTask();