using System;

namespace ConsoleApplication1
{
    class cat {
        public string name;
        public string gender;
        public string owner;

        public void Bark() {
            Console.WriteLine("{0} : 야옹", name);
        }
    }

    class Program {
        static void Main(string[] args) {
            cat c = new cat();
            c.name = "나비";
            c.gender = "남자";
            c.owner = "민수";

            c.Bark();

            Console.WriteLine("고양이의 이름: {0}, 개의 성별: {1}, 개의 주인이름: {2}", c.name, c.gender, c.owner);
        }
    }
}