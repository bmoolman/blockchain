using System;
using System.Collections.Generic;
using System.Text;

namespace BlockChainLib
{   
    public interface IBlockChainRepository
    {
        IEnumerable<Block> GetAllBlocks();
        Block GetLatestBlock();
        void AddBlock(Block block);        
    }
}
