using UnityEngine;

public class DataTypeExample : MonoBehaviour
{
    void Start()
    {
        // 자료형 (변수에 직접 값이 저장되는 데이터의 종류 = 데이터 타입)
        
        // 종류는 크게 4가지다.
        
        // 1. 숫자 (12가지)
        // - 정수(short, int, long), 실수(float, double, decimal..)
        short jaesan0 = 32767;      // short가 표현할 수 있는 데이터의 범위는 -32,768 ~ 32,767  // 2바이트
        //int jaesan1 = 12000000000;  // int가 표현할 수 있는 데이터의 범위는 약 -21억 ~ 21억      // 4바이트
        long jaesan2 = 12000000000; // long이 표현할 수 있는 데이터의 범위는 약 -9.2경 ~ 9.2경   // 8바이트

        // 50만 가지
        int id = 204023;
        long id2 = 3423894829038904830;
        // 20: 아이템의 타입
        // 4: 착용 가능한 직업
        // 023: 23레벨 아이템
        
        // 실수(float, double, decimal...)
        float floaterNumber = 3.141592653589793238462643383279502884197169399f;  // float 4바이트
        double doubleNumber = 3.141592653589793238462643383279502884197169399d;  // double 8바이트
        decimal decimalNumber = 3.141592653589793238462643383279502884197169399m;  // decimal 16바이트

        Debug.Log(floaterNumber);
        Debug.Log(doubleNumber);
        Debug.Log(decimalNumber);
        // 실제로 출력되는 소수점 이하 자릿수가 다르다. (정밀도)

        // 2. 문자(열) (2가지)
        // 문자(char), 문자열(string)
        char firstName = '홍';
        string lastName = "길동";

        // 3. 논리
        // bool
        bool isDie = true;
        // is, has, 3인칭 동사원형
        // supports;

        // 4. Object ( 참조형)
        
        
        // # 형변환
        // 변수에 담겨 있는 데이터를 다른 데이터 타입(자료형)의 변수에 옮겨 담는 것
        // 이것만 주의하면 된다!
        // 큰 자료형에서 작은 자료형으로 가는 것을 주의하면 된다!!!

        long money1 = 238472893748923;
        int  money2 = (int)money1;      // 내가 강제로 명확하게 데이터의 자료형을 바꾼다 -> 명시적 형변환
                                        // 목적지 데이터의 유효 범위보다 크거나 작으면
                                        // '오버플로우', '언더플로우'가 일어날 수 있다.
                                        
        Debug.Log(money1);
        Debug.Log(money2);

        int  maxHealth1 = 88888;
        long maxHealth2 = 34;
        maxHealth2 = maxHealth1;        // 작은 범위에서 큰 범위로 갈 때는 자동으로 자료형이 바뀐다 -> 암시적 형변환
        
        // 상수: 데이터를 초기화할 때 빼고는 절대 변경할 수 없는 변수
        // 변경하지 말아야 할 변수를 건드려서 게임에서 오류가 발생하는 것을 방지
        const int MaxHealth = 500;
        //MaxHealth = 23;
        
        // 중요한 데이터임을 암시해주기도 함
        const int GameWidth = 10;
        const int GameHeight = 50;
    }
}
