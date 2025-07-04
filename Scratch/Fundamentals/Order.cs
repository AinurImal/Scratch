namespace Scratch.Fundamentals
{
    public class User
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class Order
    {
        public User PlacedBy { get; set; }
        public bool IsCancelled { get; private set; }

        public bool CanBeCancelledBy(User user) // Admins or the user who placed the order can cancel
        {
            return (user.IsAdmin || user.Id == PlacedBy.Id);     
        }

        public void Cancel(User user)
        {
            if (!CanBeCancelledBy(user))
                throw new InvalidOperationException("User cannot cancel this order.");

            IsCancelled = true;
        }
    }
}