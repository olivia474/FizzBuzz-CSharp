namespace FizzBuzz;

internal class Program
{
    static void Main(string[] args)
    {
        Fizzbuzz();
    }
    static void Fizzbuzz()
    {
        for(int i = 1; i <= 300; i++) {
        
        List<string> result = new List<string>();

        if(IsDivisibleBy(i, 3))
        {
            result.Add("Fizz");
        }
        
        if (IsDivisibleBy(i, 5))
        {
            result.Add("Buzz");
        }

        if(IsDivisibleBy(i, 7))
        {
            result.Add("Bang");
        }
        
        if(IsDivisibleBy(i, 11))
        {
            result.Clear();
            result.Add("Bong");
        } 
        
        if(IsDivisibleBy(i, 13))
        {
            bool inserted = false;
            
            for(int j = 0; j < result.Count; j++)
            {
                
                if (result[j].StartsWith('B'))
                {
                result.Insert(j, "Fezz");
                inserted = true;
                break;
                }
            }

                if(!inserted)
                {
                    result.Add("Fezz");
                }
        }
        
        if(IsDivisibleBy(i, 17))
        {
            result.Reverse();
        }

        if(result.Count == 0)
        {
            Console.WriteLine(i);
        }

        else
        {
            Console.WriteLine(string.Join("", result));
        }

       }
     }
     private static bool IsDivisibleBy(int numerator, int denominator)
     {
        return numerator % denominator == 0;
     }
}