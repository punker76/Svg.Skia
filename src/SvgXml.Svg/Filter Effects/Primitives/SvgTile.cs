﻿using System;
using Xml;

namespace Svg.FilterEffects
{
    [Element("feTile")]
    public class SvgTile : SvgFilterPrimitive,
        ISvgCommonAttributes,
        ISvgPresentationAttributes,
        ISvgStylableAttributes
    {
        [Attribute("in", SvgNamespace)]
        public string? Input
        {
            get => this.GetAttribute("in", false, null);
            set => this.SetAttribute("in", value);
        }

        public override void SetPropertyValue(string key, string? value)
        {
            base.SetPropertyValue(key, value);
            switch (key)
            {
                case "in":
                    Input = value;
                    break;
            }
        }
    }
}
