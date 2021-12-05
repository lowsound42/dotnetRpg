// DI, Serilog, Settings

namespace GobiMax
{
    public class PlayerCharacter : IPlayerCharacter
    {

        public PlayerCharacter(string name, string profession, string faction)
        {
            Name = name;
            Profession = profession;
            Faction = faction;
        }
        public string Name { get; set; }

        private static int skillPoints;

        private static int GetSkillPoints()
        {
            return skillPoints;
        }

        private static void SetSkillPoints(int value)
        {
            skillPoints = value;
        }

        public string Profession { get; set; }
        public string Faction { get; set; }

    }
}
