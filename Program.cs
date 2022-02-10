using System;

namespace TicTakToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Tic Tak Toe Game...!!");
            TicTakToeGame game = new TicTakToeGame();
            game.GameFun();
            
        }   
    }
}