﻿namespace AngleSharp.Css
{
    static class Factory
    {
        public static DefaultFeatureValidatorFactory FeatureValidator = new DefaultFeatureValidatorFactory();

        public static DefaultCssPropertyFactory Property = new DefaultCssPropertyFactory();

        public static DefaultPseudoElementFactory PseudoElement = new DefaultPseudoElementFactory();
    }
}