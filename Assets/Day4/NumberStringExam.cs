using UnityEngine;

public class NumberStringExam : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(solution("one4seveneight"));
        Debug.Log(solution("23four5six7"));
        Debug.Log(solution("2three45sixseven"));
        Debug.Log(solution("123"));
    }

    public int solution(string s) {
        if (s.Contains("zero"))
        {
            s = s.Replace("zero", "0");
        }
        
        if (s.Contains("one"))
        {
            s = s.Replace("one", "1");
        }
        
        if (s.Contains("two"))
        {
            s = s.Replace("two", "2");
        }
        
        if (s.Contains("three"))
        {
            s.Replace("three", "3");
        }
        
        if (s.Contains("four"))
        {
            s.Replace("four", "4");
        }
        
        if (s.Contains("five"))
        {
            s.Replace("five", "5");
        }
        
        if (s.Contains("six"))
        {
            s.Replace("six", "6");
        }
        
        if (s.Contains("seven"))
        {
            s.Replace("seven", "7");
        }
        
        if (s.Contains("eight"))
        {
            s.Replace("eight", "8");
        }
        
        if (s.Contains("nine"))
        {
            s.Replace("nine", "9");
        
        }

        int answer = 0;

        try
        {
            answer = int.Parse(s);
        }
        
        catch (System.Exception ex)
        {
            Debug.Log(s);
        }

        return answer;
    }
}
