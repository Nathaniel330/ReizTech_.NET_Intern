using System;
using System.Collections.Generic;

namespace hierarchicalStructure
{
    public class Branch
    {
        public List<Branch> branches;
        public string branchName;

        public Branch(string branchName)
        {
            branches = new List<Branch>();
            this.branchName = branchName;
        }

        public List<Branch> Branches
        {
            get { return this.branches; }
            set { this.branches = value; }
        }

        protected string BranchName
        {
            get { return this.branchName; }
        }

        // Function to Find Depth.
        public static int Depth(Branch root, int depth)
        {
            int result = depth + 1;

            foreach (var node in root.Branches)
            {
                result = Math.Max(result, Depth(node, depth + 1));
            }

            return result;
        }
    }
}