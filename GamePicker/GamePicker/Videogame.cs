using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker
{
    class Videogame: Game
    {
        private string _console;
        private string _platform;
        private string _console_img_path;
        private string _platform_img_path;

        #region GettersAndSetters
        public string Console
        {
            get
            {
                return _console;
            }
            set
            {
                _console = value;
            }
        }

        public string Platform
        {
            get
            {
                return _platform;
            }
            set
            {
                _platform = value;
            }
        }

        public string ConsoleImgPath
        {
            get
            {
                return _console_img_path;
            }
            set
            {
                _console_img_path = value;
            }
        }

        public string PlatformImgPath
        {
            get
            {
                return _platform_img_path;
            }
            set
            {
                _platform_img_path = value;
            }
        }
        #endregion
    }
}
