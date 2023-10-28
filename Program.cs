void CalculateAPowB(int a, int b){
    int result=1; 
    
    for (int i = 1; i < b+1; i++){
        result = result*a;
    }
    Console.WriteLine(a + " ^ " + b + " == " + result);   
}

void GetSummOfNumbers(int number){
    int summ=0;
    Console.Write("Summ of numbers in " + number ); 

    while (number != 0){
        summ = summ + number%10;
        number = number / 10;
    }

    Console.WriteLine(" is " + summ);
}


void PrintArray(){
    int[] arr = new int[8];
    Console.Write("[");

    for (int i =0; i < 8; i++){
        Random rand = new Random();
        arr[i] = rand.Next(0, 99);
        Console.Write(arr[i]);
        if (i < 8-1){
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


//CalculateAPowB(3, 3);
//GetSummOfNumbers(1234);
PrintArray();