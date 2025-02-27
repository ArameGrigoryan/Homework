using System;

class FlightTicket 
{
	private string _passengerName;
	private int _flightNumber;
	private int _seatNumber;

	public FlightTicket(string PassengerName, int FlightNumber, int SeatNumber)
	{
		_passengerName = PassengerName;
		_flightNumber = FlightNumber;
		_seatNumber = SeatNumber;
	}
	public void AllInfoFlight()
	{
		Console.WriteLine($"Passenger Name: {_passengerName}\nFlight Numbr: {_flightNumber}\nSeat Number: {_seatNumber}");
	}
	public static FlightTicket AddTicket()
	{
		Console.Write("Enter passenger name: ");
		string? name = Console.ReadLine();
		Console.Write("Enter flight number: ");
		int flight = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter seat number: ");
		int seat = Convert.ToInt32(Console.ReadLine());
		return new FlightTicket(name, flight, seat);
	}
}
class Program 
{
	static void Main() 
	{
		FlightTicket[] tickets = new FlightTicket[3];
		for (int i = 0; i < 3; ++i) 
		{
			tickets[i] = FlightTicket.AddTicket();
		}
		for (int i = 0; i < 3; ++i) 
		{
			tickets[i].AllInfoFlight();
		}
	}
}
