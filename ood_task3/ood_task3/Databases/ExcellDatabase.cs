using System;
using System.Collections.Generic;

namespace Task3
{
    public class ExcellDatabase : Iprint
    {
        public string Names { get; }
        public string DeathRates { get; }
        public string InfectionRates { get; }
        public string GenomeIds { get; }

        public ExcellDatabase(string names, string deathRates, string infectionRates, string genomeIds)
        {
            Names = names;
            DeathRates = deathRates;
            InfectionRates = infectionRates;
            GenomeIds = genomeIds;
        }
        
        public void get_data(List<GenomeData> g)
        {
            string[] names = Names.Split(';');
            string[] deathRates = DeathRates.Split(';');
            string[] infectionRates = InfectionRates.Split(';');
            string[] genomeIds = GenomeIds.Split(';');
            //GenomeData genomeData = new GenomeData();
            //for(int i = 0; i < deathRates.Length; i++)
            //{
            //    dr.Add(int.Parse(deathRates[i]));
            //}
            
            Console.WriteLine("EXCEL DATABASE");

            for (int i = 0; i < names.Length; i++)
            {
                for(int j = 0; j < g.Count; j++)
                {
                    string tmp = Convert.ToString(g[j].Id); 
                    if(genomeIds[i].Equals(tmp))
                        Console.WriteLine($"{names[i]}, {deathRates[i]}, {infectionRates[i]}, {g[j]}");
                }

               
            }
        }
    }

    public class SimpleDatabaseRow
    {
        public string VirusName { get; set; }
        public double DeathRate { get; set; }
        public double InfectionRate { get; set; }
        public Guid GenomeId { get; set; }
    }

    public class SimpleDatabase: Iprint
    {
        public IReadOnlyList<SimpleDatabaseRow> Rows { get; }
        public SimpleDatabase(IEnumerable<SimpleDatabaseRow> simpleDatabaseRows)
        {
            var list = new List<SimpleDatabaseRow>();
            list.AddRange(simpleDatabaseRows);

            Rows = list;
        }

        public void get_data(List<GenomeData> g)
        {
            List<SimpleDatabaseRow> list = new List<SimpleDatabaseRow>();
            List<VirusData> virusDatas = new List<VirusData>();
            
            foreach(var x in Rows)
            {
                list.Add(x);
            }
            Console.WriteLine("\nSIMPLE DATABASE");
            foreach (var x in list)
            {
                //for (int j = 0; j < g.Count; j++)
                //{
                //    string tmp = Convert.ToString(g[j].Id);
                //    if (list.[i].Equals(tmp))
                //        Console.WriteLine($"{names[i]}, {deathRates[i]}, {infectionRates[i]}, {g[j]}");
                //}
            }

        }
    }
}
