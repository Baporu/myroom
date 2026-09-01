using System;
using UnityEngine;

public class KNumberExam : MonoBehaviour
{
    private void Start()
    {
        int[] arr = { 1, 5, 2, 6, 3, 7, 4 };
        int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
        Debug.Log(solution(arr, commands));
    }

    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        string arrayString = string.Empty;
        
        foreach (int number in array)
        {
            arrayString += number.ToString();
        }
        
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1] - 1;
            
            string subString = arrayString.Substring(start, end - start + 1);
            
            int[] sortingArray = new int[end - start + 1];
            
            for (int j = 0; j < subString.Length; j++)
            {
                sortingArray[j] = int.Parse(subString[j].ToString());
            }
            Array.Sort(sortingArray);
            
            answer[i] = sortingArray[commands[i, 2]];
        }
        
        return answer;
    }
}
