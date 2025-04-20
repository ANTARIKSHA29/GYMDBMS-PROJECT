using GYMDBMS.Models;
using System.Collections.Generic;

namespace SkyhawkFitnessClub.ViewModels
{
    public class SearchViewModel
    {
        public string? SearchTerm { get; set; } // Make the property nullable by adding '?'

        public List<Trainer>? TrainerResults { get; set; } // Make the property nullable by adding '?'

        public List<Exercise>? ExerciseResults { get; set; } // Make the property nullable by adding '?'

        public List<Food>? FoodResults { get; set; } // Make the property nullable by adding '?'

        public List<NutritionPlan>? NutritionPlanResults { get; set; } // Make the property nullable by adding '?'

        public List<Workout>? WorkoutResults { get; set; } // Make the property nullable by adding '?'

        // Constructor to initialize properties
        public SearchViewModel()
        {
            SearchTerm = "";
            TrainerResults = new List<Trainer>();
            ExerciseResults = new List<Exercise>();
            FoodResults = new List<Food>();
            NutritionPlanResults = new List<NutritionPlan>();
            WorkoutResults = new List<Workout>();
        }
    }
}
