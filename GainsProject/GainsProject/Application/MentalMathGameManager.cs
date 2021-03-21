using System;
using GainsProject.Domain;

namespace GainsProject.Application
{
    public class MentalMathGameManager : BaseGame
    {
        public const int WRONG_ANSWER = -50;
        public const int MAX_SCORE = 100;
        public const int MAX_SCORE_TIME = 500;
        public const int ZERO_SCORE_TIME = 4500;
        public const int SCORE_DIVISOR = -39;
        public const int RANDOM_TIME_MAX = 0;
        public const int RANDOM_TIME_MIN = 0;
        public override void runGame()
        {
            throw new NotImplementedException();
        }

        public override void calculateScore()
        {
            long time = this.getTime();
            if (time <= 0)
            {
                setScore(WRONG_ANSWER + getScore());
                return;
            }
            if(time <= MAX_SCORE_TIME)
            {
                setScore(MAX_SCORE + getScore());
                return;
            }
            if (time >= ZERO_SCORE_TIME)
                return;
            long inverse = time - ZERO_SCORE_TIME;
            setScore(inverse / SCORE_DIVISOR);
        }

        public override int randomTime()
        {
            Random rnd = new Random();
            int time = rnd.Next(RANDOM_TIME_MIN, RANDOM_TIME_MAX);
            return time;
        }
    }
}
