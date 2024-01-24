 int biggerNeighbors(int[] nums,int left,int right)
{
    int mid=left+right/2+1;
    if (nums[mid] > nums[mid + 1] && nums[mid] > nums[mid - 1])
        return mid;
    if (nums[mid] < nums[left])
    {
       return biggerNeighbors(nums,left,mid);
    }
    else
    {
      return biggerNeighbors(nums, mid, right);
    }
}
int[] nums = { 1, 2, 3, 6, 2, 10 };
Console.WriteLine(biggerNeighbors(nums,0,nums.Length-1));
