from typing import List
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        result = []
        for i in range(0, len(nums)-1):
            expected = target - nums[i]
            print(expected)
            for j in range(i+1, len(nums)):
                print('j: ', j)
                if nums[j] == expected:
                    result.append(i)
                    result.append(j)
                    return result
        return result

a = Solution()
nums = [3, 2, 4]
target = 6
b = a.twoSum(nums, target)
print(b)
            