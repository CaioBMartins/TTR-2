using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Player : Node
{
	public string name { get; set; }
	public PlayerColor color { get; set; }
	public List<Tickets> Tickets { get; set; } = new List<Tickets>();
	public List<Route> PossibleRoutes { get; set; } = new List<Route>();
	public List<City> ConnectedCities { get; set; } = new List<City>();
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
