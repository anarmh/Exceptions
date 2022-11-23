
CalculateFactorial(-5);



 static void CalculateFactorial(int numb)
{
    int mult = 1;
    try
    {
        if (numb == 0)
        {
            Console.WriteLine("0 has no Factorial");
        }
        else if (numb < 0)
        {
            throw new ArgumentException();
        }
        for (int i = numb; i > 1; i--)
        {
            mult *= i;
            Console.WriteLine(mult);
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
   
    
}