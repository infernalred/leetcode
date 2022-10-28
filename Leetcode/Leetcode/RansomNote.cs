namespace Leetcode;

public static class RansomNote
{
    public static bool CanConstruct(string ransomNote, string magazine) 
    {
        //slowly but memory usage less then 60%
        

        // var queue = new Queue<char>(ransomNote);
        // for (int i = 0; i < ransomNote.Length; i++)
        // {
        //     var letter = queue.Dequeue();
        //     var index = magazine.IndexOf(letter);
        //     if (index >= 0)
        //     {
        //         
        //         magazine = magazine.Remove(index, 1);
        //     }
        //     else
        //     {
        //         queue.Enqueue(letter);
        //     }
        // }
        // return queue.Count == 0;
        
        //faster but more memory for array
        var chars = new int[256];
        foreach (var c in magazine)
        {
            chars[c]++;
        }

        foreach (var c in ransomNote)
        {
            chars[c]--;
            if (chars[c] < 0) return false;
        }
        return true;
    }
}