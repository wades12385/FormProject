using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
namespace loltoChess.Manager
{
    //이미지만 다뤄야하고 
    //저장과 호출용도로  
    static class ImageManager
    {
		//1 원본 (클릭시) , 2 아무상호작용 안된 상태 3, 마우스 호버 
        private static Dictionary<eHero, Image> originalImage = new Dictionary<eHero, Image>();
        private static Dictionary<eHero, Image> inactiveImage = new Dictionary<eHero, Image>();
        private static Dictionary<eHero, Image> hoverImage = new Dictionary<eHero, Image>();

        public static void addImage(eHero hero, Image sender)
        {
            originalImage.Add(hero, sender);
            inactiveImage.Add(hero,
                AdjustBitmapBrightness(originalImage[hero], -70)
                );
            hoverImage.Add(hero,
                AdjustBitmapBrightness(originalImage[hero], -20)
                );
        }

        public static Image callImage(eImageState state, eHero hero)
        {
            Image Sender;
            Sender = originalImage[hero]; // 컴파일 에러 방지용 

            switch (state)
            {
                case eImageState.None:
                    Sender = inactiveImage[hero];
                    break;
                case eImageState.Hover:
                    Sender = hoverImage[hero];
                    break;
                case eImageState.Click:
                    Sender = originalImage[hero];
                    break;
                default:
                    Debug.Assert(false, "callImage Error");
                    break;
            }
            return Sender;
        }


        //명도 조절 메서드 
        public static Bitmap AdjustBitmapBrightness(Image sourceImage, int brightness)
        {
            Bitmap targetBitmap = new Bitmap(sourceImage);
            Color color;
            int r;
            int g;
            int b;
            for (int y = 0; y < targetBitmap.Height; y++)
            {
                for (int x = 0; x < targetBitmap.Width; x++)
                {
                    color = targetBitmap.GetPixel(x, y);
                    r = Math.Max(0, Math.Min(255, color.R + brightness));
                    g = Math.Max(0, Math.Min(255, color.G + brightness));
                    b = Math.Max(0, Math.Min(255, color.B + brightness));
                    color = Color.FromArgb(r, g, b);
                    targetBitmap.SetPixel(x, y, color);
                }
            }
            return targetBitmap;
        }

    }//end of class
}//end of namespace
