namespace BlazorDemoSap1.Client.Pages
{
    public partial class PageDemo
    {

        public bool IsVisible { get; set; } = true;
        public string Texte { get; set; }


        public void ModifieTexte()
        {
            Texte = "hello world";
        }

        public void ToggleVisibility()
        {
            IsVisible = !IsVisible;
        }
    }
}