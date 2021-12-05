// DI, Serilog, Settings

namespace GobiMax
{
    public interface IPlayerCharacter
    {
        string Faction { get; set; }
        string Name { get; set; }
        string Profession { get; set; }
    }
}