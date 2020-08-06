package com.company;

import java.util.HashMap;
import java.util.Map;

public class Main {

    public static void main(String[] args) {
        int[] sampleArray = new int[] {3,2,4};
        int[] a = twoSum(sampleArray, 6);
        for (int i:a) {
            System.out.println(i);
        }
    }

    public static int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            map.put(nums[i], i);
        }

        for (int i = 0; i < nums.length; i++){
            if (map.containsKey(target - nums[i]) && i != map.get(target - nums[i]))
                // Get the value of hash map
                return new int[] {i, map.get(target - nums[i])};
        }
        return new int[2];
    }
}
