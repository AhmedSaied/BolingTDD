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
    }
}
