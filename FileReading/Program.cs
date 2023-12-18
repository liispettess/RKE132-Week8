//andmete lugemine failist macis

namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/liispet-tesstalu/projects/data/heroes.txt";

            string [] dataFromFile = File.ReadAllLines(filePath);

            foreach(string element in dataFromFile)
            {
                Console.WriteLine(element);
            }
        }
    }
}