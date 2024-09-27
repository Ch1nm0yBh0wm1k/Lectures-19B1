// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//const int a = 2;

////type casting
//int numInt = 1;
//double num = numInt; //implicit

//string x = "12";
//num = (int)Convert.ToInt16(x);

//String xyz = "123";

//int[] array = { 1, 2, 3, 4 };
////foreach 
//foreach(var item in array)
//{
//    Console.WriteLine(item);
//}


//binary search
int[] array = { 1, 2, 3, 4, 8, 0 };
Array.Sort(array);
int key = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BinarySearch(array, key));
static string BinarySearch(int[] arr, int key)
{
    int min = 0;
    int max = arr.Length - 1;
    int mid = 0;

    while (min <= max)
    {
        mid = (min + max) / 2;

        if (key == arr[mid])
            return "Found";
        else if (key < arr[mid])
            max = mid - 1;
        else if (key > arr[mid])
            min = mid + 1;

    }
    return "Not Found";


    
}

