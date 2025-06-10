// Problem: 217. Contains Duplicate
// Link: https://leetcode.com/problems/contains-duplicate/
// Language: C#
// Time Complexity: O(n)
// Space Complexity: O(n)

class Program
{
       
     public static bool ContainsDuplicate(int[] nums)
     {
        HashSet<int> hm = new HashSet<int>();
        hm = nums.ToHashSet();
        if (hm.Count < nums.Length) {
            return true;
            }
        return false;
    }
}
