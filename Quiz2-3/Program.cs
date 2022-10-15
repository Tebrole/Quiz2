// See https://aka.ms/new-console-template for more information

//დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს.
int[] array = new int [] {1, 1, 2, 3, 4, 4, 4, 5, 5};

int count = 1;
int bestCount = 1;
int bestNum = 1; 
int len = array.Length;

for (int i = 0; i < len-1; i++)
{
    if (array[i] == array[i + 1])
    {
        bestCount++;
    }
    else
        bestCount = 1; 

    if (bestCount > count)
    {
        count = bestCount;
        bestNum = array[i];
    }
}

Console.WriteLine("{0}, {1}", bestNum, count);

