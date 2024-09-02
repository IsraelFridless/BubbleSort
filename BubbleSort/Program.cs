namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(", ", SelectionSort([5, 8, 2, 4, 1, 0, 10])));
            int[] nums1 = { 3, 5, 7, 9, 15 };
            int[] nums2 = { 1, 2, 3, 4, 12, 16, 23, 34 };
            Console.WriteLine(string.Join(", ", Merge(nums1, nums2)));
        }

        public static int[] SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = nums[minIndex];
                nums[minIndex] = nums[i];
                nums[i] = temp;
            }
            return nums;
        }

        public static int[] BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length -1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }

        public static int[] Merge(int[] nums1, int[] nums2)
        {
            int len = nums1.Length + nums2.Length;

            int[] newArray = new int[len];
            int i = 0, j = 0;
            int currentIndex = 0;
            while (i < nums1.Length - 1 && j < nums2.Length - 1)
            {
                if (nums1[i] <= nums2[j])
                {
                    newArray[currentIndex] = nums1[i];
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    newArray[currentIndex] = nums2[j];
                    j++;
                }
                currentIndex++;
            }

            while (i < nums1.Length)
            {
                newArray[currentIndex] = nums1[i];
                i++;
                currentIndex++;
            }
            while (j < nums2.Length)
            {
                newArray[currentIndex] = nums2[j];
                j++;
                currentIndex++;
            }
            return newArray;
        }

        public static int[] MergeSort(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums;
            }
            if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                {
                    int temp = nums[0];
                    nums[0] = nums[1];
                    nums[1] = temp;
                }
                return nums;
            }

        }
    }
}
