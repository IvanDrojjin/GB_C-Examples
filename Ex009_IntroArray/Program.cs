// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// int[] array = { 9, 28, 1, 32, 1990 };

void fillArr(int [] arrI, int minI, int maxI)
{
    int nL = arrI.Length;
    int i= 0;
    while ( i < nL)
    {
        arrI[i] = new Random().Next( minI, maxI );
        i++;
    }
}

void printArr(int [] arrI)
{
    int nL = arrI.Length;
    int i= 0;
    Console.WriteLine("    ==== Array of int ====");

    while ( i < nL)
    {
        Console.Write($" {arrI[i]}");
        i++;
    }
    Console.WriteLine("");
}

int  MaxArr(int [] arrI)
{
    int nL = arrI.Length, i = 0;
    int maximum = arrI[0];

     while ( i < nL)
    {
        if (maximum < arrI[i])
        {
            maximum = arrI[i];
        }
    }

    return  maximum;
}

int indexOf(int [] arrI, int findI)
{
    int nL = arrI.Length;
    int i= 0, iOf = -1 ; // iOf = -1  then not found findI
    while ( i < nL)
    {
        if (arrI[i] == findI)
        {
            iOf = i;
            break;   // find first ...
        }
        i++;
    }
    return iOf;
}



int arrLngth = 10;
int[] arr0 = new int [arrLngth];

fillArr(arr0, 0, 10);
printArr(arr0);

int ffI = 6;
int ffIndex =  indexOf( arr0, ffI);

if (ffIndex > -1)
{
    Console.WriteLine($"  find in array {ffI}  index  {ffIndex}");
} else {
    Console.WriteLine($"  find in array {ffI}  not found ...");
    printArr(arr0);
}


