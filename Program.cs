using Pattern_3.Patterns.Adapter;
using Pattern_3.Patterns.Adapter.Types;


//Adapter
//Original
IWriter writer = new Original();

TypeMain typeMain = new();
typeMain.mainName = "Name 1";

writer.Write(typeMain);

//Adapter

FeatureAdapter featureAdapter = new FeatureAdapter();

featureAdapter.Write(typeMain);