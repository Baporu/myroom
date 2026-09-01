using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    private void Start()
    {
        Animal person1 = new Person("손정휘", 26, 179f, 50f, false);
        Animal cat1 = new Cat("삠삐", 30f, 10f);

        Animal person2 = new Person("황유찬", 21, 179f, 45f, false);
        Animal dog1 = new Dog("누리", 50f, 15f);

        Animal person3 = new Person("하지호", 28, 170f, 40f, true);
        Animal dog2 = new Dog("덕자", 50f, 10f);

        Animal person4 = new Person("민범기", 26, 178f, 64f, false);
        Animal goldfish1 = new Goldfish("금", "빨간색");
        Animal goldfish2 = new Goldfish("붕", "주황색");

        // 자료형[] 변수명 = new 자료형[크기] { 초기값 }
        // 클래스도 자료형이고 참조 타입이며 사용자 정의 자료형이라고 하기도 한다.
        Animal[] animals = { person1, cat1, person2, dog1, person3, dog2, person4, goldfish1, goldfish2 };

        // 동물들을 반복문을 이용해 순회하면서 Introduce() 호출 가능
        foreach (Animal animal in animals)
        {
            animal.Introduce();
            
            // 동물이 사람 타입일 경우 자기소개 후 땅바닥에 앉는다.
            if (animal is Person)   // is: 객체가 실제로 해당 타입인지 검사한 후 그 결과를 bool로 반환
            {
                // 1. 명시적 형변환
                Person person = (Person)animal;
                person.SitDown();
            }
            
            // 2. as 형변환: 형변환을 시도하고 실패하면 null 반환
            Person pperson = animal as Person;
            if (pperson != null)
            {
                pperson.SitDown();
            }
            
            Person ppperson = animal as Person;
            ppperson?.SitDown();
        }
    }
}
