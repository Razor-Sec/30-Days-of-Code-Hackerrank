using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split( );
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        for (var i = n - 1; i > -1; i--)
            {
            Console.Write(arr[i] + " ");
        }
    }
}
