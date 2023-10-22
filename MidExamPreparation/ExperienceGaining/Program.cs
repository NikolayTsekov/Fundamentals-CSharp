namespace ExperienceGaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());

            int battleCount = 0;
            double experiencePerBattle = 0;
            for (int i = 0; i < countOfBattles; i++)
            {
                double currentExperiencePerBattle = double.Parse(Console.ReadLine());
                battleCount++;
                if (battleCount % 3 == 0)
                {
                    currentExperiencePerBattle = currentExperiencePerBattle * 1.15;
                }
                else if (battleCount % 5 == 0)
                {
                    currentExperiencePerBattle = currentExperiencePerBattle * 0.9;
                }
                else if (battleCount % 15 == 0)
                {
                    currentExperiencePerBattle = currentExperiencePerBattle * 1.05;
                }

                experiencePerBattle += currentExperiencePerBattle;
                if (experiencePerBattle >= neededExperience)
                {
                    Console.WriteLine(
                        $"Player successfully collected his needed experience for {battleCount} battles.");
                    break;

                }
            }

            if (experiencePerBattle < neededExperience)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience - experiencePerBattle:f2} more needed.");
            }
            
        }
    }
}