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

        public List<Game> games = new List<Game>();
        public List<Player> players = new List<Player>();

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
                g_ttp.InnerText = "00:10";
                g_description.InnerText = "Klondike is a solitaire card game. Klondike is played with a standard 52-card deck, without Jokers. The goal is to get the four suits built onto the foundations from aces up through kings.";
                g_img_path.InnerText = "";
                g_min_age.InnerText = "8";
                g_setup_time.InnerText = "00:01";
                g_card_type.InnerText = "Standard 52";
                g_card_img.InnerText = "";

                gamedb.Save("gamedb.xml");
            }
        }
        
        public void PopulateGames()
        {
            XmlDocument gamedb = new XmlDocument();
            gamedb.Load("gamedb.xml");
            XmlNodeList nodes = gamedb.SelectNodes("GAMES/GAME");
            foreach (XmlNode node in nodes)
            {
                string type = node.ChildNodes[0].InnerText;
                if (type.ToUpper() == "BOARDGAME")
                {
                    Boardgame bg = new Boardgame();
                    bg.Title = node.SelectSingleNode("TITLE").InnerText;
                    bg.MinPlayers = Int32.Parse(node.SelectSingleNode("MIN_NUM_PLAYERS").InnerText);
                    bg.MaxPlayers = Int32.Parse(node.SelectSingleNode("MAX_NUM_PLAYERS").InnerText);
                    bg.TimeToPlay = node.SelectSingleNode("TIME_TO_PLAY").InnerText;
                    bg.Description = node.SelectSingleNode("DESCRIPTION").InnerText;
                    bg.ImgPath = node.SelectSingleNode("IMG_PATH").InnerText;
                    bg.MinAge = Int32.Parse(node.SelectSingleNode("MIN_AGE").InnerText);
                    bg.SetupTime = node.SelectSingleNode("SETUP_TIME").InnerText;

                    games.Add(bg);
                }
                else if (type.ToUpper() == "CARDGAME")
                {
                    Cardgame cg = new Cardgame();
                    cg.Title = node.SelectSingleNode("TITLE").InnerText;
                    cg.MinPlayers = Int32.Parse(node.SelectSingleNode("MIN_NUM_PLAYERS").InnerText);
                    cg.MaxPlayers = Int32.Parse(node.SelectSingleNode("MAX_NUM_PLAYERS").InnerText);
                    cg.TimeToPlay = node.SelectSingleNode("TIME_TO_PLAY").InnerText;
                    cg.Description = node.SelectSingleNode("DESCRIPTION").InnerText;
                    cg.ImgPath = node.SelectSingleNode("IMG_PATH").InnerText;
                    cg.MinAge = Int32.Parse(node.SelectSingleNode("MIN_AGE").InnerText);
                    cg.SetupTime = node.SelectSingleNode("SETUP_TIME").InnerText;
                    cg.CardType = node.SelectSingleNode("CARDS_TYPE").InnerText;
                    cg.CardTypeImg = node.SelectSingleNode("CARD_IMG").InnerText;

                    games.Add(cg);
                }
                else if (type.ToUpper() == "VIDEOGAME")
                {
                    Videogame vg = new Videogame();
                    vg.Title = node.SelectSingleNode("TITLE").InnerText;
                    vg.MinPlayers = Int32.Parse(node.SelectSingleNode("MIN_NUM_PLAYERS").InnerText);
                    vg.MaxPlayers = Int32.Parse(node.SelectSingleNode("MAX_NUM_PLAYERS").InnerText);
                    vg.TimeToPlay = node.SelectSingleNode("TIME_TO_PLAY").InnerText;
                    vg.Description = node.SelectSingleNode("DESCRIPTION").InnerText;
                    vg.ImgPath = node.SelectSingleNode("IMG_PATH").InnerText;
                    vg.MinAge = Int32.Parse(node.SelectSingleNode("MIN_AGE").InnerText);
                    vg.Console = node.SelectSingleNode("CONSOLE").InnerText;
                    vg.Platform = node.SelectSingleNode("PLATFORM").InnerText;
                    vg.ConsoleImgPath = node.SelectSingleNode("CONSOLE_IMG_PATH").InnerText;
                    vg.PlatformImgPath = node.SelectSingleNode("PLATFORM_IMG_PATH").InnerText;

                    games.Add(vg);
                }
            }
        }
    }
}
