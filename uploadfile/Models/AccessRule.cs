namespace uploadfile.Base
{
    public class AccessRule
    {
        public AccessRule() { }

        public Permission Copy { get; set; }
        public Permission Download { get; set; }
        public Permission Write { get; set; }
        public string Path { get; set; }
        public Permission Read { get; set; }
        public string Role { get; set; }
        public Permission WriteContents { get; set; }
        public Permission Upload { get; set; }
        public bool IsFile { get; set; }
        public string Message { get; set; }
    }
    public enum Permission
    {
        Allow = 0,
        Deny = 1
    }
}