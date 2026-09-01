using UnityEngine;

public class Cat : Animal
{
    public Cat(string name, float height, double weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }
    
    // 지금 문법은 재정의가 아니라 메서드 섀도잉(하이딩)하고 있는 것이다.
    // 재정의 문법은 override를 써야 한다.
    // 재정의를 하면 가리키는 타입과 상관없이 실제 타입의 메서드를 호출한다.
    public override void Introduce()
    {
        Debug.Log($"야옹~ 내 이름은 {_name}이다 냥~");
    }
}
