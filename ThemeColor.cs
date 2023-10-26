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
        public Theme(Color mainMenuColor, Color panelDesktopColor, Color panelTitleBar, Color activeButtoneColor, Color textColor) {
            this.mainMenuColor = mainMenuColor;
            this.panelDesktopColor = panelDesktopColor;
            this.panelTitleBar = panelTitleBar;
            this.activeButtoneColor = activeButtoneColor;
            this.textColor = textColor;
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
            //         mainMenuColor               panelDesktopColor           panelTitleBar               activeButtoneColor           textColor
            {new Theme(Color.FromArgb(30, 30, 65), Color.FromArgb(35, 35, 80), Color.FromArgb(27, 27, 63), Color.FromArgb(40, 40, 150), Color.Gainsboro)},
            {new Theme(Color.FromArgb(30, 30, 65), Color.FromArgb(35, 35, 80), Color.FromArgb(230, 30, 30), Color.FromArgb(40, 40, 150), Color.Red)},
            {new Theme(Color.FromArgb(30, 30, 65), Color.FromArgb(35, 35, 80), Color.FromArgb(180, 120, 80), Color.FromArgb(40, 40, 150), Color.Purple)},
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