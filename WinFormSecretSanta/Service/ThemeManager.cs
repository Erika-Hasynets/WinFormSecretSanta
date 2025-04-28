using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormSecretSanta.NavigationView;

namespace WinFormSecretSanta.Service
{
    public static class ThemeManager
    {
        public static AppTheme CurrentTheme { get; private set; } = AppTheme.Light;

        public static void ApplyTheme(Form form)
        {
            Color backColor, foreColor, buttonColor;

            switch (CurrentTheme)
            {
                case AppTheme.Dark:
                    backColor = Color.FromArgb(30, 30, 30);
                    foreColor = Color.White;
                    buttonColor = Color.FromArgb(50, 50, 50);
                    break;
                case AppTheme.HighContrast:
                    backColor = Color.Black;
                    foreColor = Color.Yellow;
                    buttonColor = Color.Black;
                    break;
                default:
                    backColor = SystemColors.Control;
                    foreColor = SystemColors.ControlText;
                    buttonColor = SystemColors.ControlLight;
                    break;
            }

            form.BackColor = backColor;
            form.ForeColor = foreColor;

            ApplyThemeToControls(form.Controls, backColor, foreColor, buttonColor);
        }

        private static void ApplyThemeToControls(Control.ControlCollection controls, Color backColor, Color foreColor, Color buttonColor)
        {
            foreach (Control control in controls)
            {
                if (control is Button)
                    control.BackColor = buttonColor;
                else if (control is ComboBox or TextBox or Label)
                    control.BackColor = backColor;

                control.ForeColor = foreColor;

                if (control.HasChildren)
                    ApplyThemeToControls(control.Controls, backColor, foreColor, buttonColor);
            }
        }

        public static void SetTheme(AppTheme theme)
        {
            CurrentTheme = theme;

            // застосовуємо тему до всіх відкритих форм
            foreach (Form f in Application.OpenForms)
            {
                ApplyTheme(f);
            }
        }
    }
}
