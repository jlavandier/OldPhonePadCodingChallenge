using System.Collections.Generic;
using System.Text;

namespace C__Coding_Challenge___Old_Pad_Phone.Services
{
    /// <summary>
    /// Here is an old phone keypad with alphabetical letters, a backspace key, and a send button.
    /// </summary>
    public class PhonePadController
    {
        #region Fields

        private readonly Dictionary<char, string> _keypad;
        private readonly StringBuilder _result;
        private char _lastKey;
        private int _consecutiveCount;
        #endregion

        #region Constructor

        public PhonePadController()
        {
            _keypad = InitializeKeypadMap();
            _result = new StringBuilder();
            ResetState();
        }

        #endregion

        /// <summary>
        /// Processes a full input sequence and returns the composed message.
        /// </summary

        #region Interface

        public static string OldPhonePad(string input)
        {
            var controller = new PhonePadController();
            return controller.ProcessInput(input);
        }

        /// <summary>
        /// Processes input characters one by one, simulating keypad behavior.
        /// </summary>
        /// 

        public string ProcessInput(string input)
        {
            ResetState();
            bool messageConfirmed = false;

            foreach (char c in input)
            {
                if (c == '#')
                {
                    messageConfirmed = true;
                    break;
                }

                HandleCharacter(c);
            }

            CommitCurrentKey();

            return messageConfirmed ? _result.ToString() : string.Empty;
        }

        /// <summary>
        /// Returns the current accumulated text (for debugging or live previews).
        /// </summary>
        public string GetCurrentText() => _result.ToString();

        #endregion

        #region Processing Key Pad Interactions

        private void HandleCharacter(char input)
        {
            switch(input)
            {
                case '*':
                    HandleBackspace(); 
                    break;

                case ' ':
                    CommitCurrentKey(); 
                    break;

                case '0':
                    CommitCurrentKey(); 
                    _result.Append(' '); 
                    break;

                default:
                    HandleNumericKey(input);
                    break;


            }
        }

        private void HandleNumericKey(char key)
        {
            if (key == _lastKey)
            {
                _consecutiveCount++;
            }
            else
            {
                CommitCurrentKey();
                _lastKey = key;
                _consecutiveCount = 1;
            }
        }

        private void HandleBackspace()
        {
            CommitCurrentKey();
            if (_result.Length > 0)
                _result.Length--;
        }

        private void CommitCurrentKey()
        {
            if (_consecutiveCount > 0 && _keypad.TryGetValue(_lastKey, out var letters))
            {
                char selectedChar = letters[(_consecutiveCount - 1) % letters.Length];
                _result.Append(selectedChar);
            }

            _lastKey = '\0';
            _consecutiveCount = 0;
        }
        #endregion

        #region Key Pad Dictionary

        private void ResetState()
        {
            _result.Clear();
            _lastKey = '\0';
            _consecutiveCount = 0;
        }

        private Dictionary<char, string> InitializeKeypadMap()
        {
            return new Dictionary<char, string>
            {
                { '1', "&'(" },
                { '2', "ABC" },
                { '3', "DEF" },
                { '4', "GHI" },
                { '5', "JKL" },
                { '6', "MNO" },
                { '7', "PQRS" },
                { '8', "TUV" },
                { '9', "WXYZ" },
                { '0', " " }
            };
        }

        #endregion
    }
}




