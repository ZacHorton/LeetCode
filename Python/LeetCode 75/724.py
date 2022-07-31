# 724. Find Pivot Index
from typing import List

class Solution:
    def pivotIndex(self, nums: List[int]) -> int:
        left_sum, right_sum, pivot_index = 0, 0, 0
        for index in range(len(nums)):
            left_list = nums[:index]
            right_list = nums[index + 1:]
            if left_list:
                for num in left_list:
                    left_sum += num
            if right_list:
                for num in right_list:
                    right_sum += num
            if left_sum == right_sum:
                pivot_index = index
                return pivot_index
            left_sum, right_sum = 0, 0
        else:
            return -1

"""
Time Limit Exceeded
"""
