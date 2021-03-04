using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesEncapsulation
{
    class Dough
    {
        private double whiteFlour = 1.5;
        private double wholegrainFlour = 1.0;
        private double crispy = 0.9;
        private double chewy = 1.1;
        private double homemade = 1.0;


        private string flourType;
        private string bakingTechnique;
        private double weight;


        public string FlourType
        {
            get { return flourType; }
            set
            {
                if (value.ToLower() != "white" || value.ToLower() != "wholegrain")
                {

                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return BakingTechnique; }
            set { BakingTechnique = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public double Calories()
        {
            double result = Weight * 2;


            if (FlourType.ToLower() == "white")
            {
                result *= whiteFlour;
            }
            else if (FlourType.ToLower() == "wholegrain")
            {
                result *= wholegrainFlour;
            }


            if (BakingTechnique.ToLower() == "crispy")
            {
                result *= crispy;
            }
            else if (BakingTechnique.ToLower() == "chewy")
            {
                result *= chewy;
            }
            else if (BakingTechnique.ToLower() == "homemade")
            {
                result *= homemade;
            }

            return result;

        }

    }
}
