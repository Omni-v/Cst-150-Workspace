using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//corrected by <Owen Lindsey> 

namespace Activity10
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }

    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        // Method to add a new element to the set
        public bool addElement(int val)
        {
            // First, we check if the value is already present in the set
            if (containsElement(val))
            {
                // If it is, we return false to signal that the element was not added
                return false;
            }
            else
            {
                // If it's not in the set, we add it
                elements.Add(val);
                // And return true to signal that the element was added successfully
                return true;
            }
        }
        private bool containsElement(int val)
        {
            // Iterate over all elements in the set
            for (int i = 0; i < elements.Count; i++)
            {
                // If we find the value, we return true
                if (val == elements[i])
                    return true;
            }
            // If we finish the loop without finding the value, we return false
            return false;
        }

        // Method to merge the current set with another set passed as a parameter
        public Set union(Set rhs)
        {
            // Create a new Set object to hold the union of the two sets
            Set unionSet = new Set();

            // Add all elements from the current set to the union set
            foreach (int elem in this.elements)
            {
                unionSet.addElement(elem);
            }

            // Iterate over all elements in the second set
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // If the current element is not already in the union set, add it
                if (!unionSet.containsElement(rhs.elements[i]))
                {
                    unionSet.addElement(rhs.elements[i]);
                }
            }

            // Return the union set
            return unionSet;
        }
    }
}