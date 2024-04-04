using System.Security.Cryptography.X509Certificates;

namespace StudentRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRecord record = new StudentRecord()
            {
                Name = "Nurlan",
                Surname = "Abbasov",
                Age = 19,
                Grup = "AB106",
                Uni = "AzTu"
            };

            StudentRecord record2 = record with (Name = "dfgh", Surname = "rcgv");
            Console.WriteLine(record);
            Console.WriteLine(record2);

            /* StudentRecord record2 = new StudentRecord()
             {
                 Name = "Nurlan",
                 Surname = "Abbasov"
             };*/
            /* StudentRecord record2 = new StudentRecord("A", "B");
             StudentRecord record = new StudentRecord("A", "B");*/

            /* record.Deconstruct(out string Name,out string Surname);
             Console.WriteLine(Name + " " + Surname);*/

            /* record.Surname = "afsf"*/

            ;
           /* Console.WriteLine(record == record2);
            Console.WriteLine(object.ReferenceEquals(record, record2));
            Console.WriteLine(record);*/
        }
        /* internal record StudentRecord(string Name, string Surname);*/
        /*{
            public string Name { get; set; }
            public string Surname { get; set; }
        }*/

        record StudentRecord(string Name="XXX",string Surname="YYY",byte Age=0, string Grup="",string Uni="");
    }
}
