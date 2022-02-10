using System;

namespace TicTakToe
{
    public class TicTakToeGame
    {
        public void GameFun()
        {
            char[] arr = new char[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ' ';
                System.Console.WriteLine(arr[i]+" | ");
            }          
        }
    }
}