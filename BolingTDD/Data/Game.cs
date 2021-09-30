namespace BowlingTDD.Data
{
    public class Game
    {
        //int score = 0;
        private int[] rolled = new int[22];
        private int currentBall = 0;
        public void Roll(int pins)
        {
            rolled[currentBall] = pins;
            currentBall++;
        }

        public int GetScore()
        {
            int score = 0;
            int thisBall = 0;
            for (int i = 0; i < 10; i++)
            {
                if (IsStrike(thisBall)) //strike
                {
                    score += rolled[thisBall] + rolled[thisBall + 1] + rolled[thisBall + 2];
                    thisBall += 1;
                }
                else if (IsSpare(thisBall)) //sapre
                {
                    score += 10 + rolled[thisBall + 2];
                    thisBall += 2;
                }
                else
                {
                    score += rolled[thisBall] + rolled[thisBall + 1];
                    thisBall += 2;
                }
            }
            return score;
        }

        private bool IsSpare(int thisBall)
        {
            return rolled[thisBall] + rolled[thisBall + 1] == 10;
        }

        private bool IsStrike(int thisBall)
        {
            return rolled[thisBall] == 10;
        }
    }
}
