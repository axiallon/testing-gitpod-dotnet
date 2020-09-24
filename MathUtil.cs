namespace Testing {

    public class MathUtil {

        /// <summary>
        /// Returns the smallest number from an array of numbers.
        /// It should return 0 if the array is empty or null.
        /// </summary>
        public static int FindMin(int[] nums)
        {
            int min = nums[nums.Length-1];

            for (int i = 1; i < nums.Length; i++) {
                if (nums[i] < min) {
                    min = nums[i];
                }
            }

            return min;
        }


    }


}