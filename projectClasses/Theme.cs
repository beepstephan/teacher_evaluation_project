using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    public struct Palette
    {
        public Color mainMenuColor;
        public Color panelDesktopColor;
        public Color panelTitleBar;
        public Color activeButtoneColor;
        public Color textColor;
        public Color imgColor;
        public Palette(Color mainMenuColor, Color panelDesktopColor, Color panelTitleBar, Color activeButtoneColor, Color textColor, Color imgColor)
        {
            this.mainMenuColor = mainMenuColor;
            this.panelDesktopColor = panelDesktopColor;
            this.panelTitleBar = panelTitleBar;
            this.activeButtoneColor = activeButtoneColor;
            this.textColor = textColor;
            this.imgColor = imgColor;
        }
        public static bool operator ==(Palette c1, Palette c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Palette c1, Palette c2)
        {
            return !c1.Equals(c2);
        }
    }
    public class Theme
    {
        private int themeIndex;
        public static Palette activeTheme;
        public static float textSize;
        public static string fontStyle;

        List<Palette> themeList = new List<Palette>()
        {
            //         mainMenuColor               panelDesktopColor           panelTitleBar               activeButtoneColor           textColor         imgColor
            {new Palette(Color.FromArgb(30, 30, 65), Color.FromArgb(35, 35, 80), Color.FromArgb(27, 27, 63), Color.FromArgb(40, 40, 150), Color.Gainsboro, Color.White)},
            {new Palette(Color.FromArgb(71, 115, 115), Color.FromArgb(71, 115, 130), Color.FromArgb(30, 100, 120), Color.FromArgb(40, 90, 90), Color.Gainsboro, Color.White)},
            {new Palette(Color.FromArgb(70, 70, 70), Color.FromArgb(65, 95, 95), Color.FromArgb(54, 64, 64), Color.FromArgb(30, 80, 80), Color.Gainsboro, Color.White)},
        };

        public Theme()
        {
            textSize = 10;
            fontStyle = "Microsoft Sans Serif";
            themeIndex = 0;
            activeTheme = themeList[0];
        }

        public void SetNext()
        {
            themeIndex++;
            if (themeIndex == themeList.Count) themeIndex = 0;
            activeTheme = themeList[themeIndex];
        }
    }
}