# <p align="center"> Итоговая проверочная работа по итогам прохождения первого блока обучения по программе Разработчик. </p>
## 1. Условие задачи:

<p align="justify">Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.</p>

__*Примеры:*__  
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]  
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []

## 2. Описание алгоритма решения:

* Цикл по элементам исходного массива с проверкой условия - длина элемента <=3?  
* Если условие выполняется, то, к предварительно созданной пустой строке, добавляем этот элемент и разделитель ", ".  
* После завершения цикла преобразуем получившуюся строку в итоговый массив.

## 3. Комментарии к программе, решающей поставленную задачу:

* При решении используется метод разделения строк `String.Split` с опцией удаления пустых значений. Если составители задачи не предполагали использование этого метода, то примерный алгоритм решения:  
    * (1) подсчет в цикле кол-ва элементов исх. массива с длиной меньше 3,  
    * (2) создание итогового массива с длиной по (1),  
    * (3) цикл по исх.массиву с заполением итогового массива элементами необ.длины и использованнии доп.счетчика
* Для не_использования "магических чисел" в коде введены переменная `limit` (лимит длины элемента для включения в итоговый массив) и разделитель `separator` (для учета элементов исх.массива, которые, судя по примерам, могут включать в себя пробелы и/или различные символы)
* Программный код написан с учетом воспроизведения формата Примеров, приведенных в задании, а именно  
`(каждый элемент заключен в "", для разделения используются ", ", каждый массив заключен в [])`  
