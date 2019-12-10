using System.Text.RegularExpressions;

namespace Alduin.DataAccess.Helpers
{
    public static class NameConverter
    {
        public static string ConvertName(string name)
        {
            name = name.Replace("Entity", "");
            name = AccentRemover.RemoveAccents(name);
            name = Regex.Replace(name, "[A-Z]+", x => x.Value[0].ToString().ToUpper() + x.Value.Substring(1).ToLower());

            Match m;
            while ((m = Regex.Match(name, "[A-Z]")).Success)
            {
                var substr = name.Substring(m.Index, m.Length);
                name = name.Remove(m.Index, m.Length);
                name = name.Insert(m.Index, (m.Index > 0 ? "_" : "") + substr.ToLower());
            }

            name = Regex.Replace(name, "_+", "_");

            return name.ToLower();
        }
    }
}
