using System.Collections.Generic;
using System.Text;

namespace C__Coding_Challenge___Old_Pad_Phone.Services
{
    public class PhonePadController
    {
        private readonly Dictionary<char, string> _keypad;
        private readonly StringBuilder _result;
        private char _lastKey;
        private int _consecutiveCount;

        public PhonePadController()
        {
            _keypad = new Dictionary<char, string>
            {
                {'1', "&'(" },
                {'2', "ABC"}, 
                {'3', "DEF"}, 
                {'4', "GHI"}, 
                {'5', "JKL"},
                {'6', "MNO"}, 
                {'7', "PQRS"}, 
                {'8', "TUV"}, 
                {'9', "WXYZ"},
                {'0', " "}
            };
            _result = new StringBuilder();
            Reset();
        }

        public static string OldPhonePad(string input)
        {
            var phonePad = new PhonePadController();
            return phonePad.ProcessInput(input);
        }

        public string ProcessInput(string input)
        {
            Reset();
            bool messageSent = false;

            foreach (char c in input)
            {
                if (c == '#')
                {
                    messageSent = true;
                    break;
                }
                ProcessCharacter(c);
            }

            CommitLastKey();

            return messageSent ? _result.ToString() : "";
        }

        public void ProcessCharacter(char c)
        {
            switch (c)
            {
                case '*':
                    Backspace();
                    break;
                case ' ':
                    CommitLastKey();
                    break;
                case '0':
                    CommitLastKey();
                    _result.Append(' ');
                    break;
                default:
                    if (c == _lastKey)
                    {
                        _consecutiveCount++;
                    }
                    else
                    {
                        CommitLastKey();
                        _lastKey = c;
                        _consecutiveCount = 1;
                    }
                    break;
            }
        }

        private void CommitLastKey()
        {
            if (_consecutiveCount > 0 && _keypad.ContainsKey(_lastKey))
            {
                string letters = _keypad[_lastKey];
                if (!string.IsNullOrEmpty(letters))
                {
                    _result.Append(letters[(_consecutiveCount - 1) % letters.Length]);
                }
            }
            _lastKey = '\0';
            _consecutiveCount = 0;
        }

        private void Backspace()
        {
            CommitLastKey();
            if (_result.Length > 0)
                _result.Length--;
        }

        private void Reset()
        {
            _result.Clear();
            _lastKey = '\0';
            _consecutiveCount = 0;
        }

        public string GetCurrentText() => _result.ToString();
        public void Clear() => Reset();
    }
}



