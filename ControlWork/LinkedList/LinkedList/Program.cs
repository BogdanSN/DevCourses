﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> linkedStack = new Stack<int>();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------Commands for Stack with Linked List-------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please type  - push - to add new element to start of Linked List");
            Console.WriteLine("Please type  - pop - to remove last added element from Linked List");
            Console.WriteLine("Please type  - peek - to see last element in Linked List");
            Console.WriteLine("Please type  - show - to show whole Linked List");
            Console.WriteLine("Please type  - exit - to program exit");
            Console.WriteLine("--------------------------------------------------");

            // Will be finished soon
            // Console.WriteLine("Please type  - find - to find element by possiotion № in Linked List");
            // Console.WriteLine("Please type  - rem - to remove element by possition № from Linked List");
            // Console.WriteLine("Please type  - ins - to insert element by possition № in Linked List");
           
            while (true)
            {
                Console.Write("Please type command:");
                string queueCommand = Console.ReadLine();

                switch (queueCommand)
                {
                    case "push":
                        Console.Write("Please enter element:\n");
                        int push = Int32.Parse(Console.ReadLine());
                        linkedStack.Push(push);
                        break;
                                                                  
                    case "pop":
                        linkedStack.Pop();
                        break;

                    case "peek":
                        linkedStack.Peek();
                        break;

                    case "show":
                        linkedStack.Print();
                        break;

                    case "exit":
                        System.Environment.Exit(1);
                        break;
                    //case "ret":
                    //    Console.Write("Please enter Element possition:\n");
                    //    int retPos = Int32.Parse(Console.ReadLine());
                    //    linkedStack.Retrieve(retPos);
                    //    break;

                    //case "rem":
                    //    Console.Write("Please enter Element possition:\n");
                    //    int remPos = Int32.Parse(Console.ReadLine());
                    //    myList.Remove(remPos);
                    //    break;

                    
                }
            }
            Console.ReadLine();
        }
    }
}
