namespace MovieApp.Models.DTO
{
    public class AddToCartDTO
    {
        public Guid SelectedTicketId { get; set; }
        public double? SelectedTicketPrice { get; set; }
        public int Quantity { get; set; }
    }
}
