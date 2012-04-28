using FlagsWP7.Localization;

namespace FlagsWP7
{
    public class Translations
    {
        private static readonly TranslationsResource TextsField = new TranslationsResource();

        public TranslationsResource Texts { get { return TextsField; } }
    }
}