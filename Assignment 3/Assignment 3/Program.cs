using System;

delegate int NumberChanger(int num);

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericNode<string> startS;  //Yes, I'm still in the data structures mindset

            startS = new GenericNode<string>("This is the first node of a string generic");
            startS.link = new GenericNode<string>("This is the second node of a string generic");
            startS.link.link = new GenericNode<string>("This is the third node of a string generic");
            startS.link.link.link = new GenericNode<string>("This is the fourth node of a string generic");

            GenericNode<int> startI;

            startI = new GenericNode<int>(0);
            startI.link = new GenericNode<int>(1);
            startI.link.link = new GenericNode<int>(2);
            startI.link.link.link = new GenericNode<int>(3);

            //Look, I know creating a LL this way is sloppy, but that's not the point of the assignment

            PrintData(startS, startI);

        }

        static void PrintData(GenericNode<string> startS, GenericNode<int> startI)
        {
            GenericNode<string> currentNodeS = startS;

            do
            {
                Console.WriteLine("String node data: " + currentNodeS.data);

                currentNodeS = currentNodeS.link;

            } while (currentNodeS != null);

            Console.WriteLine();

            GenericNode<int> currentNodeI = startI;

            do
            {
                Console.WriteLine("Integer node data: " + currentNodeI.data);

                currentNodeI = currentNodeI.link;

            } while (currentNodeI != null);

        }

    }

}
