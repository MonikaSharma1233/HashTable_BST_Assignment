using System.Data;

namespace HashTable_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");
            string hash3 = hash.Get("3");
            Console.WriteLine("The 3rd Index value is : " + hash3);

            string hash5 = hash.Get("5");
            Console.WriteLine("The 5rd Index value is : " + hash5);
        }
       
      
    }
}