using System;
using System.Collections.Generic;
using System.Text;
using BlockChainLib.Crypto;

namespace BlockChainLib
{
    public class Block
    {
        //private readonly int _index;
        //private readonly DateTime _timeStamp;
        //private readonly string _data;
        //private readonly string _previousHash;
        //private readonly string _hash;
        //private readonly int _nonce;

        public int Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Data { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }
        public int Nonce { get; set; }


        //public Block(int index, DateTime timeStamp, string data, string previousHash)
        //{
        //    _index = index;
        //    _timeStamp = timeStamp;
        //    _data = data;
        //    _previousHash = previousHash;
        //    _hash = CalculateHash();
        //}
        public string CalculateHash()
        {
            return CryptoSha256.ComputeHash(Index + PreviousHash + TimeStamp.ToString("yyyyMMddHHmmss") + Data);
        }
    }
}
