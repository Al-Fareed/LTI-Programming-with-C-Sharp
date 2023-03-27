using System;

class Stall
{
    public void ComputeCost(string type,int ft){
        Console.WriteLine("Gold costs Rs.{0}",(100*ft));
    }  
    public void ComputeCost(string type, int ft, int noOfTv){
        Console.WriteLine("Diamond costs Rs.{0}",((150*ft)+(noOfTv*100)));
    }  
    public void ComputeCost(string type, int ft, bool ch){
        Console.WriteLine("Platinum costs Rs.{0}",((200*ft)+(ch==true?1000:0)));
    }  
      
}
