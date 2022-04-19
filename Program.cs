using System;
using System.Collections.Generic;

namespace _3_лаба_оп
{
    class Tree
    {
        public Branch branch = new Branch();
        public Leaves leaves = new Leaves();

        public void FallLeaves()
        {
            Console.WriteLine("All the leaves have fallen");
            leaves.leavesStatus = "fallen";
            branch.branchStatus = "The branches are not covered";
        }
        public void TurnYellow()
        {
            if (leaves.leavesStatus == "fallen")
            {
                Console.WriteLine("The leaves have fallen, they cannot be yellow");
            }
            else
            {
                Console.WriteLine("The leaves turned yellow");
                leaves.leavesStatus = "yellow";
            }
        }
        public void CoverWithFrost()
        {
            if (leaves.leavesStatus == "fallen" || leaves.leavesStatus== "yellow")
            {
                Console.WriteLine("The branches have covered with frost");
                branch.branchStatus = "covered with frost";
            }
            else
            {
                Console.WriteLine("The tree cannot be covered with frost at this time");
            }
        }
        public void ToBlossom()
        {
            if (leaves.leavesStatus == "fallen")
            {
                Console.WriteLine("Leaves appeared on the branches");
                branch.branchStatus = "covered with leaves";
                leaves.leavesStatus = "green";
            }
            else
            {
                Console.WriteLine("The tree cannot bloom now");
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Tree m = obj as Tree;
            if (m as Tree == null)
                return false;
            return m.leaves.leavesStatus == this.leaves.leavesStatus && m.branch.branchStatus == this.branch.branchStatus;
        }
        public bool Equals(Tree obj)
        {
            if (obj == null)
                return false;
            return obj.leaves.leavesStatus == this.leaves.leavesStatus && obj.branch.branchStatus == this.branch.branchStatus;
        }

        //public override int GetHashCode()
        //{
        //    int HashLeavesCode;
        //    if (leaves.leavesStatus == "green")
        //        HashLeavesCode = 1;
        //    else if (leaves.leavesStatus == "yellow")
        //        HashLeavesCode = 2;
        //    else 
        //        HashLeavesCode = 0;

        //    int HashBranchCode;
        //    if (branch.branchStatus == "covered with leaves")
        //        HashBranchCode = 5;
        //    else if (branch.branchStatus == "covered with frost")
        //        HashBranchCode = 3;
        //    else
        //        HashBranchCode = 8;

        //    return HashLeavesCode + HashBranchCode;
        //}

        public override string ToString()
        {
            return $"The leaves are {leaves.leavesStatus}, the branch are {branch.branchStatus} ";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(branch, leaves);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.FallLeaves();
            tree.TurnYellow();
            tree.CoverWithFrost();
            tree.ToBlossom();
            tree.TurnYellow();
            Console.WriteLine(tree.ToString());
            Console.WriteLine(tree.GetHashCode());
            Console.WriteLine("\n");
            
            
            Tree tree1 = new Tree();
            tree1.TurnYellow();
            tree1.ToBlossom();
            tree1.CoverWithFrost();
            Console.WriteLine(tree1.ToString());
            Console.WriteLine(tree1.GetHashCode());

            Console.WriteLine(tree.Equals(tree1) );
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
