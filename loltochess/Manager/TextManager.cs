using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loltoChess.Manager;
using loltochess;
using System.IO;

namespace loltoChess.Manager
{
    class TextManager
    {
        private static TextManager instance = new TextManager();
        List<string> arrSynergyTextRecive;
        List<string> arrSynergyTextSender = new List<string>(); // 필요한것만 받아서 넘겨줌 다 사용하면  clear 하셈 
        private TextManager()
        {
            arrSynergyTextRecive = File.ReadAllLines(@"../../Resource/SynergeText.txt").ToList();
        }
        public static TextManager Get { get { return instance; } }

        public List<string> sendSynergyTextData(Dictionary<eSynergy, synergyData> mapSynergyData)
        {
            int targetIndex;
            string text = string.Empty;
            arrSynergyTextSender.Clear();
            //find 로 sysner 텍스트 위치 찾고 몇시너지인지 확인뒤 그만큼 더하면 해당 텍스트가 나올듯 
            foreach (eSynergy index in Enum.GetValues(typeof(eSynergy)))
            {
                for (int i = mapSynergyData[index].limitCount.Count - 1; i >= 0; i--)
                {
                    if (mapSynergyData[index].count >= mapSynergyData[index].limitCount[i])
                    {
                        targetIndex = arrSynergyTextRecive.FindIndex(e => e == index.ToString())+i+1;
                        text = string.Format("({0}) {1}", mapSynergyData[index].limitCount[i],
                            arrSynergyTextRecive[targetIndex]);
                        arrSynergyTextSender.Add(text);
                        break;
                    }
                }
            }

            return arrSynergyTextSender;
        }
    }
}
