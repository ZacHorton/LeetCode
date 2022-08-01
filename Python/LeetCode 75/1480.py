# 1480. Running Sum of 1d Array
from typing import List

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        prefix_sum = []
        total = 0
        for num in nums:
            total += num
            prefix_sum.append(total)

        return prefix_sum

"""
Runtime: 61 ms, faster than 56.65% of Python3 online submissions for Running Sum of 1d Array.
Memory Usage: 14.1 MB, less than 26.83% of Python3 online submissions for Running Sum of 1d Array.
"""
