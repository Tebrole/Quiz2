// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the input length of the array: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

Console.WriteLine("Enter the array: ");

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int x = arr.Length; 
bool isSymmetric = true;
for (int i = 0; i < x / 2; i++)
{
    if (arr[i] != arr[x - 1 - i])
    {
        isSymmetric = false;
    }
}

Console.WriteLine("The statement that the given array is a palindrome is {0}", isSymmetric );