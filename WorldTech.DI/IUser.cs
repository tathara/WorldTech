namespace WorldTech.DI
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string CartJson { get; set; }
        ICart Cart { get; set; }
        List<(string, int, int)> CartData { get; set; }
    }
}
