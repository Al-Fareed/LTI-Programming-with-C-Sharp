using System;
using System.Linq;
public class UserProgram
{
    public static string[] FilterArray(string[] nameList, int minLength)
    {
        return  nameList.Where(x=>x.Length < minLength).ToArray();
    }

}