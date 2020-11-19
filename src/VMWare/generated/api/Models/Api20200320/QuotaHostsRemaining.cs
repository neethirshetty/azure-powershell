namespace Microsoft.Azure.PowerShell.Cmdlets.VMWare.Models.Api20200320
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMWare.Runtime.Extensions;

    /// <summary>Remaining hosts quota by sku type</summary>
    public partial class QuotaHostsRemaining :
        Microsoft.Azure.PowerShell.Cmdlets.VMWare.Models.Api20200320.IQuotaHostsRemaining,
        Microsoft.Azure.PowerShell.Cmdlets.VMWare.Models.Api20200320.IQuotaHostsRemainingInternal
    {

        /// <summary>Creates an new <see cref="QuotaHostsRemaining" /> instance.</summary>
        public QuotaHostsRemaining()
        {

        }
    }
    /// Remaining hosts quota by sku type
    public partial interface IQuotaHostsRemaining :
        Microsoft.Azure.PowerShell.Cmdlets.VMWare.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMWare.Runtime.IAssociativeArray<int>
    {

    }
    /// Remaining hosts quota by sku type
    internal partial interface IQuotaHostsRemainingInternal

    {

    }
}