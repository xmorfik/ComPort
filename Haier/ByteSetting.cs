using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haier
{
    [Serializable]
    
    internal class ByteSetting
    {
        public bool IsNumber { get; set; }
        public int Position { get; set; }
        public List<ValueMeaning> MeaningList { get; set; }
        public ByteSetting(int position, bool isNumber)
        {
            this.Position = position;
            this.IsNumber = isNumber;
            MeaningList = new List<ValueMeaning>();
        }
        public string GetMeaning(byte data)
        {
            if (IsNumber)
            {
                return data.ToString("X");
            }

            if (MeaningList.Count == 0)
            {
                return string.Empty;
            }

            for(int i = 0; i< MeaningList.Count; i++)
            {
                if(MeaningList[i].Value == data )
                {
                    return MeaningList[i].Meaning;
                }
            }
            
            return string.Empty;
        }
    }
}
