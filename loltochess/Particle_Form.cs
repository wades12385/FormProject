using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loltoChess.Manager;
using System.Windows.Forms;

namespace loltochess
{
	public partial class Form1
	{
		void SaveImage()
		{
			ImageManager.addImage(eHero.Aatrox,		pictureBox_Aatrox1.Image);
			ImageManager.addImage(eHero.Annie,		pictureBox_Annie1.Image);
			ImageManager.addImage(eHero.Ashe,		pictureBox_Ashe1.Image);
			ImageManager.addImage(eHero.Azir,		pictureBox_Azir1.Image);
			ImageManager.addImage(eHero.Brand,		pictureBox_Brand1.Image);
			ImageManager.addImage(eHero.Braum,		pictureBox_Braum1.Image);
			ImageManager.addImage(eHero.Diana,		pictureBox_Diana1.Image);
			ImageManager.addImage(eHero.DrMundo,	pictureBox_DrMundo1.Image);
			ImageManager.addImage(eHero.Ezreal,		pictureBox_Ezreal1.Image);
			ImageManager.addImage(eHero.Ivern,		pictureBox_Ivern1.Image);
			ImageManager.addImage(eHero.Janna,		pictureBox_Janna1.Image);
			ImageManager.addImage(eHero.Jax,		pictureBox_Jax1.Image);
			ImageManager.addImage(eHero.Khazix,		pictureBox_Khazix1.Image);
			ImageManager.addImage(eHero.Kindred,	pictureBox_Kindred1.Image);
			ImageManager.addImage(eHero.KogMaw,		pictureBox_KogMaw1.Image);
			ImageManager.addImage(eHero.Leblanc,	pictureBox_Leblanc1.Image);
			ImageManager.addImage(eHero.Lux,		pictureBox_Lux1.Image);
			ImageManager.addImage(eHero.Malphite,	pictureBox_Malphite1.Image);
			ImageManager.addImage(eHero.Malzahar,	pictureBox_Malzahar1.Image);
			ImageManager.addImage(eHero.Maokai,		pictureBox_Maokai1.Image);
			ImageManager.addImage(eHero.MasterYi,   pictureBox_MasterYi1.Image);
			ImageManager.addImage(eHero.Nami,		pictureBox_Nami1.Image);
			ImageManager.addImage(eHero.Nasus,		pictureBox_Nasus1.Image);
			ImageManager.addImage(eHero.Nautilus,	pictureBox_Nautilus1.Image);
			ImageManager.addImage(eHero.Neeko,		pictureBox_Neeko1.Image);
			ImageManager.addImage(eHero.Nocturne,	pictureBox_Nocturne1.Image);
			ImageManager.addImage(eHero.Olaf,		pictureBox_Olaf1.Image);
			ImageManager.addImage(eHero.Ornn,	    pictureBox_Ornn1.Image);
			ImageManager.addImage(eHero.Qiyana,		pictureBox_Qiyana1.Image);
			ImageManager.addImage(eHero.RekSai,		pictureBox_RekSai1.Image);
			ImageManager.addImage(eHero.Renekton,	pictureBox_Renekton1.Image);
			ImageManager.addImage(eHero.Singed,		pictureBox_Singed1.Image);
			ImageManager.addImage(eHero.Sion,	    pictureBox_Sion1.Image);
			ImageManager.addImage(eHero.Sivir,	    pictureBox_Sivir1.Image);
			ImageManager.addImage(eHero.Skarner,	pictureBox_Skarner1.Image);
			ImageManager.addImage(eHero.Soraka,		pictureBox_Soraka1.Image);
			ImageManager.addImage(eHero.Syndra,		pictureBox_Syndra1.Image);
			ImageManager.addImage(eHero.Taliyah,	pictureBox_Taliyah1.Image);
			ImageManager.addImage(eHero.Taric,		pictureBox_Taric1.Image);
			ImageManager.addImage(eHero.Thresh,	    pictureBox_Thresh1.Image);
			ImageManager.addImage(eHero.Twitch,     pictureBox_Twitch1.Image);
			ImageManager.addImage(eHero.Varus,	    pictureBox_Varus1.Image);
			ImageManager.addImage(eHero.Vayne,		pictureBox_Vayne1.Image);
			ImageManager.addImage(eHero.Veigar,		pictureBox_Veigar1.Image);
			ImageManager.addImage(eHero.Vladimir,   pictureBox_Vladimir1.Image);
			ImageManager.addImage(eHero.Volibear,   pictureBox_Volibear1.Image);
			ImageManager.addImage(eHero.Warwick,    pictureBox_Warwick1.Image);
			ImageManager.addImage(eHero.Yasuo,      pictureBox_Yasuo1.Image);
			ImageManager.addImage(eHero.Yorick,		pictureBox_Yorick1.Image);
			ImageManager.addImage(eHero.Zed,		pictureBox_Zed1.Image);
			ImageManager.addImage(eHero.Zyra,		pictureBox_Zyra1.Image);
		}

