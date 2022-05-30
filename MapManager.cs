using Godot;
using System;
using System.Collections;
using System.IO;

public class MapManager : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	StreamReader City = new StreamReader("res://Cities.txt");
	ArrayList Cities = new ArrayList();
	while((CityLine = City.ReadLine())!=null)
	{
		Cities.Add(CityLine);
	}
	Cities.Close();
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
