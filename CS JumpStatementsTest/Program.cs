﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CS_JumpStatementsTest
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("TRUE: " + true.ToString());

            while (true)
            {
                Console.WriteLine("Returned: " + IfTest(Console.ReadLine()));

                Console.Read();
            }
        }

        #region Arcade

        #region Core

        #region tennisSet

        static bool tennisSet(int score1, int score2)
        {
            if (score1 == 0 && score2 == 0)
            {
                return false;
            }

            if (score1 >= 7 && score2 >= 7)
            {
                return false;
            }

            if (score1 > 7 || score2 > 7)
            {
                return false;
            }

            if (score1 > 6 && score2 < 5 || score2 > 6 && score1 < 5)
            {
                return false;
            }

            if (score1 == 6 && score2 == 5 || score2 == 6 && score1 == 5)
            {
                return false;
            }

            if (score1 > score2 + 1 || score2 > score1 + 1)
            {
                return true;
            }

            return true;
        }

        #endregion

        #region arithmeticExpression

        static bool arithmeticExpression(int a = 8, int b = 3, int c = 2)
        {
            if (a + b == c)
            {
                return true;
            }
            if (a - b == c)
            {
                return true;
            }
            if (a * b == c)
            {
                return true;
            }
            if ((a + 0.0) / b == c)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region isInfiniteProcess

        static bool isInfiniteProcess(int a, int b)
        {
            while (a != b)
            {
                a++;
                b--;

                if (b < a)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region extraNumber

        static int extraNumber(int a = 2, int b = 7, int c = 2)
        {
            if (a == b)
            {
                return c;
            }
            if (a == c)
            {
                return b;
            }
            if (b == c)
            {
                return a;
            }

            return 0;
        }

        #endregion

        #region knapsackLight

        static int knapsackLight(int value1 = 10, int weight1 = 5, int value2 = 6, int weight2 = 4, int maxW = 8)
        {

            Console.WriteLine($"{maxW} : {weight1 + weight2}");
            if (maxW >= weight1 + weight2)
            {
                return value1 + value2;
            }

            if (maxW >= weight1 && value1 > value2)
            {
                return value1;
            }

            if (maxW >= weight2 && value2 > value1)
            {
                return value2;
            }

            if (maxW >= weight1)
            {
                return value1;
            }

            if (maxW >= weight2)
            {
                return value2;
            }

            return 0;
        }

        #endregion

        #region reachNextLevel

        bool reachNextLevel(int experience, int threshold, int reward)
        {
            if (experience + reward >= threshold)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Phone Call

        static int phoneCall(int min1 = 1, int min2_10 = 2, int min11 = 1, int s = 6)
        {
            var min = 0;
            var pay = true;

            Console.WriteLine($"S: {s}, neCost: {min1}, Min: {min}");

            if (s - min1 >= 0)
            {
                s -= min1;
                min++;
            }
            else
            {
                pay = false;
            }

            if (pay)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (s - min2_10 >= 0)
                    {
                        Console.WriteLine($"S: {s}, neCost: {min2_10}, Min: {min}");
                        s -= min2_10;
                        min++;
                    }
                    else
                    {
                        pay = false;
                    }
                }
            }

            if (pay)
            {
                while (s - min11 >= 0)
                {
                    if (s - min11 >= 0)
                    {
                        Console.WriteLine($"S: {s}, neCost: {min11}, Min: {min}");
                        s -= min11;
                        min++;
                    }
                }
            }

            return min;
        }

        #endregion

        #region Late Ride

        static int lateRide(int n = 23)
        {
            var time = TimeSpan.FromMinutes(n).ToString(@"hhmm");

            var result = addTwoDigits(int.Parse(time));

            return result;
        }

        #endregion

        #region Circle Of Numbers

        static int circleOfNumbers(int n = 10, int firstNumber = 7)
        {
            var result = firstNumber + (n / 2);

            if (result >= n)
            {
                result -= n;
            }

            return result;
        }

        #endregion

        #region Max Multiple

        static int maxMultiple(int divisor = 3, int bound = 10)
        {
            return bound - (bound % divisor);
        }

        #endregion

        #region Seats In Theater

        static int seatsInTheater(int nCols = 16, int nRows = 11, int col = 5, int row = 3)
        {
            return (nCols - col + 1) * (nRows - row);
        }

        #endregion

        #region Candies

        static int candies(int n = 3, int m = 10)
        {
            var rest = (int)(m % n);

            return (m - rest);
        }

        #endregion

        #region Largest Number

        static int largestNumber(int n = 2)
        {
            var result = "";
            for (int i = 0; i < n; i++)
            {
                result += "9";
            }

            return int.Parse(result);
        }

        #endregion

        #region Add Two Digits

        static int addTwoDigits(int n = 29)
        {
            char[] vals = n.ToString().ToCharArray();

            var result = 0;
            foreach (char c in vals)
            {
                result += int.Parse(c.ToString());
            }

            return result;
        }

        #endregion

        #endregion

        #region Intro

        #region Through the Fog

        #region stringsRearrangement

        bool stringsRearrangement(string[] inputArray)
        {
            return false;
        }

        #endregion

        #region absoluteValuesSumMinimization

        int absoluteValuesSumMinimization(int[] a)
        {
            return a[(int)Math.Floor((double)((a.Count() - 1) / 2))];
        }

        #endregion

        #region depositProfit

        static int depositProfit(int deposit = 100, int rate = 20, int threshold = 170)
        {
            var runs = 0;
            var de = deposit  + 0.0d;
            while (de < threshold)
            {
                de *= (((double)rate / 100) + 1);

                runs++;
            }

            return runs;
        }

        #endregion

        #region circleOfNumbers

        int circleOfNumbers2(int n, int firstNumber)
        {
            var result = firstNumber + (n / 2);

            if (result >= n)
            {
                result -= n;
            }

            return result;
        }

        #endregion

        #endregion

        #region Rains of Reason

        #region chessBoardCellColor

        static bool chessBoardCellColor(string cell1 = "A1", string cell2 = "H3")
        {
            var even1 = (((int)cell1[0] - 65 + (int)cell1[1]) % 2 == 0);
            var even2 = (((int)cell2[0] - 65 + (int)cell2[1]) % 2 == 0);

            return even1 == even2;
        }

        #endregion

        #region alphabeticShift

        string alphabeticShift(string inputString)
        {
            return string.Concat(inputString.Select(x => ++x > 'z' ? 'a' : x));
        }

        #endregion

        #region variableName

        static bool variableName(string name = "")
        {
            string pattern = @"(^[^0-9 !@#$%^&*()+\-=\[\]{};':\\|,.<>\/?])(\w *)";

            Match m = Regex.Match(name, pattern);

            if (m.Value == name)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region evenDigitsOnly

        bool evenDigitsOnly(int n)
        {
            foreach (char c in n.ToString().ToCharArray())
            {
                if (int.Parse(c.ToString()) % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region arrayReplace

        int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {            
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elemToReplace)
                {
                    inputArray[i] = substitutionElem;
                }
            }

            return inputArray;
        }

        #endregion

        #endregion

        #region Island of Knowledge

        #region minesweeper

        int[][] minesweeper(bool[][] matrix)
        {
            return matrix
                .Select((x, i) => x.Select((c, j) => matrix.Skip(i-1).Take(i < 1 || i == matrix.Length - 1 ? 2 : 3)
                .SelectMany(r => r.Skip(j-1).Take(j < 1 || j == x.Length - 1 ? 2 : 3))
                .Count(m => m == true) - (matrix[i][j] ? 1 : 0))
                .ToArray())
                .ToArray();
        }

        #endregion

        #region boxBlur

        int[][] boxBlur(int[][] image)
        {
            var rows = image.Length;
            var cols = image[0].Length;
            var nRows = rows - 2;
            var nCols = cols - 2;
            var sum = 0;
            var nImage = new List<int[]>(); 

            for (int r = 0; r < nRows; r++)
            {
                var array = new List<int>();
                array.Clear();
                for (int c = 0; c < nCols; c++)
                {
                    sum = 0;
                    for (int i = r; i < r + 3; i++)
                    {
                        for (int j = c; j < c + 3; j++)
                        {
                            sum += image[i][j];
                        }
                    }

                    array.Add(sum / 9);
                }
                nImage.Add(array.ToArray());
            }
            return nImage.ToArray();
        }

        #endregion

        #region avoidObstacles

        int avoidObstacles(int[] inputArray)
        {
            var jumps = 2;
            var i = 0;
            while (i != inputArray.Length)
            {
                for (i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % jumps == 0)
                    {
                        jumps++;
                        break;
                    }
                }
            }
            return jumps;
        }

        #endregion

        #region isIPv4Address

        bool isIPv4Address(string inputString)
        {
            if (!inputString.Contains('.'))
            {
                return false;
            }

            var array = inputString.Split('.');

            if (array.Length != 4)
            {
                return false;
            }

            try
            {
                foreach (string str in array)
                {
                    if (string.IsNullOrWhiteSpace(str) || int.Parse(str) > 255)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region arrayMaximalAdjacentDifference

        int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            var highest = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                var val = Math.Abs(inputArray[i] - inputArray[i + 1]);

                if (val > highest)
                {
                    highest = val;
                }
            }

            return highest;
        }

        #endregion

        #region areEquallyStrong

        static bool areEquallyStrong(int yourLeft = 10, int yourRight = 15, int friendsLeft = 15, int friendsRight = 10)
        {
            return (((yourLeft + yourRight) == (friendsLeft + friendsRight)) && (Math.Abs(yourLeft - yourRight) == Math.Abs(friendsLeft - friendsRight)));
        }

        #endregion

        #endregion

        #region Exploring the Waters

        #region palindromeRearranging

        static bool palindromeRearranging(string inputString = "aabb")
        {
            int[] array = new int[26];

            for (int i = 0; i < inputString.Length; i++)
            {
                array[inputString.ToCharArray()[i] - 'a']++;
            }
            int count = 0, countSingle = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0 && array[i] % 2 == 0)
                {
                    count++;
                }
                else if (array[i] != 0 && array[i] % 2 == 1)
                {
                    if (inputString.Length % 2 != 0)
                    {
                        if (countSingle == 1)
                            return false;
                        else
                            countSingle++;
                    }
                    else
                        return false;
                }
            }

            return true;
        }

        #endregion

        #region arrayChange

        int arrayChange(int[] inputArray)
        {
            int moves = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] >= inputArray[i + 1])
                {
                    int add = (inputArray[i] - inputArray[i + 1]) + 1;
                    moves += add;
                    inputArray[i + 1] += add;
                }
            }
            return moves;
        }

        #endregion

        #region areSimilar

        bool areSimilar(int[] a, int[] b)
        {
            var swhitched = 0;
            var messure = 0;
            for (var i = 0; i < a.Count(); i++)
            {
                if (a[i] != b[i])
                {
                    swhitched++;
                }
                messure ^= a[i];
                messure ^= b[i];
            }
            return swhitched < 3 && messure == 0;
        }

        #endregion

        #region addBorder

        static string[] addBorder(string[] picture)
        {
            var final = new List<string>();

            var wall = "";

            for (int i = 0; i < picture[0].Length + 2; i++)
            {
                wall += "*";
            }

            final.Add(wall);

            foreach (string str in picture)
            {
                final.Add($"*{str}*");
            }
            final.Add(wall);

            return final.ToArray();
        }

        #endregion

        #region alternatingSums

        int[] alternatingSums(int[] a)
        {
            var team1 = new List<int>();
            var team2 = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    team1.Add(a[i]);
                }
                else
                {
                    team2.Add(a[i]);
                }
            }

            Console.WriteLine(team1.Sum() + " : " + team2.Sum());

            return new int[] { team1.Sum(), team2.Sum() };
        }

        #endregion

        #endregion

        #region Smooth Sailing

        #region reverseInParentheses

        static string reverseInParentheses(string inputString = "foo(bar)baz(blim)")
        {
            while (inputString.LastIndexOf('(') != -1 && inputString.LastIndexOf(')') != -1)
            {
                int index1 = inputString.LastIndexOf('(');
                int index2 = inputString.IndexOf(')', index1);
                inputString = inputString.Substring(0, index1) + new string(inputString.Substring(index1 + 1, index2 - index1 - 1).Reverse().ToArray()) + inputString.Substring(index2 + 1);
            }
            return inputString;
        }

        #endregion

        #region sortByHeight

        int[] sortByHeight(int[] a)
        {
            var notTree = new List<int>();

            foreach (int i in a)
            {
                if (i != -1)
                {
                    notTree.Add(i);
                }
            }

            notTree.Sort();

            var result = new List<int>();

            var ii = 0;
            foreach (int i in a)
            {
                if (i != -1)
                {
                    result.Add(notTree[ii]);
                    ii++;
                }
                else
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region isLucky

        static bool isLucky(int n = 1230)
        {
            Console.WriteLine(n.ToString().Length);

            var h1 = n.ToString().Substring(0, (n.ToString().Length / 2));
            var h2 = n.ToString().Substring((n.ToString().Length / 2));

            Console.WriteLine(h1);
            Console.WriteLine(h2);

            var result1 = 0;
            foreach (char c in h1)
            {
                result1 += int.Parse(c.ToString());
            }

            var result2 = 0;
            foreach (char c in h2)
            {
                result2 += int.Parse(c.ToString());
            }

            if (result1 == result2)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region commonCharacterCount

        static int commonCharacterCount(string s1 = "aabcc", string s2 = "adcaa")
        {
            var str2 = s2.ToList();
            var count = 0;
            foreach (char i in s1.ToCharArray())
            {
                if (str2.Contains(i))
                {
                    count++;
                    str2.Remove(i);
                }
            }
            return count;
        }

        #endregion

        #region allLongestStrings

        static string[] allLongestStrings(string[] inputArray)
        {
            List<string> array = new List<string>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i != 0)
                {
                    if (inputArray[i].Length > array.Last().Length)
                    {
                        array.Clear();
                        array.Add(inputArray[i]);
                    }
                    else if (inputArray[i].Length == array.Last().Length)
                    {
                        array.Add(inputArray[i]);
                    }
                }
                else
                {
                    array.Add(inputArray[i]);
                }
            }

            return array.ToArray();
        }

        #endregion

        #endregion

        #region Edge of the Ocean

        #region matrixElementsSum

        static int matrixElementsSum(int[][] matrix)
        {
            var used = new List<int>();
            var result = 0;

            for (int i = 0; i < matrix.Count(); i++)
            {
                for (int ii = 0; ii < matrix[i].Count(); ii++)
                {
                    if (!used.Contains(ii))
                    {
                        if (matrix[i][ii] == 0)
                        {
                            used.Add(ii);
                        }
                        else
                        {
                            result += matrix[i][ii];
                        }
                    }
                }
            }

            return result;
        }

        #endregion

        #region almostIncreasingSequence

        static bool almostIncreasingSequence(int[] sequence)
        {
            int count = 0;
            for (int i = 0; i < sequence.Count() - 1; i++)
            {
                try
                {
                    if (sequence[i] >= sequence[i + 1])
                    {
                        count++;
                        if (sequence[i - 1] >= sequence[i + 1] && i - 1 >= 0 && sequence[i] >= sequence[i + 2] && i + 2 < sequence.Count())
                        {
                            count++;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            if (count > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region makeArrayConsecutive2

        static int makeArrayConsecutive2(int[] statues)
        {
            var sort = statues.ToList();
            sort.Sort();

            return (sort.Last() - sort.First() - (statues.Count() - 1));
        }

        #endregion

        #region shapeArea

        static int shapeArea(int n = 2)
        {
            var d = Math.Round(Math.Pow(n, 2) + Math.Pow(n - 1, 2));

            return int.Parse(d.ToString());
        }

        #endregion

        #region adjacentElementsProduct

        static int adjacentElementsProduct(int[] inputArray)
        {
            List<int> vs = new List<int>();

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                vs.Add(inputArray[i] * inputArray[i + 1]);
            }
            vs.Sort();

            return vs.Last();
        }

        #endregion

        #endregion

        #region The Journey Begins

        #region checkPalindrome

        static bool checkPalindrome(string inputString = "aabaa")
        {
            var reverse = inputString.Reverse();

            Console.WriteLine($"{String.Join("", reverse)} == {inputString}");

            if (String.Join("", reverse) == inputString)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region centuryFromYear

        static int centuryFromYear(int year = 1700)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        #endregion

        #endregion

        #endregion

        #endregion


        #region Interview Practice

        #region Arrays

        #region isCryptSolution

        bool isCryptSolution(string[] crypt, char[][] solution)
        {
            var ltrVals = new Dictionary<char, char>();
            foreach (char[] pair in solution)
                ltrVals.Add(pair[0], pair[1]);
            int[] nums = new int[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < crypt[i].Length; j++)
                {
                    if (crypt[i].Length > 1 && ltrVals[crypt[i][0]] == '0')
                        return false;
                    nums[i] = nums[i] * 10 + (ltrVals[crypt[i][j]] - '0');
                }
            }
            return nums[0] + nums[1] == nums[2];
        }

        #endregion

        #region Check Sudoku Grid

        static char[][] _grid;

        static char[][] SudokuGridGenerator()
        {
            var makeNew = false;

            char[][] newGrid = {
            new char[] {'.','9','.','.','4','.','.','.','.'},
            new char[] {'1','.','.','.','.','.','6','.','.'},
            new char[] {'.','.','3','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','7','.','.','.','.','.'},
            new char[] {'3','.','.','.','5','.','.','.','.'},
            new char[] {'.','.','7','.','.','4','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','7','.','.','.','.'}
            };

            /*
            [[".","9",".",".","4",".",".",".","."], 
             ["1",".",".",".",".",".","6",".","."], 
             [".",".","3",".",".",".",".",".","."], 
             [".",".",".",".",".",".",".",".","."], 
             [".",".",".","7",".",".",".",".","."], 
             ["3",".",".",".","5",".",".",".","."], 
             [".",".","7",".",".","4",".",".","."], 
             [".",".",".",".",".",".",".",".","."], 
             [".",".",".",".","7",".",".",".","."]]
             */
            if (makeNew)
            {
                Random random = new Random();

                foreach (char[] cc in newGrid)
                {
                    int i = 0;
                    foreach (char c in cc)
                    {
                        var num = random.Next(0, 9).ToString();

                        if (num != "0")
                        {
                            cc[i] = num[0];
                        }
                        else
                        {
                            cc[i] = '.';
                        }
                        i++;
                    }

                    Console.WriteLine(String.Join(", ", cc));
                }
            }

            return newGrid;
        }

        static bool sudoku2(char[][] grid)
        {
            int[][] newGrid = new int[grid.Count()][];

            for (int i = 0; i < newGrid.Count(); i++)
            {
                newGrid[i] = new int[grid.Count()];
            }

            for (int i = 0; i < newGrid.Count(); i++)
            {
                for (int j = 0; j < newGrid.Count(); j++)
                {
                    if (grid[i][j] == '.')
                    {
                        newGrid[i][j] = -1;
                    }
                    else
                    {
                        newGrid[i][j] = grid[i][j] - '0';
                    }
                }
            }
            return boxCheck(newGrid) && rowColumnCheck(newGrid);
        }

        static bool boxCheck(int[][] grid)
        {
            for (int i = 0; i < grid.Count(); i += 3)
            {
                for (int j = 0; j < grid.Count(); j += 3)
                {
                    bool[] gridMatrix = new bool[9];
                    for (int k = i; k < 3 + i; k++)
                    {
                        for (int l = j; l < 3 + j; l++)
                        {
                            int currentNumber = grid[k][l];
                            if (currentNumber != -1)
                            {
                                if (!gridMatrix[currentNumber - 1])
                                {
                                    gridMatrix[currentNumber - 1] = true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        static bool rowColumnCheck(int[][] grid)
        {
            for (int i = 0; i < 9; i++)
            {
                bool[] rowArray = new bool[9];
                bool[] columnArray = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    int currentNumberRow = grid[i][j];
                    int currentNumberColumn = grid[j][i];
                    if (currentNumberRow != -1)
                    {
                        if (!rowArray[currentNumberRow - 1])
                        {
                            rowArray[currentNumberRow - 1] = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (currentNumberColumn != -1)
                    {
                        if (!columnArray[currentNumberColumn - 1])
                        {
                            columnArray[currentNumberColumn - 1] = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        #endregion

        #region Rotate 2D Image in matrix

        static int[][] rotateImage(int[][] a)
        {
            var n = a.Length;

            for (int i = 0; i < n / 2; i++)
            {
                for (int ii = i; ii < n - i - 1; ii++)
                {
                    int temp = a[i][ii];

                    a[i][ii] = a[n - 1 - ii][i];

                    a[n - 1 - ii][i] = a[n - 1 - i][n - 1 - ii];

                    a[n - 1 - i][n - 1 - ii] = a[ii][n - 1 - i];

                    a[ii][n - 1 - i] = temp;
                }
            }
            return a;
        }

        static int[][] image()
        {
            var array = new int[3][];

            array[0] = new int[] { 1, 2, 3 };
            array[1] = new int[] { 4, 5, 6 };
            array[2] = new int[] { 7, 8, 9 };

            return array;
        }

        #endregion

        #region First non-repeating char

        static char firstNotRepeatingCharacter(string s)
        {
            TimeSpan ts;
            var watch = Stopwatch.StartNew();

            var isRepeat = false;
            for (int i = 0; i < s.Length; i++)
            {
                isRepeat = false;
                for (int ii = 0; ii < s.Length; ii++)
                {
                    if ((i != ii) && (s[i] == s[ii]))
                    {
                        isRepeat = true;
                        break;
                    }
                }
                switch (isRepeat == false)
                {
                    case true:
                        {
                            return s[i];
                        }
                }
            }

            ts = watch.Elapsed;

            Console.WriteLine(ts.ToString("mm\\:ss\\.ff"));

            return '_';
        }

        static int AmountFound(string str, char c)
        {
            int amount = 0;
            foreach (char cc in str)
            {
                if (cc == c)
                {
                    amount++;
                }
            }

            return amount;
        }

        static string WriteString()
        {
            var length = 50;
            var result = "";
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                result += (char)random.Next(97, 122);
            }

            return result;
        }

        #endregion

        #region Find first duplicate

        //Fast (But noth with large samples)
        static int firstDuplicateForeach(int[] a)
        {
            TimeSpan ts;
            var watch = Stopwatch.StartNew();

            List<int> used = new List<int>();

            foreach (int num in a)
            {
                switch (used.Contains(num))
                {
                    case true:
                        {
                            ts = watch.Elapsed;

                            Console.WriteLine(ts.ToString("mm\\:ss\\.ff"));

                            return num;
                        }
                    case false:
                        {
                            used.Add(num);
                            break;
                        }
                }
            }

            ts = watch.Elapsed;

            Console.WriteLine(ts.ToString("mm\\:ss\\.ff"));

            return -1;
        }

        //Fastest (uses math to find answer)
        static int firstDuplicateForeachNew(int[] a)
        {
            TimeSpan ts;
            var watch = Stopwatch.StartNew();

            foreach (int num in a)
            {
                switch (a[Math.Abs(num) - 1] < 0)
                {
                    case true:
                        {
                            ts = watch.Elapsed;

                            Console.WriteLine(ts.ToString("mm\\:ss\\.ff"));

                            return Math.Abs(num);
                        }
                    case false:
                        {
                            a[Math.Abs(num) - 1] = -a[Math.Abs(num) - 1];
                            break;
                        }

                }
            }

            ts = watch.Elapsed;

            Console.WriteLine(ts.ToString("mm\\:ss\\.ff"));

            return -1;
        }

        //Can't contain 0
        static int[] WriteArray()
        {
            List<int> vs = new List<int>();
            var lenght = 50000 - 2;

            for (int i = 1; i < lenght; i++)
            {
                if (i + 2 >= lenght)
                {
                    vs.Add(8);
                }

                if (i + 20 >= lenght)
                {
                    vs.Add(66);
                }

                vs.Add(i);
            }

            return vs.ToArray();
        }

        #endregion

        #endregion

        #region Linked Lists

        #region isListPalindrome

        //bool isListPalindrome(ListNode<int> l)
        //{

        //}

        #endregion

        #region removeKFromList

        ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            if (l?.value == k)
            {
                l = removeKFromList(l?.next, k);
            }
            if (l?.next != null)
            {
                l.next = removeKFromList(l?.next, k);
            }
            return l;
        }

        #endregion

        #endregion

        #region Hash Tables

        #region groupingDishes

        string[][] groupingDishes(string[][] dishes)
        {
            var x = dishes.SelectMany(a => a.Skip(1).Select(b => new Tuple<string, string>(b, a[0]))).GroupBy(c => c.Item1, c => c.Item2).Where(d => d.Count() > 1);

            return x.Select(e => (new string[] { e.Key }).Concat(e.OrderBy(f => f, StringComparer.Ordinal)).ToArray()).OrderBy(g => g[0], StringComparer.Ordinal).ToArray();
        }        

        #endregion

        #endregion

        #endregion


        #region Personal

        #region Jumps

        static void TestBreak()
        {
            for (int i = 1; i <= 4; i++)
            {
                if (i == 3)
                    break;

                Console.WriteLine("Break");
            }

            Console.WriteLine("");

            var ii = new int[] { 1, 2, 3, 4 };

            foreach (int i in ii)
            {
                if (i == 3)
                    break;

                Console.WriteLine("Break Foreach");
            }

            Console.WriteLine("");

            foreach (int iii in ii)
            {
                foreach (int i in ii)
                {
                    if (i == 3)
                        break;

                    Console.WriteLine("Break double Foreach");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            // Break is printed only 2 times 
            // because of break statement 
            for (int i = 1; i <= 4; i++)
            {
                if (i == 3)
                {

                }

                Console.WriteLine("No Break");
            }

            Console.WriteLine("");

            // Break is printed only 2 times 
            // because of break statement 
            for (int i = 1; i <= 4; i++)
            {
                switch (i == 3)
                {
                    case true:
                        {
                            break;
                        }
                }

                Console.WriteLine("Break Switch");
            }
        }

        static void TestContinue()
        {
            for (int i = 1; i <= 10; i++)
            {

                // if the value of i becomes 4 then  
                // it will skip 4 and send the  
                // transfer to the for loop and  
                // continue with 5  
                if (i == 4)
                    continue;

                Console.WriteLine(i);
            }
        }

        static void TestGoto()
        {
            int number = 20;
            switch (number)
            {

                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");

                    // goto statement transfer  
                    // the control to case 5 
                    goto case 5;

                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }

        static int TestReturn(int a)
        {
            // add two value and 
            // return the result of addition 
            int add = a + a;

            // using return statement 
            return add;
        }

        #endregion

        private static bool IfTest(string boo)
        {
            if (
                true == true
                &&
                boo == false.ToString()

                ||

                false == false
                &&
                true.ToString() == boo
                )
            {
                return true;
            }
            return false;
        }

        #endregion
    }

    class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }

    }
}