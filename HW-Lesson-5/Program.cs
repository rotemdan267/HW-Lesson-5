using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // בלוק פקודות קבוע שהמתכנת מכניס תחת שם אחד,
            // כך שאם יש פעולה מסוימת שאמורה להתבצע מס' פעמים
            // במהלך תכנית, אפשר לכתוב את שורות הקוד רק פעם אחת
            // ו"לקרוא" להם להתבצע על ידי שורה אחת, בכל פעם
            // שאני רוצה שיתבצעו

            #endregion

            #region Q2

            // חיסכון בכתיבת שורות קוד
            // הקוד יוצא מסודר יותר לעין
            // כאשר נדרש לבצע שינוי בקוד - במקום לשנות כמה פעמים בכל מקום בו מופיע הקוד
            // אפשר לשנות רק פעם אחת - וזה יתפוס לכל מקום שבו קראנו לפונקציה

            #endregion

            #region Q3

            // היא נכתבת בתוך ה-class
            // ומחוץ לכל פונקציה אחרת, כולל ה-Main
            // public static
            // void - במקרה שהפונקציה לא מחזירה ערך למי ש"קרא" לה
            // במקרה שהפונקציה כן מחזירה ערך אז צריך לכתוב את ה-type
            // של הערך המוחזר int/string/char[]/bool/float...
            // לאחר מכן כותבים את שם הפונקציה (נהוג שיתחיל באות גדולה)
            // ואז ()
            // במידה והפונקציה מקבלת ערכים ממי ש"קורא" לה אז מגדירים בתוך הסוגריים לעיל
            // את המשתנים שיקבלו את הערכים
            // {} ובתוכו בלוק הפקודות שהמתכנת רוצה שיתבצע
            // במידה והפונקציה מחזירה ערך חשוב לזכור לבצע בסוף בלוק הפקודות
            // return ערך;

            #endregion

            #region Q4

            // אכן

            #endregion

            #region Q5

            // לא

            #endregion

            #region Q6

            // היא נכתבת בתוך ה-class
            // ומחוץ לכל פונקציה אחרת, כולל ה-Main

            #endregion

            #region Q7

            // פונקציה המחזירה ערך - נגמרת בפקודה return
            // גם אם כתובות שורות קוד לאחר מכן
            // פונקציה שלא מחזירה ערך - בסיום בלוק הפקודות...

            #endregion


            #region Q8

            //Console.WriteLine("Enter a number between 1-10");
            //int num = int.Parse(Console.ReadLine());
            //PrintNumName(num);

            #endregion


            #region Q9

            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //bool a = PrintNumbers(num);

            #endregion


            #region Q10

            //PrintNum(1);

            #endregion


            #region Q11

            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //int isPrime = IsPrime(num);
            //if (isPrime == 1)
            //{
            //    Console.Write(isPrime + " - ");
            //    Console.WriteLine("Prime number");
            //}
            //else
            //{
            //    Console.Write(isPrime + " - ");
            //    Console.WriteLine("Not a prime number");
            //}

            #endregion


            #region Q12

            //int[] arr = { 2, 4, 9, 13, 17 };
            //IsPrimeArray(arr);

            #endregion


            #region Q13

            //int[] arr1 = { 5, 6, 3, 21, 98, 1, 453, 2, 87, 5 };
            //int[] arr2 = { 9, 87, 54, 32, 6, 52, 6, 84, 78, 456123 };
            //int check = WhichArrayIsBigger(arr1, arr2);

            //if (check == 1)
            //{
            //    Console.WriteLine("arr1 is bigger");
            //}
            //else if (check == 0)
            //{
            //    Console.WriteLine("the arrays' sum is equal");
            //}
            //else
            //{
            //    Console.WriteLine("arr2 is bigger");
            //}

            #endregion


            #region Q14

            //int[,] arr = CreateRandomMatrix();
            //for (int i = 1; i < 11; i++)
            //{
            //    CheckIfExist(arr);
            //}

            #endregion


            #region Q15

            //Console.WriteLine("enter the size of the array:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size];
            //Console.WriteLine("enter values");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arr = { -5, 10, 15, 2, 5, 100 };
            //PrintArray(SortArray(arr));

            #endregion

        }

        public static void PrintNumName(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;

                case 4:
                    Console.WriteLine("four");
                    break;

                case 5:
                    Console.WriteLine("five");
                    break;

                case 6:
                    Console.WriteLine("six");
                    break;

                case 7:
                    Console.WriteLine("seven");
                    break;

                case 8:
                    Console.WriteLine("eight");
                    break;

                case 9:
                    Console.WriteLine("nine");
                    break;

                case 10:
                    Console.WriteLine("ten");
                    break;

                default:
                    Console.WriteLine("The number is out of range");
                    break;
            }
        }

        public static bool PrintNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            if (num <= 10 && num >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrintNum(int i)
        {
            Console.WriteLine(i);
            if (i < 10)
            {
                PrintNum(i + 1);
            }
        }

        public static int IsPrime(int num)
        {
            bool prime = true;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private static void IsPrimeArray(int[] arr)
        {
            int prime;
            for (int i = 0; i < arr.Length; i++)
            {
                prime = IsPrime(arr[i]);
                if (prime == 1)
                {
                    Console.WriteLine($"{arr[i]} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{arr[i]} is not a prime number");
                }
            }
        }

        private static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                sum2 += arr2[i];
            }

            if (sum1 > sum2)
            {
                return 1;
            }
            else if (sum1 == sum2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        private static int[,] CreateRandomMatrix()
        {
            int[,] arr = new int[10, 10];
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(100) + 1;
                }
            }

            return arr;
        }

        private static void CheckIfExist(int[,] arr)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            bool flag = false;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == num)
                    {
                        flag = true;
                    }

                }
            }

            if (flag)
            {
                Console.WriteLine("exist");
            }
            else
            {
                Console.WriteLine("missing");
            }

        }

        private static int[] SortArray(int[] arr)
        {
            // Array.Sort(arr);

            int min = arr[0], index = 0;

            bool flag;

            for (int i = 0; i < arr.Length; i++)
            {
                flag = true;
                for (int j = i; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        index = j;
                        flag = false;
                    }
                }
                if (flag == false)
                {
                    arr[index] = arr[i];
                    arr[i] = min;
                }
                if (i < arr.Length - 1)
                {
                    min = arr[i + 1];
                }
            }

            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
