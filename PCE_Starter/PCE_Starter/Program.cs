using System;
using System.Collections;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Using_DotNets_Stack uds = new Using_DotNets_Stack();
            uds.RunExercise();

            // add more here, as you need
        }
    }

    class What_Is_A_Stack 
    {
        // The stack stores and removes data by whats called
        // Push and Pop. Since stack is a Last-in-First-out
        // setup, the last thing we added (or pushed) is the 
        //first thing that gets pulled (or popped) off. 
        
        // The stack would look like this 5, 4, 1 
        //Since 1 was placed first the stack pushes it down
        //when 2 and 3 are added, since they are on top, they go when popped.
        // then 4 and 5 are pushed on top of 1.
    }


    class Car
    {
    }

    class Using_DotNets_Stack 
    {
        // Your comment explaining the running time of
        // Push goes here
        // N refers to the number of elements in the array. 
        // Push is O(1) because it will never for over the given amount of steps
        // Pop is O(N) because it has to go throught the given elements (N) in the array.
        

		// Make sure that "using System.Collections;" is at the top of this file
        public void RunExercise()
        {
            Stack newStack = new Stack();
            for(int i =1; i<=3;i++)
                newStack.Push(i);
            for (int i=3; i > 0; i--)
             Console.WriteLine(newStack.Pop());
        }
    }

    class What_Is_An_Enum
    {
        // What is an enum? Why would you want to use one?
        //Enums are lists. You would have more organized error handling, than simple methods.

        // Why is an enum better than a public const int? (or a public static readonly int)?
        //Enums are better because they more efficiently handle errorhandling at runtime.
        //Where enums wont compile unless you pass good values, this reduces the chance of 
        //cleaning up errors.
    }
}