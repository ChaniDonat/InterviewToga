

int PeakElement(int[] nums,int left,int right)
{
    if (left >= right) return left;

    int mid = left + (right - left) / 2;
    if ((mid == 0 || nums[mid] > nums[mid - 1]) && (mid == nums.Length - 1 || nums[mid] > nums[mid + 1]))
    {
        return mid;
    }

    return nums[mid] < nums[mid + 1] ?
        PeakElement(nums, mid + 1, right) :
        PeakElement(nums, left, mid - 1);

}
string arr1 = Environment.GetEnvironmentVariable("arr1");
if (arr1 != null)
{
    string[] nums1Strings = arr1.Split(','); // Split by commas
    int[] nums1Array = Array.ConvertAll(nums1Strings, int.Parse);
    Console.WriteLine(PeakElement(nums1Array, 0, nums1Array.Length - 1));
}
string arr2 = Environment.GetEnvironmentVariable("arr2");
if (arr2 != null)
{
    string[] nums2Strings = arr2.Split(','); // Split by commas
    int[] nums2Array = Array.ConvertAll(nums2Strings, int.Parse);
    Console.WriteLine(PeakElement(nums2Array, 0, nums2Array.Length - 1));

}
