namespace Challenge2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("This program accepts an input character c and input width w to create a triangle of decreasing width");
            Console.WriteLine("Please input character to create triangle out of: ");
            char myCharacter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please input desired width of first row");
            int myWidth = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < myWidth; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < myWidth-i; j++)
                {
                    Console.Write(myCharacter);
                }
            }

        }
    }
}
