public class Solution {
  public int[] RunningSum(int[] nums) {
    if (nums == null || nums.Length == 0) {
      return new int[0];
    }

    int[] results = new int[nums.Length];
    results[0] = nums[0];

    for (int i = 1; i < nums.Length; i++) {
      int sum = nums[i] + results[i - 1];
      results[i] = sum;
    }

    return results;
  }
}
