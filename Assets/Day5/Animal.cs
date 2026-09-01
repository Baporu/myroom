using UnityEngine;

// 상속이란: 부모(상위/기반/슈퍼) 클래스의 속성과 기능을 자식(하위/파생/서브) 클래스에게 물려주는 것
// 장점:
// - 코드 재사용: 이미 만들어진 부모 클래스의 속성과 기능을 공유하므로 중복이 최소화된다.
// - 확장: 자식 클래스만의 고유한 속성이나 기능을 추가할 수 있다.
// - 재정의: 부모에게 물려받은 메서드를 상황에 맞게 재정의(오버라이딩)하여 사용할 수 있다.
public abstract class Animal
{
    protected string _name = string.Empty;
    protected float _height = 0f;
    protected double _weight = 0f;

    public abstract void Introduce();

    public void Run()
    {
        Debug.Log($"{_name} 뛰는 중! 속도: {100 - _height / _weight}");
    }
}
