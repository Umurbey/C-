using System;

namespace hackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());
                
                int c = a+b; // toplama

                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                 Console.WriteLine("Bir hata oluştu" + ex.message);
            }
            finally{
                Console.WriteLine("İşlem tamamlandı");
            }
        }
    }
}
