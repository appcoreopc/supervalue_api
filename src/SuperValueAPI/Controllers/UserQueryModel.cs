namespace SuperValueAPI.Controllers
{
    public class UserOrderQueryModel
    {
        public string UserId { get; set; }

        public string OrderId { get; set; }

        public string OrderDate { get; set; }

        public int QueryIntent { get; set; }
    }
}