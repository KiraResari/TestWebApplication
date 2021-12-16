namespace TestWebApplication.Backend
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
