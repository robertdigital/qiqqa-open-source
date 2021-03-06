﻿using System.Collections.Generic;

#if TEST
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QiqqaTestHelpers;
using static QiqqaTestHelpers.MiscTestHelpers;
using Utilities;

using Utilities.BibTex.Parsing;
#endif


#if !TEST

namespace Utilities.BibTex.Parsing
{
    /// <summary>
    /// Use this class to translate between the weird bibtex control codes to ASCII.
    /// The test harness suggests that this is quick (1.5M a second), so add as many translation lookups as you like...
    /// </summary>
    public class BibTexCharacterMap
    {
        private static readonly string[] MAP = new string[]
        {
            // Conversion of double-backslash `\\` back to `\` must, by necessity of not
            // causing corruption of the conversion process due to collision with other
            // backslash-escapes, happen as two-stage process, where we FIRST convert
            // double-backslash to a 'magic' Unicode NON-CHARACTER sequence and then,
            // when we've reached the end of the process, pick up from there and perform
            // the second step.
            //
            // Since the forward conversion of 'literal' backslash to double backslash
            // doesn't suffer from the same collision risk, you'll note that the
            // forward and reverse conversion routines further below are coded ever so slightly
            // different. <evil_grin />
             @"\", @"\\",

             "Ċ", @"\.C",
             "ċ", @"\.c",
             "Ė", @"\.E",
             "ė", @"\.e",
             "Ġ", @"\.G",
             "ġ", @"\.g",
             "İ", @"\.I",
             "Ż", @"\.Z",
             "ż", @"\.z",

             "Á", @"\'A",
             "á", @"\'a",
             "Ć", @"\'C",
             "ć", @"\'c",
             "É", @"\'E",
             "é", @"\'e",
             "ǵ", @"\'g",
             "Ή", @"\'H",
             "Í", @"\'I",
             "í", @"\'i",
             "Ĺ", @"\'L",
             "ĺ", @"\'l",
             "Ń", @"\'N",
             "ń", @"\'n",
             "Ó", @"\'O",
             "ό", @"\'o",
             "Ŕ", @"\'R",
             "ŕ", @"\'r",
             "Ś", @"\'S",
             "ś", @"\'s",
             "Ź", @"\'Z",
             "ź", @"\'z",
             "Ú", @"\'U",
             "ú", @"\'u",
             "Ý", @"\'Y",
             "ý", @"\'y",

             "ŉ", @"\'n",

             "ï", @"\""i",
             "Ä", @"\""A",
             "ä", @"\""a",
             "Ë", @"\""E",
             "ë", @"\""e",
             "Ï", @"\""I",
             "Ö", @"\""O",
             "ö", @"\""o",
             "Ü", @"\""U",
             "ü", @"\""u",
             "ÿ", @"\""y",
             "Ÿ", @"\""Y",

             "ì", @"\`i",
             "À", @"\`A",
             "à", @"\`a",
             "È", @"\`E",
             "è", @"\`e",
             "Ì", @"\`I",
             "Ò", @"\`O",
             "ò", @"\`o",
             "Ù", @"\`U",
             "ù", @"\`u",

             "Â", @"\^A",
             "â", @"\^a",
             "Ĉ", @"\^C",
             "ĉ", @"\^c",
             "Ê", @"\^E",
             "ê", @"\^e",
             "Ĝ", @"\^G",
             "ĝ", @"\^g",
             "Ĥ", @"\^H",
             "ĥ", @"\^h",
             "Î", @"\^I",
             "î", @"\^i",
             "Ĵ", @"\^J",
             "ĵ", @"\^j",
             "Ô", @"\^O",
             "ô", @"\^o",
             "Ŝ", @"\^S",
             "ŝ", @"\^s",
             "Û", @"\^U",
             "û", @"\^u",
             "Ŵ", @"\^W",
             "ŵ", @"\^w",
             "Ŷ", @"\^Y",
             "ŷ", @"\^y",

             "Č", @"\vC",
             "č", @"\vc",
             "Ď", @"\vD",
             "ď", @"\vd",
             "Ě", @"\vE",
             "ě", @"\ve",
             "Ľ", @"\vL",
             "ľ", @"\vl",
             "Ň", @"\vN",
             "ň", @"\vn",
             "Ř", @"\vR",
             "ř", @"\vr",
             "Š", @"\vS",
             "š", @"\vs",
             "Ž", @"\vZ",
             "ž", @"\vz",
             "Ť", @"\vT",
             "ť", @"\vt",

             "Ā", @"\=A",
             "ā", @"\=a",
             "Ē", @"\=E",
             "ē", @"\=e",
             "Ī", @"\=I",
             "ī", @"\=i",
             "Ō", @"\=O",
             "ō", @"\=o",
             "Ū", @"\=U",
             "ū", @"\=u",

             "Ã", @"\~A",
             "ã", @"\~a",
             "Ĩ", @"\~I",
             "ĩ", @"\~i",
             "Ñ", @"\~N",
             "ñ", @"\~n",
             "Õ", @"\~O",
             "õ", @"\~o",
             "Ũ", @"\~U",
             "ũ", @"\~u",

             "Ő", @"\HO",
             "ő", @"\Ho",
             "Ű", @"\HU",
             "ű", @"\Hu",

             "Ă", @"\uA",
             "ă", @"\ua",
             "Ĕ", @"\uE",
             "ĕ", @"\ue",
             "Ğ", @"\uG",
             "ğ", @"\ug",
             "Ĭ", @"\uI",
             "ĭ", @"\ui",
             "Ŏ", @"\uO",
             "ŏ", @"\uo",
             "Ŭ", @"\uU",
             "ŭ", @"\uu",

             "Ç", @"\cC",
             "ç", @"\cc",
             "Ģ", @"\cG",
             "ģ", @"\cg",
             "Ķ", @"\cK",
             "ķ", @"\ck",
             "Ļ", @"\cL",
             "ļ", @"\cl",
             "Ņ", @"\cN",
             "ņ", @"\cn",
             "Ŗ", @"\cR",
             "ŗ", @"\cr",
             "Ş", @"\cS",
             "ş", @"\cs",
             "Ţ", @"\cT",
             "ţ", @"\ct",

             "Ą", @"\kA",
             "ą", @"\ka",
             "Ę", @"\kE",
             "ę", @"\ke",
             "Į", @"\kI",
             "į", @"\ki",
             "Ų", @"\kU",
             "ų", @"\ku",

             "Å", @"\AA",
             "å", @"\aa",
             "Æ", @"\AE",
             "æ", @"\ae",
             "Œ", @"\OE",
             "œ", @"\oe",
             "Ŋ", @"\NG",
             "ŋ", @"\ng",
             "Ł", @"\L",
             "ł", @"\l",
             "Ø", @"\O",
             "ø", @"\o",
             "Ů", @"\rU",
             "ů", @"\ru",
             "ß", @"\ss",
             "Ð", @"\DH",
             "ð", @"\dh",
             "Þ", @"\TH",
             "þ", @"\th",

             "Α", @"\upAlpha",
             "α", @"\upalpha",
             "Β", @"\upBeta",
             "Χ", @"\upChi",
             "Δ", @"\upDelta",
             "δ", @"\updelta",
             "Ϝ", @"\upDigamma",
             "ϝ", @"\updigamma",
             "Ε", @"\upEpsilon",
             "ϵ", @"\upepsilon",
             "Η", @"\upEta",
             "η", @"\upeta",
             "Γ", @"\upGamma",
             "γ", @"\upgamma",
             "Ι", @"\upIota",
             "ι", @"\upiota",
             "Κ", @"\upKappa",
             "κ", @"\upkappa",
             "Ϟ", @"\upKoppa",
             "ϟ", @"\upkoppa",
             "Λ", @"\upLambda",
             "Μ", @"\upMu",
             "μ", @"\upmu",
             "Ν", @"\upNu",
             "ν", @"\upnu",
             "Ϙ", @"\upoldKoppa",
             "ϙ", @"\upoldkoppa",
             "Ω", @"\upOmega",
             "Ο", @"\upOmicron",
             "ο", @"\upomicron",
             "Φ", @"\upPhi",
             "ϕ", @"\upphi",
             "Π", @"\upPi",
             "π", @"\uppi",
             "Ψ", @"\upPsi",
             "ψ", @"\uppsi",
             "Ρ", @"\upRho",
             "ρ", @"\uprho",
             "Ϡ", @"\upSampi",
             "ϡ", @"\upsampi",
             "Σ", @"\upSigma",
             "σ", @"\upsigma",
             "Ϛ", @"\upStigma",
             "ϛ", @"\upstigma",
             "Ζ", @"\upZeta",
             "ζ", @"\upzeta",
             "Τ", @"\upTau",
             "τ", @"\uptau",
             "Θ", @"\upTheta",
             "Υ", @"\upUpsilon",
             "υ", @"\upupsilon",
             "Ξ", @"\upXi",
             "ξ", @"\upxi",
        };

