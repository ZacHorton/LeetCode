public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] newArray = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            newArray[i] = nums[i] * nums[i];
        }

        Array.Sort(newArray);
        return newArray;
    }
}
