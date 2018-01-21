using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks.Map.Block
{
    class BlockMask
    {
        public Block Block { get; private set; }
        public GameRes.GameObject GameObj { get; private set; }

        public BlockMask(Block block, GameRes.GameObject gameObj = null)
        {
            Block = block;
            GameObj = gameObj;
        }

        public void UpdateGameObject(GameRes.GameObject obj)
        {
            GameObj = obj;
        }
        public void UpdateBlock(Block block)
        {
            Block = block;
        }
    }
}
