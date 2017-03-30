﻿namespace ConsoleReader.Parsing
{
    internal sealed class UInt16TokenParser : ITokenParser<ushort>
    {
        public ushort Parse(string token)
        {
            return ushort.Parse(token);
        }
    }
}
