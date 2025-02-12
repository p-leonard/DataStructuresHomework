// Written By: Patrick Leonard
// 2/2/25

namespace Page_75___Repairing_The_Clocktower; 

public static class Clocktower
{
	// This object is stateless. I can't even think of something to store in here to justify
	// creating backing fields, accessors/mutators, etc etc.

	// Methods
	public static string TickOrTock(int num)
	{
		return num % 2 == 0 ? "Tick" : "Tock";
	}
}
