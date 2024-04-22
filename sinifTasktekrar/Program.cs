using sinifTasktekrar.Models;

namespace sinifTasktekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group DF765 = new Group("df765");
            Group DF766 = new Group("df766");
            List<Student> students = new();
            students.Add(new Student("Aynur", "Tagizade", 21, 600, DF765));
            students.Add(new Student("Gunay", "Hesenli", 20,800, DF766));

            students.Add(new Student("Sevil", "Zemirlil", 23, 350, DF765));
            students.Add(new Student("Leyla", "Kerimli", 30, 800, DF766));
            //var df765Students  = students.FindAll(s => s.Group == DF765);
            //var df766Students = students.FindAll(x=> x.Group == DF766);
            
            var ab765Students = students.Where(s => s.Group.Name == "df765");

            var lowCreditStudents = students.Where(s => s.Credits < 300);

            students
           .Where(s => s.Name.Contains("n", StringComparison.OrdinalIgnoreCase))
           .ToList()
           .ForEach(s => Console.WriteLine($"{s.Name} {s.Surname}"));

            //kredite gore siralamaq
            var lowCredStuds = students.Where(s => s.Credits < 300);

            //butun telebelerin Ad soyadi
            string allNames = string.Join(" ", students.Select(s => $"{s.Name} {s.Surname}"));

            Console.WriteLine($"Butun telebelerin Ad ve soyadi: {allNames}");

            int totalCredits = students.Sum(s=> s.Credits);
            
            bool under18Exists = students.Any(s => s.Age < 18);

            bool allPaidAtLst200Cred = students.All(s => s.Credits >= 200);

            var studentWithMaxCred = students.OrderByDescending(students => students.Credits).ThenBy(s => s.Age).FirstOrDefault();

            Console.WriteLine($"Total Credits: {totalCredits}");
            Console.WriteLine($"18 yasindan kicik telebe varmi?: {(under18Exists ? "Beli" : "Xeyir")}");
            Console.WriteLine($"Butun telebeler en az 200 kredit odedi?: {(allPaidAtLst200Cred ? "Beli" : "Xeyir")}");
            Console.WriteLine($"En yuksek kredite sahib en genc telebe: {studentWithMaxCred.Name} {studentWithMaxCred.Surname}");


        }
    }
}
