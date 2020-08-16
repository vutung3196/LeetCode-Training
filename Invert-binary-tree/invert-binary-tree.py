# invert binary tree using DFS solution
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.Val = val
        self.Left = left
        self.Right = right

class Solution:
    def invertTree(self, root: TreeNode) -> TreeNode:
        stack = [root]
        while stack:
            node = stack.pop()
            if node:
                node.Left, node.Right = node.Right, node.Left
                stack += node.Left, node.Right
        return root