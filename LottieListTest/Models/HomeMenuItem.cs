using System;
using System.Collections.Generic;
using System.Text;

namespace LottieListTest.Models
{
    public enum MenuItemType
    {
        Browse,
        Random,
        SendEmail,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
