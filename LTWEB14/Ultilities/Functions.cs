namespace LTWEB14.Utilities
{
    public class Functions
    {
        public static string TitleSlugGeneration(string type, string title, int id)
        {
            string stitle = type + "-" + SlugGenerator.SlugGenerator.GenerateSlug(title) + "-" + id.ToString() + ".html";
            return stitle;
        }
    }
}
