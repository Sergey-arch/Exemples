// Fibonacci 

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1; // если значение n = 1 или n = 2
                                    // то вовращаем 1
    else return Fibonacci(n - 1) + Fibonacci(n - 2); // в противном случае 
                                // мы хотим вернить фибоначи(n-1)+фибоначи(n-2)
}
for (int i = 1; i < 20; i++) // для 
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}


