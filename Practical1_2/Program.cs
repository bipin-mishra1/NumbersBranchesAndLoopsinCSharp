using System;
using Branches;
using Loops;
namespace Program
{
    class MainProgram{
        public static void Main(string[] args){
            Console.WriteLine("\nOn Branches : ");
            Branches.Branch.ConditionalStatement();

            Console.WriteLine("\nOn Loops : ");
            Loops.Loop.IterativeStatement();
        }
    }
}