namespace RealEstateApp.Repository
{
    public interface ISqlBuilder
    {
        void SetTable(string table);
        void AddSelect(string selectField);
        void AddClause(string name, string clause,  object value);
        string GetQuery();
        object GetParams();
    }
}
