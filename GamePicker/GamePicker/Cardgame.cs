using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker
{
    class Cardgame: Boardgame
    {
        private string _card_type;
        private string _card_img_path;

        #region SettersAndGetters
        public string CardType
        {
            get
            {
                return _card_type;
            }
            set
            {
                _card_type = value;
            }
        }

        public string CardImgType
        {
            get
            {
                return _card_img_path;
            }
            set
            {
                _card_img_path = value;
            }
        }
        #endregion
    }
}
