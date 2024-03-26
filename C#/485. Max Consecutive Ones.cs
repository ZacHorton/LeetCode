public class Solution {
  public int FindMaxConsecutiveOnes(int[] nums) {
    int largestCount = 0;
    int count = 0;
    foreach(int num in nums) {
      if (num == 1) {
        count++;
      }

      if (count > largestCount) {
        largestCount = count;
      }

      if (num == 0) {
        count = 0;
      }
    }

    return largestCount;
  }
}
