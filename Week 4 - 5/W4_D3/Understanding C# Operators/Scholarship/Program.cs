/*
Mark studies at Teswan National University. Now is the time for exam results. Mark hopes that his scores in 5 subjects in the exam could fetch him a scholarship for his GRE preparation.

The following simple rules  are used to find whether he is eligible to receive the scholarship:

The University follows 5 point grading system. In an exam, a student can receive any score from 2 to 5.  2 is called an F grade, meaning that the student has failed that exam.
The student should not have failed any of the exams.
The Student must obtain a full score in some of his/her exams to show that he/she is excellent in some of the subjects.
He/She must have a grade point average not less than 4.
​You are given information regarding how Mark performed in those 5 subjects. Write a program to check whether he will receive the scholarship or not.

 
Input Format:

The input contains 5 integers denoting Mark’s 5 subjects score in the exam.

Output Format:

Output a single line - "Yes" (without quotes) if Mark will receive the scholarship, otherwise "No" (without quotes).
Refer sample input and output for formatting specifications.

 

[All text in bold corresponds to input and the rest corresponds to the output.]

Sample Input and Output 1:

Enter the subject 1 mark
3
Enter the subject 2 mark
5
Enter the subject 3 mark
4
Enter the subject 4 mark
4
Enter the subject 5 mark
3
No


Sample Input and Output 2:

Enter the subject 1 mark
3
Enter the subject 2 mark
4
Enter the subject 3 mark
4
Enter the subject 4 mark
4
Enter the subject 5 mark
5
Yes
*/
using System;
class Program{
    void display(int num){
        Console.WriteLine("Enter the subject {0} mark",num);
    }
    bool result(int marks){
        if(marks<=2){
            return false;
        }else{
            return true;
        }
    }
    static void Main(){
        Program p=new Program();
        p.display(1);
        int sub1=int.Parse(Console.ReadLine());
        bool pass1=p.result(sub1);
        p.display(2);
        int sub2=int.Parse(Console.ReadLine());
        bool pass2=p.result(sub2);
        p.display(3);
        int sub3=int.Parse(Console.ReadLine());
        bool pass3=p.result(sub3);
        p.display(4);
        int sub4=int.Parse(Console.ReadLine());
        bool pass4=p.result(sub4);
        p.display(5);
        int sub5=int.Parse(Console.ReadLine());
        bool pass5=p.result(sub5);
        int avg=(sub1+sub2+sub3+sub4+sub5)/5;
        if(pass1 && pass2 && pass3 && pass4 && pass4 && pass5){
            if(avg>=4){
                Console.WriteLine("Yes");
            }
        }else{
            Console.WriteLine("No");
        }
    }
}