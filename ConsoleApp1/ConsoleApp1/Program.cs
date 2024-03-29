﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp1.FizzBuzzPrac;
using ConsoleApp1.GreetingPrac;
using ConsoleApp1.PyramidPrac;
using ConsoleApp1.RandomNumberPrac;
using ConsoleApp1.StringPrac;
using ConsoleApp1.typesConversion;
using ConsoleApplication1.EnumPrac;
using ConsoleApplication1.ParametersImpl;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // print palindrome text
            PalindromePrac pp = new PalindromePrac();
            // string[] tmp = pp.ConvertToStringArr("Hi,exe? ABBA!");
            // for (int i = 0; i < tmp.Length; i++)
            // {
            //     Console.WriteLine(tmp[i]);
            // }
            //Console.WriteLine(pp.ConvertToStringArr("Hi,exe? ABBA!"));
            
            pp.printPalindromeOnly("Hi,exe? ABBA! Hog fully a string: ExE. Bob");
            
            
            //reverse string
            ReverseString rs = new ReverseString();
            //rs.PrintReversedString("alpha365");
            string s = "kjrge";
            //Console.WriteLine(rs.ToCharArrayStringReverse(s));
            
            
            
            
            string elva= "elva365";
            char[] wordsArr = elva.ToCharArray();
            //Console.WriteLine(elva[2]); // ok
            // foreach (char cha in elva)
            // {
            //     Console.WriteLine(cha);
            // }
            Console.WriteLine();
            Console.WriteLine("-----");

            
            // loop, copy array
            int[] firArr = { 0,1, 2, 3, 4, 5, 6,7,8,9 };
            int[] secondArr = new int[firArr.Length];
            //
            // for (int i = 0; i < firArr.Length; i++)
            // {
            //     secondArr[i] = firArr[i];
            //     Console.WriteLine($"firstArr: {firArr[i]}");
            //     Console.WriteLine($"secondArr: {secondArr[i]}");
            // }

            // copy array
            int[] originalArray = { 1, 2, 3, 4, 5 };

            // Using CopyTo()
            int[] copyArray = new int[5];
            originalArray.CopyTo(copyArray, 0);

            // Using Clone()
            int[] clonedArray = (int[])originalArray.Clone();
            
            
            
            // store diff data types
            object[] arrObj = new object[] { 1, true, 5.00, "ghdj" };
            // Console.WriteLine(arrObj[1]);
            // Console.WriteLine(arrObj[3]);
            
            // sort array
            int[] arr2 = new int[] { 99, 5, 1, 47, 0 };
            Array.Sort(arr2);
            // Console.WriteLine(arr2[0]);
            // Console.WriteLine(arr2.Length);
            
            // array
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            // Console.WriteLine(arr[0]);
            
            
            // counting
            // for (int i = 1; i <= 4; i++) {
            //     // Inner loop for counting up to 24 with the increment based on the outer loop variable
            //     for (int j = 0; j <= 24; j += i) {
            //         // Print the current value
            //         Console.Write(j);
            //     
            //         // Print comma if it's not the last value
            //         if (j != 24) {
            //             Console.Write(",");
            //         }
            //     }
            //     Console.WriteLine(); // Move to the next line after each set of numbers
            // }
            
            // greeting
            DateTime t = new DateTime(1999, 1, 13, 22, 57, 32, 11);
            DateTime cur = DateTime.Now;
            //Console.WriteLine(t);
            Greeting g = new Greeting();
            //g.GreetingWords(t);
            
            
            
            
            // pyramid
            Pyramid p = new Pyramid();
            //p.BuildPyramid(5);
            
            // generate random number
            RandomNumber rn = new RandomNumber();
            // rn.GuessARandomNumber();
            
            
            Random rnd = new Random();
            int num = rnd.Next();
            // Console.WriteLine(rnd.Next(1,4)); // range between 1~3, (>= 1 and < 4)
            // int correctNumber = new Random().Next(3) + 1;
            // Console.WriteLine(correctNumber);
            
            Console.WriteLine("-----");
            
            // infinite loop
            int max = 500;
            // for (byte i = 0; i < max; i++)
            // {
            //     Console.WriteLine(i);
            //     byte maxVal = byte.MaxValue;
            //     if (i == maxVal)
            //     {
            //         Console.WriteLine("warning!! If continues, next number will have byte overflow problem");
            //         break;
            //     }
            // }
            
            //FizBuzz
            FizzBuzz fb = new FizzBuzz();
            // for (int i = 0; i <= 100; i++)
            // {
            //     Console.WriteLine("number: "+i );
            //     fb.printFizzBuzz(i);
            // }
            
            
            // forEach
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            // foreach (int num in numbers){
            //     Console.WriteLine(num);
            // }

            // switch
            // string result = "";
            // switch(result)
            // {
            //     case"+" : break;
            //     case"-" :
            //         break;
            // };

            
            // int day = 4;
            // switch(day) 
            // {
            //     case 4:
            //         // code block
            //         Console.WriteLine("Thursday");
            //         break;
            //     case 2:
            //         // code block
            //         Console.WriteLine("error");
            //         break;
            //     default:
            //         Console.WriteLine("default");
            //         break;
            // }
            
            // string name = "John";
            // switch(name) 
            // {
            //     case "John":
            //         // code block
            //         Console.WriteLine("it is John");
            //         break;
            //     case "Mary":
            //         // code block
            //         Console.WriteLine("error");
            //         break;
            //     default:
            //         Console.WriteLine("default");
            //         break;
            // }
            
            // infinite loop
            // for (; true;)
            // {
            // }


            // return in loop
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("ahead: "+i );
            //     if (i == 2)
            //     {
            //         return;
            //     }
            //
            //     Console.WriteLine(i);
            // }
            

            // What is the difference between x = y++; and x = ++y;?
            int x11 = 5;
            int y11 = ++x11;
            Console.WriteLine(y11+", "+ x11);
            // increments the value of x,
            // and then assigns it to y.
            
            int x2 = 5;
            int y2 = x2++;
            Console.WriteLine(y2+", "+ x2);
            // assigns the value of x to y,
            // and then increments x.
            
            // knowledge
            //byte num2 = 255+1; //Cannot convert source type 'int' to target type 'byte'
            byte num2 = 255;
            // Console.WriteLine(num2.GetType());
            // Console.WriteLine($"byte255+1: {num2+1}");
            // Console.WriteLine(-4.0/0);
            
            // century conversion
            CenturyConversion centuryC = new CenturyConversion();
            // centuryC.CenturyConversionDetail(1);
            // long days = 100 * 36525L;
            // Console.WriteLine(days);
            
            
            // Number sizes and ranges
            // Console.WriteLine($"sbyte size:  {sizeof(sbyte)}, MinValue: {sbyte.MinValue}, MaxValue: {sbyte.MaxValue}");
            // Console.WriteLine($"byte size:  {sizeof(byte)}, MinValue: {byte.MinValue}, MaxValue: {byte.MaxValue}");
            // Console.WriteLine($"short size:  {sizeof(short)}, MinValue: {short.MinValue}, MaxValue: {short.MaxValue}");
            // Console.WriteLine($"ushort size:  {sizeof(ushort)}, MinValue: {ushort.MinValue}, MaxValue: {short.MaxValue}");
            // Console.WriteLine($"int size:  {sizeof(int)}, MinValue: {int.MinValue}, MaxValue: {int.MaxValue}");
            // Console.WriteLine($"uint size:  {sizeof(uint)}, MinValue: {uint.MinValue}, MaxValue: {uint.MaxValue}");
            // Console.WriteLine($"long size:  {sizeof(long)}, MinValue: {long.MinValue}, MaxValue: {long.MaxValue}");
            // Console.WriteLine($"ulong size:  {sizeof(ulong)}, MinValue: {ulong.MinValue}, MaxValue: {ulong.MaxValue}");
            // Console.WriteLine($"float size:  {sizeof(float)}, MinValue: {float.MinValue}, MaxValue: {float.MaxValue}");
            // Console.WriteLine($"double size:  {sizeof(double)}, MinValue: {double.MinValue}, MaxValue: {double.MaxValue}");
            // Console.WriteLine($"decimal size:  {sizeof(decimal)}, MinValue: {decimal.MinValue}, MaxValue: {decimal.MaxValue}");
            byte a = 255;
            //byte a = -1;
            char b = 'g';
            
            
            
            // ReadLine and WriteLine
            // string feeling; //declaring variable feeling           
            //
            // Console.WriteLine("Hey, how do you feel today?");            
            //
            // feeling = Console.ReadLine(); // takes the input from the user           
            //
            // Console.WriteLine("Hello there! I am feeling "+ feeling + "!"); // print the output 
            
            
            


            Console.WriteLine("********");
 

            


            
            // pass by ref
            ParamPassing demo = new ParamPassing();
            int x = 30;
            int y = 10;
            string c = "hello";
            // Console.WriteLine($"Before calling passing by value method: x={x}, y={y}, c={c}");
            // demo.PassingByValue(x, y, c);
            // Console.WriteLine($"After calling passing by value method: x={x}, y={y}, c={c}");
            // Console.WriteLine("______________________________");
            // Console.WriteLine($"Before calling passing by reference method: x={x}, y={y}, c={c}");
            // demo.PassingByReference(ref x, ref y, ref c);
            // Console.WriteLine($"After calling passing by reference method: x={x}, y={y}, c={c}");
            //out mode
            string str;
            // Console.WriteLine(demo.IsAuthentic("Anjila", "Antra123", out str));
            // Console.WriteLine("str:"+ str);
            //Param
            // demo.PrintParamString("John", "abc@gmail.con", "seattle", "WA");
            // Console.WriteLine(demo.AddNumbers(20,30));
            // Console.WriteLine(demo.AddNumbers(20,30,30,40));

            //demo.AddTwoNumbers(1,2);
            //demo.AddThreeNumbers(1,2,3);
            
            
            
            DaysOfWeek today = DaysOfWeek.Tuesday;
            //Console.WriteLine(today);

            // boxing and unboxing
            int numm = 123;
            object obj = numm; // boxed num

            obj = 123;
            numm = (int) obj; //unboxing


            // Console.WriteLine("hello world"); //cw tab
            // Console.WriteLine("try shortcut"); // command+ option+ /
            
            // Pagination
            // Sample data (list of integers)
            var data = Enumerable.Range(1, 100); // Generating numbers from 1 to 100
        
            // Pagination parameters
            int pageSize = 10; // Number of items per page
            int pageNumber = 3; // Page number to retrieve (0-based index)

            // Calculate how many elements to skip based on page size and number
            int itemsToSkip = pageNumber * pageSize;

            // Retrieve a page of data
            var pageOfData = data.Skip(itemsToSkip).Take(pageSize);

            // Display the page of data
            Console.WriteLine($"Page {pageNumber + 1}:");
            foreach (var item in pageOfData)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}