using System;
using Microsoft.SmallBasic.Library;

namespace turtle_game
{
	class Program
	{
		public static void Main(string[] args)
		{
			
/*			UPSTAIRS
			for(int i = 0; i < 10; i++)
			{
				Turtle.TurnLeft();
				Turtle.Move(20);
				Turtle.TurnRight();
				Turtle.Move(20);
			}
*/

/*			DOWNSTAIRS
			Turtle.TurnRight();
			for(int i = 0; i < 10; i++)
			{
				Turtle.TurnRight();
				Turtle.Move(20);
				Turtle.TurnLeft();
				Turtle.Move(20);
			}
*/		

/* REGULAR POLYGON (N = 17)
			short N = 17;
			for(int i = 0; i < N; i++)
			{
				Turtle.Move(30);
				Turtle.Turn(360/N);
			}
*/			
		}
	}
}