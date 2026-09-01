using UnityEngine;

public class PersonClassExample : MonoBehaviour
{
    private void Start()
    {
        Chair chair1 = new Chair();
        Chair chair2 = new Chair();
        chair2.Color = "푸른색";
        
        Person person1 = new Person("홍길동", 20, 182.7f, 78, false);
        person1.Introduce();
        person1.Run();
        person1.SitDown(chair2);

        Person person2 = new Person("홍동길", 19, 178.2f, 72, true);
        person2.Introduce();
        person2.Run();
        person2.SitDown();
        
        person1.Punch(person2);


        Person person3 = null;
        // null이란 존재하지 않는다는 뜻
        // 메모리 주소를 가리킬 변수만 만들었을 뿐, 알맹이는 존재하지 않음

        // 객체지향 프로그래밍에서 제임스 고슬링이 땅을 치고 후회하는 문법 중 하나
        // 가장 빈번하게 오류를 일으키는 문법
        
        person1.Punch(person3);
    }
}
