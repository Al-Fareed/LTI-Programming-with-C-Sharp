/*

Hazecraft Client Series 
The Event Organizing Company "Hazecraft" focuses on event management in a way that creates a win-win situation for all involved stakeholders. Hazecraft doesn't look at building one time associations with clients but aim at creating long-lasting collaborations that will span years to come. This goal of the company has helped them to evolve and gain more clients within a notable time.
The number of clients of the company from the start day of their journey till now is recorded sensibly and is seemed to have followed a specific series like 2,3,5,7,11,13,17,19, 23,…, etc

Write a program that takes an integer N as the input and will output the series till the Nth term.

Note:

The given series is prime number series.

Input Format:

The first line of the input is an integer N.

Output Format:

The output is a single line series till Nth term, each separated by a space.
Refer sample input and output for formatting specifications.

Sample Input 1:

5

Sample Output 1:

2 3 5 7 11

Sample Input 2:

10

Sample Output 2:

2 3 5 7 11 13 17 19 23 29
*/

// Try this :)
// using System;
// class Program{
//     static void Main(){
//         int n=int.Parse(Console.ReadLine());
//         int[] arr={2, 3, 5, 7, 11 ,13, 17 ,19 ,23, 29, 31, 37, 41, 43 ,47, 53, 59, 61 ,67, 71 ,73 ,79, 83, 89, 97 ,101 ,103, 107, 109,113, 127, 131, 137, 139,149 ,151, 157, 163, 167 ,173, 179, 181, 191, 193, 197, 199, 211, 223, 227 ,229, 233, 239, 241 ,251, 257, 263 ,269, 271 ,277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541};
//         for(int i=0;i<n;i++){
//             Console.Write(arr[i]+" ");
//         }
//     }
// }
// else try this

class Program {
    static bool IsPrime(int num) {
        if (num <= 1) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }

    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int num = 2;
        while (count < n) {
            if (IsPrime(num)) {
                Console.Write(num + " ");
                count++;
            }
            num++;
        }
    }
}
