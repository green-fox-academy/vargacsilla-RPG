using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using RPGGame;
using System.IO;

namespace RPGgame
{
    class Map
    {
        int tileNumHeight;
        int tileNumWidth;
        List<GameObject> map;

        public Map(int tileNumHeight, int tileNumWidth)
        {
            this.tileNumHeight = tileNumHeight;
            this.tileNumWidth = tileNumWidth;
            map = new List<GameObject>();
            LoadMap();
        }

        public void LoadMap()
        {
            List<string[]> mapText = GetMapFromTxt();
            
            for (int i = 0; i < mapText.Count; i++)
            {
                for (int j = 0; j < mapText[i].Length; j++)
                {
                    if (mapText[i][j] == "f")
                    {
                        map.Add(new Floor(j * Tile.Width, i * Tile.Height));
                    }
                    if (mapText[i][j] == "w")
                    {
                        map.Add(new Wall(j * Tile.Width, i * Tile.Height));
                    }
                }
            }
        }

        private List<string[]> GetMapFromTxt()
        {
            string path = @"../../map.txt";
            string[] content = File.ReadAllLines(path);
            var mapText = new List<string[]>();
            foreach (var line in content)
            {
                mapText.Add(line.Split(' '));
            }
            return mapText;
        }

        public void DrawMap(FoxDraw foxDraw)
        {
            foreach (var gameObject in map)
            {
                gameObject.DrawGameObject(foxDraw);
            }
        }    
    }
}
