// using System;
// using System.IO;

// class Program {
//     static void Main(string[] args) {
//         Console.Write("Enter the size of the array: ");
//         int n = int.Parse(Console.ReadLine());

//         int[] arr = new int[n];
//         for (int i = 0; i < n; i++) {
//             Console.Write($"Enter element {i+1}: ");
//             arr[i] = int.Parse(Console.ReadLine());
//         }

//         // write array elements to file
//         string filename = "array.txt";
//         using (StreamWriter writer = new StreamWriter(filename)) {
//             foreach (int num in arr) {
//                 writer.WriteLine(num);
//             }
//         }

//         // read array elements from file and find max and min
//         int max = int.MinValue;
//         int min = int.MaxValue;
//         using (StreamReader reader = new StreamReader(filename)) {
//             string line;
//             while ((line = reader.ReadLine()) != null) {
//                 int num = int.Parse(line);
//                 if (num > max) {
//                     max = num;
//                 }
//                 if (num < min) {
//                     min = num;
//                 }
//             }
//         }

//         Console.WriteLine($"Max: {max}");
//         Console.WriteLine($"Min: {min}");
//     }
// }

using System;
// using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
// using Newtonsoft.Json.Linq;
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        #region creating object to serialize
        // Create an object to serialize
        var person = new { Name = "Alice", Age = 25, Occupation = "Engineer" };
        #endregion creating object to serialize
        
        // Serialize the object to JSON
        var json = JsonSerializer.Serialize(person);

        #region Writing into jason file and displaying it
        // Display the serialized JSON string
        Console.WriteLine(json);
        StreamWriter writer = new StreamWriter("input.json");
        writer.WriteLine(json);
        writer.Close();

        #endregion Writing into jason file and displaying it

        // Deserialize the object
        Person obj = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine($"{obj.Name}");
        Console.WriteLine($"{obj.Age}");
        // TODO: kuch nhi
        // FIXME: hi
        Console.WriteLine($"{obj.Occupation}");
    }
}
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
}