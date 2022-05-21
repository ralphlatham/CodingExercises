using NUnit.Framework;
using System.Linq;

namespace ChristmasLights.Kata
{
    public class Tests
    {
        ChristmasLights christmasLights;

        [SetUp]
        public void Setup()
        {
            christmasLights = new ChristmasLights();
        }

        [Test]
        public void TestTurnOnAllLights()
        {
            christmasLights.TurnOnLights(0, 0, 999, 999);

            Assert.True(christmasLights.LightBulbGrid().Count(m => m.isTurnedOn == true) == 1000000);
        }

        [Test]
        public void TestTurnOnFirstRow()
        {
            christmasLights.TurnOnLights(0, 0, 0, 999);

            Assert.True(christmasLights.LightBulbGrid().Count(m => m.xCoordinate == 0 && m.isTurnedOn == true) == 1000
                        && christmasLights.LightBulbGrid().Count(m => m.xCoordinate > 0 && m.isTurnedOn == true) == 0);
        }

        [Test]
        public void TestTurnOnMiddleFour()
        {
            christmasLights.TurnOnLights(499, 499, 500, 500);

            Assert.True(christmasLights.LightBulbGrid().Count(m => m.isTurnedOn == true) == 4);
        }

        [TestCase(0, 0, 0, 1)]
        [TestCase(2, 2, 4, 4)]
        [TestCase(887, 9, 959, 629)]
        [TestCase(454, 398, 844, 448)]
        [TestCase(539, 243, 559, 965)]
        [TestCase(370, 819, 676, 868)]
        [TestCase(145, 40, 370, 997)]
        [TestCase(301, 3, 808, 453)]
        [TestCase(351, 678, 951, 908)]
        [TestCase(720, 196, 897, 994)]
        [TestCase(831, 394, 904, 860)]
        public void TestTurnOnCombinations(int xTop, int yTop, int xBottom, int yBottom)
        {
            christmasLights.TurnOnLights(xTop, yTop, xBottom, yBottom);

            Assert.True(!christmasLights.LightBulbGrid().Any(m => m.xCoordinate >= xTop && m.xCoordinate <= xBottom && m.yCoordinate >= yTop && m.yCoordinate <= yBottom && m.isTurnedOn == false)
                        && !christmasLights.LightBulbGrid().Any(m => m.xCoordinate < xTop && m.xCoordinate > xBottom && m.yCoordinate < yTop && m.yCoordinate > yBottom && m.isTurnedOn == true));
        }
    }

    public class ChristmasLights
    {
        private LightBulb[] _lightBulbGrid = new LightBulb[1000000];
        private int _lightBulbNumber = 0;

        public void TurnOnLights(int xTop, int yTop, int xBottom, int yBottom)
        {
            for (int x = 0; x <= 999; x++)
            {
                _lightBulbGrid[_lightBulbNumber] = new LightBulb();

                _lightBulbGrid[_lightBulbNumber].xCoordinate = x;

                for (int y = 0; y <= 999; y++)
                {
                    _lightBulbGrid[_lightBulbNumber].yCoordinate = y;

                    if (x >= xTop && y <= yBottom && x <= xBottom && y >= yTop)
                    {
                        _lightBulbGrid[_lightBulbNumber].isTurnedOn = true;
                    }

                    _lightBulbNumber++;

                    if (_lightBulbNumber <= 999999)
                    {
                        _lightBulbGrid[_lightBulbNumber] = new LightBulb();
                        _lightBulbGrid[_lightBulbNumber].xCoordinate = x;
                    }
                }
            }
        }

        public LightBulb[] LightBulbGrid()
        {
            return _lightBulbGrid;
        }
    }

    public class LightBulb
    {
        public int xCoordinate { get; set; }

        public int yCoordinate { get; set; }

        public bool isTurnedOn { get; set; }
    }
}