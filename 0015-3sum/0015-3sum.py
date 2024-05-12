class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        result = []
        
        if len(nums) < 3:
            return result
        
        for i in range (0, len(nums) - 2):
            left, right = i + 1, len(nums) - 1
            
            # Skip duplicate triplets by checking if the current element is the same as the previous one
            if i > 0 and nums[i] == nums[i - 1]:
                continue
            
            while left < right:
                triplet = nums[i] + nums[left] + nums[right]
                if triplet == 0:
                    result.append([nums[i], nums[left], nums[right]])
                    
                     # Skip duplicate values of 'left' and 'right'
                    while left < right and nums[left] == nums[left + 1]:
                        left += 1
                    while left < right and nums[right] == nums[right - 1]:
                        right -= 1
                    
                    # Move pointers to the next unique elements
                    left += 1
                    right -= 1
                elif triplet > 0:
                    right -= 1
                else:
                    left += 1
        
        return result