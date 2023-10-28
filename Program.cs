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

//CalculateAPowB(3, 3);
GetSummOfNumbers(1234);