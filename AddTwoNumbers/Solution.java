class Solution {
    public List<Integer> addToArrayForm(int[] A, int K) {
        List<Integer> finalResult = new ArrayList<>();
        int count = 0;
        int temp = K;
        do {
            count++;
            int lastDigit = (int) (temp % 10);
            temp /= 10;
        } 
        while (temp != 0);
        int max = A.length > count ? A.length : count;
        System.out.println(max);
        int[] number1 = new int[max];
        int[] number2 = new int[max];
        for(int i = 0; i < A.length; i++) {
            number1[i] = A[A.length - i - 1];
        }
        int j = 0;
        do {
            int lastDigit = (int) (K % 10);
            number2[j] = lastDigit;
            K /= 10;
            j++;
        } 
        while (K != 0);
        int[] sum = new int[max+1];
        boolean isGreaterOrEqualThan10 = false;
        int carry = 0;
        for(int i = 0; i < max; i++) {
            sum[i] = (number2[i] + number1[i] + carry) % 10;
            
            if(number2[i] + number1[i] + carry >= 10) {
                carry = 1;
            } else {
                carry = 0;
            } 
        }
        sum[max] = carry;
        for(int i = max; i >= 0; i--) {
            if (i == max && sum[max] == 0) {
                continue;
            }
            finalResult.add(sum[i]);
        }
        return finalResult;
    }

    // from editorial
    public List<Integer> addToArrayForm(int[] A, int K) {
        int N = A.length;
        int cur = K;
        List<Integer> ans = new ArrayList();

        int i = N;
        while (--i >= 0 || cur > 0) {
            if (i >= 0)
                cur += A[i];
            ans.add(cur % 10);
            cur /= 10;
        }

        Collections.reverse(ans);
        return ans;
    }
}