using System.Collections.Generic;
using System.Text;

namespace ArraysPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // STRINGBUILDER // 
            // STRINGBUILDER // 
            // STRINGBUILDER // 
            // STRINGBUILDER // 
            // STRINGBUILDER //
            // 
            /*
             * String Manipulation Methods ....
                        .Append();
                        .Insert();
                        .Remove();
                        .Replace();
                        .Clear();*/


            var builder = new StringBuilder("Hello to the entire world planet");
            builder.Append('-', 10)
                .AppendLine()
                .Append("header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
            // Removes first 10 characters from the string...
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(builder);



       

















            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 


            // Summarizing Text...


            var sentence = "tk tr6j e5yhw4 6he5 je57 je5 h5 jt7i k6j heyh ruyj 6r7he 5h tjr67 he56  asdf sadf asdf asdf asdf asdf asrfg bnsrfg nsr hnsry nhsdrxqsxqwd cwd cwd cdwcwcdw cdwcwdcwdcwdcwdcw efdf saf sdf wer qwer qr erqwe rqwe rqw erq wer qwer wqerqw ez n thn thn thn thn thn thn thn thnrg brgb rgb rgb rgb rgb rgb rgb rgb efv efv efv efv efv efv efv efv efve fv efv efvwd cwdc wd cwdc wdc wdc wdc wdc wdc wdc wdcw dc qsx qsx qsx qsxqs xqs xqsxqtyn dtyn ythry dry dr yhdrh dryh r yhsxqx stg stg setg qsx xqsxq serg setg sth sethsasdf asdfsegtdty tyui yui tyui tyui ytui tyui tyui ytui tyuity uit yuit yug jhkg hjkgh jkgh jkg hjk hgjkh gjkgh jkhj gkghj kj k jkhg bvc nv nmmn bv mnbv mnbv mncxv zxcv zcxv zxcv zxvc zxcv zxcv zxcv zxc vzxc vcx zv  tyuba ethq whj ns d athwr ns xfghn xdfghmr yiukg uyfj oui opui poiup oyp ouifg bsvfvevef yhn sdryn srhn sry hnsr yn sryn sry nsr yn sryn dtyhnm yuk i,my jm fyjm il, ip.,o mfoup oyui pouii o thn th vbm nm vb k,lhl khl khlk hjlk jh lkjh lkj kjlh lkjhl khjlk j posfghr p oiup oiop uip oiu poui poiu oui ouyi pskjgh erg esg egh eisdigsdi srth srth seg ergugherig erg setgrg   reg erg earg rtg estrg ehseghseghseg ssgb    sdfgb fbsf gbsfg bns 4wgh e576j 7xsqxsxqsx qxsq xqsx qsxsqqs srfxsqxxq sqxs yujm tuik yjmyfu ntyh qxsqxqs ergeg etg etg eg vfvefvfew wrf rwg vefvefv efvefv sregf wgf f srg ergefvefv srfevefvef vefvefvefvefvefvef vefvefvefvefvefvev vefvefefvefvefvefve thnb fgbs tgs rtgbnd tn dyftg abs dn fjm fkgm fyun dn tn dtn jy kmy fub sgbn fym iol uiopl io myuim njynm km , muimj ruy srt seb xbx gfndtyd  dyhdtyhdyh dtyj tydt yj guikyu olu mtb sev srhdt mfh nsbt gsertn jfym yfun srgbsr hdtu mjt nsrtg er5gyw 465jr 76uj rtgw45 6yhr6 k79 k7j eyb w4g2 4h5 47j5 kjru yhwtgp oiu pf";


/*            var summary = StringUtility.SummarizeText(sentence, 125);
*//*            var summary = SummarizeText(sentence, 50);
*//*            var summary = SummarizeText(sentence, 100);
*//*            Console.WriteLine(summary);
*/

        /*    static string SummarizeText(string text, int maxLength = 20)
            {
*//*                const int maxLength = 20;
*//*                if( text.Length < maxLength)
                {
                    return text;
                } else
                {
                    var words = text.Split(' ');
                    var totalCharacters = 0;
                    var summaryWords = new List<string>(); 

                    foreach (var word in words)
                    {
                        summaryWords.Add(word);

                        totalCharacters += word.Length + 1;
                        if (totalCharacters > maxLength)
                            break;
                    }

                    return String.Join(" ", summaryWords) + "...";

                }

            }
*/
             























            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 
            // TEXT // TEXT // TEXT // TEXT // TEXT / TEXT // TEXT // TEXT // TEXT // TEXT // TEXT 




            var fullName = "Andrew Townsley   ";
            /*            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            *//*            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            */
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
    /*        Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);*/

            var names = fullName.Split(' ');
       /*     Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);*/
            fullName.Replace("Andrew", "NotAndrew");


            /*            if (String.IsNullOrEmpty(null))
            *//*            if (String.IsNullOrEmpty(""))
            */
            /*            if (String.IsNullOrEmpty("asdasd ".Trim()))
            *//*            if (String.IsNullOrEmpty(" ".Trim()))
                        {
                            Console.WriteLine("InValid");
                        }
                        else
                            Console.WriteLine("Validated Input");*/

            /*     if (String.IsNullOrWhiteSpace(" ".Trim()))
                 {
                     Console.WriteLine("InValid");
                 }
                 else
                     Console.WriteLine("Validated Input");*/


       /*     var str = "25";
            var age = Convert.ToByte(str);
            var alsoWorksForAge = Convert.ToInt32(str);
            *//*
                        Console.WriteLine(age);
                        Console.WriteLine(alsoWorksForAge);*//*

            float price = 45.98f;
            // Convert price to Curreny format
            Console.WriteLine(price.ToString("C"));*/






















































            // DATES & TIME // DATES & TIME // DATES & TIME //



            /*
                        var dateTime = new DateTime(2018, 1, 2); // Declare a sopecific Date //
                        var now = DateTime.Now; // Current Date && Time //
                        var todaysDate = DateTime.Today; // Current Date //

                        Console.WriteLine("Current Second: " + now.Second);
                        Console.WriteLine("Current Minute: " + now.Minute);
                        Console.WriteLine("Current Hour: " + now.Hour);
                        Console.WriteLine("Current Day: " + now.Day);
                        Console.WriteLine("Current Year: " + now.Year);
                        Console.WriteLine("Current Month: " + now.Month);*/



            /*var now = DateTime.Now; */// Current Date && Time //

            /*  var tomorrow = now.AddDays(1);  
              var yesterday = now.AddDays(-1);*/
            /*   Console.WriteLine(now.ToLongDateString());
               Console.WriteLine(now.ToShortDateString());
               Console.WriteLine(now.ToLongTimeString());
               Console.WriteLine(now.ToShortTimeString());*/
            /*            Console.WriteLine(now.ToString("MM-dd-yyyy HH:mm"));
            */



            // TIMESPAN //




       /*     var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("DUration: " + duration);*/































            // LISTS // LISTS // LISTS //

            /*
             * List Methods ...
             * .Add()
             .AddRange()
             .Remove()
             .RemoveAt()
             .IndexOf()
             .Contains()
             .Count

             */

            // List with items delared, which is optional
            /*  var numbers = new List<int>() { 1,2,3,4,5,6 };

              var products = new List<string>();*/




            /*            var stockCount = new List<int>() { 1, 2, 1, 3, 1, 4, 1, 2, 1, 3, 1, 4, 1, 4, 1, 5, 1, 7, 1, 6, 1 };
            */
            // .Add() - adds an element to the List
            /*            stockCount.Add(1);
            
            // .AddRange() - adds a range of elements to the list
            /*stockCount.AddRange(new int[4] { 5, 6, 7, 8 });

            foreach(var item in stockCount)
            {
                Console.WriteLine(item);
            }*/

            // .IndexOf(element) - finds the Index of the given element of the List
            /*
                        Console.WriteLine("IndexOf 1: " + stockCount.IndexOf(1));
             // .LastIndexOf(element) - finds the LAST Index of the given element of the List

                        Console.WriteLine("LastIndexOf 1: " + stockCount.LastIndexOf(1));*/
            // .Remove() - Removes the specified element of the List.
            /* Console.WriteLine(stockCount.Remove(1));
 *//*            Console.WriteLine(stockCount.Count);
 *//*            foreach(var item in stockCount)
             {
                 Console.WriteLine(item);
             }*/


            /*for(var i=0 ;i < stockCount.Count ; i++)
            {
                if (stockCount[i] == 1)
                {
                    stockCount.Remove(stockCount[i]);
                }
            }

            foreach(var item in stockCount)
            {
                Console.WriteLine(item);

            }*/

            // .Clear() - Removes all Items from the List.
            /*stockCount.Clear();
            Console.WriteLine(stockCount.Count);*/






















        }
    }











    //////////////////////ARRAYS///////////ARRAYS////////////////ARRAYS//////////
    /*  internal class Program
      {
          static void Main(string[] args)
          {

              var productStock = new[] { 3, 5, 23, 77, 6, 10 };

              // Length
              /*            Console.WriteLine("Length: " + productStock.Length);*//*

              // IndexOf()
              *//*     var index = Array.IndexOf(productStock, 23);
                   Console.WriteLine(index);*//*

              // Clear
              *//* Array.Clear(productStock, 0, 2);

               foreach (var product in productStock)
                   Console.WriteLine(product);*//*

              // Copy
              int[] newArray = new int[3];

          *//*    Array.Copy(productStock, newArray, 3);
              Console.WriteLine("Effect of Copy Method");

              foreach(var num in newArray)
              {
                  Console.WriteLine(num);
              }*//*

              // Sort
              Array.Sort(productStock);

              Console.WriteLine("Effect of Sort Method");
              foreach( var num in productStock)
              {
                  Console.WriteLine(num);
              }

              // Reverse()

              Array.Reverse(productStock);

              Console.WriteLine("Effect of Reverse Method");







              *//*    // Jagged Arrays
                  var matrix = new int[3, 5]
                  {
                      { 1, 2, 3, 4, 5},
                      { 6, 7, 8, 9, 10},
                      { 11, 12, 13, 14, 15},
                  };

                  var item = matrix[0, 0];

          }*//*
          }
          }*/
}