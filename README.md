# **Final Test**

*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*

## Текстовое описание решения

* Задаем исходный массив.
* Создаем ф-цию которая считает количество строк подходящих под условие задачи в исходном массиве.
* Объявляем новый (второй) массив, длина которого являеться результат вышеуказанной ф-ции (экономим оперативную память).
* Перебираем в цикле исходный массив и задаем условия задачи. Если условие выполняется, сохраняем подходящие строки в новый массив.
* Выводим новый массив в консоль для проверки.
