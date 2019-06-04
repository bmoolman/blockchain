using System;
using System.Collections.Generic;
using System.Text;

namespace BlockChainLib
{
    public class BlockChainRepository : IBlockChainRepository
    {
        private List<Block> _chain;
        public BlockChainRepository()
        {
            if (_chain == null)
            {
                InitializeBlockChain();
                _chain[0].Hash = _chain[0].CalculateHash();
            }
        }

        private void InitializeBlockChain()
        {
            _chain = new List<Block>();
            Block GenesisBlock = new Block()
            {
                Index = 0,
                TimeStamp = Convert.ToDateTime("2019-01-01"),
                Data = "Genesis Block",
                PreviousHash = "0"
            };
            _chain.Add(GenesisBlock);

        }

        public void AddBlock(Block block)
        {
            block.PreviousHash = GetLatestBlock().Hash;
            block.Hash = block.CalculateHash();
            _chain.Add(block);
        }

        public Block GetLatestBlock()
        {
            return _chain[_chain.Count - 1];
        }          

        public IEnumerable<Block> GetAllBlocks()
        {
            return _chain;
        }
    }
}
