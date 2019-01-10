using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ToolKit.Models;

namespace ToolKit
{
   public static class ReflectionEx
    {
        
        public static void GetConstructorInfos(Type types)
        {
            ConstructorInfo[] constructorInfos = types.GetConstructors();

            foreach (var consInfo in constructorInfos)
            {
               //Constructor Parameters
                ParameterInfo[] parameterInfos = consInfo.GetParameters();

                foreach (var parInfo in parameterInfos)
                {
                    Console.WriteLine($"ParameterName:{parInfo.Name}\tParameterType:{parInfo.ParameterType}\tisOptional::{parInfo.IsOut}");
                }
                
            }
            
        }

        public static void GetPropertyInfos(Type type)
        { 
            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (var item in propertyInfos)
            {
                Console.WriteLine($"Name:{item.Name}\tDeclaringType:{item.DeclaringType}\tPropertyType:{item.PropertyType}");
            }
        }
         
        public static void GetMethodInfos(Type type)
        { 
            MethodInfo[] methodInfos = type.GetMethods();

            foreach (var metInfo in methodInfos)
            {
                Console.WriteLine($"Name:{metInfo.Name}\tReturnType:{metInfo.ReturnType}");
            }
        }

        public static string LateBinding()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType("ToolKit.Models.Author");

            object author = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod("CombineNameAndSurname");
            
            string[] parameters = new string[2] { "M", "K" };
            
            return (string)methodInfo.Invoke(author,parameters);
        }

    }
}
