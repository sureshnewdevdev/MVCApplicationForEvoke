using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsBasics
{
    public class CollectionExample
    {
        public void ExampleOfArray()
        {
            var x = 10;

            int[] nos=new int[10];
            nos[0] = 1; nos[1] = 2; nos[2] = 3;
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("SSS");
            arrayList.Add(true);

             


            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();


            Queue q=new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            q.Enqueue(4);
            q.Dequeue();



            object obj = "Raj"; // Boxing
            string name = obj.ToString();// unboxing

            // Generic

            Queue<int> intQ=new Queue<int>();
            intQ.Enqueue(10);
            intQ.Enqueue(20);
            intQ.Enqueue(30);

            List<string> strList = new List<string>();
            strList.Add("A");
            strList.Add("d");
            strList.Add("e");
            strList.Add("b");
            strList.Add("c");

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************************************************************");
            strList.Sort();

            foreach (var item in strList)
            {
                Console.WriteLine(item);
            }

            List<DateTime> listDates = new List<DateTime>();
            listDates.Add(DateTime.Now.AddDays(1));
            listDates.Add(DateTime.Now.AddDays(-1));
            listDates.Add(DateTime.Now.AddDays(-3));
            listDates.Add(DateTime.Now.AddDays(-2));
            listDates.Add(DateTime.Now.AddDays(3));

            foreach (var item in listDates)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************************************************************");

            listDates.Sort();

            foreach (var item in listDates)
            {
                Console.WriteLine(item);
            }

            var coll = from item in strList
                       orderby item descending
                       select item.ToUpper();


            foreach (var item in coll)
            {
                Console.WriteLine(item);
            }

            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 5, Name="A", Rank=2 }) ;
            students.Add(new Student { Id = 2, Name="e", Rank= 5 }) ;
            students.Add(new Student { Id = 2, Name="d", Rank= 4 }) ;
            students.Add(new Student { Id = 3, Name="b", Rank= 1 }) ;
            students.Add(new Student { Id = 4, Name="c", Rank= 3 }) ;

            var orderbyNameStudents = from stu in students
                                      orderby stu.Name descending
                                      select stu.Name;
            var orderbyRankStudents = from stu in students
                                      orderby stu.Rank ascending
                                      select new { Name=stu.Name, rank=stu.Rank, id=stu.Id };
            var orderbyIdStudents = from stu in students
                                      orderby stu.Id ascending
                                      select new { Name = stu.Name, rank = stu.Rank, id = stu.Id };

        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Rank { get; set; }
    }
}
