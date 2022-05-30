using Godot;
using System;
using System.IO;

public class Tickets : Node
{
	public string City1 { get; set; }
	public string City2 { get; set; }
	public int Points { get; set; }
	
	public Tickets(string city1, string city2, int points)
	{
		City1 = city1;
		City2 = city2;
		Points = points;
	}
}
