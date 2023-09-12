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
                Console.WriteLine("If you want to check your operation history write 'history'\n");

                var choice = Console.ReadLine();

                if (choice == "add")
                {
                    Console.Clear();
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
                        Console.WriteLine("\nWrite your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }

                        _result = _firstNumber + _secondNumber;
                        Console.WriteLine($"\nYour result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }

                }

                if (choice == "sub")
                {
                    Console.Clear();
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
                        Console.WriteLine("\nWrite your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }
                        _result = _firstNumber - _secondNumber;
                        Console.WriteLine($"\nYour result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }
                }

                if (choice == "multi")
                {
                    Console.Clear();
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
                        Console.WriteLine("\nWrite your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }
                        _result = _firstNumber * _secondNumber;
                        Console.WriteLine($"\nYour result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }
                }

                if (choice == "div")
                {
                    Console.Clear();
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
                        Console.WriteLine("\nWrite your second number");
                        if (!int.TryParse(Console.ReadLine(), out _secondNumber))
                        {
                            Console.WriteLine("Write an integer value!");
                            break;
                        }

                        if(_firstNumber == 0 || _secondNumber == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            break;
                        }


                        _result = _firstNumber / _secondNumber;


                        Console.WriteLine($"\nYour result is: {_result}");

                        history.Add(_result);
                        game.Add(_gameType);
                        firstNumber.Add(_firstNumber);
                        secondNumber.Add(_secondNumber);
                        break;
                    }
                }

                if (choice == "history")
                {
                    Console.Clear();
                    for (int i = 0; i < history.Count; i++)
                    {
                        if (game[i] == "Subdivision")
                        {
                            Console.WriteLine($"\nHistory: {firstNumber[i]} - {secondNumber[i]} = {history[i]} {game[i]} ");
                        }
                        if (game[i] == "Addition")
                        {
                            Console.WriteLine($"\nHistory: {firstNumber[i]} + {secondNumber[i]} = {history[i]} {game[i]} ");
                        }
                        if (game[i] == "Multiplication")
                        {
                            Console.WriteLine($"\nHistory: {firstNumber[i]} * {secondNumber[i]} = {history[i]} {game[i]} ");
                        }
                        if (game[i] == "Division")
                        {
                            Console.WriteLine($"\nHistory: {firstNumber[i]} / {secondNumber[i]} = {history[i]} {game[i]} ");
                        }

                    }
   
                }
            }
        }
    }

}