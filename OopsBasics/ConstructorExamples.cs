using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasics
{
     public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ObjectCreatedTime { get; set; }

        public Employee()
        {
            ObjectCreatedTime = DateTime.Now.ToString();
        }

        public Employee(int id) : this()
        {
            this.Id = id;
        }

        public Employee(int id, string name) : this(id) 
        {
            this.Name = name;
        }
    }


}
