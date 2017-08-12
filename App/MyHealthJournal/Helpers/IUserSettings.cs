namespace MyHealthJournal.Helpers
{
    public interface IUserSettings
    {
        
        string GetAnySetting();
        void SaveAnySetting(string value);


    }
}