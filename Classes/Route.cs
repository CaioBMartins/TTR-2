using Godot;
using System;

public class Route : Node
{
	public string city1 { get; set; }
	public string city2 { get; set; }
	public int color { get; set; }
	public int length { get; set; }
	public bool isOccupied { get; set; }
	
	public int pointValue
	{
		get
		{
			switch(length)
			{
				case 1; return 1;
				case 2; return 2;
				case 3; return 4;
				case 4; return 7;
				case 5; return 10;
				case 6; return 15;
				default; return 1;
			}
		}
	}
	
	public Route(string origin, string destination, int hue, int leng)
	{
		city1 = origin;
		city2 = destination;
		color = hue;
		length = leng;
	}
}
