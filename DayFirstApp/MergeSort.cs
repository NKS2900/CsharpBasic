using System;
using System.Collections.Generic;
using System.Text;

namespace DayFirstApp
{
    class MergeSort
    {
        public static int[] array;
        public static int[] tempMergeArr;
        public static int length;
        //public static void mergeMain()
        static void Main(string[] args)
        {
            int[] inputArr = { 48, 36, 13, 52, 19, 92, 21 };
            sort(inputArr);

            int i;
            for (i = 0; i < inputArr.Length; i++)
            {
                Console.Write(inputArr[i]+" ");
            }
        }
        public static void sort(int[] inputArr)
        {
            array = inputArr;
            length = inputArr.Length;
            tempMergeArr = new int[length];
            divideArray(0,length-1);


        }
        public static void divideArray(int lowerIndex,int hegerIndex)
        {
            if (lowerIndex < hegerIndex)
            {
                int middle = lowerIndex + (hegerIndex - lowerIndex);
                //it will sort the left side of an array
                divideArray(lowerIndex,middle);
                //it will sort the right side of an array
                divideArray(middle+1,hegerIndex);

                mergeArray(lowerIndex,middle,hegerIndex);
            }
           
        }
        public static void mergeArray(int lowerIndex, int middle, int higherIndex)
        {
            int i;
            for ( i = lowerIndex; i <= higherIndex; i++)
            {
                tempMergeArr[i] = array[i];
            }
            int p = lowerIndex;
            int j = middle;
            int k = lowerIndex;
            while (p <= middle && j <= higherIndex)
            {
                if (tempMergeArr[p] <= tempMergeArr[j])
                {
                    array[k] = tempMergeArr[p];
                    p++;
                }
                else {
                    array[k] = tempMergeArr[j];
                    j++;
                }
                k++;
            }
        }
    }
}
