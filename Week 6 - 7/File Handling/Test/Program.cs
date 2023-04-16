using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            Console.Write($"Enter element {i+1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // write array elements to file
        string filename = "array.txt";
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (int num in arr) {
                writer.WriteLine(num);
            }
        }

        // read array elements from file and find max and min
        int max = int.MinValue;
        int min = int.MaxValue;
        using (StreamReader reader = new StreamReader(filename)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                int num = int.Parse(line);
                if (num > max) {
                    max = num;
                }
                if (num < min) {
                    min = num;
                }
            }
        }

        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
    }
}
