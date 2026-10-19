using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        // ==========================================
        // LECTURE METHODS (4 Methods)
        // ==========================================

        #region Lecture 01: Recursive Factorial
        public int LCT01_RecursiveFactorial(int n)
        {
            return FactorialHelper(n);
        }

        private int FactorialHelper(int n)
        {
            // Base Case: 0! = 1, 1! = 1 และป้องกันกรณี n <= 0
            if (n <= 1)
            {
                return 1;
            }
            // Recursive Case: n! = n * (n - 1)!
            return n * FactorialHelper(n - 1);
        }
        #endregion

        #region Lecture 02: Recursive Fibonacci
        public int LCT02_RecursiveFibonacci(int n)
        {
            return FibonacciHelper(n);
        }

        private int FibonacciHelper(int n)
        {
            // Base Case: F(0) = 0, F(1) = 1
            if (n <= 1)
            {
                return n;
            }
            // Recursive Case: F(n) = F(n-1) + F(n-2)
            return FibonacciHelper(n - 1) + FibonacciHelper(n - 2);
        }
        #endregion

        #region Lecture 03: Recursive Sum Of 1 to N
        public int LCT03_RecursiveSumOfOneToN(int n)
        {
            return SumOfOneToNHelper(n);
        }

        private int SumOfOneToNHelper(int n)
        {
            // Base Case: ผลรวมของ 0 หรือน้อยกว่าคือ 0
            if (n <= 0)
            {
                return 0;
            }
            // Recursive Case: Sum(n) = n + Sum(n-1)
            return n + SumOfOneToNHelper(n - 1);
        }
        #endregion

        #region Lecture 04: Recursive Sum Of Numbers (Array)
        public int LCT04_RecursiveSumOfNumbers(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            return SumOfNumbersHelper(numbers, 0);
        }

        private int SumOfNumbersHelper(int[] numbers, int index)
        {
            // Base Case: เมื่อเดินผ่านครบทุก index ของ array แล้ว
            if (index >= numbers.Length)
            {
                return 0;
            }
            // Recursive Case: นำค่าที่ index ปัจจุบัน บวกกับผลรวมของส่วนที่เหลือ
            return numbers[index] + SumOfNumbersHelper(numbers, index + 1);
        }
        #endregion


        // ==========================================
        // ASSIGNMENT METHODS (4 Methods)
        // ==========================================

        #region Assignment 01: Recursive Power
        public int ASN01_RecursivePower(int baseNum, int exponent)
        {
            return PowerHelper(baseNum, exponent);
        }

        private int PowerHelper(int baseNum, int exponent)
        {
            // Base Case: x^0 = 1
            if (exponent == 0)
            {
                return 1;
            }
            // Recursive Case: baseNum * baseNum^(exponent - 1)
            return baseNum * PowerHelper(baseNum, exponent - 1);
        }
        #endregion

        #region Assignment 02: Is Palindrome
        public bool ASN02_IsPalindrome(string str)
        {
            if (str == null)
            {
                return false;
            }
            return IsPalindromeHelper(str, 0, str.Length - 1);
        }

        private bool IsPalindromeHelper(string str, int start, int end)
        {
            // Base Case 1: ตรวจสอบจนตำแหน่งไขว้กันหรือเจอกันพอดี แสดงว่าเป็น Palindrome
            if (start >= end)
            {
                return true;
            }
            // Base Case 2: ถ้าตัวอักษรหัว-ท้ายไม่ตรงกัน ไม่ใช่ Palindrome
            if (str[start] != str[end])
            {
                return false;
            }
            // Recursive Case: เขยิบดรรชนีเข้าหากัน แล้วเช็กต่อ
            return IsPalindromeHelper(str, start + 1, end - 1);
        }
        #endregion

        #region Assignment 03: Recursive GCD (Euclidean Algorithm)
        public int ASN03_RecursiveGCD(int a, int b)
        {
            return GCDHelper(a, b);
        }

        private int GCDHelper(int a, int b)
        {
            // Base Case: เมื่อตัวเศษเป็น 0 ค่า ห.ร.ม. คือ a
            if (b == 0)
            {
                return a;
            }
            // Recursive Case: GCD(a, b) = GCD(b, a % b)
            return GCDHelper(b, a % b);
        }
        #endregion

        #region Assignment 04: Recursive Binary Search
        public int ASN04_RecursiveBinarySearch(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0)
            {
                return -1;
            }
            return BinarySearchHelper(arr, target, 0, arr.Length - 1);
        }

        private int BinarySearchHelper(int[] arr, int target, int low, int high)
        {
            // Base Case 1: หาไม่พบ (ขอบเขตแคบจน low สวนทางกับ high)
            if (low > high)
            {
                return -1;
            }

            // คำนวณหาตำแหน่งกลาง
            int mid = low + (high - low) / 2;

            // Base Case 2: เจอ target ในตำแหน่ง mid พอดี
            if (arr[mid] == target)
            {
                return mid;
            }
            // Recursive Case 1: target น้อยกว่าค่ากลาง -> ค้นหาครึ่งซ้าย
            else if (arr[mid] > target)
            {
                return BinarySearchHelper(arr, target, low, mid - 1);
            }
            // Recursive Case 2: target มากกว่าค่ากลาง -> ค้นหาครึ่งขวา
            else
            {
                return BinarySearchHelper(arr, target, mid + 1, high);
            }
        }
        #endregion
    }
}