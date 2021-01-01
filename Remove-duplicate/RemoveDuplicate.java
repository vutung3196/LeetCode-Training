public class RemoveDuplicate {
    public int removeDuplicate(int[] nums) {
        int start = 0;
        int end = 0;
        while (end < nums.length) {
            if (nums[start] == nums[end]) {
                end++;
            } else {
                start++;
                nums[start] = nums[end];
                end++;
            }
        }
        return start + 1;
    }
}