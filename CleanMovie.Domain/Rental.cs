namespace CleanMovie.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        //One to Many Relationship with Member
        public ICollection<Member> Members { get; set; }

        //Many to Many Relationship with Movie using fluent 
        public IList<MovieRental> MovieRentals { get; set; }

    }
}