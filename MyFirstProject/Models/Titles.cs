using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public static class Titles
    {
        #region MAIN
        public static string MainPageTitle { get; } = "Main Page";
        public static string MainPageSubtitle { get; } = "My Mobile App!";
        #endregion
        #region LAYOUT
        public static string LayoutTitle { get; } = "Layout View";
        public static string AbsoluteTitle { get; } = "Absolute View";
        public static string AbsolutePageTitle { get; } = "Absolute Page View";
        public static string RelativeTitle { get; } = "Relative View";
        public static string RelativeLayoutTitle { get; } = "Relative Layout View";
        #endregion
        #region IMAGE
        public static string ImageTitle { get; } = "Image View";
        public static string ImageMenuTitle { get; } = "Image Menu";
        public static string ImageURITitle { get; } = "URI Image";
        public static string EmbeddedImageTitle { get; } = "Embedded Image";
        public static string ActivityIndicatorTitle { get; } = "Activity Indicator";
        #endregion
        #region LISTVIEW
        public static string ListViewTitle { get; } = "ListView View";
        public static string ListMenuTitle { get; } = "ListMenu View";
        public static string DisplayPeopleTitle { get; } = "DisplayPeople View";
        #endregion
        #region SQLITE
        public static string SQLiteTitle { get; } = "SQLite View";
        #endregion
        #region CONTROLS
        public static string ControlsTitle { get; } = "Controls View";
        #endregion
    }
}
