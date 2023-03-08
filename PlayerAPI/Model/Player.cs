namespace PlayerAPI.Model
{
    public class Player
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string? Nationality { get; set; }
        public List<string> Positions { get; set; } = new List<string>();

        public Player(string name, int age, string nationality, List<string> positions)
        {
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;
            this.Positions = positions;

        }
    }
}
