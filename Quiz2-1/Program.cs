// See https://aka.ms/new-console-template for more information

//დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით

Console.WriteLine("Enter the length of the array: ");
int n = int.Parse(Console.ReadLine()); 
int[] arr = new int[n];

Console.WriteLine("Enter the elements of the array: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

//კენტი რიცხვების ჯამი მასივში 
int oddSum = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 != 0)
    {
        oddSum += arr[i];
    }
}
Console.WriteLine("The sum of odd numbers is {0}", oddSum);

//ლუწი რიცხვების ნამრავლი მასივში 

int evenProd = 1;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
    {
        evenProd *= arr[i];
    }
}
Console.WriteLine("The product of even numbers is {0}", evenProd);

//დაითვლის თითოეული ელემენტის რაოდენობას 

int count = 1;
Array.Sort(arr);
for (int i = 0; i < n-1; i++)
{
    if (arr[i] == arr[i+1])
    {
        count++;
        Console.WriteLine("element {0} occurs {1} times", arr[i], count);
    }
    else
    {
        count = 1; 
        Console.WriteLine("element {0} occurs {1} times", arr[i], count);
    }
}