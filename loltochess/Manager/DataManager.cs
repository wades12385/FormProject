using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace loltoChess.Manager
{
    public class boxData 
    {
        public bool isClick;
        public PictureBox box;
        public eHero hero;
        public boxData() { }
        public boxData(PictureBox box)
        {
            hero = eHero.Max;
            this.box = box;
        }
    }
    class synergyData
    {
        private int numData;
        public int count
        {
            get { return numData; }
            set
            {
                numData = value;
                if (numData < 0) numData = 0;
            }
        }

        public List<int> limitCount;

        public synergyData(int[] arr)
        {
            limitCount = new List<int>(arr);
        }
    }
    struct Rect
    {
        public Point pos;
        public Size size;
        public Rect(Point pos, Size size)
        {
            this.pos = pos;
            this.size = size;
        }
    }

    static partial class DataManager
    {
		//픽처박스 캐싱map 누르면 이걸로 이미지 변화 
        private static Dictionary<eHero, List<PictureBox>> mapPictureBoxList = new Dictionary<eHero, List<PictureBox>>();
		//search용 데이터와 관련 데이터 저장용 컨테이너
		private static Dictionary<eHero, boxData> mapPictureBoxData = new Dictionary<eHero, boxData>();
		//
        private static Dictionary<eSynergy, List<Label>> mapSynergyLabelList = new Dictionary<eSynergy, List<Label>>();
        private static Dictionary<eSynergy, synergyData> mapSynergyData = new Dictionary<eSynergy, synergyData>();

        private static List<boxData> arrPickHeroPictureBox = new List<boxData>();

        public static Label selectCountLabel;
        public static PictureBox resetButton;

        private static int selecNum;
        public static int selectCount
        {
            get { return selecNum; }
            set
            {
                selecNum = value;
                if (selecNum < 0) selecNum = 0;
            }
        }
        static DataManager()
        {
            for (eHero i = 0; i <= eHero.Zyra; i++)
            {
                mapPictureBoxData.Add(i, new boxData());
            }
            initMapSynergyData();
            initEnumFlag();
        }


        public static void addPictureBoxList(eHero hero, PictureBox box)
        {
            switch (hero)
            {
                case eHero.Aatrox:
                    pictureAatrox.Add(box);
                    break;
                case eHero.Annie:
                    pictureAnnie.Add(box);
                    break;
                case eHero.Ashe:
                    pictureAshe.Add(box);
                    break;
                case eHero.Azir:
                    pictureAzir.Add(box);
                    break;
                case eHero.Brand:
                    pictureBrand.Add(box);
                    break;
                case eHero.Braum:
                    pictureBraum.Add(box);
                    break;
                case eHero.Diana:
                    pictureDiana.Add(box);
                    break;
                case eHero.DrMundo:
                    pictureDrMundo.Add(box);
                    break;
                case eHero.Ezreal:
                    pictureEzreal.Add(box);
                    break;
                case eHero.Ivern:
                    pictureIvern.Add(box);
                    break;
                case eHero.Janna:
                    pictureJanna.Add(box);
                    break;
                case eHero.Jax:
                    pictureJax.Add(box);
                    break;
                case eHero.Khazix:
                    pictureKhazix.Add(box);
                    break;
                case eHero.Kindred:
                    pictureKindred.Add(box);
                    break;
                case eHero.KogMaw:
                    pictureKogMaw.Add(box);
                    break;
                case eHero.Leblanc:
                    pictureLeblanc.Add(box);
                    break;
                case eHero.Lux:
                    pictureLux.Add(box);
                    break;
                case eHero.Malphite:
                    pictureMalphite.Add(box);
                    break;
                case eHero.Malzahar:
                    pictureMalzahar.Add(box);
                    break;
                case eHero.Maokai:
                    pictureMaokai.Add(box);
                    break;
                case eHero.MasterYi:
                    pictureMasterYi.Add(box);
                    break;
                case eHero.Nami:
                    pictureNami.Add(box);
                    break;
                case eHero.Nasus:
                    pictureNasus.Add(box);
                    break;
                case eHero.Nautilus:
                    pictureNautilus.Add(box);
                    break;
                case eHero.Neeko:
                    pictureNeeko.Add(box);
                    break;
                case eHero.Nocturne:
                    pictureNocturne.Add(box);
                    break;
                case eHero.Olaf:
                    pictureOlaf.Add(box);
                    break;
                case eHero.Ornn:
                    pictureOrnn.Add(box);
                    break;
                case eHero.Qiyana:
                    pictureQiyana.Add(box);
                    break;
                case eHero.RekSai:
                    pictureRekSai.Add(box);
                    break;
                case eHero.Renekton:
                    pictureRenekton.Add(box);
                    break;
                case eHero.Singed:
                    pictureSinged.Add(box);
                    break;
                case eHero.Sion:
                    pictureSion.Add(box);
                    break;
                case eHero.Sivir:
                    pictureSivir.Add(box);
                    break;
                case eHero.Skarner:
                    pictureSkarner.Add(box);
                    break;
                case eHero.Soraka:
                    pictureSoraka.Add(box);
                    break;
                case eHero.Syndra:
                    pictureSyndra.Add(box);
                    break;
                case eHero.Taliyah:
                    pictureTaliyah.Add(box);
                    break;
                case eHero.Taric:
                    pictureTaric.Add(box);
                    break;
                case eHero.Thresh:
                    pictureThresh.Add(box);
                    break;
                case eHero.Twitch:
                    pictureTwitch.Add(box);
                    break;
                case eHero.Varus:
                    pictureVarus.Add(box);
                    break;
                case eHero.Vayne:
                    pictureVayne.Add(box);
                    break;
                case eHero.Veigar:
                    pictureVeigar.Add(box);
                    break;
                case eHero.Vladimir:
                    pictureVladimir.Add(box);
                    break;
                case eHero.Volibear:
                    pictureVolibear.Add(box);
                    break;
                case eHero.Warwick:
                    pictureWarwick.Add(box);
                    break;
                case eHero.Yasuo:
                    pictureYasuo.Add(box);
                    break;
                case eHero.Yorick:
                    pictureYorick.Add(box);
                    break;
                case eHero.Zed:
                    pictureZed.Add(box);
                    break;
                case eHero.Zyra:
                    pictureZyra.Add(box);
                    break;
                default:
                    Debug.Assert(false, "DataManager addPictureBoxList Input Error");
                    break;
            }
        }


        public static void clickBox(eHero hero)
        {
            if (selectCount > 9 && mapPictureBoxData[hero].isClick == false) return;

            mapPictureBoxData[hero].isClick = !mapPictureBoxData[hero].isClick;

            controlSysnergyData(hero, mapPictureBoxData[hero].isClick);
            PickingUpdate(mapPictureBoxData[hero].isClick, hero);

            if (selectCount > 0) resetButton.Visible = true;
            else resetButton.Visible = false;


            foreach (var picBoxlist in mapPictureBoxList[hero])
            {
                if (mapPictureBoxData[hero].isClick)
                {
                    picBoxlist.Image = ImageManager.callImage(eImageState.Click, hero);
                    picBoxlist.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    picBoxlist.Image = ImageManager.callImage(eImageState.None, hero);
                    picBoxlist.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            labelUpdate();
        }

        public static void resetPictureBox()
        {
            for (eHero i = 0; i < eHero.Max; i++)
            {
                foreach (var picBox in mapPictureBoxList[i])
                {
                    picBox.Image = ImageManager.callImage(eImageState.None, i);
                    picBox.BorderStyle = BorderStyle.FixedSingle;
                }
                mapPictureBoxData[i].isClick = false;
            }
        }

        private static void labelUpdate()
        {
            foreach (eSynergy index in Enum.GetValues(typeof(eSynergy)))
            {
                for (int i = mapSynergyData[index].limitCount.Count - 1; i >= 0; i--)
                {
                    labelColorUpdate(index, -1);
                    if (mapSynergyData[index].count >= mapSynergyData[index].limitCount[i])
                    {
                        labelColorUpdate(index, i);
                        break;
                    }
                }
            }
        }
        private static void labelColorUpdate(eSynergy index, int targetIndex)
        {
            for (int i = 0; i < mapSynergyLabelList[index].Count; i++)
            {
                if (i == targetIndex)
                {
                    mapSynergyLabelList[index][i].ForeColor = System.Drawing.Color.OrangeRed;
                    continue;
                }
                mapSynergyLabelList[index][i].ForeColor = System.Drawing.SystemColors.AppWorkspace;
            }
        }

        private static void PickingUpdate(bool click, eHero hero)
        {
            if (click)
            {
                addPickHeroBox(selectCount++);
            }
            else
            {
                removePickHeroBox();
                selectCount--;
            }

            selectCountLabel.Text = selectCount.ToString();

            void addPickHeroBox(int key)
            {
                arrPickHeroPictureBox[key].hero = hero;
                arrPickHeroPictureBox[key].isClick = true;
                arrPickHeroPictureBox[key].box.Visible = true;
                arrPickHeroPictureBox[key].box.Image = ImageManager.callImage(eImageState.Click, hero);
            }
            void removePickHeroBox()
            {
                int index;
                index = arrPickHeroPictureBox.FindIndex(e => e.hero == hero);

                if (index == 9)
                {
                    arrPickHeroPictureBox[index].hero = eHero.Max;
                    arrPickHeroPictureBox[index].box.Visible = false;
                    arrPickHeroPictureBox[index].isClick = false;
                    return;
                }
                for (int i = index; i < arrPickHeroPictureBox.Count - 1; i++)
                {
                    arrPickHeroPictureBox[i].hero = arrPickHeroPictureBox[i + 1].hero;
                    arrPickHeroPictureBox[i].isClick = arrPickHeroPictureBox[i + 1].isClick;
                    arrPickHeroPictureBox[i].box.Image = arrPickHeroPictureBox[i + 1].box.Image;
                    arrPickHeroPictureBox[i].box.Visible = arrPickHeroPictureBox[i + 1].box.Visible;//
                    arrPickHeroPictureBox[i + 1].box.Visible = false;
                    arrPickHeroPictureBox[i + 1].isClick = false;
                    arrPickHeroPictureBox[i + 1].hero = eHero.Max;
                }
            }
        }

        public static void Reset()
        {
            if (resetButton.Visible == false) return;

			resetPictureBox();

            selectCount = 0;

            selectCountLabel.Text = selectCount.ToString();

            foreach (var pickData in arrPickHeroPictureBox)
            {
                pickData.isClick = false;
                pickData.hero = eHero.Max;
                pickData.box.Visible = false;
            }

			foreach (eSynergy index in Enum.GetValues(typeof(eSynergy)))
            {
                mapSynergyData[index].count = 0;
                labelColorUpdate(index, -1);
            }

            resetButton.Visible = false;
        }

		


        public static void PanelUpdate(Panel panel)
        {
            int x = 0;
            int y = 0;
            int line = 0;
            List<Rect> labelPosList = new List<Rect>();
            List<string> str = TextManager.Get.sendSynergyTextData(mapSynergyData);

            for (int i = 0; i < str.Count; i++)
            {
                //panel 사이즈 넘어가는 string은 한줄 내려 
                Label text = new Label();
                text.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                text.ForeColor = Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(148)))), ((int)(((byte)(114)))));
                text.Text = str[i];
                text.AutoSize = true;
                using (Graphics graphics = text.CreateGraphics())
                { text.Size = Size.Truncate(graphics.MeasureString(text.Text, text.Font)); }


                findBlackPositon(text);
                text.Location = new Point(x, y);
                text.Padding = new Padding(0, 0, 0, 0);
                panel.Controls.Add(text);
            }
            void findBlackPositon(Label label)
            {
                x = 0;
                y = 0;
				int index = 0;
                for (int i = 0; i < labelPosList.Count; i++)
                {
                    Debug.Assert(y/19 < 5, "synergy tetx line over");

                    if (x + label.Size.Width > panel.Width)
                    {
                        y += labelPosList[i].size.Height;
                        x = 0;
                        continue;
                    }
                    if (labelPosList[i].pos.Y == y && !notCross(labelPosList[i], new Rect(new Point(x, y), label.Size)))
                    {
                        x = labelPosList[i].pos.X + labelPosList[i].size.Width + 10;
                       if (i != 0) i--;
						index++;
					}
                }
				labelPosList.Insert(index,new Rect(new Point(x, y), label.Size));
            }

            bool notCross(Rect r1, Rect r2)
            {
                return (r1.pos.X + r1.size.Width < r2.pos.X) || (r1.pos.X > r2.pos.X + r2.size.Width) ||
                    (r1.pos.Y + r1.size.Height < r2.pos.Y) || (r1.pos.Y > r2.pos.Y + r2.size.Height);
            }
		
		}

		public static void pickBoxClick(int tartgetIndex)
		{
			if (arrPickHeroPictureBox[tartgetIndex].box.Visible == false) return;
			clickBox(arrPickHeroPictureBox[tartgetIndex].hero);
		}


    }//end of class
}//end of namespace
