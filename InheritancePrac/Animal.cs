using System;
namespace InheritancePrac
{
    internal class Animal
    {
        private void Private() { }
        protected void Protected() { }
        public void Public() { }
        public void TestA()
        {
            Private();
            Protected();
            Public();
        }
        public int Age { get; set; }

        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }
}