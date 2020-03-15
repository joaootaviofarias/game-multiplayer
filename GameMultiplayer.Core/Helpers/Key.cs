using GameMultiplayer.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GameMultiplayer.Core.Helpers
{
    public class Key
    {
        public Key(int key)
        {
            KeyPressed = key;
        }

        public int KeyPressed { get; protected set; }

        public Keys GetKeyPressed()
        {
            return (Keys)KeyPressed;
        }
    }
}
