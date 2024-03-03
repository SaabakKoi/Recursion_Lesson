void Main(){
    Console.WriteLine("Введите значение M:");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int n = Convert.ToInt32(Console.ReadLine());

    Recursion(m, n);

}

void Recursion(int m, int n){
    if (m > n){
        Console.Write(n + " ");
        return;
    }

    Console.Write($"{m} ");
    Recursion(m + 1, n);
}

Main();