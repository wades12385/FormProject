using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace loltoChess.Manager
{
	static partial class DataManager
	{
		#region PictureBox List
		private static List<PictureBox> pictureAatrox = new List<PictureBox>();
		private static List<PictureBox> pictureAnnie = new List<PictureBox>();
		private static List<PictureBox> pictureAshe = new List<PictureBox>();
		private static List<PictureBox> pictureAzir = new List<PictureBox>();
		private static List<PictureBox> pictureBrand = new List<PictureBox>();
		private static List<PictureBox> pictureBraum = new List<PictureBox>();
		private static List<PictureBox> pictureDiana = new List<PictureBox>();
		private static List<PictureBox> pictureDrMundo = new List<PictureBox>();
		private static List<PictureBox> pictureEzreal = new List<PictureBox>();
		private static List<PictureBox> pictureIvern = new List<PictureBox>();
		private static List<PictureBox> pictureJanna = new List<PictureBox>();
		private static List<PictureBox> pictureJax = new List<PictureBox>();
		private static List<PictureBox> pictureKhazix = new List<PictureBox>();
		private static List<PictureBox> pictureKindred = new List<PictureBox>();
		private static List<PictureBox> pictureKogMaw = new List<PictureBox>();
		private static List<PictureBox> pictureLeblanc = new List<PictureBox>();
		private static List<PictureBox> pictureLux = new List<PictureBox>();
		private static List<PictureBox> pictureMalphite = new List<PictureBox>();
		private static List<PictureBox> pictureMalzahar = new List<PictureBox>();
		private static List<PictureBox> pictureMaokai = new List<PictureBox>();
		private static List<PictureBox> pictureMasterYi = new List<PictureBox>();
		private static List<PictureBox> pictureNami = new List<PictureBox>();
		private static List<PictureBox> pictureNasus = new List<PictureBox>();
		private static List<PictureBox> pictureNautilus = new List<PictureBox>();
		private static List<PictureBox> pictureNeeko = new List<PictureBox>();
		private static List<PictureBox> pictureNocturne = new List<PictureBox>();
		private static List<PictureBox> pictureOlaf = new List<PictureBox>();
		private static List<PictureBox> pictureOrnn = new List<PictureBox>();
		private static List<PictureBox> pictureQiyana = new List<PictureBox>();
		private static List<PictureBox> pictureRekSai = new List<PictureBox>();
		private static List<PictureBox> pictureRenekton = new List<PictureBox>();
		private static List<PictureBox> pictureSinged = new List<PictureBox>();
		private static List<PictureBox> pictureSion = new List<PictureBox>();
		private static List<PictureBox> pictureSivir = new List<PictureBox>();
		private static List<PictureBox> pictureSkarner = new List<PictureBox>();
		private static List<PictureBox> pictureSoraka = new List<PictureBox>();
		private static List<PictureBox> pictureSyndra = new List<PictureBox>();
		private static List<PictureBox> pictureTaliyah = new List<PictureBox>();
		private static List<PictureBox> pictureTaric = new List<PictureBox>();
		private static List<PictureBox> pictureThresh = new List<PictureBox>();
		private static List<PictureBox> pictureTwitch = new List<PictureBox>();
		private static List<PictureBox> pictureVarus = new List<PictureBox>();
		private static List<PictureBox> pictureVayne = new List<PictureBox>();
		private static List<PictureBox> pictureVeigar = new List<PictureBox>();
		private static List<PictureBox> pictureVladimir = new List<PictureBox>();
		private static List<PictureBox> pictureVolibear = new List<PictureBox>();
		private static List<PictureBox> pictureWarwick = new List<PictureBox>();
		private static List<PictureBox> pictureYasuo = new List<PictureBox>();
		private static List<PictureBox> pictureYorick = new List<PictureBox>();
		private static List<PictureBox> pictureZed = new List<PictureBox>();
		private static List<PictureBox> pictureZyra = new List<PictureBox>();
		#endregion

		#region synergy list
		private static List<Label> synergyOfAlchemistLabels = new List<Label>();
		private static List<Label> synergyOfAssassinLabels = new List<Label>();
		private static List<Label> synergyOfAvatarLabels = new List<Label>();
		private static List<Label> synergyOfBerserkerLabels = new List<Label>();
		private static List<Label> synergyOfBlademasterLabels = new List<Label>();
		private static List<Label> synergyOfCrystalLabels = new List<Label>();
		private static List<Label> synergyOfDesertLabels = new List<Label>();
		private static List<Label> synergyOfDruidLabels = new List<Label>();
		private static List<Label> synergyOfElectricLabels = new List<Label>();
		private static List<Label> synergyOfForestLabels = new List<Label>();
		private static List<Label> synergyOfGlacialLabels = new List<Label>();
		private static List<Label> synergyOfInfernoLabels = new List<Label>();
		private static List<Label> synergyOfLightLabels = new List<Label>();
		private static List<Label> synergyOfMageLabels = new List<Label>();
		private static List<Label> synergyOfMountainLabels = new List<Label>();
		private static List<Label> synergyOfMysticLabels = new List<Label>();
		private static List<Label> synergyOfOceanLabels = new List<Label>();
		private static List<Label> synergyOfPosionLabels = new List<Label>();
		private static List<Label> synergyOfPredatorLabels = new List<Label>();
		private static List<Label> synergyOfRangerLabels = new List<Label>();
		private static List<Label> synergyOfShadowLabels = new List<Label>();
		private static List<Label> synergyOfSteelLabels = new List<Label>();
		private static List<Label> synergyOfSummonerLabels = new List<Label>();
		private static List<Label> synergyOfWardenLabels = new List<Label>();
		private static List<Label> synergyOfWindLabels = new List<Label>();
		#endregion

		#region enum flag
		private static eSynergy flagAatrox;
		private static eSynergy flagAnnie;
		private static eSynergy flagAshe;
		private static eSynergy flagAzir;
		private static eSynergy flagBrand;
		private static eSynergy flagBraum;
		private static eSynergy flagDiana;
		private static eSynergy flagDrMundo;
		private static eSynergy flagEzreal;
		private static eSynergy flagIvern;
		private static eSynergy flagJanna;
		private static eSynergy flagJax;
		private static eSynergy flagKhazix;
		private static eSynergy flagKindred;
		private static eSynergy flagKogMaw;
		private static eSynergy flagLeblanc;
		private static eSynergy flagLux;
		private static eSynergy flagMalphite;
		private static eSynergy flagMalzahar;
		private static eSynergy flagMaokai;
		private static eSynergy flagMasterYi;
		private static eSynergy flagNami;
		private static eSynergy flagNasus;
		private static eSynergy flagNautilus;
		private static eSynergy flagNeeko;
		private static eSynergy flagNocturne;
		private static eSynergy flagOlaf;
		private static eSynergy flagOrnn;
		private static eSynergy flagQiyana;
		private static eSynergy flagRekSai;
		private static eSynergy flagRenekton;
		private static eSynergy flagSinged;
		private static eSynergy flagSion;
		private static eSynergy flagSivir;
		private static eSynergy flagSkarner;
		private static eSynergy flagSoraka;
		private static eSynergy flagSyndra;
		private static eSynergy flagTaliyah;
		private static eSynergy flagTaric;
		private static eSynergy flagThresh;
		private static eSynergy flagTwitch;
		private static eSynergy flagVarus;
		private static eSynergy flagVayne;
		private static eSynergy flagVeigar;
		private static eSynergy flagVladimir;
		private static eSynergy flagVolibear;
		private static eSynergy flagWarwick;
		private static eSynergy flagYasuo;
		private static eSynergy flagYorick;
		private static eSynergy flagZed;
		private static eSynergy flagZyra;
        #endregion

        public static bool getIsClick(eHero hero)
        {
            return mapPictureBoxData[hero].isClick;
        }
        public static void addLabelList(eSynergy synergy, Label label)
		{
			switch (synergy)
			{
				case eSynergy.Alchemist:
					synergyOfAlchemistLabels.Add(label);
					break;
				case eSynergy.Assassin:
					synergyOfAssassinLabels.Add(label);
					break;
				case eSynergy.Avatar:
					synergyOfAvatarLabels.Add(label);
					break;
				case eSynergy.Berserker:
					synergyOfBerserkerLabels.Add(label);
					break;
				case eSynergy.Blademaster:
					synergyOfBlademasterLabels.Add(label);
					break;
				case eSynergy.Crystal:
					synergyOfCrystalLabels.Add(label);
					break;
				case eSynergy.Desert:
					synergyOfDesertLabels.Add(label);
					break;
				case eSynergy.Druid:
					synergyOfDruidLabels.Add(label);
					break;
				case eSynergy.Electric:
					synergyOfElectricLabels.Add(label);
					break;
				case eSynergy.Forest:
					synergyOfForestLabels.Add(label);
					break;
				case eSynergy.Glacial:
					synergyOfGlacialLabels.Add(label);
					break;
				case eSynergy.Inferno:
					synergyOfInfernoLabels.Add(label);
					break;
				case eSynergy.Light:
					synergyOfLightLabels.Add(label);
					break;
				case eSynergy.Mage:
					synergyOfMageLabels.Add(label);
					break;
				case eSynergy.Mountain:
					synergyOfMountainLabels.Add(label);
					break;
				case eSynergy.Mystic:
					synergyOfMysticLabels.Add(label);
					break;
				case eSynergy.Ocean:
					synergyOfOceanLabels.Add(label);
					break;
				case eSynergy.Poison:
					synergyOfPosionLabels.Add(label);
					break;
				case eSynergy.Predator:
					synergyOfPredatorLabels.Add(label);
					break;
				case eSynergy.Ranger:
					synergyOfRangerLabels.Add(label);
					break;
				case eSynergy.Shadow:
					synergyOfShadowLabels.Add(label);
					break;
				case eSynergy.Steel:
					synergyOfSteelLabels.Add(label);
					break;
				case eSynergy.Summoner:
					synergyOfSummonerLabels.Add(label);
					break;
				case eSynergy.Warden:
					synergyOfWardenLabels.Add(label);
					break;
				case eSynergy.Wind:
					synergyOfWindLabels.Add(label);
					break;
				default:
					Debug.Assert(false, "synergy list input Error");
					break;
			}
		}

		private static void initMapSynergyData()
		{

			mapSynergyData.Add(eSynergy.Alchemist, new synergyData(new int[] { 1 }));

			mapSynergyData.Add(eSynergy.Assassin, new synergyData(new int[] { 3, 6 }));

			mapSynergyData.Add(eSynergy.Avatar, new synergyData(new int[] { 1 }));

			mapSynergyData.Add(eSynergy.Berserker, new synergyData(new int[] { 3, 6 }));

			mapSynergyData.Add(eSynergy.Blademaster, new synergyData(new int[] { 2, 4, 6 }));

			mapSynergyData.Add(eSynergy.Crystal, new synergyData(new int[] { 2, 4 }));

			mapSynergyData.Add(eSynergy.Desert, new synergyData(new int[] { 2, 4 }));

			mapSynergyData.Add(eSynergy.Druid, new synergyData(new int[] { 2 }));

			mapSynergyData.Add(eSynergy.Electric, new synergyData(new int[] { 2, 3, 4 }));

			mapSynergyData.Add(eSynergy.Forest, new synergyData(new int[] { 3 }));

			mapSynergyData.Add(eSynergy.Glacial, new synergyData(new int[] { 2, 4, 6 }));

			mapSynergyData.Add(eSynergy.Inferno, new synergyData(new int[] { 3, 6, 9 }));

			mapSynergyData.Add(eSynergy.Light, new synergyData(new int[] { 3, 6, 9 }));

			mapSynergyData.Add(eSynergy.Mage, new synergyData(new int[] { 3, 6 }));

			mapSynergyData.Add(eSynergy.Mountain, new synergyData(new int[] { 2 }));

			mapSynergyData.Add(eSynergy.Mystic, new synergyData(new int[] { 2, 4 }));

			mapSynergyData.Add(eSynergy.Ocean, new synergyData(new int[] { 2, 4, 6 }));

			mapSynergyData.Add(eSynergy.Poison, new synergyData(new int[] { 3 }));

			mapSynergyData.Add(eSynergy.Predator, new synergyData(new int[] { 3 }));

			mapSynergyData.Add(eSynergy.Ranger, new synergyData(new int[] { 2, 4, 6 }));

			mapSynergyData.Add(eSynergy.Shadow, new synergyData(new int[] { 2, 4 }));

			mapSynergyData.Add(eSynergy.Steel, new synergyData(new int[] { 2, 3, 4 }));

			mapSynergyData.Add(eSynergy.Summoner, new synergyData(new int[] { 3, 6 }));

			mapSynergyData.Add(eSynergy.Warden, new synergyData(new int[] { 2, 4, 6 }));

			mapSynergyData.Add(eSynergy.Wind, new synergyData(new int[] { 2, 3, 4 }));

		}

		private static void initEnumFlag()
		{
			flagAatrox = eSynergy.Light | eSynergy.Blademaster;
			flagAnnie = eSynergy.Inferno | eSynergy.Summoner;
			flagAshe = eSynergy.Crystal | eSynergy.Ranger;
			flagAzir = eSynergy.Desert | eSynergy.Summoner;
			flagBrand = eSynergy.Inferno | eSynergy.Mage;
			flagBraum = eSynergy.Glacial | eSynergy.Warden;
			flagDiana = eSynergy.Inferno | eSynergy.Assassin;
			flagDrMundo = eSynergy.Poison | eSynergy.Berserker;
			flagEzreal = eSynergy.Glacial | eSynergy.Ranger;
			flagIvern = eSynergy.Forest | eSynergy.Druid;
			flagJanna = eSynergy.Wind | eSynergy.Mystic;
			flagJax = eSynergy.Light | eSynergy.Berserker;
			flagKhazix = eSynergy.Desert | eSynergy.Assassin;
			flagKindred = eSynergy.Inferno | eSynergy.Shadow | eSynergy.Ranger;
			flagKogMaw = eSynergy.Poison | eSynergy.Predator;
			flagLeblanc = eSynergy.Forest | eSynergy.Assassin | eSynergy.Mage;
			flagMalphite = eSynergy.Mountain | eSynergy.Warden;
			flagMalzahar = eSynergy.Shadow | eSynergy.Summoner;
			flagMaokai = eSynergy.Forest | eSynergy.Druid;
			flagMasterYi = eSynergy.Shadow | eSynergy.Blademaster | eSynergy.Mystic;
			flagNami = eSynergy.Ocean | eSynergy.Mystic;
			flagNasus = eSynergy.Light | eSynergy.Warden;
			flagNautilus = eSynergy.Ocean | eSynergy.Warden;
			flagNeeko = eSynergy.Forest | eSynergy.Druid;
			flagNocturne = eSynergy.Steel | eSynergy.Assassin;
			flagOlaf = eSynergy.Glacial | eSynergy.Berserker;
			flagOrnn = eSynergy.Electric | eSynergy.Warden;
			flagRekSai = eSynergy.Steel | eSynergy.Predator;
			flagRenekton = eSynergy.Desert | eSynergy.Berserker;
			flagSinged = eSynergy.Poison | eSynergy.Alchemist;
			flagSion = eSynergy.Shadow | eSynergy.Berserker;
			flagSivir = eSynergy.Desert | eSynergy.Blademaster;
			flagSkarner = eSynergy.Crystal | eSynergy.Predator;
			flagSoraka = eSynergy.Light | eSynergy.Mystic;
			flagSyndra = eSynergy.Ocean | eSynergy.Mage;
			flagTaliyah = eSynergy.Mountain | eSynergy.Mage;
			flagTaric = eSynergy.Crystal | eSynergy.Warden;
			flagThresh = eSynergy.Ocean | eSynergy.Warden;
			flagTwitch = eSynergy.Poison | eSynergy.Ranger;
			flagVarus = eSynergy.Inferno | eSynergy.Ranger;
			flagVayne = eSynergy.Light | eSynergy.Ranger;
			flagVeigar = eSynergy.Shadow | eSynergy.Mage;
			flagVladimir = eSynergy.Ocean | eSynergy.Mage;
			flagVolibear = eSynergy.Electric | eSynergy.Glacial | eSynergy.Berserker;
			flagWarwick = eSynergy.Glacial | eSynergy.Predator;
			flagYasuo = eSynergy.Wind | eSynergy.Blademaster;
			flagYorick = eSynergy.Light | eSynergy.Summoner;
			flagZed = eSynergy.Electric | eSynergy.Assassin | eSynergy.Summoner;
			flagZyra = eSynergy.Inferno | eSynergy.Summoner;
			flagQiyana = eSynergy.Mountain | eSynergy.Ocean | eSynergy.Wind | eSynergy.Inferno | eSynergy.Assassin;
			flagLux = eSynergy.Steel | eSynergy.Shadow | eSynergy.Ocean | eSynergy.Wind | eSynergy.Glacial | eSynergy.Light | eSynergy.Crystal |
					   eSynergy.Forest | eSynergy.Electric | eSynergy.Inferno | eSynergy.Avatar;
		}

		private static void controlSysnergyData(eHero hero, bool isClick)
		{
			switch (hero)
			{
				case eHero.Aatrox:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagAatrox & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Annie:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagAnnie & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Ashe:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagAshe & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Azir:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagAzir & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Brand:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagBrand & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Braum:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagBraum & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Diana:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagDiana & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.DrMundo:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagDrMundo & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Ezreal:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagEzreal & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Ivern:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagIvern & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Janna:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagJanna & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Jax:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagJax & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Khazix:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagKhazix & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Kindred:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagKindred & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.KogMaw:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagKogMaw & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Leblanc:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagLeblanc & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Lux:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagLux & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Malphite:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagMalphite & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Malzahar:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagMalzahar & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Maokai:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagMaokai & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.MasterYi:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagMasterYi & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Nami:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagNami & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Nasus:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagNasus & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Nautilus:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagNautilus & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Neeko:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagNeeko & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Nocturne:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagNocturne & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Olaf:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagOlaf & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Ornn:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagOrnn & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Qiyana:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagQiyana & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.RekSai:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagRekSai & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Renekton:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagRenekton & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Singed:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagSinged & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Sion:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagSion & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Sivir:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagSivir & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Skarner:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagSkarner & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Soraka:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagSoraka & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Syndra:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagSyndra & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Taliyah:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagTaliyah & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Taric:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagTaric & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Thresh:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagThresh & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Twitch:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagTwitch & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Varus:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagVarus & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Vayne:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagVayne & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Veigar:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagVeigar & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Vladimir:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagVladimir & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Volibear:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagVolibear & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Warwick:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagWarwick & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Yasuo:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagYasuo & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Yorick:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagYorick & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Zed:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagZed & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				case eHero.Zyra:
					foreach (eSynergy val in Enum.GetValues(typeof(eSynergy)))
					{
						if ((flagZyra & val) != 0)
						{
							if (isClick)
								mapSynergyData[val].count++;
							else
								mapSynergyData[val].count--;
						}
					}
					break;
				default:
					Debug.Assert(false, "controlSysnergy Error");
					break;
			}

		}

		public static void addMapPictureBoxList() // inputPitureBoxData() 가 끝난 다음에 실행
		{
			mapPictureBoxList.Add(eHero.Aatrox, pictureAatrox);
			mapPictureBoxList.Add(eHero.Annie, pictureAnnie);
			mapPictureBoxList.Add(eHero.Ashe, pictureAshe);
			mapPictureBoxList.Add(eHero.Azir, pictureAzir);
			mapPictureBoxList.Add(eHero.Brand, pictureBrand);
			mapPictureBoxList.Add(eHero.Braum, pictureBraum);
			mapPictureBoxList.Add(eHero.Diana, pictureDiana);
			mapPictureBoxList.Add(eHero.DrMundo, pictureDrMundo);
			mapPictureBoxList.Add(eHero.Ezreal, pictureEzreal);
			mapPictureBoxList.Add(eHero.Ivern, pictureIvern);
			mapPictureBoxList.Add(eHero.Janna, pictureJanna);
			mapPictureBoxList.Add(eHero.Jax, pictureJax);
			mapPictureBoxList.Add(eHero.Khazix, pictureKhazix);
			mapPictureBoxList.Add(eHero.Kindred, pictureKindred);
			mapPictureBoxList.Add(eHero.KogMaw, pictureKogMaw);
			mapPictureBoxList.Add(eHero.Leblanc, pictureLeblanc);
			mapPictureBoxList.Add(eHero.Lux, pictureLux);
			mapPictureBoxList.Add(eHero.Malphite, pictureMalphite);
			mapPictureBoxList.Add(eHero.Malzahar, pictureMalzahar);
			mapPictureBoxList.Add(eHero.Maokai, pictureMaokai);
			mapPictureBoxList.Add(eHero.MasterYi, pictureMasterYi);
			mapPictureBoxList.Add(eHero.Nami, pictureNami);
			mapPictureBoxList.Add(eHero.Nasus, pictureNasus);
			mapPictureBoxList.Add(eHero.Nautilus, pictureNautilus);
			mapPictureBoxList.Add(eHero.Neeko, pictureNeeko);
			mapPictureBoxList.Add(eHero.Nocturne, pictureNocturne);
			mapPictureBoxList.Add(eHero.Olaf, pictureOlaf);
			mapPictureBoxList.Add(eHero.Ornn, pictureOrnn);
			mapPictureBoxList.Add(eHero.Qiyana, pictureQiyana);
			mapPictureBoxList.Add(eHero.RekSai, pictureRekSai);
			mapPictureBoxList.Add(eHero.Renekton, pictureRenekton);
			mapPictureBoxList.Add(eHero.Singed, pictureSinged);
			mapPictureBoxList.Add(eHero.Sion, pictureSion);
			mapPictureBoxList.Add(eHero.Sivir, pictureSivir);
			mapPictureBoxList.Add(eHero.Skarner, pictureSkarner);
			mapPictureBoxList.Add(eHero.Soraka, pictureSoraka);
			mapPictureBoxList.Add(eHero.Syndra, pictureSyndra);
			mapPictureBoxList.Add(eHero.Taliyah, pictureTaliyah);
			mapPictureBoxList.Add(eHero.Taric, pictureTaric);
			mapPictureBoxList.Add(eHero.Thresh, pictureThresh);
			mapPictureBoxList.Add(eHero.Twitch, pictureTwitch);
			mapPictureBoxList.Add(eHero.Varus, pictureVarus);
			mapPictureBoxList.Add(eHero.Vayne, pictureVayne);
			mapPictureBoxList.Add(eHero.Veigar, pictureVeigar);
			mapPictureBoxList.Add(eHero.Vladimir, pictureVladimir);
			mapPictureBoxList.Add(eHero.Volibear, pictureVolibear);
			mapPictureBoxList.Add(eHero.Warwick, pictureWarwick);
			mapPictureBoxList.Add(eHero.Yasuo, pictureYasuo);
			mapPictureBoxList.Add(eHero.Yorick, pictureYorick);
			mapPictureBoxList.Add(eHero.Zed, pictureZed);
			mapPictureBoxList.Add(eHero.Zyra, pictureZyra);
		}

		public static void addMapLabelList()
		{
			mapSynergyLabelList.Add(eSynergy.Alchemist, synergyOfAlchemistLabels);
			mapSynergyLabelList.Add(eSynergy.Assassin, synergyOfAssassinLabels);
			mapSynergyLabelList.Add(eSynergy.Avatar, synergyOfAvatarLabels);
			mapSynergyLabelList.Add(eSynergy.Berserker, synergyOfBerserkerLabels);
			mapSynergyLabelList.Add(eSynergy.Blademaster, synergyOfBlademasterLabels);
			mapSynergyLabelList.Add(eSynergy.Crystal, synergyOfCrystalLabels);
			mapSynergyLabelList.Add(eSynergy.Desert, synergyOfDesertLabels);
			mapSynergyLabelList.Add(eSynergy.Druid, synergyOfDruidLabels);
			mapSynergyLabelList.Add(eSynergy.Electric, synergyOfElectricLabels);
			mapSynergyLabelList.Add(eSynergy.Forest, synergyOfForestLabels);
			mapSynergyLabelList.Add(eSynergy.Glacial, synergyOfGlacialLabels);
			mapSynergyLabelList.Add(eSynergy.Inferno, synergyOfInfernoLabels);
			mapSynergyLabelList.Add(eSynergy.Light, synergyOfLightLabels);
			mapSynergyLabelList.Add(eSynergy.Mage, synergyOfMageLabels);
			mapSynergyLabelList.Add(eSynergy.Mountain, synergyOfMountainLabels);
			mapSynergyLabelList.Add(eSynergy.Mystic, synergyOfMysticLabels);
			mapSynergyLabelList.Add(eSynergy.Ocean, synergyOfOceanLabels);
			mapSynergyLabelList.Add(eSynergy.Poison, synergyOfPosionLabels);
			mapSynergyLabelList.Add(eSynergy.Predator, synergyOfPredatorLabels);
			mapSynergyLabelList.Add(eSynergy.Ranger, synergyOfRangerLabels);
			mapSynergyLabelList.Add(eSynergy.Shadow, synergyOfShadowLabels);
			mapSynergyLabelList.Add(eSynergy.Steel, synergyOfSteelLabels);
			mapSynergyLabelList.Add(eSynergy.Summoner, synergyOfSummonerLabels);
			mapSynergyLabelList.Add(eSynergy.Warden, synergyOfWardenLabels);
			mapSynergyLabelList.Add(eSynergy.Wind, synergyOfWindLabels);
		}

		public static void addarrPickHero(boxData box)
		{
			arrPickHeroPictureBox.Add(box);
		}
	}
}
