using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PigDice {
	class Program {
		Random rnd = new Random();
		int DiceRoll() {
			var Roll = rnd.Next(6)+1;
			// Print($"You rolled {Roll}");
			return Roll;
		}

		void Print(string message) {
			Console.WriteLine(message);
		}
		
		int Game() {
			var Roll = DiceRoll();
			var Total = 0;
			while (Roll != 1) {
				Total = Total + Roll;
				Roll = DiceRoll();
			}
			//Print($"Score: {Total}");
			return Total;
		}

		void Run() {
			bool PlayAgain = true;
			while (PlayAgain == true) {
				var BestTotal = 0;

				var counter = 0;
				while (counter++ < 10000000) {
					var ThisGame = Game();
					//BestTotal = (ThisGame > BestTotal) ? ThisGame : BestTotal;
					if (ThisGame > BestTotal) {
						BestTotal = ThisGame;
					}
				}
				//Console.WriteLine($"Best game score is {BestTotal} in only {counter - 1} rolls.");
				//Console.Write($"Do you want to play again? Y/N : ");
				//var answer = Console.ReadLine();
				//
				if (BestTotal < 500) { // repeats game 10000000 rolls at a time until a total of 500 is achieved
					PlayAgain = true;
				} else {





					Console.WriteLine($"Best game score is {BestTotal} in only {counter - 1} rolls.");
					PlayAgain = false;
				}
			}
		}

		static void Main(string[] args) {
			new Program().Run();
		}
	}
}


