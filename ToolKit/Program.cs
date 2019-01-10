using System;
using System.Collections.Generic;
using System.Reflection;
using ToolKit.Models;

namespace ToolKit
{
    class Program
    {
        static void Main(string[] args)
        {
            //string InterPolation
            //Interpolation ınterpolation = new Interpolation();
            //string interpolation = ınterpolation.InterpolationWithClassData();
            //Console.WriteLine(interpolation);

            //Null Check
            //NullControlMechanism nullControlMechanism = new NullControlMechanism();
            //string isNull = nullControlMechanism.NullableControl();
            //Console.WriteLine(isNull);

            //ToType Extension Method
            //string number = "12";
            //long convertedToLong = number.ToLong();
            //Console.WriteLine(convertedToLong);
            //DateTime dateTime = DateTime.UtcNow;
            //Console.WriteLine(dateTime);
            //string convertDateTime = dateTime.DateTimeToString();
            //Console.WriteLine(convertDateTime);
            //int first = 12,second = 5;
            //if (first.intEquals(second))
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("not equals");
            //}

            //udage of delegate
            //DelegateExample delegateExample = new DelegateExample();
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = delegateExample.getEvenNumbers(numbers);


            //nameof example
            //NameOfExample nameOfExample = new NameOfExample();
            //Console.WriteLine(nameOfExample.AuthorInfo());

            //JsonEx.CreateJsonData();
            //List<Customer> customers = new List<Customer>();
            //customers.AddRange(JsonEx.ReadJsonDataFromTxt());



            //1-
            Type param = Type.GetType("ToolKit.Models.Author");
            //Type param = Type.GetType("System.String");

            //2
            //Customer customer = new Customer();
            //Type param = customer.GetType();

            Console.WriteLine("-Constructor Infos-");
            ReflectionEx.GetConstructorInfos(param);
           
            Console.WriteLine("-Property Infos-");
            ReflectionEx.GetPropertyInfos(param);
            
            Console.WriteLine("-Method Infos-");
            ReflectionEx.GetMethodInfos(param);


            //3->Runtime Reflection
            Console.WriteLine("-DynamicallyDataBinding Infos-");
            Console.WriteLine($"DynamicallyDataBinding:{ReflectionEx.LateBinding()}");

            Console.ReadLine();
        }
    }
}
