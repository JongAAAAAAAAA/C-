using System;
using static System.Console;

namespace BAEKJOON_11720
{
    class MainApp
    {
        static void Main()
        {
            // 첫번째 입력 숫자의 개수 N
            int inputNum1 = int.Parse(ReadLine());
            // 두번째 입력 숫자 N개
            string inputNum2 = ReadLine();

            // 첫번째 개수만큼 배열크기를 지정
            int[] intArr = new int[inputNum1];
            // 두번째 입력 숫자만큼 배열 크기를 지정
            string[] strArr = new string[inputNum2.Length];

            // 합을 담을 변수
            int sum = 0;
            // for을 돌려서 입력된 N개를 배열로 쪼갠다
            for (int i = 0; i < strArr.Length; i++)
            {
                // strArr배열에 입력받은 값을 하나하나 쪼개서 넣어준다.
                strArr[i] = Convert.ToString(inputNum2[i]);
                // sum에 쪼개어진 값을 더해준다.
                sum += int.Parse(strArr[i]);
            }
            // 더해진 값 출력
            WriteLine(sum);
        }
    }
}