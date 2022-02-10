using System;

namespace TicTakToe
{
    public class TicTakToeGame
    {
        public void GameFun()
        {
            char[] arr = new char[10];

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = ' ';
                System.Console.WriteLine(arr[i]+" | ");
            }          

            System.Console.WriteLine("please select X or O to play the game.");
            char input = Convert.ToChar(Console.ReadLine());
        
            switch (input)
            {
                case 'X':
                    System.Console.WriteLine("Player Choose "+input+" to play");
                    break;
                case 'O':
                    System.Console.WriteLine("Player Choose "+input+" to play");
                    break;
                default:
                    System.Console.WriteLine("Choose correct charactor.");
                    break;
                }
                
            
        }
    }
}