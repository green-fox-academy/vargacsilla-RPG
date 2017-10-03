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
        public List<List<GameObject>> map;

        public Map(int tileNumHeight, int tileNumWidth)
        {
            this.tileNumHeight = tileNumHeight;
            this.tileNumWidth = tileNumWidth;
            map = new List<List<GameObject>>();
            LoadMap();
        }

        public void LoadMap()
        {
            List<string[]> mapText = GetMapFromTxt();
            
            for (int i = 0; i < mapText.Count; i++)
            {
                map.Add(new List<GameObject>());

                for (int j = 0; j < mapText[i].Length; j++)
                {
                    if (mapText[i][j] == "f")
                    {
                        map[i].Add(new Floor(j, i));
                    }
                    if (mapText[i][j] == "w")
                    {
                        map[i].Add(new Wall(j, i));
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
            for (int i = 0; i < map.Count; i++)
            {
                foreach (var gameObject in map[i])
                {
                    gameObject.DrawGameObject(foxDraw);
                }
            }
        }    

        //public void Add(GameObject gameObject)              // NOT SURE IF THIS SOULD BE HERE OR ON AN HIGHER LEVEL
        //{
        //    map.Add(gameObject);
        //}
    }
}
