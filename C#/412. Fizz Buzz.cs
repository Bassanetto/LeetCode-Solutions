public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>(n);

        for(int i = 1; i <= n; i++) {
            bool divisivelPor3 = i % 3 == 0;
            bool divisivelPor5 = i % 5 == 0;

            if(divisivelPor3 && divisivelPor5) {
                answer.Add("FizzBuzz");
            } else if(divisivelPor3) {
                answer.Add("Fizz");
            } else if(divisivelPor5) {
                answer.Add("Buzz");
            } else {
                answer.Add(i.ToString());
            }
        }
        return answer;
    }
}