using UnityEngine;

public class StringFormatExample : MonoBehaviour
{
    void Start()
    {
        string name = "홍길동";
        int age = 26;
        bool isMale = true;

        // 나의 이름은 ㅇㅇㅇ이고, 나이는 00살입니다. 성별은 00입니다.
        
        // 1. + 연산자를 이용한 문자열 더하기 방식
        //    (내부적으로 ToString()을 호출한다.)
        Debug.Log("나의 이름은 " + name + "이고, 나이는 " + age + "살입니다. 성별은 " + (isMale ? "남자" : "여자") + "입니다.");

        // 2. 문자열 서식(String.Format)을 이용한 방식
        string gender = isMale ? "남자" : "여자";
        string introduceString = string.Format("나의 이름은 {0}이고, 나이는 {1}살입니다. 성별은 {2}입니다.", name, age, gender);
        Debug.Log(introduceString);
        
        // 3. $ 기호를 이용한 문자열 보간
        string introduceString2 = $"나의 이름은 {name}이고, 나이는 {age}살입니다. 성별은 {gender}입니다.";
        Debug.Log(introduceString2);

        float height = 182.754f;
        Debug.Log(height);      // 182.754 -> 나는 소수점 첫 번째 자리까지만 출력하고 싶다.. -> 서식 문자열
        int money = 6564321;
        Debug.Log(money);       // 6564321 -> 나는 원 단위로 숫자 세자리마다 ,를 붙여서 출력하고 싶다.. -> 서식 문자열
        
        Debug.Log(string.Format("{0,F1}", height));
        Debug.Log(string.Format("{0,N0}", money));
        
        Debug.Log($"{height:F1}");
        Debug.Log($"{money:N0}");

        int hour = 3;
        int minute = 13;
        // 03시 13분
        Debug.Log($"{hour:2D}시 {minute}분");
    }
}
