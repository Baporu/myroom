using UnityEngine;

enum Direction
{
    East,
    South,
    West,
    North
}

public class Spiral : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(solution(4));
    }
    
    public int[,] solution(int n) {
        int[,] answer = new int[n,n];
        Debug.Log($"행 개수: {answer.GetLength(0)}, 열 개수: {answer.GetLength(1)}, 전체 요소 개수: {answer.Length}");
        
        int minX = 0, minY = 0;
        int maxX = n, maxY = n;

        int currentNumber = 1;
        Direction currentDirection = Direction.East;
        
        while (minX < maxX || minY < maxY)
        {
            switch (currentDirection)
            {
                case Direction.East:
                {
                    for (int j = minY; j < maxY; j++)
                    {
                        answer[minX, j] = currentNumber;
                        currentNumber++;
                        
                        Debug.Log(answer[minX, j]);
                    }
                
                    minY++;
                    currentDirection = Direction.South;
                    break;
                }
                
                case Direction.South:
                {
                    for (int i = minX; i < maxX; i++)
                    {
                        answer[i, maxY - 1] = currentNumber;
                        currentNumber++;
                    }
                    
                    maxX--;
                    currentDirection = Direction.West;
                    break;
                }
                    
                case Direction.West:
                {
                    for (int j = maxY - 1; j >= minY; j--)
                    {
                        Debug.Log($"maxX = {maxX}");
                        answer[maxX - 1, j] = currentNumber;
                        currentNumber++;
                    }
                
                    maxY--;
                    currentDirection = Direction.North;
                    break;
                }
                 
                case Direction.North:
                {
                    for (int i = maxX - 1; i >= minX; i--)
                    {
                        answer[i, minY] = currentNumber;
                        currentNumber++;
                    }
                
                    minX++;
                    currentDirection = Direction.East;
                    break;
                }
            }
        }
        
        return answer;
    }
}
