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
                XmlDocument gamedb = new XmlDocument();
                XmlElement root = gamedb.CreateElement("GAMES");
                gamedb.AppendChild(root);

                XmlElement game = gamedb.CreateElement("GAME");
                root.AppendChild(game);
                XmlAttribute g_id = gamedb.CreateAttribute("GAME");
                game.Attributes.Append(g_id);

                XmlElement g_type = gamedb.CreateElement("TYPE");
                XmlElement g_title = gamedb.CreateElement("TITLE");
                XmlElement g_min_players = gamedb.CreateElement("MIN_NUM_PLAYERS");
                XmlElement g_max_players = gamedb.CreateElement("MAX_NUM_PLAYERS");
                XmlElement g_ttp = gamedb.CreateElement("TIME_TO_PLAY");
                XmlElement g_description = gamedb.CreateElement("DESCRIPTION");
                XmlElement g_img_path = gamedb.CreateElement("IMG_PATH");
                XmlElement g_min_age = gamedb.CreateElement("MIN_AGE");
                XmlElement g_setup_time = gamedb.CreateElement("SETUP_TIME");
                XmlElement g_card_type = gamedb.CreateElement("CARDS_TYPE");
                XmlElement g_card_img = gamedb.CreateElement("CARD_IMG");

                game.AppendChild(g_type);
                game.AppendChild(g_title);
                game.AppendChild(g_min_players);
                game.AppendChild(g_max_players);
                game.AppendChild(g_ttp);
                game.AppendChild(g_description);
                game.AppendChild(g_img_path);
                game.AppendChild(g_min_age);
                game.AppendChild(g_setup_time);
                game.AppendChild(g_card_type);
                game.AppendChild(g_card_img);

                g_id.Value = gamedb.SelectNodes("GAMES/GAME").Count.ToString();
                g_type.InnerText = "CARDGAME";
                g_title.InnerText = "Solitaire - Klondike";
                g_min_players.InnerText = "1";
                g_max_players.InnerText = "1";
                g_ttp.InnerText = "00:11";
                g_description.InnerText = "Klondike is a solitaire card game. Klondike is played with a standard 52-card deck, without Jokers. The goal is to get the four suits built onto the foundations from aces up through kings.";
                g_img_path.InnerText = "./img/games/klondike.png";
                g_min_age.InnerText = "1";
                g_setup_time.InnerText = "00:05";
                g_card_type.InnerText = "Standard 52";
                g_card_img.InnerText = "/img/cards/standard_52.png";

                gamedb.Save("gamedb.xml");
            }
        }
        
        private void PopulateGames()
        {
            
        }
    }
}