        // re performance: https://stackoverflow.com/questions/301371/why-is-dictionary-preferred-over-hashtable-in-c
        private static readonly Dictionary<string, string> MAP_U2T = new Dictionary<string, string>(/* MAP */);
        private static readonly Dictionary<string, string> MAP_T2U = new Dictionary<string, string>(/* MAP */);
        private static readonly int Size = MAP.Length;

        static BibTexCharacterMap()
        {
            for (int i = 0; i < MAP.Length; i += 2)
            {
                MAP_U2T.Add(MAP[i], MAP[i + 1]);
                MAP_T2U.Add(MAP[i], MAP[i + 1]);
            }
        }

        public static string BibTexToASCII(string source)
        {
            if (null == source)
            {
                return source;
            }

            // Get rid of any curlies
            source = source.Replace("{", "");
            source = source.Replace("}", "");

            // Check if there are any escape characters
            if (source.IndexOf('\\') >= 0)
            {
                // Guard for the DOUBLE \\
                const string BACKSLASH_GUARD = "\uFDD0\uFDD1"; // http://www.unicode.org/faq/private_use.html#nonchar3 and onwards
                source = source.Replace(@"\\", BACKSLASH_GUARD);

                // Do the million substitutions; skip the double-backslash conversion entry as that one's useless now
                int len = MAP.Length;
                for (int i = 2; i < len; i += 2)
                {
                    source = source.Replace(MAP[i + 1], MAP[i]);
                }

                source = source.Replace(BACKSLASH_GUARD, @"\");
            }

            return source;
        }

        public static string ASCIIToBibTex(string source)
        {
            if (null == source)
            {
                return source;
            }

            // Do the million substitutions
            int len = MAP.Length;
            for (int i = 0; i < len; i += 2)
            {
                source = source.Replace(MAP[i], MAP[i + 1]);
            }

            return source;
        }
    }
}

#else

#region --- Test ------------------------------------------------------------------------

namespace QiqqaUnitTester
{
    [TestClass]
    public class BibTexCharacterMapTester
    {
        // see also http://diacritics.typo.cz/index.php?id=1

