﻿using System.Collections.Generic;

namespace BlackJack.GameElements
{
    public enum RankValue
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 10,
        Queen = 11,
        King = 12,
        Ace = 13
    }

    public class Rank : IRank
    {
        private RankValue _value;

        private Dictionary<RankValue, string> ValueMappings { get; } = new Dictionary<RankValue, string>
        {
            {RankValue.Jack, "J"},
            {RankValue.Queen, "Q"},
            {RankValue.King, "K"},
            {RankValue.Ace, "A"}
        };

        public Rank(int value)
        {
            _value = (RankValue)value;
        }

        public int GetValue()
        {
            if (_value == RankValue.Ace) return 11;
            return (int)_value > 10 ? 10 : (int)_value;
        }

        public void SetValue(int value) => _value = (RankValue)value;

        public override string ToString()
        {
            return ValueMappings.ContainsKey(_value) ? ValueMappings[_value] : ((int)_value).ToString();
        }
    }
}
