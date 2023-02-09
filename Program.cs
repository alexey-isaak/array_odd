int array_length = 100;

int[] array = new int[array_length];
for (int i=0;i<array_length;i++)
{
    Random random = new Random();
    int a = random.Next(1, 100);
    array[i] = a;
}


int summ_odd = 0;
for (int i=0;i<array_length;i++)
{
    if (i % 2 != 0)
    {
        summ_odd = summ_odd + array[i];
    }
}

Console.WriteLine("Сумма чисел на нечетных позициях: " + summ_odd);

//
//Второй способ
//

List<int> array_odd = new List<int>(); //создаем коллекцию неопределенной длины
for (int i=0;i<array_length;i++)
{
    if (i % 2 != 0)
    {
        array_odd.Add(array[i]); //наполняем коллекцию элементами исходного массива
    }
}

int summ_odd1 = 0;
int array_odd_l = array_odd.Count; //вычисляем длину
for (int j=0;j<array_odd_l;j++)
{
    summ_odd1 = summ_odd1 + array_odd[j];
}

Console.WriteLine("Сумма чисел на нечетных позициях: " + summ_odd1);