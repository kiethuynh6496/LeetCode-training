public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int index1 = 0;
        int index2 = 0;
        int neededNum;
        int indexNeededNum;
        for(int i = 0; i < nums.Length; ++i){
            neededNum = target - nums[i];
            indexNeededNum = Array.IndexOf(nums, neededNum);
            if(indexNeededNum != i && indexNeededNum >= 0){
                index1 = i;
                index2 = indexNeededNum;
                break;
            }
        }
        return new int[]{index1, index2};
    }
}