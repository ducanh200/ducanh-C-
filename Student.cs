using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    internal class Student
    {
        public string name;
        public string email;
        public int age;
        public string telephone;
        public int tu;
        public int mau;

        public Student() 
        {
            this.run();
            this.learn();
        }

        public void run()
        {
            Console.WriteLine(this.name + "Running...");
        }
        public void learn()
        {
            Console.WriteLine(this.name + "Learning...");
        }
        

    }
    

}
