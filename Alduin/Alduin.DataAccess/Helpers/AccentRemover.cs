namespace Alduin.DataAccess.Helpers
{
    public static class AccentRemover
    {
        private const string _accents = "áéíóöőúüűÁÉÍÓÖŐÚÜŰ";
        private const string _accentsReplacements = "aeiooouuuAEIOOOUUU";

        public static string RemoveAccents(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                var idx = _accents.IndexOf(str[i]);
                if (idx >= 0)
                    str.Replace(str[i], _accentsReplacements[idx]);
            }

            return str;
        }
    }
}
