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
namespace loltochess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			SaveImage();
			inputPitureBoxData();
            inputLabelData();
			inputPictureBoxPickHero();
			DataManager.selectCountLabel = label_uiCountText;
			DataManager.resetButton = pictureBox_resetButton;
            DataManager.addMapPictureBoxList();
			DataManager.resetPictureBox();
            DataManager.addMapLabelList();
			
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			
        }

		#region Click mathod
		private void pictureBox_Lux1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_RekSai1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.RekSai);
		}

		private void pictureBox_Nocturne1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nocturne);
		}

		private void pictureBox_Malzahar1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Malzahar);
		}

		private void pictureBox_Veigar1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Veigar);
		}

		private void pictureBox_Sion1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Sion);
		}

		private void pictureBox_Kindred1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Kindred);
		}

		private void pictureBox_MasterYi1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.MasterYi);
		}

		private void pictureBox_Lux2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Taliyah1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Taliyah);
		}

		private void pictureBox_Qiyana1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Qiyana);
		}

		private void pictureBox_Malphite1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Malphite);
		}

		private void pictureBox_Yasuo1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Yasuo);
		}

		private void pictureBox_Aatrox1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Aatrox);
		}

		private void pictureBox_Sivir1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Sivir);
		}

		private void pictureBox_MasterYi2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.MasterYi);
		}

		private void pictureBox_Renekton1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Renekton);
		}

		private void pictureBox_Volibear1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Volibear);
		}

		private void pictureBox_Jax1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Jax);
		}

		private void pictureBox_DrMundo1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.DrMundo);
		}

		private void pictureBox_Sion2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Sion);
		}

		private void pictureBox_Olaf1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Olaf);
		}

		private void pictureBox_KogMaw1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.KogMaw);
		}

		private void pictureBox_DrMundo2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.DrMundo);
		}

		private void pictureBox_Twitch1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Twitch);
		}

		private void pictureBox_Singed1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Singed);
		}

		private void pictureBox_Vladimir1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Vladimir);
		}

		private void pictureBox_Syndra1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Syndra);
		}

		private void pictureBox_Thresh1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Thresh);
		}

		private void pictureBox_Nautilus1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nautilus);
		}

		private void pictureBox_Qiyana2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Qiyana);
		}

		private void pictureBox_Nami1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nami);
		}

		private void pictureBox_Lux3_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Ivern1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ivern);
		}

		private void pictureBox_Maokai1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Maokai);
		}

		private void pictureBox_Neeko1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Neeko);
		}

		private void pictureBox_Zyra1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Zyra);
		}

		private void pictureBox_Malzahar2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Malzahar);
		}

		private void pictureBox_Azir1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Azir);
		}

		private void pictureBox_Annie1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Annie);
		}

		private void pictureBox_Yorick1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Yorick);
		}

		private void pictureBox_Zed1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Zed);
		}

		private void pictureBox_Yasuo2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Yasuo);
		}

		private void pictureBox_Qiyana3_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Qiyana);
		}

		private void pictureBox_Janna1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Janna);
		}

		private void pictureBox_Lux4_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Warwick1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Warwick);
		}

		private void pictureBox_Volibear2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Volibear);
		}

		private void pictureBox_Braum1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Braum);
		}

		private void pictureBox_Ezreal1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ezreal);
		}

		private void pictureBox_Olaf2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Olaf);
		}

		private void pictureBox_Lux5_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Soraka1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Soraka);
		}

		private void pictureBox_Janna2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Janna);
		}

		private void pictureBox_Nami2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nami);
		}

		private void pictureBox_MasterYi3_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.MasterYi);
		}

		private void pictureBox_Diana1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Diana);
		}

		private void pictureBox_Leblanc1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Leblanc);
		}

		private void pictureBox_Nocturne2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nocturne);
		}

		private void pictureBox_Qiyana4_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Qiyana);
		}

		private void pictureBox_Khazix1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Khazix);
		}

		private void pictureBox_Zed2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Zed);
		}

		private void pictureBox_Nasus1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nasus);
		}

		private void pictureBox_Vayne1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Vayne);
		}

		private void pictureBox_Jax2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Jax);
		}

		private void pictureBox_Soraka2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Soraka);
		}

		private void pictureBox_Aatrox2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Aatrox);
		}

		private void pictureBox_Yorick2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Yorick);
		}

		private void pictureBox_Lux6_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Renekton2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Renekton);
		}

		private void pictureBox_Sivir2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Sivir);
		}

		private void pictureBox_Azir2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Azir);
		}

		private void pictureBox_Khazix2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Khazix);
		}

		private void pictureBox_Singed2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Singed);
		}

		private void pictureBox_Vladimir2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Vladimir);
		}

		private void pictureBox_Taliyah2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Taliyah);
		}

		private void pictureBox_Leblanc2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Leblanc);
		}

		private void pictureBox_Syndra2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Syndra);
		}

		private void pictureBox_Veigar2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Veigar);
		}

		private void pictureBox_Brand1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Brand);
		}

		private void pictureBox_Skarner1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Skarner);
		}

		private void pictureBox_Ashe1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ashe);
		}

		private void pictureBox_Taric1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Taric);
		}

		private void pictureBox_Lux7_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Maokai2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Maokai);
		}

		private void pictureBox_Ivern2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ivern);
		}

		private void pictureBox_Neeko2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Neeko);
		}

		private void pictureBox_Leblanc3_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Leblanc);
		}

		private void pictureBox_Lux8_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Vayne2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Vayne);
		}

		private void pictureBox_Varus1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Varus);
		}

		private void pictureBox_Ezreal2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ezreal);
		}

		private void pictureBox_Kindred2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Kindred);
		}

		private void pictureBox_Ashe2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ashe);
		}

		private void pictureBox_Twitch2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Twitch);
		}

		private void pictureBox_Nasus2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nasus);
		}

		private void pictureBox_Ornn1_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ornn);
		}

		private void pictureBox_Braum2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Braum);
		}

		private void pictureBox_Thresh2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Thresh);
		}

		private void pictureBox_Nautilus2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Nautilus);
		}

		private void pictureBox_Malphite2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Malphite);
		}

		private void pictureBox_Taric2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Taric);
		}

		private void pictureBox_Ornn2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Ornn);
		}

		private void pictureBox_Volibear3_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Volibear);
		}

		private void pictureBox_Zed3_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Zed);
		}

		private void pictureBox_Lux9_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Diana2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Diana);
		}

		private void pictureBox_Zyra2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Zyra);
		}

		private void pictureBox_Varus2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Varus);
		}

		private void pictureBox_Qiyana5_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Qiyana);
		}

		private void pictureBox_Kindred3_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Kindred);
		}

		private void pictureBox_Brand2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Brand);
		}

		private void pictureBox_Annie2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Annie);
		}

		private void pictureBox_Lux10_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		private void pictureBox_Warwick2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Warwick);
		}

		private void pictureBox_KogMaw2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.KogMaw);
		}

		private void pictureBox_RekSai2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.RekSai);
		}

		private void pictureBox_Skarner2_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Skarner);
		}

		private void pictureBox_Lux11_Click(object sender, EventArgs e)
		{
			DataManager.clickBox(eHero.Lux);
		}

		#endregion

		#region Hover nonHover
		private void RekSai_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.RekSai)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.RekSai);
		}

		private void RekSai_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.RekSai)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.RekSai);
		}

		private void Nocturne_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nocturne)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Nocturne);
		}

		private void Nocturne_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nocturne)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Nocturne);
		}

		private void Malzahar_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Malzahar)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Malzahar);
		}

		private void Malzahar_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Malzahar)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Malzahar);
		}

		private void Veigar_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Veigar)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Veigar);
		}

		private void Veigar_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Veigar)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Veigar);
		}

		private void Sion_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Sion)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Sion);
		}
		private void Sion_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Sion)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Sion);
		}

		private void Kindred_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Kindred)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Kindred);
		}

		private void Kindred_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Kindred)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Kindred);
		}

		private void MasterYi_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.MasterYi)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.MasterYi);
		}

		private void MasterYi_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.MasterYi)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.MasterYi);
		}

		private void Taliyah_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Taliyah)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Taliyah);
		}

		private void Taliyah_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Taliyah)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Taliyah);
		}

		private void Qiyana_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Qiyana)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Qiyana);
		}

		private void Qiyana_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Qiyana)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Qiyana);
		}

		private void Malphite_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Malphite)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Malphite);
		}
		private void Malphite_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Malphite)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Malphite);
		}

		private void Yasuo_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Yasuo)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Yasuo);
		}

		private void Yasuo_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Yasuo)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Yasuo);
		}

		private void Aatrox_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Aatrox)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Aatrox);
		}

		private void Aatrox_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Aatrox)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Aatrox);
		}

		private void Sivir_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Sivir)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Sivir);
		}

		private void Sivir_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Sivir)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Sivir);
		}

		private void Renkton_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Renekton)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Renekton);
		}

		private void Renekton_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Renekton)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Renekton);
		}

		private void Volibear_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Volibear)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Volibear);
		}
		private void Volibear_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Volibear)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Volibear);
		}

		private void Jax_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Jax)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Jax);
		}

		private void Jax_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Jax)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Jax);
		}

		private void DrMundo_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.DrMundo)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.DrMundo);
		}

		private void DrMundo_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.DrMundo)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.DrMundo);
		}

		private void Olaf_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Olaf)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Olaf);
		}

		private void Olaf_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Olaf)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Olaf);
		}

		private void KogMaw_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.KogMaw)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.KogMaw);
		}

		private void KogMaw_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.KogMaw)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.KogMaw);
		}

		private void Twitch_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Twitch)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Twitch);
		}

		private void Twitch_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Twitch)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Twitch);
		}

		private void Singed_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Singed)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Singed);
		}

		private void Singed_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Singed)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Singed);
		}

		private void Vladimir_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Vladimir)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Vladimir);
		}

		private void Vladimir_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Vladimir)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Vladimir);
		}

		private void Syndra_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Syndra)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Syndra);
		}

		private void Syndra_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Syndra)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Syndra);
		}

		private void Thresh_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Thresh)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Thresh);
		}

		private void Thresh_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Thresh)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Thresh);
		}

		private void Nautilus_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nautilus)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Nautilus);
		}

		private void Nautilus_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nautilus)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Nautilus);
		}

		private void Nami_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nami)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Nami);
		}

		private void Nami_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nami)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Nami);
		}

		private void Lux_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Lux)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Lux);
		}
		private void Lux_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Lux)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Lux);
		}

		private void Ivern_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ivern)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Ivern);
		}

		private void Ivern_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ivern)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Ivern);
		}

		private void Maokai_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Maokai)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Maokai);
		}

		private void Maokai_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Maokai)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Maokai);
		}

		private void Neeko_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Neeko)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Neeko);
		}

		private void Neeko_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Neeko)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Neeko);
		}

		private void Zyra_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Zyra)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Zyra);
		}

		private void Zyra_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Zyra)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Zyra);
		}

		private void Azir_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Azir)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Azir);
		}

		private void Azir_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Azir)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Azir);
		}

		private void Annie_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Annie)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Annie);
		}

		private void Annie_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Annie)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Annie);
		}

		private void Yorick_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Yorick)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Yorick);
		}

		private void Yorick_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Yorick)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Yorick);
		}

		private void Zed_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Zed)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Zed);
		}

		private void Zed_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Zed)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Zed);
		}

		private void Janna_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Janna)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Janna);
		}

		private void Janna_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Janna)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Janna);
		}

		private void Warwick_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Warwick)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Warwick);
		}

		private void Warwick_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Warwick)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Warwick);
		}

		private void Braum_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Braum)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Braum);
		}

		private void Braum_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Braum)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Braum);
		}

		private void Ezreal_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ezreal)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Ezreal);
		}

		private void Ezreal_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ezreal)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Ezreal);
		}

		private void Soraka_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Soraka)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Soraka);
		}

		private void Soraka_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Soraka)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Soraka);
		}

		private void Diana_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Diana)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Diana);
		}

		private void Diana_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Diana)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Diana);
		}

		private void Leblanc_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Leblanc)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Leblanc);
		}

		private void Leblanc_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Leblanc)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Leblanc);
		}

		private void Khazix_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Khazix)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Khazix);
		}

		private void Khazix_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Khazix)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Khazix);
		}

		private void Nasus_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nasus)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Nasus);
		}

		private void Nasus_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Nasus)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Nasus);
		}

		private void Vayne_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Vayne)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Vayne);
		}

		private void Vayne_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Vayne)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Vayne);
		}

		private void Brand_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Brand)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Brand);
		}

		private void Brand_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Brand)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Brand);
		}

		private void Skarner_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Skarner)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Skarner);
		}

		private void Skarner_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Skarner)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Skarner);
		}

		private void Ashe_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ashe)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Ashe);
		}

		private void Ashe_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ashe)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Ashe);
		}

		private void Taric_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Taric)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Taric);
		}
		private void Taric_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Taric)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Taric);
		}

		private void Varus_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Varus)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Varus);
		}

		private void Varus_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Varus)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Varus);
		}

		private void Ornn_onMouse(object sender, MouseEventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ornn)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.Hover, eHero.Ornn);
		}

		private void Ornn_leaveMouse(object sender, EventArgs e)
		{
			if (DataManager.getIsClick(eHero.Ornn)) return;
			var box = sender as PictureBox;
			if (box != null)
				box.Image = ImageManager.callImage(eImageState.None, eHero.Ornn);
		}




		#endregion

		private void pictureBox_resetButton_Click(object sender, EventArgs e)
		{
			DataManager.Reset();
			panel1.Controls.Clear();
		}

		private void nowSynergy(object sender, EventArgs e)
		{
            panel1.Controls.Clear();
            DataManager.PanelUpdate(panel1);
		}

		private void pictureBox_pick1_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(0);
		}

		private void pictureBox_pick2_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(1);

		}

		private void pictureBox_pick3_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(2);

		}

		private void pictureBox_pick4_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(3);

		}

		private void pictureBox_pick5_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(4);

		}

		private void pictureBox_pick6_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(5);

		}

		private void pictureBox_pick7_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(6);

		}

		private void pictureBox_pick8_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(7);

		}

		private void pictureBox_pick9_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(8);

		}

		private void pictureBox_pick10_Click(object sender, EventArgs e)
		{
			DataManager.pickBoxClick(9);

		}
	}//end of class
}//end of namespace
