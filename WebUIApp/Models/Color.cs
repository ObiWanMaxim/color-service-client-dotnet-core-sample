﻿using WebUIApp.Utility;
using SysColor = System.Drawing.Color;

namespace WebUIApp.Models
{
    public class Color
    {
        public string Value { get; set; } = "Green";

        private SysColor SystemColor => SysColor.FromName(this.Value);

        public string CssColor => this.SystemColor.ToCssColor();

        public string CssXorColor => this.SystemColor.ToXorColor().ToCssColor();
    }
}