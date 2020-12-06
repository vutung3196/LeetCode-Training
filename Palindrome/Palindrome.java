class Solution {
    public boolean isPalindrome(String s) {
        // preprocessing
        StringBuilder builder = new StringBuilder();
        for(char e : s.toCharArray()) {
            int x = getAlphaNumericNumber(e);
            if(x != -1) {
                builder.append(e);
            }
        }
        String processedText = builder.toString();
        int[] table = new int[processedText.length()];
        
        for(int i = 0; i < table.length; i++) {
            int x = getAlphaNumericNumber(processedText.charAt(i));
            if(x != -1) {
                table[i] = x;
            }
        }
        
        int index1 = 0;
        int index2 = table.length - 1;
        while (index1 < table.length && index2 >= 0) {
            if(table[index1] != table[index2]) {
                return false;
            }
            index1++;
            index2--;
        }
        return true;
    }
    
    
    static int getAlphaNumericNumber(char c) {
        int zero = Character.getNumericValue('0');
        int nine = Character.getNumericValue('9');
        int a = Character.getNumericValue('a');
        int z = Character.getNumericValue('z');
        int A = Character.getNumericValue('A');
        int Z = Character.getNumericValue('Z');
        int val = Character.getNumericValue(c);
        if (a <= val && val <= z) {
            return val;
        } else if (A <= val && val <= Z) {
            return val + 32;
        } else if (zero <= val && val <= nine) {
            return val;
        }
        return - 1;
    }
}