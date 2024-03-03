void Main(){

int[] array = {1,2,3,4,5};

PrintArray(array.Length, array);

}

void PrintArray(int i, int[] array){

    if (i == 0) 
        return; 

    Console.Write($" {array[i - 1]} "); 

    PrintArray(--i, array);

}

Main();


