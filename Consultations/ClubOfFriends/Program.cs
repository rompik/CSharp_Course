namespace ClubOfFriends
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Person1" };
            Person p2 = new Person { Name = "Person2" };
            Person p3 = new Person { Name = "Person3" };
            Person p4 = new Person { Name = "Person4" };

            Club club = new Club();
            club.Add(p1);
            club.Add(p2);
            club.Add(p3);
            club.Add(p4);

            Person p5 = new Person { Name = "Person5" };

            club.WantingPerson = p5;
            p5.OnFriendship(new RequestEventArgs
            {
                Intent = "Хочу дружить и все тут!",
                NameReference = "Person"
            });

            Console.WriteLine(p5.IsClubman);
        }
    }
}
