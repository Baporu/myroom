using UnityEngine;

public class StringMethodExample : MonoBehaviour
{
    // 문자열은 문자열만의 여러 가지 속성과 기능을 가지고 있다.
    // 서식, 길이, 탐색, 변형, 분할..
    void Start()
    {
        string name = "황금독수리 새상을 놀라게 하다.";
        Debug.Log(name.Length);

        name = name.Trim();
        Debug.Log(name);

        name = name.Insert(6, "온");
        Debug.Log(name);

        name = name.Remove(name.IndexOf('.'));
        name = name.Replace(".", "");
        name = name.Replace("새", "세");

        string name2 = "Karina";
        name2 = name2.ToUpper();
        Debug.Log(name2);
        name2 = name2.ToLower();
        Debug.Log(name2);
    }
}
