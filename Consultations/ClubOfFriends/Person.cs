namespace ClubOfFriends
{
    public class Person
    {
        Random rnd = new Random();
        public string? Name { get; set; }
        public bool IsClubman { get; set; }

        public event FriendHandler? NotifyOfFriendship;
        public void OnFriendship(RequestEventArgs eventArgs)
        {
            NotifyOfFriendship?.Invoke(this, eventArgs);
        }

        public void Response(object? sender, RequestEventArgs args)
        {
            if (args.NameReference.Equals(Name) && rnd.Next(0, 4) > 0)
            {
                ((Person)sender).IsClubman = true;
            }
        }
    }
}
