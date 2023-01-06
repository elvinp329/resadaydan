namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wexsin adini daxil edin");
            int[] rewad = new int[3];
            int[] aydan = new int[3];

            int aydaninbali = 0;
            int rewadbali= 0;
                

            for (int i = 0; i< rewad.Length; i++)
            {
                rewad[i] = int.Parse(Console.ReadLine());
                

            } 
            for (int i = 0; i < aydan.Length ; i++)
            {
                aydan[i] = int.Parse(Console.ReadLine()) ;
            }
            for ( int i = 0; i< aydan.Length ; i++)
            {
                if (aydan[i] > rewad[i])
                {
                    aydaninbali++;
                }
                
                if (rewad[i] > aydan[i])
                {
                    rewadbali++;
                }
            }
            Console.WriteLine($"{aydaninbali} { rewadbali}" );


            Console.WriteLine("Hello, World!");
        }
    }
}