using UnityEngine;

public class SwitchCaseExample : MonoBehaviour
{
    void Start()
    {
        // 분기문
        // 내가 원하는 값과 같냐 다르냐에 따라서 실행할 코드 분기를 나눌 수 있다.

        /*
         * switch (검사할 변수)
         * {
         *     case 값1:
         *     {
         *         실행할 코드
         *         break;
         *     }
         * 
         *     case 값2:
         *     {
         *         실행할 코드
         *         break;
         *     }
         *
         *     default:     // 옵션, 아무런 case에 해당하지 않을 경우
         *     {
         *         실행할 코드
         *         break;
         *     }
         * }
         */
        
        // 1번 문제
        // 변수 today를 선언하고, 요일에 따라 "오늘은 ○요일입니다!"를 출력해주는 코드를 작성하세요.
        DayOfWeek today = DayOfWeek.Thursday;

        switch (today)
        {
            case DayOfWeek.Monday:
            {
                Debug.Log("오늘은 월요일입니다!");
                break;
            }
            case DayOfWeek.Tuesday:
            {
                Debug.Log("오늘은 화요일입니다!");
                break;
            }
            case DayOfWeek.Wednesday:
            {
                Debug.Log("오늘은 수요일입니다!");
                break;
            }
            case DayOfWeek.Thursday:
            {
                Debug.Log("오늘은 목요일입니다!");
                break;
            }
            case DayOfWeek.Friday:
            {
                Debug.Log("오늘은 금요일입니다!");
                break;
            }
            case DayOfWeek.Saturday:
            {
                Debug.Log("오늘은 토요일입니다!");
                break;
            }
            case DayOfWeek.Sunday:
            {
                Debug.Log("오늘은 일요일입니다!");
                break;
            }
        }

        // 2번 문제
        // 변수 score를 선언하고, 점수(0~100)에 따라
        // 100: "A+", 90~99: "A", 80~89 "B", 70~79 "C", 60~69 "D", 60 미만 "F"
        // 를 출력해주는 코드를 작성하세요.
        int score = 98;

        switch (score / 10)
        {
            case 10:
            {
                Debug.Log("A+");
                break;
            }
            
            case 9:
            {
                Debug.Log("A");
                break;
            }
            
            case 8:
            {
                Debug.Log("B");
                break;
            }
            
            case 7:
            {
                Debug.Log("C");
                break;
            }
            
            case 6:
            {
                Debug.Log("D");
                break;
            }
            
            default:
            {
                Debug.Log("F");
                break;
            }
        }
        
        switch (score)
        {
            case 100:
            {
                Debug.Log("A+");
                break;
            }
            
            case 99:
            case 98:
            case 97:
            case 96:
            case 95:
            case 94:
            case 93:
            case 92:
            case 91:
            case 90:
            {
                Debug.Log("A");
                break;
            }
            
            case 89:
            case 88:
            case 87:
            case 86:
            case 85:
            case 84:
            case 83:
            case 82:
            case 81:
            case 80:
            {
                Debug.Log("B");
                break;
            }
            
            case 79:
            case 78:
            case 77:
            case 76:
            case 75:
            case 74:
            case 73:
            case 72:
            case 71:
            case 70:
            {
                Debug.Log("C");
                break;
            }
            
            case 69:
            case 68:
            case 67:
            case 66:
            case 65:
            case 64:
            case 63:
            case 62:
            case 61:
            case 60:
            {
                Debug.Log("D");
                break;
            }

            default:
            {
                Debug.Log("F");
                break;
            }
        }
    }
}
