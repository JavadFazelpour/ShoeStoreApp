using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp
{
    internal class ShoeCloset
    {
        private readonly List<Shoe> shoes = new List<Shoe>();
        public void PrintShoes()
        {
            if (shoes.Count==0)
                Console.WriteLine("\nThe shoe closet is empty.");
            else
            {
                Console.WriteLine("\nThe shoe closet contains: ");
                int i = 1;
                foreach (Shoe shoe in shoes)
                {
                    Console.WriteLine($"Shoe #{i++}: {shoe.Description}");
                }
            }
        }
        public void AddShoe()
        {

        }
        public void RemoveShoe()
        {

        }
    }
}
