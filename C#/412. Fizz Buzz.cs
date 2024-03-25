public class Solution {
  public string[] FizzBuzz(int n) {
    string[] results = new string[n];
    for (int x = 1; x <= n; x++) {
      if (x % 3 == 0 && x % 5 == 0) {
        results[x - 1] = "FizzBuzz";
      } else if (x % 3 == 0) {
        results[x - 1] = "Fizz";
      } else if (x % 5 == 0) {
        results[x - 1] = "Buzz";
      } else {
        results[x - 1] = x.ToString();
      }
    }

    return results;
  }
}
