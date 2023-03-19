using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace simpleMathGame
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game created by Paulius Jurgelis\n");
            Thread.Sleep(1000);
            Console.WriteLine("Math game of 4 operation\n");

            List<int> history = new List<int>();
            List<string> game = new List<string>();
            List<int> firstNumber = new List<int>();
            List<int> secondNumber = new List<int>();

            while (true)
            {
                Console.WriteLine("--------------------\n");
                Console.WriteLine("If you want to use Addition write add\n");
                Console.WriteLine("If you want to use Subtraction write sub\n");
                Console.WriteLine("If you want to use Multiplication write multi\n");
                Console.WriteLine("If you want to use Division write div\n");

                var choice = Console.ReadLine();

                if (choice == "add")
                {
                    int _firstNumber;
                    int _secondNumber;
                    int _result;

                    string _gameType = "Addition";

                    while (choice == "add")
                    {
                        Console.WriteLine("Write your first number");
                        if (!int.TryParse(Console.ReadLine(), out _firstNumber))
                        {
                            Console.WriteLine("Write and integer value!");
                            break;
                        }
                        Console.WriteLine("Write your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }

                        _result = _firstNumber + _secondNumber;
                        Console.WriteLine($"Your result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }

                }

                if (choice == "sub")
                {
                    int _firstNumber;
                    int _secondNumber;
                    int _result;

                    string _gameType = "Subdivision";

                    while (choice == "sub") {

                        Console.WriteLine("Write your first number");
                        if (!int.TryParse(Console.ReadLine(), out _firstNumber))
                        {
                            Console.WriteLine("Write and integer value!");
                            break;
                        }
                        Console.WriteLine("Write your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }
                        _result = _firstNumber - _secondNumber;
                        Console.WriteLine($"Your result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }
                }

                if (choice == "multi")
                {
                    int _firstNumber;
                    int _secondNumber;
                    int _result;

                    string _gameType = "Multiplication";

                    while (choice == "multi")
                    {

                        Console.WriteLine("Write your first number");
                        if (!int.TryParse(Console.ReadLine(), out _firstNumber))
                        {
                            Console.WriteLine("Write and integer value!");
                            break;
                        }
                        Console.WriteLine("Write your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }
                        _result = _firstNumber * _secondNumber;
                        Console.WriteLine($"Your result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }
                }

                if (choice == "div")
                {
                    int _firstNumber;
                    int _secondNumber;
                    int _result;

                    string _gameType = "Division";

                    while (choice == "div")
                    {

                        Console.WriteLine("Write your first number");
                        if (!int.TryParse(Console.ReadLine(), out _firstNumber))
                        {
                            Console.WriteLine("Write and integer value!");
                            break;
                        }
                        Console.WriteLine("Write your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }
                        _result = _firstNumber / _secondNumber;
                        Console.WriteLine($"Your result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }
                }

                if (choice == "history")
                {
                    for (int i = 0; i < history.Count; i++)
                    {
                        if (game[i] == "Subdivision")
                        {
                            Console.WriteLine($"History: {firstNumber[i]} - {secondNumber[i]} = {history[i]} {game[i]} ");
                        }
                        if (game[i] == "Addition")
                        {
                            Console.WriteLine($"History: {firstNumber[i]} + {secondNumber[i]} = {history[i]} {game[i]} ");
                        }
                        if (game[i] == "Multiplication")
                        {
                            Console.WriteLine($"History: {firstNumber[i]} + {secondNumber[i]} = {history[i]} {game[i]} ");
                        }
                        if (game[i] == "Division")
                        {
                            Console.WriteLine($"History: {firstNumber[i]} + {secondNumber[i]} = {history[i]} {game[i]} ");
                        }

                    }
   
                }
            }
        }
    }

}