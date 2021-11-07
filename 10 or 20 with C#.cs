namespace 연습문제_7장_코딩
{
    class Unit { }
    class Tank : Unit { }

    class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit();
            Tank tank = new Tank();

            Unit a = (Unit)unit;
            Unit b = (Unit)tank;
            Tank c = (Tank)unit; //여기에서 오류 발생!!
            Tank d = (Tank)tank;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습문제_7장_코딩
{
    class Parent
    {
        public int question = 10;
    }

    class Child : Parent
    {
        public string question = "20";
    }
    class _6번
    {
        static void Main(string[] args)
        {
            Parent child = new Parent();
            Console.WriteLine(child.question); //20 출력
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습문제_7장_코딩
{
    class Parent
    {
        public int Questioni() { return 10; }
    }

    class Child : Parent
    {
        public int Question() { return 20; }
    }

    class _8번
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.Question()); //20 출력
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습문제_7장_코딩
{
    class Parent
    {
        public int Question() { return 10; }
    }

    class Child : Parent
    {
        public new int Question() { return 20; }
    }

    class _9번
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.Question()); //20 출력
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습문제_7장_코딩
{
    class Parent
    {
        public virtual int Question() { return 10; }
    }

    class Child : Parent
    {
        public new int Question() { return 20; }
    }

    class _10번
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.Question()); //20 출력
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습문제_7장_코딩
{
    class Parent
    {
        public virtual int Question() { return 10; }
    }

    class Child : Parent
    {
        public override int Question() { return 20; }
    }

    class _11qjs
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.Question()); //20 출력
        }
    }
}