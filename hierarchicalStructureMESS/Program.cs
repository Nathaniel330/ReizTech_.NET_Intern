using System;
using System.Collections.Generic;

namespace hierarchicalStructure
{
    class Program
    {
        static void Main()
        {
            // Creating Depth 0
            Branch root = new Branch(); // root instantiated


            // Creating + Adding Depth 1
            Branch rootZero = new Branch();
            root.branches.Add(rootZero);

            Branch rootOne = new Branch();
            root.branches.Add(rootOne);


            // Creating + Adding Depth 2
            Branch rootZeroZero = new Branch();            
            root.branches[0].branches.Add(rootZeroZero);

            Branch rootOneZero = new Branch();
            Branch rootOneOne = new Branch();
            Branch rootOneTwo = new Branch();
            root.branches[1].branches.Add(rootOneZero);
            root.branches[1].branches.Add(rootOneOne);
            root.branches[1].branches.Add(rootOneTwo);


            // Creating + Adding Depth 3
            Branch rootOneZeroZero = new Branch();
            root.branches[1].branches[0].branches.Add(rootOneZeroZero);

            Branch rootOneOneZero = new Branch();
            Branch rootOneOneOne = new Branch();
            root.branches[1].branches[1].branches.Add(rootOneOneZero);
            root.branches[1].branches[1].branches.Add(rootOneOneOne);


            // Creating + Adding Depth 4
            Branch rootOneOneZeroZero = new Branch();
            root.branches[1].branches[1].branches[0].branches.Add(rootOneOneZeroZero);


            // Find the maximum depth
            // ??????????????????????


            // Tests
            // Console.WriteLine(root.branches.Count);                // Depth 0 — Root

            // Console.WriteLine(root.branches[0].branches.Count);    // Depth 1
            // Console.WriteLine(root.branches[1].branches.Count);    // Depth 1

            // Console.WriteLine(root.branches[0].branches[0].branches.Count); // Depth 2
            // Console.WriteLine(root.branches[1].branches[0].branches.Count); // Depth 2
            // Console.WriteLine(root.branches[1].branches[1].branches.Count); // Depth 2
            // Console.WriteLine(root.branches[1].branches[2].branches.Count); // Depth 2

            // Console.WriteLine(root.branches[1].branches[0].branches[0].branches.Count); // Depth 3
            // Console.WriteLine(root.branches[1].branches[1].branches[0].branches.Count); // Depth 3
            // Console.WriteLine(root.branches[1].branches[1].branches[1].branches.Count); // Depth 3

            // Console.WriteLine(root.branches[1].branches[1].branches[0].branches[0].branches.Count); // Depth 4
        }
    }
}