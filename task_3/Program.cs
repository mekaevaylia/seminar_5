// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76

int [] array = GetArray(5, 1, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
int result = 0;
int max = array[0];
int min = array[0];
for(int i = 0; i < array.Length; i++){
    if(array[i] > max)  {
        max = array[i]; 
    }
    if(array[i] < min) {
        min = array[i];
    }
result = max - min;
}
Console.WriteLine($"Ответ {max} - {min} равно {result}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}