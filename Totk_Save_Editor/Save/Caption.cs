using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Diagnostics;

namespace TOTK_SaveGame_Editor.Save
{
    public class Caption
    {
        public bool IsLoaded = false;

        internal string _Path;
        internal byte[] _Data;
        


        public int FindBytePatternOffset(byte[] pattern)
        {
            for (int i = 0; i <= _Data.Length - pattern.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < pattern.Length; j++)
                {
                    if (_Data[i + j] != pattern[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    return ReadInt(i + pattern.Length);                    
                }
            }
            return -1;
        }

        // Read/Write
        public void ReadImage(int offset)
        {
            
            uint capSize = ReadUInt32(offset);
            //Debug.WriteLine("writting image");
            byte[] valueBytes = new byte[capSize];
            Array.Copy( _Data, offset + 4, valueBytes, 0, capSize);

            ImageConverter converter = new ImageConverter();            
            Image img = (Image)converter.ConvertFrom(valueBytes);
            //Debug.WriteLine(_Path + "\\caption.png");
            img.Save(_Path + "\\caption.png");

        }

        public uint ReadUInt32(int offset)
        {
            return BitConverter.ToUInt32(_Data, offset);
        }

        public int ReadInt(int offset)
        {
            return BitConverter.ToInt32(_Data, offset);
        }

    }
}
