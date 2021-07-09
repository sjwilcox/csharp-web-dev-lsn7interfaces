using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;
            //Flavorcomparer comparer = new Flavorcomparer();
            Console.WriteLine("Original:");
            foreach (Flavor flav in availableFlavors)
            {
                
                Console.WriteLine(flav.Name);
            }

            availableFlavors.Sort(new Flavorcomparer());
            Console.WriteLine("Sorted--------------------------");
            foreach (Flavor flav in availableFlavors)
            {
                
                Console.WriteLine(flav.Name);
            }

            foreach(Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: {cone.Cost}");
            }
            availableCones.Sort(new ConeComparer());
            Console.WriteLine();
            Console.WriteLine("Sorted--------------------------");
            foreach (Cone cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: {cone.Cost}");
            }

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
