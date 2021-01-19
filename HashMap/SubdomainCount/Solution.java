/*
 * Click `Run` to execute the snippet below!
 */

import java.io.*;
import java.util.*;

/*
 * To execute Java, please define "static void main" on a class
 * named Solution.
 *
 * If you need more classes, simply define them inline.
 */

class Solution {
  public static void main(String[] args) {
    String[] domains = new String[] {"900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"};
    List<String> result = subDomainsVisits(domains);
    for(String element : result) {
      System.out.println(element);
    }
  }
  
  public static List<String> subDomainsVisits(String[] domains) {
    Map<String, Integer> counts = new HashMap<>();
    for(String domain : domains) {
      String[] subDomainElements = domain.split("\\s+");
      String[] domainFrags = subDomainElements[1].split("\\.");
      int count = Integer.parseInt(subDomainElements[0]);
      String cur = "";
      for(int i = domainFrags.length - 1; i >= 0; i--) {
        cur = domainFrags[i] + (i < domainFrags.length - 1 ? "." : "") + cur;
        counts.put(cur, counts.getOrDefault(cur, 0) + count);
      }
    }
    
    List<String> ans = new ArrayList<>();
    for(String dom: counts.keySet()) {
      ans.add(counts.get(dom) + " " + dom);
    }
    return ans;
  }
}