        [DataRow("fixtures/TeXcharmap/test-0001.txt")]
        [DataRow("fixtures/TeXcharmap/test-0002.txt")]
        [DataTestMethod]
        public void Test_Conversion_To_BibTeX_Text(string filepath)
        {
            string path = GetNormalizedPathToAnyTestDataTestFile(filepath);
            ASSERT.FileExists(path);

            string data_in = GetTestFileContent(path);
            string s1 = data_in;
            string s2 = BibTexCharacterMap.ASCIIToBibTex(s1);

            ApprovalTests.Approvals.Verify(
                new QiqqaApprover(s2, filepath),
                ApprovalTests.Approvals.GetReporter()
            );
        }

        [DataRow("fixtures/TeXcharmap/test-0001.txt")]
        [DataRow("fixtures/TeXcharmap/test-0002.txt")]
        [DataTestMethod]
        public void Test_Conversion_To_And_From_BibTeX_Text(string filepath)
        {
            string path = GetNormalizedPathToAnyTestDataTestFile(filepath);
            ASSERT.FileExists(path);

            string data_in = GetTestFileContent(path);
            string s1 = data_in;
            string s2 = BibTexCharacterMap.ASCIIToBibTex(s1);
            string s3 = BibTexCharacterMap.BibTexToASCII(s2);

            //ASSERT.AreEqual(s1, s3);
            ApprovalTests.Approvals.Verify(
                new QiqqaApprover(s3, filepath),
                ApprovalTests.Approvals.GetReporter()
            );
        }

        [DataRow("fixtures/TeXcharmap/test-0001.txt")]
        [DataTestMethod]
        public void Test_SPEED(string filepath)
        {
            string path = GetNormalizedPathToAnyTestDataTestFile(filepath);
            ASSERT.FileExists(path);

            string data_in = GetTestFileContent(path);
            string s1 = data_in;
            string s2 = BibTexCharacterMap.ASCIIToBibTex(s1);
            string s3 = BibTexCharacterMap.BibTexToASCII(s2);

            const int NUM = 1000000;
            const int CHUNK = 10000;
            Stopwatch start = Stopwatch.StartNew();
            int i;

            for (i = 0; i < NUM; ++i)
            {
                if (i % CHUNK == CHUNK - 1)
                {
                    // don't run for more than 2 seconds
                    if (start.ElapsedMilliseconds >= 2000)
                    {
                        break;
                    }
                }
                s2 = BibTexCharacterMap.ASCIIToBibTex(s1);
            }
            double time_a2b = i * 1.0E-3 * s1.Length / start.ElapsedMilliseconds;
            Logging.Info("ASCIIToBibTex can do {0:0.000}M operations per second per character", time_a2b);

            start = Stopwatch.StartNew();
            for (i = 0; i < NUM; ++i)
            {
                if (i % CHUNK == CHUNK - 1)
                {
                    // don't run for more than 2 seconds
                    if (start.ElapsedMilliseconds >= 2000)
                    {
                        break;
                    }
                }
                s3 = BibTexCharacterMap.BibTexToASCII(s2);
            }
            double time_b2a = i * 1.0E-3 * s1.Length / start.ElapsedMilliseconds;
            Logging.Info("BibTexToASCII can do {0:0.000}M operations per second per character", time_b2a);

            // dummy
            BibTexCharacterMap.ASCIIToBibTex(s3);
        }
    }
}

#endregion

#endif
