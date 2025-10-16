namespace Common
{
    public delegate void TenantChangedEventHandler(object source, TenantChangedEventArgs args);
    public class TenantService : ITenantService
    {
        public TenantService() => _tenant = GetTenants()[0];

        public TenantService(int? tenant) => _tenant = tenant;

        private int? _tenant;

        public event TenantChangedEventHandler OnTenantChanged = null!;

        public int? Tenant => _tenant;

        public void SetTenant(int? tenant)
        {
            if (tenant != _tenant)
            {
                var old = _tenant;
                _tenant = tenant;
                OnTenantChanged?.Invoke(this, new TenantChangedEventArgs(old, _tenant??0));
            }
        }
        
        public int[] GetTenants() => new[]
        {
            1,
            2,
        };
    }
}
