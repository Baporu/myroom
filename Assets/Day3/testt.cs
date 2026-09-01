using UnityEngine;

public class testt : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(solution("18446744073709551615", "287346502836570928366"));
    }
    
    public string solution(string a, string b) {
        string answer = "";
        string reversedAnswer = "";
        
        // 마지막부터 순회 -> 더하고 모듈러, 올림 별도 기록 (스택같은 느낌)
        // 근데 두 개가 서로 자리수가 다른데 어카지
        // 어카긴 나눠야지 뭐
        
        int sum = 0;
        bool flag = false;

        if (a.Length > b.Length)
        {
            // 올림 계산을 위해 반대로 순회
            for (int i = a.Length - 1; i >= a.Length - b.Length; i--)
            {
                int index = i - a.Length + b.Length - 1;
                sum = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString());

                // 이전 자리수에서 올림이 있으면 +1
                // (한 자리수 연산에서 올림은 2 이상 불가능)
                if (flag)
                {
                    sum++;
                    flag = false;
                }
                
                if (sum >= 10)
                {
                    sum -= 10;
                    flag = true;
                }
                
                reversedAnswer += sum.ToString();
            }
            
            // 남은 자리수 마저 계산
            for (int i = a.Length - b.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(a[i].ToString());
                
                if (flag)
                {
                    sum++;
                    flag = false;
                }
                
                if (sum >= 10)
                {
                    sum -= 10;
                    flag = true;
                }
                
                reversedAnswer += sum.ToString();
            }
        }

        else if (a.Length == b.Length)
        {
            // 올림 계산을 위해 반대로 순회
            for (int i = a.Length - 1; i >= a.Length - b.Length; i--)
            {
                sum = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString());

                // 이전 자리수에서 올림이 있으면 +1
                // (한 자리수 연산에서 올림은 2 이상 불가능)
                if (flag)
                {
                    sum++;
                    flag = false;
                }
                
                if (sum >= 10)
                {
                    sum -= 10;
                    flag = true;
                }
                
                reversedAnswer += sum.ToString();
            }
        }
        
        else
        {
            // 올림 계산을 위해 반대로 순회
            for (int i = b.Length - 1; i >= b.Length - a.Length; i--)
            {
                sum = int.Parse(a[i].ToString()) + int.Parse(b[i].ToString());

                // 이전 자리수에서 올림이 있으면 +1
                // (한 자리수 연산에서 올림은 2 이상 불가능)
                if (flag)
                {
                    sum++;
                    flag = false;
                }
                
                if (sum >= 10)
                {
                    sum -= 10;
                    flag = true;
                }
                
                reversedAnswer += sum.ToString();
            }
            
            // 남은 자리수 마저 계산
            for (int i = b.Length - a.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(b[i].ToString());
                
                if (flag)
                {
                    sum++;
                    flag = false;
                }
                
                if (sum >= 10)
                {
                    sum -= 10;
                    flag = true;
                }
                
                reversedAnswer += sum.ToString();
            }
        }
        
        // 다 돌았는데 올림 연산 남은 경우 (99999 + 1같은 상황)
        if (flag)
        {
            reversedAnswer += "1";
        }

        for (int i = reversedAnswer.Length - 1; i >= 0; i--)
        {
            answer += reversedAnswer[i];
        }
        
        return answer;
    }
}