		void inputPitureBoxData()
		{
			DataManager.addPictureBoxList(eHero.Aatrox, pictureBox_Aatrox1);
			DataManager.addPictureBoxList(eHero.Aatrox, pictureBox_Aatrox2);

			DataManager.addPictureBoxList(eHero.Annie, pictureBox_Annie1);
			DataManager.addPictureBoxList(eHero.Annie, pictureBox_Annie2);

			DataManager.addPictureBoxList(eHero.Ashe, pictureBox_Ashe1);
			DataManager.addPictureBoxList(eHero.Ashe, pictureBox_Ashe2);

			DataManager.addPictureBoxList(eHero.Azir, pictureBox_Azir1);
			DataManager.addPictureBoxList(eHero.Azir, pictureBox_Azir2);

			DataManager.addPictureBoxList(eHero.Brand, pictureBox_Brand1);
			DataManager.addPictureBoxList(eHero.Brand, pictureBox_Brand2);

			DataManager.addPictureBoxList(eHero.Braum, pictureBox_Braum1);
			DataManager.addPictureBoxList(eHero.Braum, pictureBox_Braum2);

			DataManager.addPictureBoxList(eHero.Diana, pictureBox_Diana1);
			DataManager.addPictureBoxList(eHero.Diana, pictureBox_Diana2);

			DataManager.addPictureBoxList(eHero.DrMundo, pictureBox_DrMundo1);
			DataManager.addPictureBoxList(eHero.DrMundo, pictureBox_DrMundo2);

			DataManager.addPictureBoxList(eHero.Ezreal, pictureBox_Ezreal1);
			DataManager.addPictureBoxList(eHero.Ezreal, pictureBox_Ezreal2);

			DataManager.addPictureBoxList(eHero.Ivern, pictureBox_Ivern1);
			DataManager.addPictureBoxList(eHero.Ivern, pictureBox_Ivern2);

			DataManager.addPictureBoxList(eHero.Janna, pictureBox_Janna1);
			DataManager.addPictureBoxList(eHero.Janna, pictureBox_Janna2);

			DataManager.addPictureBoxList(eHero.Jax, pictureBox_Jax1);
			DataManager.addPictureBoxList(eHero.Jax, pictureBox_Jax2);

			DataManager.addPictureBoxList(eHero.Khazix, pictureBox_Khazix1);
			DataManager.addPictureBoxList(eHero.Khazix, pictureBox_Khazix2);

			DataManager.addPictureBoxList(eHero.Kindred, pictureBox_Kindred1);
			DataManager.addPictureBoxList(eHero.Kindred, pictureBox_Kindred2);
			DataManager.addPictureBoxList(eHero.Kindred, pictureBox_Kindred3);

			DataManager.addPictureBoxList(eHero.KogMaw, pictureBox_KogMaw1);
			DataManager.addPictureBoxList(eHero.KogMaw, pictureBox_KogMaw2);

			DataManager.addPictureBoxList(eHero.Leblanc, pictureBox_Leblanc1);
			DataManager.addPictureBoxList(eHero.Leblanc, pictureBox_Leblanc2);
			DataManager.addPictureBoxList(eHero.Leblanc, pictureBox_Leblanc3);

			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux1);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux2);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux3);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux4);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux5);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux6);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux7);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux8);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux9);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux10);
			DataManager.addPictureBoxList(eHero.Lux, pictureBox_Lux11);

			DataManager.addPictureBoxList(eHero.Malphite, pictureBox_Malphite1);
			DataManager.addPictureBoxList(eHero.Malphite, pictureBox_Malphite2);

			DataManager.addPictureBoxList(eHero.Malzahar, pictureBox_Malzahar1);
			DataManager.addPictureBoxList(eHero.Malzahar, pictureBox_Malzahar2);

			DataManager.addPictureBoxList(eHero.Maokai, pictureBox_Maokai1);
			DataManager.addPictureBoxList(eHero.Maokai, pictureBox_Maokai2);

			DataManager.addPictureBoxList(eHero.MasterYi, pictureBox_MasterYi1);
			DataManager.addPictureBoxList(eHero.MasterYi, pictureBox_MasterYi2);
			DataManager.addPictureBoxList(eHero.MasterYi, pictureBox_MasterYi3);

			DataManager.addPictureBoxList(eHero.Nami, pictureBox_Nami1);
			DataManager.addPictureBoxList(eHero.Nami, pictureBox_Nami2);

			DataManager.addPictureBoxList(eHero.Nasus, pictureBox_Nasus1);
			DataManager.addPictureBoxList(eHero.Nasus, pictureBox_Nasus2);

			DataManager.addPictureBoxList(eHero.Nautilus, pictureBox_Nautilus1);
			DataManager.addPictureBoxList(eHero.Nautilus, pictureBox_Nautilus2);

			DataManager.addPictureBoxList(eHero.Neeko, pictureBox_Neeko1);
			DataManager.addPictureBoxList(eHero.Neeko, pictureBox_Neeko2);

			DataManager.addPictureBoxList(eHero.Nocturne, pictureBox_Nocturne1);
			DataManager.addPictureBoxList(eHero.Nocturne, pictureBox_Nocturne2);

			DataManager.addPictureBoxList(eHero.Olaf, pictureBox_Olaf1);
			DataManager.addPictureBoxList(eHero.Olaf, pictureBox_Olaf2);

			DataManager.addPictureBoxList(eHero.Ornn, pictureBox_Ornn1);
			DataManager.addPictureBoxList(eHero.Ornn, pictureBox_Ornn2);

			DataManager.addPictureBoxList(eHero.Qiyana, pictureBox_Qiyana1);
			DataManager.addPictureBoxList(eHero.Qiyana, pictureBox_Qiyana2);
			DataManager.addPictureBoxList(eHero.Qiyana, pictureBox_Qiyana3);
			DataManager.addPictureBoxList(eHero.Qiyana, pictureBox_Qiyana4);
			DataManager.addPictureBoxList(eHero.Qiyana, pictureBox_Qiyana5);

			DataManager.addPictureBoxList(eHero.RekSai, pictureBox_RekSai1);
			DataManager.addPictureBoxList(eHero.RekSai, pictureBox_RekSai2);

			DataManager.addPictureBoxList(eHero.Renekton, pictureBox_Renekton1);
			DataManager.addPictureBoxList(eHero.Renekton, pictureBox_Renekton2);

			DataManager.addPictureBoxList(eHero.Singed, pictureBox_Singed1);
			DataManager.addPictureBoxList(eHero.Singed, pictureBox_Singed2);

			DataManager.addPictureBoxList(eHero.Sion, pictureBox_Sion1);
			DataManager.addPictureBoxList(eHero.Sion, pictureBox_Sion2);

			DataManager.addPictureBoxList(eHero.Sivir, pictureBox_Sivir1);
			DataManager.addPictureBoxList(eHero.Sivir, pictureBox_Sivir2);

			DataManager.addPictureBoxList(eHero.Skarner, pictureBox_Skarner1);
			DataManager.addPictureBoxList(eHero.Skarner, pictureBox_Skarner2);

			DataManager.addPictureBoxList(eHero.Soraka, pictureBox_Soraka1);
			DataManager.addPictureBoxList(eHero.Soraka, pictureBox_Soraka2);

			DataManager.addPictureBoxList(eHero.Syndra, pictureBox_Syndra1);
			DataManager.addPictureBoxList(eHero.Syndra, pictureBox_Syndra2);


			DataManager.addPictureBoxList(eHero.Taliyah, pictureBox_Taliyah1);
			DataManager.addPictureBoxList(eHero.Taliyah, pictureBox_Taliyah2);

			DataManager.addPictureBoxList(eHero.Taric, pictureBox_Taric1);
			DataManager.addPictureBoxList(eHero.Taric, pictureBox_Taric2);

			DataManager.addPictureBoxList(eHero.Thresh, pictureBox_Thresh1);
			DataManager.addPictureBoxList(eHero.Thresh, pictureBox_Thresh2);

			DataManager.addPictureBoxList(eHero.Twitch, pictureBox_Twitch1);
			DataManager.addPictureBoxList(eHero.Twitch, pictureBox_Twitch2);

			DataManager.addPictureBoxList(eHero.Varus, pictureBox_Varus1);
			DataManager.addPictureBoxList(eHero.Varus, pictureBox_Varus2);

			DataManager.addPictureBoxList(eHero.Vayne, pictureBox_Vayne1);
			DataManager.addPictureBoxList(eHero.Vayne, pictureBox_Vayne2);

			DataManager.addPictureBoxList(eHero.Veigar, pictureBox_Veigar1);
			DataManager.addPictureBoxList(eHero.Veigar, pictureBox_Veigar1);

			DataManager.addPictureBoxList(eHero.Vladimir, pictureBox_Vladimir1);
			DataManager.addPictureBoxList(eHero.Vladimir, pictureBox_Vladimir2);

			DataManager.addPictureBoxList(eHero.Volibear, pictureBox_Volibear1);
			DataManager.addPictureBoxList(eHero.Volibear, pictureBox_Volibear2);
			DataManager.addPictureBoxList(eHero.Volibear, pictureBox_Volibear3);

			DataManager.addPictureBoxList(eHero.Warwick, pictureBox_Warwick1);
			DataManager.addPictureBoxList(eHero.Warwick, pictureBox_Warwick2);

			DataManager.addPictureBoxList(eHero.Yasuo, pictureBox_Yasuo1);
			DataManager.addPictureBoxList(eHero.Yasuo, pictureBox_Yasuo2);

			DataManager.addPictureBoxList(eHero.Yorick, pictureBox_Yorick1);
			DataManager.addPictureBoxList(eHero.Yorick, pictureBox_Yorick2);

			DataManager.addPictureBoxList(eHero.Zed, pictureBox_Zed1);
			DataManager.addPictureBoxList(eHero.Zed, pictureBox_Zed2);
			DataManager.addPictureBoxList(eHero.Zed, pictureBox_Zed3);

			DataManager.addPictureBoxList(eHero.Zyra, pictureBox_Zyra1);
			DataManager.addPictureBoxList(eHero.Zyra, pictureBox_Zyra2);
		}

        void inputLabelData()
        {
            DataManager.addLabelList(eSynergy.Alchemist, label_Alchemist_1);

            DataManager.addLabelList(eSynergy.Assassin, label_Assassin_3);
            DataManager.addLabelList(eSynergy.Assassin, label_Assassin_6);

            DataManager.addLabelList(eSynergy.Avatar, label_Avatar_1);

            DataManager.addLabelList(eSynergy.Berserker, label_Berserker_3);
            DataManager.addLabelList(eSynergy.Berserker, label_Berserker_6);

            DataManager.addLabelList(eSynergy.Blademaster, label_Blademaster_2);
            DataManager.addLabelList(eSynergy.Blademaster, label_Blademaster_4);
            DataManager.addLabelList(eSynergy.Blademaster, label_Blademaster_6);

            DataManager.addLabelList(eSynergy.Crystal, label_Crystal_2);
            DataManager.addLabelList(eSynergy.Crystal, label_Crystal_4);

            DataManager.addLabelList(eSynergy.Desert, label_Desert_2);
            DataManager.addLabelList(eSynergy.Desert, label_Desert_4);

            DataManager.addLabelList(eSynergy.Druid, label_Druid_2);

            DataManager.addLabelList(eSynergy.Electric, label_Electric_2);
            DataManager.addLabelList(eSynergy.Electric, label_Electric_3);
            DataManager.addLabelList(eSynergy.Electric, label_Electric_4);

            DataManager.addLabelList(eSynergy.Forest, label_Forest_3);

            DataManager.addLabelList(eSynergy.Glacial, label_Glacial_2);
            DataManager.addLabelList(eSynergy.Glacial, label_Glacial_4);
            DataManager.addLabelList(eSynergy.Glacial, label_Glacial_6);

            DataManager.addLabelList(eSynergy.Inferno, label_Inferno_3);
            DataManager.addLabelList(eSynergy.Inferno, label_Inferno_6);
            DataManager.addLabelList(eSynergy.Inferno, label_Inferno_9);

            DataManager.addLabelList(eSynergy.Light, label_Light_3);
            DataManager.addLabelList(eSynergy.Light, label_Light_6);
            DataManager.addLabelList(eSynergy.Light, label_Light_9);

            DataManager.addLabelList(eSynergy.Mage, label_Mage_3);
            DataManager.addLabelList(eSynergy.Mage, label_Mage_6);

            DataManager.addLabelList(eSynergy.Mountain, label_Mountain_2);

            DataManager.addLabelList(eSynergy.Mystic, label_Mystic_2);
            DataManager.addLabelList(eSynergy.Mystic, label_Mystic_4);

            DataManager.addLabelList(eSynergy.Ocean, label_Ocean_2);
            DataManager.addLabelList(eSynergy.Ocean, label_Ocean_4);
            DataManager.addLabelList(eSynergy.Ocean, label_Ocean_6);

            DataManager.addLabelList(eSynergy.Poison, label_Posion_3);

            DataManager.addLabelList(eSynergy.Predator, label_Predator_3);

            DataManager.addLabelList(eSynergy.Ranger, label_Ranger_2);
            DataManager.addLabelList(eSynergy.Ranger, label_Ranger_4);
            DataManager.addLabelList(eSynergy.Ranger, label_Ranger_6);

            DataManager.addLabelList(eSynergy.Shadow, label_Shadow_2);
            DataManager.addLabelList(eSynergy.Shadow, label_Shadow_4);

            DataManager.addLabelList(eSynergy.Steel, label_Steel_2);
            DataManager.addLabelList(eSynergy.Steel, label_Steel_3);
            DataManager.addLabelList(eSynergy.Steel, label_Steel_4);

            DataManager.addLabelList(eSynergy.Summoner, label_Summoner_3);
            DataManager.addLabelList(eSynergy.Summoner, label_Summoner_6);

            DataManager.addLabelList(eSynergy.Warden, label_Warden_2);
            DataManager.addLabelList(eSynergy.Warden, label_Warden_4);
            DataManager.addLabelList(eSynergy.Warden, label_Warden_6);

            DataManager.addLabelList(eSynergy.Wind, label_Wind_2);
            DataManager.addLabelList(eSynergy.Wind, label_Wind_3);
            DataManager.addLabelList(eSynergy.Wind, label_Wind_4);
        }
		
		void inputPictureBoxPickHero()
		{
			DataManager.addarrPickHero(new boxData( pictureBox_pick1));
			DataManager.addarrPickHero(new boxData( pictureBox_pick2));
			DataManager.addarrPickHero(new boxData( pictureBox_pick3));
			DataManager.addarrPickHero(new boxData( pictureBox_pick4));
			DataManager.addarrPickHero(new boxData( pictureBox_pick5));
			DataManager.addarrPickHero(new boxData( pictureBox_pick6));
			DataManager.addarrPickHero(new boxData( pictureBox_pick7));
			DataManager.addarrPickHero(new boxData( pictureBox_pick8));
			DataManager.addarrPickHero(new boxData( pictureBox_pick9));
			DataManager.addarrPickHero(new boxData( pictureBox_pick10));
		}
	}//end of calss
}//end fo namespace
