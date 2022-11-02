namespace Leetcode;

public static class MedianOfTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            (nums1, nums2) = (nums2, nums1);
        }

        var low = 0;
        var high = nums1.Length;
        var totalLength = nums1.Length + nums2.Length;

        while (low <= high)
        {
            var x = (low + high) / 2;
            var y = (totalLength + 1) / 2 - x;

            var leftX = GetMax(nums1, x);
            var rightX = GetMin(nums1, x);
            
            var leftY = GetMax(nums2, y);
            var rightY = GetMin(nums2, y);

            if (leftX <= rightY && leftY <= rightX)
            {
                if (totalLength % 2 == 0)
                {
                    return (Math.Max(leftX, leftY) + Math.Min(rightX, rightY)) / 2.0;
                }

                return Math.Max(leftX, leftY);
            }

            if (leftX > rightY)
            {
                high = x - 1;
            }
            else
            {
                low = x + 1;
            }
        }

        return -1;
    }

    private static int GetMax(IReadOnlyList<int> nums, int index)
    {
        return index == 0 ? int.MinValue : nums[index - 1];
    }
    
    private static int GetMin(IReadOnlyList<int> nums, int index)
    {
        return index == nums.Count ? int.MaxValue : nums[index];
    }
}