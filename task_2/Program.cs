//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = GetArray(5, 1, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
int sum = 0;
for(int i = 0; i < array.Length; i++){
    sum += i % 2 != 0 ? array[i] : 0;
}
Console.WriteLine(sum);
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
