using NUnit.Framework;
using System.Text;

namespace RomanNumerals.Kata
{
    public class Tests
    {
        RomanNumeralConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new RomanNumeralConverter();
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(21, "XXI")]
        [TestCase(22, "XXII")]
        [TestCase(23, "XXIII")]
        [TestCase(24, "XXIV")]
        [TestCase(25, "XXV")]
        [TestCase(26, "XXVI")]
        [TestCase(27, "XXVII")]
        [TestCase(28, "XXVIII")]
        [TestCase(29, "XXIX")]
        [TestCase(30, "XXX")]
        [TestCase(31, "XXXI")]
        [TestCase(32, "XXXII")]
        [TestCase(33, "XXXIII")]
        [TestCase(34, "XXXIV")]
        [TestCase(35, "XXXV")]
        [TestCase(36, "XXXVI")]
        [TestCase(37, "XXXVII")]
        [TestCase(38, "XXXVIII")]
        [TestCase(39, "XXXIX")]
        [TestCase(40, "XL")]
        [TestCase(41, "XLI")]
        [TestCase(42, "XLII")]
        [TestCase(43, "XLIII")]
        [TestCase(44, "XLIV")]
        [TestCase(45, "XLV")]
        [TestCase(46, "XLVI")]
        [TestCase(47, "XLVII")]
        [TestCase(48, "XLVIII")]
        [TestCase(49, "XLIX")]
        [TestCase(50, "L")]
        [TestCase(51, "LI")]
        [TestCase(52, "LII")]
        [TestCase(53, "LIII")]
        [TestCase(54, "LIV")]
        [TestCase(55, "LV")]
        [TestCase(56, "LVI")]
        [TestCase(57, "LVII")]
        [TestCase(58, "LVIII")]
        [TestCase(59, "LIX")]
        [TestCase(60, "LX")]
        [TestCase(61, "LXI")]
        [TestCase(62, "LXII")]
        [TestCase(63, "LXIII")]
        [TestCase(64, "LXIV")]
        [TestCase(65, "LXV")]
        [TestCase(66, "LXVI")]
        [TestCase(67, "LXVII")]
        [TestCase(68, "LXVIII")]
        [TestCase(69, "LXIX")]
        [TestCase(70, "LXX")]
        [TestCase(71, "LXXI")]
        [TestCase(72, "LXXII")]
        [TestCase(73, "LXXIII")]
        [TestCase(74, "LXXIV")]
        [TestCase(75, "LXXV")]
        [TestCase(76, "LXXVI")]
        [TestCase(77, "LXXVII")]
        [TestCase(78, "LXXVIII")]
        [TestCase(79, "LXXIX")]
        [TestCase(80, "LXXX")]
        [TestCase(81, "LXXXI")]
        [TestCase(82, "LXXXII")]
        [TestCase(83, "LXXXIII")]
        [TestCase(84, "LXXXIV")]
        [TestCase(85, "LXXXV")]
        [TestCase(86, "LXXXVI")]
        [TestCase(87, "LXXXVII")]
        [TestCase(88, "LXXXVIII")]
        [TestCase(89, "LXXXIX")]
        [TestCase(90, "XC")]
        [TestCase(91, "XCI")]
        [TestCase(92, "XCII")]
        [TestCase(93, "XCIII")]
        [TestCase(94, "XCIV")]
        [TestCase(95, "XCV")]
        [TestCase(96, "XCVI")]
        [TestCase(97, "XCVII")]
        [TestCase(98, "XCVIII")]
        [TestCase(99, "XCIX")]
        [TestCase(100, "C")]
        [TestCase(101, "CI")]
        [TestCase(102, "CII")]
        [TestCase(103, "CIII")]
        [TestCase(104, "CIV")]
        [TestCase(105, "CV")]
        [TestCase(106, "CVI")]
        [TestCase(107, "CVII")]
        [TestCase(108, "CVIII")]
        [TestCase(109, "CIX")]
        [TestCase(110, "CX")]
        [TestCase(111, "CXI")]
        [TestCase(112, "CXII")]
        [TestCase(113, "CXIII")]
        [TestCase(114, "CXIV")]
        [TestCase(115, "CXV")]
        [TestCase(116, "CXVI")]
        [TestCase(117, "CXVII")]
        [TestCase(118, "CXVIII")]
        [TestCase(119, "CXIX")]
        [TestCase(120, "CXX")]
        [TestCase(121, "CXXI")]
        [TestCase(122, "CXXII")]
        [TestCase(123, "CXXIII")]
        [TestCase(124, "CXXIV")]
        [TestCase(125, "CXXV")]
        [TestCase(126, "CXXVI")]
        [TestCase(127, "CXXVII")]
        [TestCase(128, "CXXVIII")]
        [TestCase(129, "CXXIX")]
        [TestCase(130, "CXXX")]
        [TestCase(131, "CXXXI")]
        [TestCase(132, "CXXXII")]
        [TestCase(133, "CXXXIII")]
        [TestCase(134, "CXXXIV")]
        [TestCase(135, "CXXXV")]
        [TestCase(136, "CXXXVI")]
        [TestCase(137, "CXXXVII")]
        [TestCase(138, "CXXXVIII")]
        [TestCase(139, "CXXXIX")]
        [TestCase(140, "CXL")]
        [TestCase(141, "CXLI")]
        [TestCase(142, "CXLII")]
        [TestCase(143, "CXLIII")]
        [TestCase(144, "CXLIV")]
        [TestCase(145, "CXLV")]
        [TestCase(146, "CXLVI")]
        [TestCase(147, "CXLVII")]
        [TestCase(148, "CXLVIII")]
        [TestCase(149, "CXLIX")]
        [TestCase(150, "CL")]
        [TestCase(151, "CLI")]
        [TestCase(152, "CLII")]
        [TestCase(153, "CLIII")]
        [TestCase(154, "CLIV")]
        [TestCase(155, "CLV")]
        [TestCase(156, "CLVI")]
        [TestCase(157, "CLVII")]
        [TestCase(158, "CLVIII")]
        [TestCase(159, "CLIX")]
        [TestCase(160, "CLX")]
        [TestCase(161, "CLXI")]
        [TestCase(162, "CLXII")]
        [TestCase(163, "CLXIII")]
        [TestCase(164, "CLXIV")]
        [TestCase(165, "CLXV")]
        [TestCase(166, "CLXVI")]
        [TestCase(167, "CLXVII")]
        [TestCase(168, "CLXVIII")]
        [TestCase(169, "CLXIX")]
        [TestCase(170, "CLXX")]
        [TestCase(171, "CLXXI")]
        [TestCase(172, "CLXXII")]
        [TestCase(173, "CLXXIII")]
        [TestCase(174, "CLXXIV")]
        [TestCase(175, "CLXXV")]
        [TestCase(176, "CLXXVI")]
        [TestCase(177, "CLXXVII")]
        [TestCase(178, "CLXXVIII")]
        [TestCase(179, "CLXXIX")]
        [TestCase(180, "CLXXX")]
        [TestCase(181, "CLXXXI")]
        [TestCase(182, "CLXXXII")]
        [TestCase(183, "CLXXXIII")]
        [TestCase(184, "CLXXXIV")]
        [TestCase(185, "CLXXXV")]
        [TestCase(186, "CLXXXVI")]
        [TestCase(187, "CLXXXVII")]
        [TestCase(188, "CLXXXVIII")]
        [TestCase(189, "CLXXXIX")]
        [TestCase(190, "CXC")]
        [TestCase(191, "CXCI")]
        [TestCase(192, "CXCII")]
        [TestCase(193, "CXCIII")]
        [TestCase(194, "CXCIV")]
        [TestCase(195, "CXCV")]
        [TestCase(196, "CXCVI")]
        [TestCase(197, "CXCVII")]
        [TestCase(198, "CXCVIII")]
        [TestCase(199, "CXCIX")]
        [TestCase(200, "CC")]
        [TestCase(236, "CCXXXVI")]
        [TestCase(379, "CCCLXXIX")]
        [TestCase(423, "CDXXIII")]
        [TestCase(577, "DLXXVII")]
        [TestCase(666, "DCLXVI")]
        [TestCase(754, "DCCLIV")]
        [TestCase(889, "DCCCLXXXIX")]
        [TestCase(999, "CMXCIX")]
        public void TestRoman_Numerals(int numberToConvert, string expectedRomanNumeral)
        {
            var romanNumeralResult = converter.Convert(numberToConvert);

            Assert.That(romanNumeralResult, Is.Not.Null);
            Assert.That(romanNumeralResult, Is.EqualTo(expectedRomanNumeral));
        }
    }

    public class RomanNumeralConverter
    {
        public string Convert(int numberToConvert)
        {
            StringBuilder romanNumeralBuilder = new StringBuilder();
            string[] numerals;

            if (numberToConvert >= 100 && numberToConvert <= 1000)
            {
                numerals = new string[] { "C", "CD", "D", "CM" };
                numberToConvert = ConvertMultipleDigitsToNumeral(numberToConvert, 100, numerals, romanNumeralBuilder);
            }

            if (numberToConvert >= 10 && numberToConvert < 100)
            {
                numerals = new string[] { "X", "XL", "L", "XC" };
                numberToConvert = ConvertMultipleDigitsToNumeral(numberToConvert, 10, numerals, romanNumeralBuilder);
            }

            if (numberToConvert != 0)
            {
                numerals = new string[] { "I", "IV", "V", "IX" };
                ConvertSingleDigitsToNumeral(numberToConvert, numerals, romanNumeralBuilder);
            }

            return romanNumeralBuilder.ToString();
        }

        public int ConvertMultipleDigitsToNumeral(int numberToConvert, int divider, string[] numerals, StringBuilder romanNumeralBuilder)
        {
            int firstDigit = numberToConvert / divider;
            int remainingDigits = numberToConvert % divider;

            ConvertSingleDigitsToNumeral(firstDigit, numerals, romanNumeralBuilder);

            return remainingDigits;
        }

        public void ConvertSingleDigitsToNumeral(int firstDigit, string[] numerals, StringBuilder romanNumeralBuilder)
        {
            switch (firstDigit)
            {
                case 1:
                case 2:
                case 3:
                    AddNumeral(0, firstDigit, numerals[0], romanNumeralBuilder);
                    break;
                case 4:
                    romanNumeralBuilder.Append(numerals[1]);
                    break;
                case 5:
                    romanNumeralBuilder.Append(numerals[2]);
                    break;
                case 6:
                case 7:
                case 8:
                    romanNumeralBuilder.Append(numerals[2]);
                    AddNumeral(5, firstDigit, numerals[0], romanNumeralBuilder);
                    break;
                case 9:
                    romanNumeralBuilder.Append(numerals[3]);
                    break;
            }
        }

        public void AddNumeral(int startNumber, int firstDigit, string numeral, StringBuilder romanNumeralBuilder)
        {
            for (int i = startNumber; i < firstDigit; i++)
            {
                romanNumeralBuilder.Append(numeral);
            }
        }
    }
}