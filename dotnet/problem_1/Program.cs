using System;
using System.Collections.Generic;

public class Program
{
    public static void Main (string[] args)
    {
        List<int> muiltipleByThreeAndFive = new List<int>();
        int naturalNumber = 100;
        
        for(int i=1; i<naturalNumber; i++){
            if ((i % 3) == 0) {
                muiltipleByThreeAndFive.Add(i);
            }
            if ((i % 5) == 0) {
                muiltipleByThreeAndFive.Add(i);
            }
        }
        for(int i=0; i<muiltipleByThreeAndFive.Count; i++){
            Console.WriteLine(muiltipleByThreeAndFive[i]);
        }
        
    }
}