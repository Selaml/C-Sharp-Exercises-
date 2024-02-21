using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //    var list = new List<string>(){
        //    "a","b","c"
        //    };
        //    int[] a = { 5, 6, 7 };

        //    int[] b = { 3, 6, 10 };
        //    var rt = new List<int>();
        //    int suma = 0;
        //    int sumb = 0;
        //    for (int i = 0; i < a.Count(); i++)
        //    {

        //        if (a[i] > b[i])
        //        {
        //            suma = suma + 1;
        //            // rt.Add(suma);

        //        }
        //        else if (a[i] < b[i])
        //        {
        //            sumb = sumb + 1;
        //            // rt.Add(sumb);
        //        }
        //        else
        //        {
        //            suma = suma + 0;
        //            sumb = sumb + 0;
        //        }



        //    }
        //    Console.WriteLine(suma);
        //    Console.WriteLine(sumb);
        //    rt.Add(suma);
        //    rt.Add(sumb);
        //    foreach (var tt in rt)
        //    {
        //        Console.WriteLine(tt);

        //    }
        //    List<List<int>> arr = new List<List<int>>();

        //    arr.Add(new List<int>() { 1, 2, 3 });
        //    arr.Add(new List<int>() { 4, 5, 6 });
        //    arr.Add(new List<int>() { 7, 8, 10 });
        //    //    arr.Add(new List<int>() { 17, 18, 10 });

        //    int sum1 = 0;
        //    int sum2 = 0;
        //    int n = arr.Count;
        //    Console.WriteLine(n);
        //    //  arr.Add(new List<int> { 18,19,11 });
        //    //Console.WriteLine(arr[2][1]);
        //    //int sum1 = arr[0][0] + arr[1][1] + arr[2][2];
        //    //int sum2 = arr[0][2] + arr[1][1] + arr[2][0];
        //    ////int sum3 = arr[0][3]
        //    //Console.WriteLine(sum1);
        //    //Console.WriteLine(sum2);
        //    //Console.WriteLine(Math.Abs(sum1-sum2));

        //    // iterate over each row
        //    //for (int i = 0; i < arr.Count; i++)
        //    //{
        //    //    iterate over each column in the current row
        //    //    for (int j = i + 1; j < arr[i].Count; j++)
        //    //    {
        //    //        print the current element
        //    //     var sum1 = arr[i] + arr[j];
        //    //        Console.Write(arr[i][j] + " ");
        //    //    }

        //    //    move to the next row
        //    //    Console.WriteLine();
        //    //}

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        sum1 = sum1 + arr[i][i];
        //        sum2 = sum2 + arr[i][n - 1 - i];


        //        // Console.WriteLine(arr[i][j]);
        //        //  Console.WriteLine(arr[0][0]);


        //        // Console.WriteLine(u.ToList());

        //    }

        //    Console.WriteLine(sum1);
        //    Console.WriteLine(sum2);
        //    var list = new List<int>() {

        //       1,-1,2,-3,0
        //       };

        //    var list2 = new List<int>();
        //    var list3 = new List<int>();
        //    var list4 = new List<int>();
        //    foreach (var item in list)
        //    {
        //        if (item > 0)
        //        {
        //            list2.Add(item);




        //        }
        //        else if (item < 0)
        //        {
        //            list3.Add(item);

        //        }
        //        else
        //        {
        //            list4.Add(item);

        //        }
        //    }
        //    decimal r1 = Convert.ToDecimal(list2.Count) / Convert.ToDecimal(list.Count);
        //    decimal r2 = Convert.ToDecimal(list3.Count) / Convert.ToDecimal(list.Count);
        //    decimal r3 = Convert.ToDecimal(list4.Count) / Convert.ToDecimal(list.Count);

        //    Console.WriteLine(r1.ToString("F6"));
        //    Console.WriteLine(r2.ToString("F6"));
        //    Console.WriteLine(r3.ToString("F6"));

        //    var list = new List<string>(4);
        // List<List<int>> arr = new List<List<int>>(4);
        //int n = arr.Count;
        //int n = 4;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= n; j++)
        //    {
        //        if (j <=  i)
        //        {
        //            Console.Write("#");
        //        }
        //        else
        //        {
        //            Console.Write("");
        //        }
        //    }
        //    Console.WriteLine();
        //}
        // var list = new List<int>()
        // {
        //    256741038,623958417, 467905213, 714532089, 938071625
        // };
        // long sum1 = 0;


        // var a =list.Max();
        // var b =list.Min();
        //// var c = Convert.ToInt64(list);

        // foreach(var item in list )
        // {
        //     if (item >= 1 && item <= 1000000000)
        //     {
        //        // var abc = Convert.ToInt64(item);

        //         sum1 = sum1+ item;
        //     }
        //     //sum2 =sum2+ list[i];

        // }




        // Console.WriteLine($"{sum1-a} {sum1-b}");
        // var list = new List<int>()
        //{ 1,2,3,4,4};
        // var list2 = new List<int>();
        //var a= list.Max();
        // Console.WriteLine(a);
        // foreach (var x in list)
        // {
        //     if (x == a){
        //         list2.Add(x);

        //         } 
        // string s = "12:05:45AM";
        //var nn = s.TrimEnd
        //     ('P','M');
        // Console.WriteLine(nn);
        // var g = DateTime.Parse(s);

        // // var bb = g.TimeOfDay;
        // Console.WriteLine(g.TimeOfDay.ToString());

        // if (s.EndsWith("AM") )
        // {

        //     Console.WriteLine(s.TrimEnd
        //     ('P', 'M'));
        // } else if(s.EndsWith("PM"))
        // {
        //     Console.WriteLine(g.TimeOfDay);
        // }

        var grades = new List<int>()
        {


84,
94,
21,
0,

        };
        List<List<int>> ar1 = new List<List<int>>();

        ar1.Add(new List<int>() { 1, 1, 1, 0 ,0 ,0
});
        ar1.Add(new List<int>() {0, 1, 0,0 ,0 ,0
 });
        ar1.Add(new List<int>() {1, 1, 1, 0 ,0, 0
});
        ar1.Add(new List<int>() { 0, 0, 2, 4, 4, 0 });
        ar1.Add(new List<int>() { 0, 0, 0 ,2 ,0 ,0
});
        ar1.Add(new List<int>() {0, 0, 1, 2, 4, 0
});

        //  ConsoleApp1 nn = new ConsoleApp1
        Riverse vv = new Riverse();
        var bb = vv.reverseArray(grades);
        foreach (int i in bb)
        {
            Console.WriteLine(i);
        }
        //// HourGlass ss = new HourGlass();
        // var sss = ss.hourglassSum(ar1);
        // foreach (var k in sss)
        // {

        //     Console.WriteLine(k);

        // }


        List<int> list = new List<int>() { -2, 2, 1 };
        List<int> list1 = new List<int>() { 5, -6 };

        SamsThree sam = new SamsThree();
        sam.countApplesAndOranges(7, 11, 5, 15, list, list1);


        HourGlass glass = new HourGlass();
        var n = glass.hourglassSum(ar1);
        Console.WriteLine(n);


        kangaroo kk = new kangaroo();

        var gg = kk.kangaroodist(2564, 5393, 5121, 2836);
        Console.WriteLine(gg);
        rotateArray rotate = new rotateArray();
        List<int> listRotate = new List<int>() { 1, 2, 3, 4, 5 };
        var reeee = rotate.rotateLeft(4, listRotate);
        Console.WriteLine(reeee);

        SearchMAtchingStrings mAtchingStrings = new SearchMAtchingStrings();
        List<string> listString = new List<string>() { "aba", "baba", "aba", "xzxb" };

        List<string> QString = new List<string>() { "aba", "xzxb", "ab" };
        var result = mAtchingStrings.matchingStrings(listString, QString);
        Console.WriteLine(result);



        RemoveNumber find = new RemoveNumber();
        int[] liststtttt = { 1, 2, 3, 4, 5, 6, 7 };
        int[] redddsult = find.RemoveNumberArray(liststtttt, 3);

        Console.WriteLine(redddsult[3]);

       List<int> listScore = new List<int>() { 3, 4, 21, 36 ,10, 28, 35 ,5 ,24, 42 };

        HigestScore higestScore = new HigestScore();
      var nn=  higestScore.HighScore(listScore);
      Console.WriteLine(nn);
        foreach (int i in nn)
        {
            Console.WriteLine(i);
        }

        //for (int i = 0; i <= 6; i++)
        //{
        //    for (int j = i; j<=6; j++)
        //    {

        //            Console.WriteLine("#");




        //    }

        //    Console.WriteLine("");



        //}


        //vv.reverseArray(grades);


        // }
        // Console.WriteLine(list2.Count);
        // 
        //var updatedgrades = new List<int>();
        //foreach (var i in grades)
        //{
        //    if (i < 38)
        //    {
        //        updatedgrades.Add
        //            (i);
        //    }
        //    else if (i>=38 && i<100)
        //    {

        //        for(int j = i+1; j <=100; j++)
        //        {
        //            if(j%5==0)
        //            {
        //                int x = j - i;
        //                if(x<3)
        //                {
        //                    updatedgrades.Add (j);
        //                    break;
        //                }
        //                else
        //                {
        //                    updatedgrades.Add (i);  
        //                    break;
        //                }              
        //            }

        //        }

        //    }
        //    else
        //    {
        //        updatedgrades.Add(i);
        //    }


        //}




        //foreach (var item in updatedgrades)
        //{
        //    Console.WriteLine(item);



        //}




        ///oprators subscribe for the system   they add their own b  
        ///but what i do is collecto alll the data rom alll subscribers and show it 
        ///which is better subscribe or rolle based 
        ///subscription , diffrent services
        ///user management C# and nest js other 





        int[,] arr = { { 0,1,1,2}, { 0,5,0,0},{ 2,0,3,13} };
        CodeBot codeBot = new CodeBot();
       var cde= codeBot.findRoom(arr);

        //  Console.WriteLine(cde);

        int[,] arr2 = { { 0, 1, 1, 2 }, { 0, 5, 0, 0 }, { 2, 0, 3, 13 } };

        securityCamera securityCameras = new securityCamera();
        var vvien = securityCameras.counttheBoxes(arr2);

        Console.WriteLine(vvien);


        singleLinkedLis lii = new singleLinkedLis();
        lii.add(20);
        lii.add(30);
        lii.add(40);
        lii.display();

    }
}


