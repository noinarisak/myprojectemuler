using System;
using System.Collections.Generic;

public class Program
{
    public static void Main (string[] args)
    {
        List<int> multipleByThreeAndFive = new List<int>();
        int naturalNumber = 10;
        int sum = 0;
        
        multipleByThreeAndFive = GetMultipleOfThreeAndFive(naturalNumber);
        sum = GetSumFoundNaturalNumber(multipleByThreeAndFive);
        
        Console.WriteLine("Natural number below: " + naturalNumber.ToString());
        Console.WriteLine("Sum: " + sum.ToString());
        
        naturalNumber = 1000;
        
        multipleByThreeAndFive = GetMultipleOfThreeAndFive(naturalNumber);
        sum = GetSumFoundNaturalNumber(multipleByThreeAndFive);
        
        Console.WriteLine("Natural number below: " + naturalNumber.ToString());
        Console.WriteLine("Sum: " + sum.ToString());
        
    }
    
    private static List<int> GetMultipleOfThreeAndFive(int naturalNumber){
        List<int> multipleByThreeAndFive = new List<int>();
        
        for(int i=1; i<naturalNumber; i++){
            if (((i % 3) == 0) || ((i % 5) == 0)){
                multipleByThreeAndFive.Add(i);
            }
        }
        
        return multipleByThreeAndFive;
    }
    
    private static int GetSumFoundNaturalNumber(List<int> multipleByThreeAndFiveList){
        int sum = 0;
        for(int i=0; i<multipleByThreeAndFiveList.Count; i++){
            Console.WriteLine(multipleByThreeAndFiveList[i]);
            sum += multipleByThreeAndFiveList[i];
        }
        return sum;
    }
}