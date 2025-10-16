namespace Common
{
    public class TenantChangedEventArgs : EventArgs
    {
        public TenantChangedEventArgs(int? oldTenant, int newTenant)
        {
            OldTenant = oldTenant;
            NewTenant = newTenant;
        }

        public int? OldTenant { get; private set; }

        public int NewTenant { get; private set; }
    }
}
