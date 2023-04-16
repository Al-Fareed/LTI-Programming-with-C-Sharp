using System;
using System.Collections.Generic;
public class program
{
    static void Main()
    {
        HallBO hallBo = new HallBO();
        List<Hall> hallList = new List<Hall>();
        int choice;
        do
        {
            Console.WriteLine("1.Add Hall\n2.Remove Hall\n3.Exit\nEnter the choice:");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter hall detail:");
                string detail = Console.ReadLine();
                Hall halls = hallBo.CreateHall(detail);
                hallList.Add(halls);
                Console.WriteLine("Hall Created Successfully");
            }
            else if (choice == 2)
            {
                if (hallList.Count == 0)
                {
                    Console.WriteLine("List is Empty");
                    return;
                }

                if (hallList.Count > 0)
                {
                    Console.WriteLine("Total {0} Halls", hallList.Count);
                    Console.WriteLine("Enter the index:");
                    int index = int.Parse(Console.ReadLine());
                    if (index - 1 < hallList.Count)
                    {
                        hallList.RemoveAt(index - 1);
                        if (hallList.Count > 0)
                        {
                            hallBo.DisplayHalls(hallList);
                        }
                        else
                        {
                            Console.WriteLine("Hall list empty");
                        }
                    }
                    else
                    {
                       Console.WriteLine("List is Empty");
                       return;
                    }
                }
                // ----------------------------------------------------------------
                // if (hallList.Count > 0)
                // {
                //     Console.WriteLine("Total {0} Halls", hallList.Count);
                //     Console.WriteLine("Enter the index:");
                //     int index = int.Parse(Console.ReadLine());
                //     bool flag = hallBo.RemoveHallFromList(hallList, index);
                //     if (!flag)
                //     {
                //         Console.WriteLine("List is Empty");
                //     }
                // }
                // else
                // {
                //     Console.WriteLine("List is Empty");
                // }

            }
            else
            {
                return;
            }
        } while (choice != 3);
    }
}
