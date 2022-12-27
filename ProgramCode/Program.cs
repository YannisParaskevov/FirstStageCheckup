using System;
using static System.Console;
Clear();

// метод для печати массива строк в виде - каждый элемент в "" и разделен separator'ом
// доп параметры - startLine и endLine - начало и конец строки вывода
void PrintArray(string[] array, string separator, string startLine, string endLine) { 
    Write(startLine);
    for (int i = 0; i < array.Length; i++){
        Write($"\"{array[i]}\"");
        if (i < array.Length - 1) {
            Write(separator);
        }
    }
    Write(endLine);
}

// метод для создания целевого массива строк по условиям задачи
string[] LimitElementLenght(string[] array, int limit, string separator) { 
    string resultString = String.Empty;
    for(int i=0; i<array.Length; i++){
        if(array[i].Length <= limit) {
            resultString += array[i] + separator;
        }
    }
    string[] resArray = resultString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    return resArray;
}

string[] sourceArray = {"1971", "for", ":))", " 12", " | ", " || ", "c_ ", "trap"};
// string[] sourceArray = {"Hello", "2", "world", ":-)"};
// string[] sourceArray = {"1234", "1567", "-2", "computer science"};
// string[] sourceArray = {"Russia", "Denmark", "Kazan"};
int limit = 3; // ограничение длины элемента для попадания в итоговый массив
string separator = ", "; // формат разделителя элементов массивов
PrintArray(sourceArray, separator, "[", "]  ->  ");
string[] targetArrey = LimitElementLenght(sourceArray, limit, separator);
PrintArray(targetArrey, separator, "[", "]");
