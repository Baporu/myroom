using UnityEngine;

public class Person : Animal
{
    // 필드 (속성, 멤버, 변수)
    // public: 외부에서 접근(읽기, 쓰기)이 가능하다.
    // private: 외부에서 접근이 불가능하다.
    
    // 추상화 -> 은닉화 -> 캡슐화
    
    private int _age = 0;
    public bool HasGlasses = false;

    // 생성자 메서드
    // - 객체가 생성될 때 new 키워드와 함께 호출하는 메서드
    // - 클래스 이름과 같아야 한다.
    public Person(string name,  int age, float height, double weight, bool hasGlasses)
    {
        _name = name;
        _age = age;
        _height = height;
        _weight = weight;
        HasGlasses = hasGlasses;
    }
    
    // 메서드 (기능, 함수)
    public override void Introduce()
    {
        Debug.Log($"안녕하세요. 제 이름은 {_name}이고, 나이는 {_age}입니다. 키와 몸무게는 {_height}cm / {_weight}kg입니다.");
    }
    
    public void SitDown()
    {
        Debug.Log($"바닥에 앉는다!");
    }
    
    public void SitDown(Chair chair)
    {
        Debug.Log($"{chair.Color} 의자에 앉는다!");
    }

    
    // public  필드 변수는: Name (파스칼)
    // private 필드 변수는: _name (_카멜)
    //         지역 변수는: name (카멜)
    
    public void Punch(Person otherPerson)
    {
        Debug.Log($"{_name}이가 {otherPerson._name}이를 때렸다!");
    }
}
