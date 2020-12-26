class PalindromeNumber {
    public boolean isPalindrome(int x) {
        if (x < 0) {
            return false;
        }
        int digitNumber = 0;
        int currentValue = x;
        while(currentValue > 0) {
            currentValue /= 10;
            digitNumber += 1;
        }
        int[] arr = new int[digitNumber];
        for (int i = 0; i < digitNumber; i++) {
            arr[i] = x % 10;
            x /= 10;

        }
        for (int i = 0; i < digitNumber; i++) {
            if (arr[i] != arr[digitNumber - i - 1])
                return false;
        }
        return true;
    }
}