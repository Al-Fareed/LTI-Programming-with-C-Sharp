using System;
using System.Collections.Generic;
class GenericClass
{
    public static void Print<T>(T element){
        Console.WriteLine(element);
    }   
}