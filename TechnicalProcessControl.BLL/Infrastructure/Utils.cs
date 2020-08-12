namespace TechnicalProcessControl.BLL.Infrastructure
{
    public static class Utils
    {
        public enum Operation
        {
            Add,
            Update,
            Template,
            Custom
        };

        public enum Rules
        {
            NoAuthUser,
            AuthUser,
            Manager,
            Admin
        };
    }
}
