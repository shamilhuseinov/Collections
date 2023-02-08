using System;
namespace test
{
    public class Program
    {
        static void Main()
        {
            //1
            //List<Group> listGroups = new List<Group>();

            //var group1 = new Group();
            //group1.Name = "team1";
            //var group2 = new Group();
            //group2.Name = "team2";
            //var group3 = new Group();
            //group3.Name = "team3";

            //AddGroup(listGroups, group1);
            //AddGroup(listGroups, group2);
            //AddGroup(listGroups, group3);

            //static void AddGroup(List<Group> listGroups, Group group)
            //{
            //    var dublicateName = listGroups.Any(g => g.Name == group.Name);
            //    if (!dublicateName)
            //    {
            //        listGroups.Add(group);
            //    }
            //}

            //2
            List<Student> listStudents = new List<Student>();
            var student1 = new Student
            {
                Name = "Shamil",
                Surname = "Huseynov",
                PIN = 1234
            };
            var student2 = new Student
            {
                Name = "Elchin",
                Surname = "Murselov",
                PIN = 12345
            };
            var student3 = new Student
            {
                Name = "Abdulla",
                Surname = "Hesenov",
                PIN = 354
            };

            AddStudents(listStudents, student1);
            AddStudents(listStudents, student2);
            AddStudents(listStudents, student3);

            static void AddStudents(List<Student> listStudents, Student student)
            {
                var dublicatePIN = listStudents.Any(s => s.PIN == student.PIN);
                if (!dublicatePIN)
                {
                    listStudents.Add(student);
                }
            }

            static void CountA(List<Student> listStudents)
            {
                char letter = 'a';
                var countOfStudents = listStudents.Count(s => s.Name.Contains(letter));
                Console.WriteLine($"number of students whose name contains {letter} is {countOfStudents}");
            }

            CountA(listStudents);
        }
    }
}