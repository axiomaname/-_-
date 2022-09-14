string [] array1(int size)
{
    string [] newArray= new string [size];
    Console.WriteLine("Создание массива ниже: ");
    for (int i=0;i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент  : ");
        newArray[i]=Convert.ToString(Console.ReadLine());
    }
        Console.WriteLine();
      return newArray;

}

void array2(string [] array1)
    {
        for (int i=0;i < array1.Length; i++)
        {   
            int size=3;
            if(array1[i].Length<=size)
            {
                string[] newArray2=new string[array1.Length];
                newArray2[i]=array1[i];
        
            Console.Write($" {newArray2[i]} ");
            }
        }
    
Console.WriteLine();
}

void ShowArray(string [] array)
{
    for (int i=0;i < array.Length; i++)
    Console.Write(array[i] + " ");
 Console.WriteLine();
}

string [] NewArray=array1(4);
ShowArray(NewArray);
Console.Write("Новый масив: ");
array2(NewArray);



