using Godot;
using System;
using Random;

public class Deck_Manager : Node
{
	private int[] contents;
	private Random rand = new Random();

	//TODO - add Signals that can indicate to the AI class that something's been added to or removed from the deck 

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		contents = new int[9];
		contents[0] = 14;
		for(int i = 1; i < 9; i++){
			contents[i] = 12;
		}
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	public int draw(){ //draws one card from the deck. Returns -1 if the deck is empty.
		int color = rand.next(0, 9);
		
		int counter = 0;
		while(counter < 9){
			if(contents[(color+counter)%9] > 0){
				contents[(color+counter)%9]--;
				return (color+counter)%9;
			}
			counter++;
		}
		
		return -1;
	}
	
	public void add(int num_cards, int color){
		contents[color] += num_cards;
	}
}
