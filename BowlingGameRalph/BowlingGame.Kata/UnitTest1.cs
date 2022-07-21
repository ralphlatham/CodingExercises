using NUnit.Framework;
using System;

namespace BowlingGame.Kata
{
    public class Tests
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void TestPlayerCanScoreZero()
        {
            ThrowMultipleRolls(20, 0);

            Assert.AreEqual(0, _game.Score());
        }

        [Test]
        public void TestPlayerCanScoreOnes()
        {
            ThrowMultipleRolls(20, 1);

            Assert.AreEqual(20, _game.Score());
        }

        [Test]
        public void TestSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(2);
            ThrowMultipleRolls(17, 0);
            Assert.AreEqual(14, _game.Score());
        }

        [Test]
        public void TestStrike()
        {
            _game.Roll(0);
            _game.Roll(10);
            _game.Roll(8);
            _game.Roll(1);
            ThrowMultipleRolls(16, 0);
            Assert.AreEqual(28, _game.Score());
        }

        [Test]
        public void TestLastFrameWithStrike()
        {
            ThrowMultipleRolls(18, 0);
            _game.Roll(10);
            _game.Roll(0);
            _game.Roll(8);
            Assert.AreEqual(18, _game.Score());
        }

        [Test]
        public void TestLastFrameWithSpare()
        {
            ThrowMultipleRolls(18, 0);
            _game.Roll(7);
            _game.Roll(3);
            _game.Roll(8);
            Assert.AreEqual(26, _game.Score());
        }

        private void ThrowMultipleRolls(int totalRolls, int pins)
        {
            for (int i = 1; i <= totalRolls; i++)
            {
                _game.Roll(pins);
            }
        }
    }

    public class Game
    {
        private int rollNumber = 1;
        private int _score = 0;
        private int[] _scores = new int[20];
        private int scoreIndex = 0;
        private bool isSpare = false;
        private bool isStrike = false;
        private bool isBonusRoll = false;

        public void Roll(int pinsKnockedDown)
        {
            bool lastRollInFrame = rollNumber % 2 == 0;
            bool isBonusRoll = rollNumber == 21;

            if (isStrike && lastRollInFrame && !isBonusRoll)
            {
                int bonus = _scores[scoreIndex - 1] + pinsKnockedDown;
                _scores[scoreIndex] += pinsKnockedDown + bonus;
            }
            else if (isSpare)
            {
                _scores[scoreIndex] += pinsKnockedDown * 2;
            }
            else
            {
                _scores[scoreIndex] += pinsKnockedDown;
            }

            if (lastRollInFrame)
            {
                isStrike = _scores[scoreIndex] == 10 || _scores[scoreIndex - 1] == 10;

                isSpare = !isStrike && (_scores[scoreIndex] + _scores[scoreIndex - 1] == 10);
            }

            if (rollNumber == 20 && (isStrike || isSpare))
            {
                Array.Resize(ref _scores, 21);
            }

            rollNumber++;
            scoreIndex++;
        }

        public int Score()
        {
            foreach (int score in _scores)
            {
                _score += score;
            }

            return _score;
        }
    }
}