namespace SIPSorcery.Sys {

    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class Table : System.Attribute{
        public string Name;
    }

    [System.AttributeUsage(System.AttributeTargets.Property)]
    public class Column : System.Attribute {
        public string Storage;
        public string Name;
        public string DbType;
        public bool IsPrimaryKey;
        public bool CanBeNull;
        public UpdateCheck UpdateCheck;
    }

    public enum UpdateCheck
    {
        Never = 0
    }
}
