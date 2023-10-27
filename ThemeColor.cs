using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project {
    public struct Theme {
        public Color mainMenuColor;
        public Color panelDesktopColor;
        public Color panelTitleBar;
        public Color activeButtoneColor;
        public Color textColor;
        public Color imgColor;
        public Theme(Color mainMenuColor, Color panelDesktopColor, Color panelTitleBar, Color activeButtoneColor, Color textColor, Color imgColor) {
            this.mainMenuColor = mainMenuColor;
            this.panelDesktopColor = panelDesktopColor;
            this.panelTitleBar = panelTitleBar;
            this.activeButtoneColor = activeButtoneColor;
            this.textColor = textColor;
            this.imgColor = imgColor;
    }
        public static bool operator == (Theme c1, Theme c2) {
            return c1.Equals(c2);
        }
        public static bool operator != (Theme c1, Theme c2) {
            return !c1.Equals(c2);
        }
    }

    public class ThemeColor {
        Random random = new Random();
        List<Theme> themeList = new List<Theme>()
        {
            //         mainMenuColor               panelDesktopColor           panelTitleBar               activeButtoneColor           textColor         imgColor
            {new Theme(Color.FromArgb(30, 30, 65), Color.FromArgb(35, 35, 80), Color.FromArgb(27, 27, 63), Color.FromArgb(40, 40, 150), Color.Gainsboro, Color.White)},
            {new Theme(Color.FromArgb(30, 30, 65), Color.FromArgb(35, 35, 80), Color.FromArgb(230, 30, 30), Color.FromArgb(40, 40, 150), Color.Red, Color.Black)},
            {new Theme(Color.FromArgb(30, 30, 65), Color.FromArgb(35, 35, 80), Color.FromArgb(180, 120, 80), Color.FromArgb(40, 40, 150), Color.Purple, Color.Red)},
        };
        public Theme GetTheme() {
            int themeIndex = random.Next(0, themeList.Count);
            return themeList[themeIndex];
        }
        public Theme GetDefaultTheme() {
            return themeList[0];
        }
    }
}