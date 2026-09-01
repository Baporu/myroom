using UnityEngine;

public class PasswordExam : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(solution("aukks", "wbqd", 5));
    }

    public string solution(string s, string skip, int index) {
        string answer = s;
        
        // a~z 만들고 remove 쓰면?
        string alphabets = "abcdefghijklmnopqrstuvwxyz";
        
        foreach (char alphabet in skip)
        {
            int idx =  alphabets.IndexOf(alphabet);
            if (idx != -1)
            {
                alphabets = alphabets.Remove(idx, 1);
            }
        }
        Debug.Log(alphabets);
        
        foreach (char alphabet in s)
        {
            answer = answer.Replace(alphabet, alphabets[(alphabets.IndexOf(alphabet) + index) % alphabets.Length]);
        }
        
        return answer;
    }
}
