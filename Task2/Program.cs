void Main(){
    Console.WriteLine("Введите m:");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите n:");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Результат: {Function(m, n)}");

}

int Function(int m, int n){
    if(m == 0)
    return n+1;

    if(n == 0)
    return Function(m - 1, 1);

    return Function(m - 1, Function(m, n - 1));
}

Main();