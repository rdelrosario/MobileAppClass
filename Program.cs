using System;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frameworks = new string[] { "Xamarin", "React Native", "Flutter", "React Native" };
            StringBuilder sb=new StringBuilder();
            for(int i=0; i< frameworks.Length; i++)
            {
               Console.WriteLine($"Hola {frameworks[i]}");
            }
        }
    }
}
