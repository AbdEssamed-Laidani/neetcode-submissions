  public class Solution
  {
      public bool hasDuplicate(int[] nums)
      {
          
          HashSet<int> Set = new HashSet<int>();
          foreach (var item in nums)
          {
              if(Set.Contains(item))
                  return true;
              Set.Add(item);
          }
          return false;
      }
  }