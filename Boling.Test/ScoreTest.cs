using BowlingTDD.Data;
using Xunit;

namespace Bowling.Test
{
    public class ScoreTest
    {
        private readonly Game game;
        public ScoreTest()
        {
             game = new();
        }

        [Fact]
        public void RollZeroScoreIsZero()
        {
            game.Roll(0);
            Assert.Equal(0, game.GetScore());
        }

        [Fact]
        public void OpenFramAddsPins()
        {
            game.Roll(2);
            game.Roll(4);
            Assert.Equal(6, game.GetScore());
        }

        [Fact]//(Skip = "SpareAddsNextBall")
        public void SpareAddsNextBall()
        {
            game.Roll(6);
            game.Roll(4);
            game.Roll(3);
            game.Roll(0);
            Assert.Equal(16, game.GetScore());
        }

        [Fact]
        public void ATenInTwoFramesIsNotaSpare()
        {
            game.Roll(3);
            game.Roll(6);
            game.Roll(4);
            game.Roll(2);
            Assert.Equal(15, game.GetScore());
        }

        [Fact]
        public void AStrikeAddsNextTwoBalls()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(2);
            Assert.Equal(20, game.GetScore());
        }

        [Fact]
        public void PerfectGameScoreIs300()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Roll(10);
            }
            Assert.Equal(300, game.GetScore());
        }
    }
}
