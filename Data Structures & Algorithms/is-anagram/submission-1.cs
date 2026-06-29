 public class Solution
 {
     public bool IsAnagram(string s, string t)
     {
         if (s.Length != t.Length) return false;

         var s1 = s.ToCharArray();
         var t1 = t.ToCharArray();

         Array.Sort(s1);
         Array.Sort(t1);
         for (int i = 0; i < s1.Length; i++)
         {
             if(s1[i] != t1[i])
                 return false;
         }
         return true;
     }
 }