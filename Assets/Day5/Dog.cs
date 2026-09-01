using UnityEngine;

public class Dog : Animal
{
    public Dog(string name, float height, double weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }

    public override void Introduce()
    {
        Debug.Log($"멍멍~ 내 이름은 {_name}이다 멍~");
    }
}
