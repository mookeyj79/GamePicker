using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GamePicker
{
    class GamePicker
    {

        List<Game> games;

        public void GameDBCheck()
        {
            if (!File.Exists("gamedb.xml")) 
            {
                XmlDocument db = new XmlDocument();
                XmlElement games = db.CreateElement("GAMES");
                db.AppendChild(games);
                db.Save("gamedb.xml");
            }
        }
        
        private void PopulateGames()
        {
        }
    }
}
