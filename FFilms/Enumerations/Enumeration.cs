namespace FFilms.Enumerations
{
    public class Enumeration : IEnumeration
    {
        public string GetContactMessagePath => "~/Views/Mail/ContactMessage.cshtml";

        public string GetConfirmationEmailText => "Hello";
    }
}