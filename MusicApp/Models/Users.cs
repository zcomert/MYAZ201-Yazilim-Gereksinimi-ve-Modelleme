public class Users
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public List<Musics> LikedMusics { get; set; }
    public Users()
    {
        LikedMusics = new List<Musics>();
    }

    public Users(int ıd, string name, string email, string password)
    : this()
    {
        Id = ıd;
        Name = name;
        Email = email;
        Password = password;
    }
}