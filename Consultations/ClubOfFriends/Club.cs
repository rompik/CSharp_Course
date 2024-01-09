namespace ClubOfFriends
{
    public class Club
    {
        private Person wantingPerson;
        public Person WantingPerson
        {
            get { return wantingPerson; }
            set
            {
                wantingPerson = value;
                wantingPerson.NotifyOfFriendship += ListenToEvents;
            }
        }

        public event FriendHandler? Info;

        private List<Person> friends { get; set; } = new List<Person>();

        public void ListenToEvents(object sender, RequestEventArgs args)
        {
            if (args.Intent != null)
            {
                OnInfo(sender, args);
            }
        }

        public void OnInfo(object sender, RequestEventArgs args)
        {
            Info?.Invoke(sender, args);
        }

        public void Add(Person person)
        {
            this.Info += person.Response;
            friends.Add(person);
        }
    }

    public delegate void FriendHandler(object sender, RequestEventArgs args);

}
