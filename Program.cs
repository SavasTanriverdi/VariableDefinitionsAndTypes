using System;

namespace VariableDefinitionsAndTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer (Tam sayı) tipi örneği
            int age = 25;
            Console.WriteLine("Age: " + age);

            // Double (Ondalık sayı) tipi örneği
            double height = 1.75;
            Console.WriteLine("Height: " + height);

            // String (Metin) tipi örneği
            string name = "John Doe";
            Console.WriteLine("Name: " + name);

            // Boolean (Mantıksal) tipi örneği
            bool isStudent = true;
            Console.WriteLine("Is Student: " + isStudent);

            // Char (Tek karakter) tipi örneği
            char grade = 'A';
            Console.WriteLine("Grade: " + grade);

            // Var (Türü derleme zamanında belirlenen değişken)
            var country = "USA";
            Console.WriteLine("Country: " + country);

            // Constant (Sabit) değişken örneği
            const double PI = 3.14159;
            Console.WriteLine("PI: " + PI);

            // Farklı türde değişkenleri birleştirerek kullanım örneği
            Console.WriteLine($"{name} is {age} years old, height is {height} meters, grade is {grade}, and studies in {country}.");
        }
    }
}