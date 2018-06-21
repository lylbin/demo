using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    for (var i = 0; i < 10; i++)
                    {
                        var list = MsgServiceClient.GetList(0, "1", 0, 0);
                    }
                }
                catch (Exception ex)
                {

                }
                Console.ReadKey();
            }
        }
    }
}
