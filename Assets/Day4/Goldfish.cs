using UnityEngine;

public class Goldfish : Animal
{
    private string _color = string.Empty;
    
    public Goldfish(string name, string color)
    {
        _name = name;
        _height = 2;
        _weight = 0.3;
        _color = color;
    }

    public override void Introduce()
    {
        Debug.Log($"{_name}: 뻐끔뻐끔 나의 비늘 색깔은 {_color}입니다.");
    }
}
