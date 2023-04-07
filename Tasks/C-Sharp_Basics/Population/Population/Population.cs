using System;

namespace PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population must be greater than 0.");
            }

            if (visitors < 0)
            {
                throw new ArgumentException("Number of visitors cannot be less than 0.");
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population must be greater than 0.");
            }

            if (currentPopulation < initialPopulation)
            {
                throw new ArgumentException("Current population must be greater than initial population.");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Percentage must be between 0 and 100.");
            }

            int years = 0;
            double population = initialPopulation;

            for (; population < currentPopulation; years++)
            {
                population += (population * percent / 100) + visitors;
            }

            return years;
        }
    }
}
