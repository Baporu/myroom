using UnityEngine;

public class StringParseExample : MonoBehaviour
{
    void Start()
    {
        string stringAge = "38살";
        int intAge = 0;
        Debug.Log(int.Parse(stringAge));
        
        bool result1 = int.TryParse(stringAge, out intAge);

        if (result1)
        {
            Debug.Log(intAge);
        }
        else
        {
            Debug.Log("변환에 실패했습니다.");
        }

        string stringWeight = "70.2kg";
        float floatWeight = .0f;
        bool result2 = float.TryParse(stringWeight, out floatWeight);
        
        if (result2)
        {
            Debug.Log(floatWeight);
        }
        else
        {
            Debug.Log("변환에 실패했습니다.");
        }
    }
}
