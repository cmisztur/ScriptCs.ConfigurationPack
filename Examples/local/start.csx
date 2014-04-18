
var configx = Require<Configx>();
var cfg = configx.Get();

foreach (ConnectionStringSettings cs in cfg.ConnectionStrings.ConnectionStrings)
{
  string name = cs.Name;
  string provider = cs.ProviderName;
  string connectionString = cs.ConnectionString;

  Console.WriteLine("Name:               {0}", name);
  Console.WriteLine("Connection string:  {0}", connectionString);
  Console.WriteLine("Provider:           {0}", provider);
}