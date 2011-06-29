﻿namespace TEdit.TerrariaWorld
{
    public static class TileProperties
    {
        public const byte MaxTileTypes = 86;
        public const byte MaxWallTypes = 14;

        public static bool[] TileCut = new bool[byte.MaxValue];
        public static bool[] TileAlch = new bool[byte.MaxValue];
        public static int[] TileShine = new int[byte.MaxValue];
        public static bool[] WallHouse = new bool[byte.MaxValue];
        public static bool[] TileStone = new bool[byte.MaxValue];
        public static bool[] TileWaterDeath = new bool[byte.MaxValue];
        public static bool[] TileLavaDeath = new bool[byte.MaxValue];
        public static bool[] TileTable = new bool[byte.MaxValue];
        public static bool[] TileBlockLight = new bool[byte.MaxValue];
        public static bool[] TileDungeon = new bool[byte.MaxValue];
        public static bool[] TileSolidTop = new bool[byte.MaxValue];
        public static bool[] TileSolid = new bool[byte.MaxValue];
        public static bool[] TileNoAttach = new bool[byte.MaxValue];
        public static bool[] TileNoFail = new bool[byte.MaxValue];
        public static bool[] TileFrameImportant = new bool[byte.MaxValue];
        public static string[] TileName = new string[byte.MaxValue];

        static TileProperties()
        {
            for (int i = 0; i < byte.MaxValue; i++)
            {
                TileCut[i] = false;
                TileAlch[i] = false;
                TileShine[i] = 0;
                WallHouse[i] = false;
                TileStone[i] = false;
                TileWaterDeath[i] = false;
                TileLavaDeath[i] = false;
                TileTable[i] = false;
                TileBlockLight[i] = false;
                TileDungeon[i] = false;
                TileSolidTop[i] = false;
                TileSolid[i] = false;
                TileNoAttach[i] = false;
                TileNoFail[i] = false;
                TileFrameImportant[i] = false;
                TileName[i] = string.Empty;
            }

            TileAlch[82] = true;
            TileAlch[83] = true;
            TileAlch[84] = true;
            TileBlockLight[0] = true;
            TileBlockLight[10] = true;
            TileBlockLight[10] = true;
            TileBlockLight[1] = true;
            TileBlockLight[22] = true;
            TileBlockLight[23] = true;
            TileBlockLight[25] = true;
            TileBlockLight[2] = true;
            TileBlockLight[30] = true;
            TileBlockLight[32] = true;
            TileBlockLight[37] = true;
            TileBlockLight[38] = true;
            TileBlockLight[39] = true;
            TileBlockLight[40] = true;
            TileBlockLight[41] = true;
            TileBlockLight[43] = true;
            TileBlockLight[44] = true;
            TileBlockLight[45] = true;
            TileBlockLight[46] = true;
            TileBlockLight[47] = true;
            TileBlockLight[48] = true;
            TileBlockLight[51] = true;
            TileBlockLight[52] = true;
            TileBlockLight[53] = true;
            TileBlockLight[56] = true;
            TileBlockLight[57] = true;
            TileBlockLight[58] = true;
            TileBlockLight[59] = true;
            TileBlockLight[60] = true;
            TileBlockLight[62] = true;
            TileBlockLight[63] = true;
            TileBlockLight[64] = true;
            TileBlockLight[65] = true;
            TileBlockLight[66] = true;
            TileBlockLight[67] = true;
            TileBlockLight[68] = true;
            TileBlockLight[6] = true;
            TileBlockLight[70] = true;
            TileBlockLight[75] = true;
            TileBlockLight[76] = true;
            TileBlockLight[7] = true;
            TileBlockLight[8] = true;
            TileBlockLight[9] = true;
            TileCut[24] = true;
            TileCut[28] = true;
            TileCut[32] = true;
            TileCut[3] = true;
            TileCut[51] = true;
            TileCut[52] = true;
            TileCut[61] = true;
            TileCut[62] = true;
            TileCut[69] = true;
            TileCut[71] = true;
            TileCut[73] = true;
            TileCut[74] = true;
            TileCut[82] = true;
            TileCut[83] = true;
            TileCut[84] = true;
            TileDungeon[41] = true;
            TileDungeon[43] = true;
            TileDungeon[44] = true;
            TileFrameImportant[10] = true;
            TileFrameImportant[11] = true;
            TileFrameImportant[12] = true;
            TileFrameImportant[13] = true;
            TileFrameImportant[14] = true;
            TileFrameImportant[15] = true;
            TileFrameImportant[16] = true;
            TileFrameImportant[17] = true;
            TileFrameImportant[18] = true;
            TileFrameImportant[20] = true;
            TileFrameImportant[21] = true;
            TileFrameImportant[24] = true;
            TileFrameImportant[26] = true;
            TileFrameImportant[27] = true;
            TileFrameImportant[28] = true;
            TileFrameImportant[29] = true;
            TileFrameImportant[31] = true;
            TileFrameImportant[33] = true;
            TileFrameImportant[34] = true;
            TileFrameImportant[35] = true;
            TileFrameImportant[36] = true;
            TileFrameImportant[3] = true;
            TileFrameImportant[42] = true;
            TileFrameImportant[50] = true;
            TileFrameImportant[55] = true;
            TileFrameImportant[5] = true;
            TileFrameImportant[61] = true;
            TileFrameImportant[71] = true;
            TileFrameImportant[72] = true;
            TileFrameImportant[73] = true;
            TileFrameImportant[74] = true;
            TileFrameImportant[77] = true;
            TileFrameImportant[78] = true;
            TileFrameImportant[79] = true;
            TileFrameImportant[81] = true;
            TileFrameImportant[82] = true;
            TileFrameImportant[83] = true;
            TileFrameImportant[84] = true;
            TileFrameImportant[85] = true;
            TileLavaDeath[10] = true;
            TileLavaDeath[11] = true;
            TileLavaDeath[12] = true;
            TileLavaDeath[13] = true;
            TileLavaDeath[14] = true;
            TileLavaDeath[15] = true;
            TileLavaDeath[16] = true;
            TileLavaDeath[17] = true;
            TileLavaDeath[18] = true;
            TileLavaDeath[19] = true;
            TileLavaDeath[20] = true;
            TileLavaDeath[27] = true;
            TileLavaDeath[28] = true;
            TileLavaDeath[29] = true;
            TileLavaDeath[32] = true;
            TileLavaDeath[33] = true;
            TileLavaDeath[34] = true;
            TileLavaDeath[35] = true;
            TileLavaDeath[36] = true;
            TileLavaDeath[3] = true;
            TileLavaDeath[42] = true;
            TileLavaDeath[49] = true;
            TileLavaDeath[50] = true;
            TileLavaDeath[52] = true;
            TileLavaDeath[55] = true;
            TileLavaDeath[5] = true;
            TileLavaDeath[61] = true;
            TileLavaDeath[62] = true;
            TileLavaDeath[69] = true;
            TileLavaDeath[71] = true;
            TileLavaDeath[72] = true;
            TileLavaDeath[73] = true;
            TileLavaDeath[74] = true;
            TileLavaDeath[79] = true;
            TileLavaDeath[80] = true;
            TileLavaDeath[81] = true;
            TileName[13] = "Bottle";
            TileName[14] = "Table";
            TileName[15] = "Chair";
            TileName[16] = "Anvil";
            TileName[17] = "Furnace";
            TileName[18] = "Workbench";
            TileName[26] = "Demon Altar";
            TileName[77] = "Hellforge";
            TileNoAttach[10] = true;
            TileNoAttach[13] = true;
            TileNoAttach[14] = true;
            TileNoAttach[15] = true;
            TileNoAttach[16] = true;
            TileNoAttach[17] = true;
            TileNoAttach[18] = true;
            TileNoAttach[19] = true;
            TileNoAttach[19] = true;
            TileNoAttach[20] = true;
            TileNoAttach[21] = true;
            TileNoAttach[27] = true;
            TileNoAttach[3] = true;
            TileNoAttach[4] = true;
            TileNoAttach[50] = true;
            TileNoFail[24] = true;
            TileNoFail[32] = true;
            TileNoFail[3] = true;
            TileNoFail[4] = true;
            TileNoFail[50] = true;
            TileNoFail[61] = true;
            TileNoFail[73] = true;
            TileNoFail[74] = true;
            TileNoFail[82] = true;
            TileNoFail[83] = true;
            TileNoFail[84] = true;
            TileShine[12] = 1000;
            TileShine[21] = 1000;
            TileShine[22] = 1150;
            TileShine[45] = 1900;
            TileShine[46] = 2000;
            TileShine[47] = 2100;
            TileShine[63] = 900;
            TileShine[64] = 900;
            TileShine[65] = 900;
            TileShine[66] = 900;
            TileShine[67] = 900;
            TileShine[68] = 900;
            TileShine[6] = 1150;
            TileShine[7] = 1100;
            TileShine[8] = 1000;
            TileShine[9] = 1050;
            TileSolidTop[14] = true;
            TileSolidTop[16] = true;
            TileSolidTop[18] = true;
            TileSolidTop[19] = true;
            TileSolid[0] = true;
            TileSolid[10] = true;
            TileSolid[11] = false;
            TileSolid[19] = true;
            TileSolid[1] = true;
            TileSolid[22] = true;
            TileSolid[23] = true;
            TileSolid[25] = true;
            TileSolid[2] = true;
            TileSolid[30] = true;
            TileSolid[37] = true;
            TileSolid[38] = true;
            TileSolid[39] = true;
            TileSolid[3] = false;
            TileSolid[40] = true;
            TileSolid[41] = true;
            TileSolid[43] = true;
            TileSolid[44] = true;
            TileSolid[45] = true;
            TileSolid[46] = true;
            TileSolid[47] = true;
            TileSolid[48] = true;
            TileSolid[4] = false;
            TileSolid[53] = true;
            TileSolid[54] = true;
            TileSolid[56] = true;
            TileSolid[57] = true;
            TileSolid[58] = true;
            TileSolid[59] = true;
            TileSolid[5] = false;
            TileSolid[60] = true;
            TileSolid[63] = true;
            TileSolid[64] = true;
            TileSolid[65] = true;
            TileSolid[66] = true;
            TileSolid[67] = true;
            TileSolid[68] = true;
            TileSolid[6] = true;
            TileSolid[70] = true;
            TileSolid[75] = true;
            TileSolid[76] = true;
            TileSolid[7] = true;
            TileSolid[8] = true;
            TileSolid[9] = true;
            TileStone[63] = true;
            TileStone[64] = true;
            TileStone[65] = true;
            TileStone[66] = true;
            TileStone[67] = true;
            TileStone[68] = true;
            TileTable[14] = true;
            TileTable[18] = true;
            TileTable[19] = true;
            TileWaterDeath[4] = true;
            TileWaterDeath[51] = true;
            WallHouse[10] = true;
            WallHouse[11] = true;
            WallHouse[12] = true;
            WallHouse[1] = true;
            WallHouse[4] = true;
            WallHouse[5] = true;
            WallHouse[6] = true;
        }
    }
}