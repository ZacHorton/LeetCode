public class Solution {
  public int MaximumWealth(int[][] accounts) {
    if (accounts == null || accounts.Length == 0) {
      return 0;
    }

    int largestSum = 0;
    for (int i = 0; i < accounts.Length; i++) {
      int arrTotal = 0;
      for (int j = 0; j < accounts[i].Length; j++) {
        arrTotal += accounts[i][j];
      }
      if (arrTotal > largestSum) {
        largestSum = arrTotal;
      }
    }

    return largestSum;
  }
}
