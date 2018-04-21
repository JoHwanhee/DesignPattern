using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(IVisitable visitableObject);
    }

    public class Teacher : IVisitor
    {
        public int SumAge { get; private set; }

        public void CalcurateAge(List<IVisitable> visitableObjects)
        {
            foreach (IVisitable visitable in visitableObjects)
            {
                Visit(visitable);
            }
        }

        public void Visit(IVisitable visitableObject)
        {
            if (visitableObject is Student student)
            {
                SumAge += student.Age;
            }
        }
    }

    public class Student : IVisitable
    {
        public int Age { get; }
        public Student(int age)
        {
            Age = age;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IVisitable> students = new List<IVisitable>
            {
                new Student(17),
                new Student(12),
                new Student(16),
                new Student(14),
                new Student(12),
                new Student(17),
                new Student(19),
                new Student(20)
            };

            Teacher teacher = new Teacher();
            teacher.CalcurateAge(students);

            int sunAge = teacher.SumAge;

            Console.WriteLine(sunAge);
            Console.ReadLine();
        }
    }
}
