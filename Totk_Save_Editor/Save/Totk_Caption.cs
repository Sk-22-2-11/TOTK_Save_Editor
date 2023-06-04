using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TOTK_SaveGame_Editor.Data;
using TOTK_SaveGame_Editor.Items;

namespace TOTK_SaveGame_Editor.Save
{
    public class TOTK_Caption : Caption
    {
        #region Offsets

        private int RUPEE_ADDRESS;           
        private int HEART_ADDRESS;          
        private int MAX_HEART_ADDRESS;     
        private int STAMINA_ADDRESS;
        
        private int ARROW_ADDRESS;

        private int SWORD_ADDRESS;
        private int BOW_ADDRESS;
        private int SHIELD_ADDRESS;
        private int ARMOR_ADDRESS;

        private int SWORD_DURABILITY;
        private int BOW_DURABILITY;
        private int SHIELD_DURABILITY;

        private int SWORD_MODIFIER;
        private int BOW_MODIFIER;
        private int SHIELD_MODIFIER;

        private int SWORD_POUCH_SIZE;
        private int BOW_POUCH_SIZE;
        private int SHIELD_POUCH_SIZE;

        public int LOOKOUTLANDING_MAP;
        public int GERUDOCANYON_MAP;
        public int POPLAFOOTHILLS_MAP;
        public int MOUNTLANAYRU_MAP;
        public int UPLANDZORANA_MAP;
        public int ULRIMOUNTAIN_MAP;
        public int ELDINCANYON_MAP;
        public int THYPHLORUINS_MAP;
        public int GERUDOHIGHLANDS_MAP;
        public int HYRULEFIELD_MAP;
        public int RABELLAWETLANDS_MAP;
        public int PIKIDASTONEGROVE_MAP;
        public int ROSPROPASS_MAP;
        public int LINDORSBROW_MAP;
        public int SAHASRASLOPE_MAP;

        public int LOOKOUTLANDING_TOWER_ACTIVE;
        public int GERUDOCANYON_TOWER_ACTIVE;
        public int POPLAFOOTHILLS_TOWER_ACTIVE;
        public int MOUNTLANAYRU_TOWER_ACTIVE;
        public int UPLANDZORANA_TOWER_ACTIVE;
        public int ULRIMOUNTAIN_TOWER_ACTIVE;
        public int ELDINCANYON_TOWER_ACTIVE;
        public int THYPHLORUINS_TOWER_ACTIVE;
        public int GERUDOHIGHLANDS_TOWER_ACTIVE;
        public int HYRULEFIELD_TOWER_ACTIVE;
        public int RABELLAWETLANDS_TOWER_ACTIVE;
        public int PIKIDASTONEGROVE_TOWER_ACTIVE;
        public int ROSPROPASS_TOWER_ACTIVE;
        public int LINDORSBROW_TOWER_ACTIVE;
        public int SAHASRASLOPE_TOWER_ACTIVE;

        public int LOOKOUTLANDING_TOWER_PIN;
        public int GERUDOCANYON_TOWER_PIN;
        public int POPLAFOOTHILLS_TOWER_PIN;
        public int MOUNTLANAYRU_TOWER_PIN;
        public int UPLANDZORANA_TOWER_PIN;
        public int ULRIMOUNTAIN_TOWER_PIN;
        public int ELDINCANYON_TOWER_PIN;
        public int THYPHLORUINS_TOWER_PIN;
        public int GERUDOHIGHLANDS_TOWER_PIN;
        public int HYRULEFIELD_TOWER_PIN;
        public int RABELLAWETLANDS_TOWER_PIN;
        public int PIKIDASTONEGROVE_TOWER_PIN;
        public int ROSPROPASS_TOWER_PIN;
        public int LINDORSBROW_TOWER_PIN;
        public int SAHASRASLOPE_TOWER_PIN;

        #endregion

        public int CAPTION_ADD;
        public byte[] Caption;

        public TOTK_Caption(string path)
        {
            string[] caption_list = { "\\slot_00", "\\slot_01", "\\slot_02", "\\slot_03", "\\slot_04", "\\slot_05" };
            IsLoaded = false;

            for (int i = 0; i < 6; i++)
            {
                _Path = path + caption_list[i];

                if (!Directory.Exists(_Path))
                {
                    //Debug.WriteLine("path not exist: {0}", _Path);
                    IsLoaded = false;
                    return;
                }                

                if (!File.Exists(_Path + "\\caption.sav"))
                {
                    //Debug.WriteLine("file not exist");
                    IsLoaded = false;
                    return;
                }

                _Data = File.ReadAllBytes(_Path + "\\caption.sav");              

                LoadOffsets();
                ReadImage(CAPTION_ADD);

            }

            IsLoaded = true;
        }

        private void LoadOffsets()
        {
            CAPTION_ADD = FindBytePatternOffset(Byte_Patterns.CAP_PATTERN);
            
        }

    }
}
