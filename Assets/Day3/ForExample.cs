using UnityEngine;

public class ForExample : MonoBehaviour
{
    private void Start()
    {
        // 1. 1부터 1,000까지 짝수만 더한 값을 구해보세요.
        int sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        
        Debug.Log(sum);
        
        // 2. 구구단 2단부터 9단까지 5단을 제외하고 중첩 반복문을 이용해서 출력해보세요.
        // 점프문: 반복문 내부에서 흐름을 끊고 코드 실행 위치를 원하는 곳으로 점프해준다.
        // - break      : 현재 실행 중인 반복문이나 분기문의 실행을 중단할 때 사용. (종료/탈출이라고 부르기도 함)
        // - continue   : 반복문 코드 블록 내에서 현재 실행 중인 코드 라인의 아래 코드들의 실행을 건너뛸 때 사용
        for (int i = 2; i <= 9; i++)
        {
            if (i == 5)
            {
                continue;
            }

            for (int j = 1; j <= 9; j++)
            {
                Debug.Log($"{i} x {j} = {i * j}");
            }
        }
    }

    private void Update()
    {
        
    }
}
