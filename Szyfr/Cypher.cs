using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfr
{
    class Cypher
    {
        public static string CaesarsCypher(string text)
        {
            text = text.ToUpper().Replace(" ", "");
            char[] letters = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in text)
            {
                int charValue = (int)c;

                charValue += 3;
                if (charValue > 90)
                {
                    charValue -= 26;
                }
                char result = (char)charValue;
                output += result;
            }
            return output;
        }
        public static string DictionaryCypher(string text)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', 'D');
            dict.Add('B', 'E');
            dict.Add('C', 'F');
            dict.Add('D', 'G');
            dict.Add('E', 'H');
            dict.Add('F', 'I');
            dict.Add('G', 'J');
            dict.Add('H', 'K');
            dict.Add('I', 'L');
            dict.Add('J', 'M');
            dict.Add('K', 'N');
            dict.Add('L', 'O');
            dict.Add('M', 'P');
            dict.Add('N', 'Q');
            dict.Add('O', 'R');
            dict.Add('P', 'S');
            dict.Add('Q', 'T');
            dict.Add('R', 'U');
            dict.Add('S', 'V');
            dict.Add('T', 'W');
            dict.Add('U', 'X');
            dict.Add('V', 'Y');
            dict.Add('W', 'Z');
            dict.Add('X', 'A');
            dict.Add('Y', 'B');
            dict.Add('Z', 'C');
            text = text.ToUpper().Replace(" ", "");
            char[] letters = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in text)
            {
                output += dict[c];
            }
            return output;
        }
        public static string GADERYPOLUKICypher(string text)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', 'G');
            dict.Add('B', 'B');
            dict.Add('C', 'C');
            dict.Add('D', 'E');
            dict.Add('E', 'D');
            dict.Add('F', 'F');
            dict.Add('G', 'A');
            dict.Add('H', 'H');
            dict.Add('I', 'K');
            dict.Add('J', 'J');
            dict.Add('K', 'I');
            dict.Add('L', 'U');
            dict.Add('M', 'M');
            dict.Add('N', 'N');
            dict.Add('O', 'P');
            dict.Add('P', 'O');
            dict.Add('Q', 'Q');
            dict.Add('R', 'Y');
            dict.Add('S', 'S');
            dict.Add('T', 'T');
            dict.Add('U', 'L');
            dict.Add('V', 'V');
            dict.Add('W', 'W');
            dict.Add('X', 'X');
            dict.Add('Y', 'R');
            dict.Add('Z', 'Z');
            text = text.ToUpper().Replace(" ", "");
            char[] letters = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in text)
            {
                output += dict[c];
            }
            return output;

        }
    }
}
