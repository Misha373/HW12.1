namespace HW12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть номер порядку, Числа Фіабанічі якого ви хочете дізнатись: ");
            int Num = int.Parse(Console.ReadLine());
            int result = NumPhibanachi(Num);
            Console.WriteLine($"Число Фібаначі з порядковим номеров - {Num}, дорівнює - {result}.");
        }
        public static int NumPhibanachi(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            return NumPhibanachi(n - 1) + NumPhibanachi(n - 2);
        }
    }
}
