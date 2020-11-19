namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Static Site ARM resource.</summary>
    public partial class StaticSiteArmResource :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResource,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.Resource();

        /// <summary>The target branch in the repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string Branch { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).Branch; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).Branch = value; }

        /// <summary>The path to the api code within the repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string BuildPropertyApiLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildPropertyApiLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildPropertyApiLocation = value; }

        /// <summary>The path of the app artifacts after building.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string BuildPropertyAppArtifactLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildPropertyAppArtifactLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildPropertyAppArtifactLocation = value; }

        /// <summary>The path to the app code within the repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string BuildPropertyAppLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildPropertyAppLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildPropertyAppLocation = value; }

        /// <summary>Current number of instances assigned to the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public int? Capacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Capacity = value; }

        /// <summary>The custom domains associated with this static site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string[] CustomDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).CustomDomain; }

        /// <summary>The default autogenerated hostname for the static site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string DefaultHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).DefaultHostname; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Id; }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Kind = value; }

        /// <summary>Resource Location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for BuildProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteBuildProperties Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResourceInternal.BuildProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).BuildProperty = value; }

        /// <summary>Internal Acessors for CustomDomain</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResourceInternal.CustomDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).CustomDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).CustomDomain = value; }

        /// <summary>Internal Acessors for DefaultHostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResourceInternal.DefaultHostname { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).DefaultHostname; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).DefaultHostname = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSite Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.StaticSite()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescription Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResourceInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.SkuDescription()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for SkuCapacity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuCapacity Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteArmResourceInternal.SkuCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacity = value; }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSite _property;

        /// <summary>Core resource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSite Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.StaticSite()); set => this._property = value; }

        /// <summary>
        /// A user's github repository token. This is used to setup the Github Actions workflow file and API secrets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string RepositoryToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).RepositoryToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).RepositoryToken = value; }

        /// <summary>URL for the repository of the static site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string RepositoryUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).RepositoryUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteInternal)Property).RepositoryUrl = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescription _sku;

        /// <summary>Description of a SKU for a scalable resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescription Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.SkuDescription()); set => this._sku = value; }

        /// <summary>Capabilities of the SKU, e.g., is traffic manager enabled?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICapability[] SkuCapability { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Capability; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Capability = value; }

        /// <summary>Default number of workers for this App Service plan SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public int? SkuCapacityDefault { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityDefault; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityDefault = value; }

        /// <summary>Maximum number of workers for this App Service plan SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public int? SkuCapacityMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityMaximum; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityMaximum = value; }

        /// <summary>Minimum number of workers for this App Service plan SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public int? SkuCapacityMinimum { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityMinimum; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityMinimum = value; }

        /// <summary>Available scale configurations for an App Service plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SkuCapacityScaleType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityScaleType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).SkuCapacityScaleType = value; }

        /// <summary>Family code of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Family; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Family = value; }

        /// <summary>Locations of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string[] SkuLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Location = value; }

        /// <summary>Name of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Name = value; }

        /// <summary>Size specifier of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SkuSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Size; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Size = value; }

        /// <summary>Service tier of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescriptionInternal)Sku).Tier = value; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Tag = value; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="StaticSiteArmResource" /> instance.</summary>
        public StaticSiteArmResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Static Site ARM resource.
    public partial interface IStaticSiteArmResource :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResource
    {
        /// <summary>The target branch in the repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target branch in the repository.",
        SerializedName = @"branch",
        PossibleTypes = new [] { typeof(string) })]
        string Branch { get; set; }
        /// <summary>The path to the api code within the repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to the api code within the repository.",
        SerializedName = @"apiLocation",
        PossibleTypes = new [] { typeof(string) })]
        string BuildPropertyApiLocation { get; set; }
        /// <summary>The path of the app artifacts after building.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path of the app artifacts after building.",
        SerializedName = @"appArtifactLocation",
        PossibleTypes = new [] { typeof(string) })]
        string BuildPropertyAppArtifactLocation { get; set; }
        /// <summary>The path to the app code within the repository.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to the app code within the repository.",
        SerializedName = @"appLocation",
        PossibleTypes = new [] { typeof(string) })]
        string BuildPropertyAppLocation { get; set; }
        /// <summary>Current number of instances assigned to the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current number of instances assigned to the resource.",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? Capacity { get; set; }
        /// <summary>The custom domains associated with this static site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The custom domains associated with this static site.",
        SerializedName = @"customDomains",
        PossibleTypes = new [] { typeof(string) })]
        string[] CustomDomain { get;  }
        /// <summary>The default autogenerated hostname for the static site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The default autogenerated hostname for the static site.",
        SerializedName = @"defaultHostname",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultHostname { get;  }
        /// <summary>
        /// A user's github repository token. This is used to setup the Github Actions workflow file and API secrets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A user's github repository token. This is used to setup the Github Actions workflow file and API secrets.",
        SerializedName = @"repositoryToken",
        PossibleTypes = new [] { typeof(string) })]
        string RepositoryToken { get; set; }
        /// <summary>URL for the repository of the static site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL for the repository of the static site.",
        SerializedName = @"repositoryUrl",
        PossibleTypes = new [] { typeof(string) })]
        string RepositoryUrl { get; set; }
        /// <summary>Capabilities of the SKU, e.g., is traffic manager enabled?</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Capabilities of the SKU, e.g., is traffic manager enabled?",
        SerializedName = @"capabilities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICapability[] SkuCapability { get; set; }
        /// <summary>Default number of workers for this App Service plan SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default number of workers for this App Service plan SKU.",
        SerializedName = @"default",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacityDefault { get; set; }
        /// <summary>Maximum number of workers for this App Service plan SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of workers for this App Service plan SKU.",
        SerializedName = @"maximum",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacityMaximum { get; set; }
        /// <summary>Minimum number of workers for this App Service plan SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum number of workers for this App Service plan SKU.",
        SerializedName = @"minimum",
        PossibleTypes = new [] { typeof(int) })]
        int? SkuCapacityMinimum { get; set; }
        /// <summary>Available scale configurations for an App Service plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Available scale configurations for an App Service plan.",
        SerializedName = @"scaleType",
        PossibleTypes = new [] { typeof(string) })]
        string SkuCapacityScaleType { get; set; }
        /// <summary>Family code of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Family code of the resource SKU.",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string SkuFamily { get; set; }
        /// <summary>Locations of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Locations of the SKU.",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(string) })]
        string[] SkuLocation { get; set; }
        /// <summary>Name of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Size specifier of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size specifier of the resource SKU.",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(string) })]
        string SkuSize { get; set; }
        /// <summary>Service tier of the resource SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service tier of the resource SKU.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string SkuTier { get; set; }

    }
    /// Static Site ARM resource.
    internal partial interface IStaticSiteArmResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IResourceInternal
    {
        /// <summary>The target branch in the repository.</summary>
        string Branch { get; set; }
        /// <summary>Build properties to configure on the repository.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSiteBuildProperties BuildProperty { get; set; }
        /// <summary>The path to the api code within the repository.</summary>
        string BuildPropertyApiLocation { get; set; }
        /// <summary>The path of the app artifacts after building.</summary>
        string BuildPropertyAppArtifactLocation { get; set; }
        /// <summary>The path to the app code within the repository.</summary>
        string BuildPropertyAppLocation { get; set; }
        /// <summary>Current number of instances assigned to the resource.</summary>
        int? Capacity { get; set; }
        /// <summary>The custom domains associated with this static site.</summary>
        string[] CustomDomain { get; set; }
        /// <summary>The default autogenerated hostname for the static site.</summary>
        string DefaultHostname { get; set; }
        /// <summary>Core resource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IStaticSite Property { get; set; }
        /// <summary>
        /// A user's github repository token. This is used to setup the Github Actions workflow file and API secrets.
        /// </summary>
        string RepositoryToken { get; set; }
        /// <summary>URL for the repository of the static site.</summary>
        string RepositoryUrl { get; set; }
        /// <summary>Description of a SKU for a scalable resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuDescription Sku { get; set; }
        /// <summary>Capabilities of the SKU, e.g., is traffic manager enabled?</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICapability[] SkuCapability { get; set; }
        /// <summary>Min, max, and default scale values of the SKU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ISkuCapacity SkuCapacity { get; set; }
        /// <summary>Default number of workers for this App Service plan SKU.</summary>
        int? SkuCapacityDefault { get; set; }
        /// <summary>Maximum number of workers for this App Service plan SKU.</summary>
        int? SkuCapacityMaximum { get; set; }
        /// <summary>Minimum number of workers for this App Service plan SKU.</summary>
        int? SkuCapacityMinimum { get; set; }
        /// <summary>Available scale configurations for an App Service plan.</summary>
        string SkuCapacityScaleType { get; set; }
        /// <summary>Family code of the resource SKU.</summary>
        string SkuFamily { get; set; }
        /// <summary>Locations of the SKU.</summary>
        string[] SkuLocation { get; set; }
        /// <summary>Name of the resource SKU.</summary>
        string SkuName { get; set; }
        /// <summary>Size specifier of the resource SKU.</summary>
        string SkuSize { get; set; }
        /// <summary>Service tier of the resource SKU.</summary>
        string SkuTier { get; set; }

    }
}