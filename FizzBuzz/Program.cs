using System.Reflection;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceType = Assembly.GetExecutingAssembly().GetType("FizzBuzz.FizzBuzzService");

            if (serviceType != null)
            {
                var serviceInstance = Activator.CreateInstance(serviceType);
                var methodInfo = serviceType.GetMethod("GetFizzBuzzOutput");

                if (methodInfo != null && serviceInstance != null)
                {
                    for(int i = 1; i <= 100; i++)
                    {
                        var result = methodInfo.Invoke(serviceInstance, [i]);
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    Console.WriteLine("Method not found");
                }
            }
            else
            {
                Console.WriteLine("Type not found");
            }
            Console.ReadLine();
        }
    }
}
