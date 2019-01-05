using EntityFramework.Model.Context;
using EntityFramework.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDataDbContext Data = new SampleDataDbContext();

            //Database and table have been created
            //Data.Database.Create();

            //New data has been inserted
            //Data.SampleTables.Add(new SampleTable {
            //   Column1 = "Sample column1",
            //   Column2 = "Sample column2"
            //});

            //Data.SaveChanges();

            //Data was updated
            //SampleTable sample = Data.SampleTables.FirstOrDefault(o => o.ID ==1);
            //sample.Column1 = "Column1 was updated";
            //sample.Column2 = "Column2 was updated";
            //Data.SaveChanges();

            //Data was deleted
            //SampleTable sample = Data.SampleTables.FirstOrDefault(o => o.ID == 1);
            //Data.SampleTables.Remove(sample);
            //Data.SaveChanges();

            //Read data
            //foreach (var item in Data.SampleTables)
            //{
            //    Console.WriteLine($"{item.Column1} {item.Column2}");
            //}
            //Console.Read();
        }
    }
}
