using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum eHero
{
    Aatrox,
    Annie,
    Ashe,
    Azir,
    Brand,
    Braum,
    Diana,
    DrMundo,
    Ezreal,
    Ivern,
    Janna,
    Jax,
    Khazix,
    Kindred,
    KogMaw,
    Leblanc,
    Lux,
    Malphite,
    Malzahar,
    Maokai,
    MasterYi,
    Nami,
    Nasus,
    Nautilus,
    Neeko,
    Nocturne,
    Olaf,
    Ornn,
    Qiyana,
    RekSai,
    Renekton,
    Singed,
	Sion,
    Sivir,
    Skarner,
    Soraka,
    Syndra,
    Taliyah,
    Taric,
    Thresh,
    Twitch,
    Varus,
    Vayne,
    Veigar,
    Vladimir,
    Volibear,
    Warwick,
    Yasuo,
    Yorick,
    Zed,
    Zyra,

	Max,
}

[Flags]
public enum eSynergy
{
    Alchemist       = 1 << 0,
    Assassin        = 1 << 1,
    Avatar          = 1 << 2,
    Berserker       = 1 << 3,
    Blademaster     = 1 << 4,
    Crystal         = 1 << 5,
    Desert          = 1 << 6,
    Druid           = 1 << 7,
    Electric        = 1 << 8,
    Forest          = 1 << 9,
    Glacial         = 1 << 10,
    Inferno         = 1 << 11,
    Light           = 1 << 12,
    Mage            = 1 << 13,
    Mountain        = 1 << 14,
    Mystic          = 1 << 15,
    Ocean           = 1 << 16,
    Poison          = 1 << 17,
    Predator        = 1 << 18,
    Ranger          = 1 << 19,
    Shadow          = 1 << 20,
    Steel           = 1 << 21,
    Summoner        = 1 << 22,
    Warden          = 1 << 23,
    Wind            = 1 << 24,
}

enum eImageState
{
    None,
    Hover,
    Click,
}
