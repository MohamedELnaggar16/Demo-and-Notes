using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Sum(int x,int y)
        {
            return x - y;
        }
        static void Main(string[]   args)
        {
            //Console.WriteLine("Hello World!");
            #region

            #region syntax error or compilation error
            //intt x; ==> when you write the commands wrong 
            // we called it compilation error bec we have error when we change this code to assembly file 
            #endregion

            #region runtime error 
            // error happen in run time when we change assembly file to 0 and 1
           // int x = 5;
           // int y = 0;
           // Console.WriteLine(x / y);
            // error happen in runtime bec we cant diveded 5 or any number to zero
            #endregion

            #region Logical error 
            // error in the logic and it will clear by example that we made function to add two nums
            // but in code we do mistake that two nums will subtracting not adding
            int a = 10;
            int b = 5;
            Console.WriteLine(Sum(a, b));

            #endregion

            #region Warining
            //int x;
            // the variable you declared not used yet and this is waste of memory

            #endregion

            #region variable 
            //5
            // int number = 5 ;
            // before we declare the variable we should know the type of int 
            // the size of it 
            // and then when we declare variable and run it CLR will take it and make address in ram to reach it 
            // note => variable saved in ram not in hard 
            // note => we store the address of value in stack and the value of it in the heap
            #endregion

            #region CTS - CLS
            // spesification that has common it all .net languages like C# , F# , VB
            // there is two data types : Value type , Reference type (stored in stack and heap)
            // stack => small memory ,soted in it when you know the value exactly 
            // heap => biger than stack when i stored value that i dont know what value it is

            #endregion

            #region Value type
            // int x;  // allocate 4 byte in stack
            // int x = 4 ;
            // int y = 9;  // allocate 4 byte in stack
            // y = x  // we equal y = x = 4

            // x++ // we add 4 with 1 = 5

            #endregion

            #region Refrence type
            //we make class poin has two ponts x and y 
            // point p1 ; // allocate 4 byte in stack and zero byte in heap
            // p1 = New Point // allocate reqired byte in heap 9 byte bec class has two points 4 , 4
            // and take refrence (p1) to point to heap with the value (new point)

            #endregion

            #endregion
        }
    }
}
