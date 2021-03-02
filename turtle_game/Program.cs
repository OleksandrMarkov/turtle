using System;
using Microsoft.SmallBasic.Library;

namespace turtle_game
{
	class Program
	{	
		public class Pretty_turtle
		{	
			public Pretty_turtle(int speed)
			{
				Turtle.Speed = speed;	
			}
			
			public void back_to_start()
			{
				Turtle.X = 200;
				Turtle.Y = 200;
				Turtle.Angle = 0;
			}
			
			public void turtle_goes_upstairs(int step, int step_length)
			{
				back_to_start();
				for(int i = 0; i < step; i++)
				{
					Turtle.TurnLeft();
					Turtle.Move(step_length);
					Turtle.TurnRight();
					Turtle.Move(step_length);
				}
			}
		
			public void turtle_goes_downstairs(int step, int step_length)
			{
				back_to_start();
				Turtle.TurnRight();
				for(int i = 0; i < step; i++)
				{
					Turtle.TurnRight();
					Turtle.Move(step_length);
					Turtle.TurnLeft();
					Turtle.Move(step_length);
				}
			}
		
			public void turtle_climbs_on_a_fence(int step, int step_length)
			{
				back_to_start();
				for(int i = 0; i < step; i++)
				{
					Turtle.Move(step_length);
					Turtle.TurnRight();
					Turtle.Move(step_length);
					Turtle.TurnRight();
					Turtle.Move(step_length);
					Turtle.TurnLeft();
					Turtle.Move(step_length);
					Turtle.TurnLeft();
				}
			}
		
			public void turtle_draws_a_regular_polygon(int side, int side_length)
			{
				back_to_start();
				for(int i = 0; i < side; i++)
				{
					Turtle.Move(side_length);
					Turtle.Turn(360/side);
				}
			}
			
			public void turtle_draws_TEST()
			{
				const int line_length = 25;
				back_to_start();
				
				// 'T'
				Turtle.Move(line_length * 2);
				Turtle.TurnLeft();
				Turtle.Move(line_length);
				Turtle.Turn(180);
				Turtle.Move(line_length * 2);
				
				// 'E'
				Turtle.X = 250;
				Turtle.Y = 200;
				Turtle.Angle = 0;
				Turtle.TurnRight();
				Turtle.Move(line_length);
				Turtle.Turn(180);
				Turtle.Move(line_length);
				Turtle.TurnRight();
				Turtle.Move(line_length);
				Turtle.TurnRight();
				Turtle.Move(line_length);
				Turtle.Turn(180);
				Turtle.Move(line_length);
				Turtle.TurnRight();
				Turtle.Move(line_length);
				Turtle.TurnRight();
				Turtle.Move(line_length);
				
				// 'S'
				Turtle.X = 300;
				Turtle.Y = 200;
				Turtle.Angle = 0;	
				Turtle.TurnRight();
				Turtle.Move(line_length);
				Turtle.TurnLeft();
				Turtle.Move(line_length);
				Turtle.TurnLeft();
				Turtle.Move(line_length);
				Turtle.TurnRight();
				Turtle.Move(line_length);
				Turtle.TurnRight();
				Turtle.Move(line_length);
				
				// 'T'
				Turtle.X = 370;
				Turtle.Y = 200;
				Turtle.Angle = 0;
				Turtle.Move(line_length * 2);
				Turtle.TurnLeft();
				Turtle.Move(line_length);
				Turtle.Turn(180);
				Turtle.Move(line_length * 2);
			}
		}
		
		
		public static void Main(string[] args)
		{
			Pretty_turtle turtle = new Pretty_turtle(9); //Speed 
			
			turtle.turtle_climbs_on_a_fence(5, 15);
			GraphicsWindow.Clear();
			turtle.turtle_draws_a_regular_polygon(7,30);
			GraphicsWindow.Clear();
			turtle.turtle_draws_TEST();
			GraphicsWindow.Clear();
			turtle.turtle_goes_downstairs(5, 20);
			GraphicsWindow.Clear();
			turtle.turtle_goes_upstairs(5, 20);
			GraphicsWindow.Clear();
			
			Environment.Exit(0);
		}
	}
}