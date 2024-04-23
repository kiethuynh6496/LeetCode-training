class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        hashMap = {}
        index = []
        for i in range(len(nums)):
            if nums[i] in hashMap:
                index.append(i)
                index.append(hashMap[nums[i]])
            neededNum = target - nums[i]
            hashMap[neededNum] = i
        return index