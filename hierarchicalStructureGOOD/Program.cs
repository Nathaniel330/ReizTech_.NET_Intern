using System;
using System.Collections.Generic;
using System.Text;

namespace hierarchicalStructure
{
    class Program
    {
        static void Main()
        {
            Branch root = new Branch("root");
                Branch rootZero = new Branch("rootZero");
                    Branch rootZeroZero = new Branch("rootZeroZero");
                Branch rootOne = new Branch("rootOne");
                    Branch rootOneZero = new Branch("rootOneZero");
                        Branch rootOneZeroZero = new Branch("rootOneZeroZero");
                    Branch rootOneOne = new Branch("rootOneOne");
                        Branch rootOneOneZero = new Branch("rootOneOneZero");
                            Branch deepest = new Branch("deepest");
                        Branch rootOneOneOne = new Branch("rootOneOneOne");
                    Branch rootOneTwo = new Branch("rootOneTwo");

            root.Branches = new List<Branch>(){
                rootZero, 
                rootOne
            };
            rootZero.Branches = new List<Branch>(){
                rootZeroZero
            };
            rootOne.Branches = new List<Branch>(){
                rootOneZero,
                rootOneOne,
                rootOneTwo
            };
            rootOneZero.Branches = new List<Branch>(){
                rootOneZeroZero
            };
            rootOneOne.Branches = new List<Branch>(){
                rootOneOneZero,
                rootOneOneOne
            };
            rootOneOneZero.Branches = new List<Branch>(){
                deepest
            };

            // Create the Structure on the Console
            var consoleTree = new StringBuilder();
            consoleTree.AppendLine("\t\t root");
            consoleTree.AppendLine("\t\t  /\\");
            consoleTree.AppendLine($"{root.branches.Count}\t\t[ ][ ]");
            consoleTree.AppendLine("\t\t/  /|\\");
            consoleTree.Append($"{rootZero.branches.Count}");
            consoleTree.Append(",");
            consoleTree.Append($"{rootOne.branches.Count}\t     [ ] [ ][ ][ ]");
            consoleTree.AppendLine();
            consoleTree.AppendLine("\t\t /  / \\");
            consoleTree.Append($"{rootOneZero.branches.Count}");
            consoleTree.Append(",");
            consoleTree.Append($"{rootOneOne.branches.Count}\t      [ ] [ ] [ ]");
            consoleTree.AppendLine();
            consoleTree.AppendLine("\t\t   |");
            consoleTree.AppendLine($"{rootOneOneZero.branches.Count}\t      [ deepest ]");
            Console.WriteLine(consoleTree.ToString());


            // Find depth. Pass -1 to reduce output by 1.
            // (depth passed originally at 0)
            int depth = Branch.Depth(root, -1);

            Console.WriteLine("\n--+--+--+--+--+--+--+--+--+--");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"In this structure,\nthe depth of the deepest node is {depth}.");
            Console.ResetColor();
            Console.WriteLine("--+--+--+--+--+--+--+--+--+--\n\n");
        }
    }
}