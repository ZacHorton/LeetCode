def twoSum(nums, target):
    # Here is a Python solution in O(n) time
    # LeetCoders: Nathan_Fegard and __guoqiao__
    # Uses dictionary, called map in other languages, to track previous values and indices
    d = {}
    for i, n in enumerate(nums):
        m = target - n
        # n + m = target
        if m in d:
            return [d[m], i]
        else:
            d[n] = i
