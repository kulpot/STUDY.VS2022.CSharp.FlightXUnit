namespace Domain
{
    public class Flight
    {

        public int RemainingNumbersOfSeats { get; set; }

        public Flight(int seatCapacity)
        {
            RemainingNumbersOfSeats = seatCapacity;
        }

        public object? Book(string passengerEmail, int numberOfSeats)
        {
            //throw new NotImplementedException();

            if (numberOfSeats > this.RemainingNumbersOfSeats)// logic for Overbooking error 
                return new OverbookingError();

            RemainingNumbersOfSeats -= numberOfSeats;
            return null;
        }
    }
}