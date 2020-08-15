class ListNode:
    def __init__(self, key, val):
        self.pair = (key, val)
        self.next = None

class MyHashMap:
    def __init__(self):
        self.m = 10000
        self.h = [None] * self.m

    # insert or update
    def put(self, key, value):
        index = key % self.m
        if self.h[index] == None:
            self.h[index] = ListNode(key, value)
        else:
            curr = self.h[index]
            while True:
                if curr.pair[0] == key:
                    curr.pair = (key, value)  #update
                    return
                if curr.next == None:
                    break
                curr = curr.next
            curr.next = ListNode(key, value)
    
    def get(self, key):
        index = key % self.m
        curr = self.h[index]
        while curr:
            if curr.pair[0] == key:
                return curr.pair[1] # return value of key
            else:
                curr = curr.next
        return -1

    def remove(self, key):
        index = key % self.m
        curr = prev = self.h[index]
        if not curr:
            return
        if curr.pair[0] == key:
            self.h[index] = curr.next
        else:
            curr = curr.next
            while curr:
                if curr.pair[0] == key:
                    prev.next = curr.next
                    break
                else:
                    curr, prev = curr.next, prev.next