# 1480. Running Sum of 1d Array
from typing import List

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        return_list = []
        total = 0
        for index in range(len(nums)):
            total += nums[index]
            return_list.append(total)

        return return_list

"""
Runtime: 46 ms, faster than 85.31% of Python3 online submissions for Running Sum of 1d Array.
Memory Usage: 14.1 MB, less than 71.44% of Python3 online submissions for Running Sum of 1d Array.
"""
