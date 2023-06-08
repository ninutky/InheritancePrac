using System;
namespace InheritancePrac
{
    internal class Animal
    {
        public int Age { get; set; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }
}