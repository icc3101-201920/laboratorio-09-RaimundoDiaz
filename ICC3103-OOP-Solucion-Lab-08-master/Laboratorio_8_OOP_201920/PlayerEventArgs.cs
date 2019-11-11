using System;
using Laboratorio_8_OOP_201920.Cards;

namespace Laboratorio_8_OOP_201920
{
    public class PlayerEventArgs : EventArgs
    {
        public Card Card { get; set; }
        public Player Player { get; set; }
    }
}
