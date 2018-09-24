namespace FFParser.Enumerations
{
    public interface IEnumeration
    {
        string GetGoogleBooksApiUrl { get; }

        string GetImDbApiUrl { get; }

        string GetImDbapiToken { get; }

        string GetMoonwalkUrl { get; }

        string[] GetMoonwalkToken { get; }
    }    
}