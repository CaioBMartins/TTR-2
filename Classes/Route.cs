using Godot;
using System;

public class Route : Sprite
{
	public City city1 { get; set; }
	public City city2 { get; set; }
	public int color { get; set; }
	public int length { get; set; }
	public bool isOccupied { get; set; }
	public int offset {get; set; } // offsets the route from the centerline between the two cities if there is more than one route.
	
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
		offset = 0;
		
		place_on_map();
	}
	
	public Route(string origin, string destination, int hue, int leng, int offset)
	{
		city1 = origin;
		city2 = destination;
		color = hue;
		length = leng;
		offset = offset;
		
		place_on_map();
	}
	
	private place_on_map(){
		Vector2 base_pos = .5*(city1.get_position() + city2.get_position());
		Vector2 offset = offset * (city1.get_position() - city2.get_position()).tangent().normalized();
		set_position(base_pos + offset);
	}
}
