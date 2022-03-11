using System;
using System.Collections.Generic;
using Task3.Subjects;
using Task3.Vaccines;

namespace Task3
{
    class Program
    {
        public class databaseData
        {
            public List<GenomeData> genomeDatas = new List<GenomeData>();
            public List<string> names = new List<string>();
            public List<double> deathRate = new List<double>();
            public List<double> infectionRate = new List<double>();
            public List<VirusData> virusDatas = new List<VirusData>();
        }
        public class MediaOutlet
        {

            public List<object> db = new List<object>();
            public void addDb(object o)
            {
                db.Add(o);
            }
            public void Publish(List<GenomeData> g)
            {
                foreach (var d in db)
                {
                    if (d is Iprint)
                    {
                        Iprint p = d as Iprint;
                        p.get_data(g);
                    }
                }
            }
        }

        public class Tester
        {
            public void Test()
            {
                var vaccines = new List<IVaccine>() { new AvadaVaccine(), new Vaccinator3000(), new ReverseVaccine() };

                foreach (var vaccine in vaccines)
                {
                    Console.WriteLine($"Testing {vaccine}");
                    var subjects = new List<ISubject>();
                    int n = 5;
                    for (int i = 0; i < n; i++)
                    {
                        subjects.Add(new Cat($"{i}"));
                        subjects.Add(new Dog($"{i}"));
                        subjects.Add(new Pig($"{i}"));
                    }

                    foreach (var subject in subjects)
                    {
                        // process of vaccination
                    }

                    var genomeDatabase = Generators.PrepareGenomes();
                    var simpleDatabase = Generators.PrepareSimpleDatabase(genomeDatabase);
                    // iteration over SimpleGenomeDatabase using solution from 1)
                    // subjects should be tested here using GetTested function


                    // iterating over simpleDatabase
                    //{
                        //foreach (var subject in subjects)
                        //{
                        //    subject.GetTested();
                        //}
                    //}

                    int aliveCount = 0;
                    foreach (var subject in subjects)
                    {
                        if (subject.Alive) aliveCount++;
                    }
                    Console.WriteLine($"{aliveCount} alive!");
                }
            }
        }
        public static void Main(string[] args)
        {
            var genomeDatabase = Generators.PrepareGenomes();
            var simpleDatabase = Generators.PrepareSimpleDatabase(genomeDatabase);
            var excellDatabase = Generators.PrepareExcellDatabase(genomeDatabase);
            var overcomplicatedDatabase = Generators.PrepareOvercomplicatedDatabase(genomeDatabase);
            var mediaOutlet = new MediaOutlet();
            mediaOutlet.addDb(excellDatabase);
            mediaOutlet.addDb(simpleDatabase);
            mediaOutlet.Publish(genomeDatabase.genomeDatas);
            //excellDatabase.get_data(genomeDatabase.genomeDatas);




            // testing animals
            //var tester = new Tester();
            //tester.Test();
        }
    }
}
