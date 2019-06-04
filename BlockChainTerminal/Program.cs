using System;
using BlockChainLib;
namespace BlockChainTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            IBlockChainRepository blockChain = new BlockChainRepository();
                        
            blockChain.AddBlock(new Block { Index = 1, TimeStamp = Convert.ToDateTime("2019-01-03"), Data = "{'description':'ABC','value':50}" });
            blockChain.AddBlock(new Block { Index = 2, TimeStamp = Convert.ToDateTime("2019-01-04"), Data = "{'description':'DEF','value':99}" });

            foreach (var item in blockChain.GetAllBlocks())
            {

                Console.WriteLine(item.Index + "\n" + item.TimeStamp + "\n" + item.Data + "\n" + item.PreviousHash + "\n" + item.Hash);

                Console.WriteLine("----------------");
            }
        }
    }
}
