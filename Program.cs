namespace NewC_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberImages = 52;
            int numberLines;
            int placesLine = 3;
            int imagesIncompleteIine;

            numberLines = numberImages / placesLine;
            imagesIncompleteIine= numberImages % placesLine;

            Console.WriteLine($"Получилось полных {numberLines} радов картин, а в последнем {imagesIncompleteIine}");
            Console.ReadKey(); 
        }
    }
}