using System.Collections.Generic;
using System.Linq;

namespace AlgorithmOnIteration
{
    class TeamFormation
    {
        public static int WaysToFormTeam(List<int> skills, int minLevel, int maxLevel, int minPlayers)
        {
            List<int> skillRange = skills.Where(x => x >= minLevel && x <= maxLevel).ToList();
            if (skillRange.Count == minPlayers)
                return CombWays(skillRange.Count, minPlayers);
            else
                return CombWays(skillRange.Count, minPlayers) + 1;
        }
        public static int CombWays(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
