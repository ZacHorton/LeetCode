public class Solution {
  public bool CanConstruct(string ransomNote, string magazine) {
    foreach(char c in ransomNote) {
      if (magazine.Contains(c)) {
        int index = magazine.IndexOf(c);
        magazine = magazine.Substring(0, index) + magazine.Substring(index + 1);
      } 
      else {
        return false;
      }
    }

    return true;
  }
}
