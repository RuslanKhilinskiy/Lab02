using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public struct Distance 
    {
        public int Feet;
        public int Inches;

        public Distance(int feet, int inches) 
        {
            Feet = feet;
            Inches = inches;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Distance a, b, c;

            Console.WriteLine("Please enter the first feet value: ");
            int feet1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first inches value: ");
            int inches1 = int.Parse(Console.ReadLine());

            a = new Distance(feet1, inches1);

            Console.Write("Please enter the second feet value: ");
            int feet2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second feet value: ");
            int inches2 = int.Parse(Console.ReadLine());

            b = new Distance(feet2, inches2);
            
            int totalInches = (a.Feet + b.Feet) +(a.Inches + b.Inches) / 12;
            int c = new Distance (a.Inches + b.Inches) % 12;

            Console.WriteLine("Distance sum is");
            Console.WriteLine($"{a.feet}'-{a.inches}\" + {b.feet}'-{b.inches}\" = {c.feet}'-{c.inches}\"");

            Console.ReadLine();
        }
    }
}
