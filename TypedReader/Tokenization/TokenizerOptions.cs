﻿namespace TypedReader.Tokenization
{
    public class TokenizerOptions
    {
        public static readonly TokenizerOptions Default = new TokenizerOptions();
        
        /// <summary>
        /// The character by which the user input will be split.
        /// </summary>
        public char[] Separators { get; }

        /// <summary>
        /// Flag which indicates whether to ignore the whitespace symbols
        /// </summary>
        public bool IgnoreWhiteSpace { get; }

        public TokenizerOptions(params char[] separators) : this(true, separators)
        {
        }
        
        public TokenizerOptions(bool ignoreWhiteSpace, params char[] separators)
        {
            Separators = separators.Length == 0 ? new [] {' '} : separators;
            IgnoreWhiteSpace = ignoreWhiteSpace;
        }
    }
}
