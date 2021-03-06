using SmartStore.Core.Domain.Localization;
using System.Runtime.Serialization;
using System.Collections.Generic;
using SmartStore.Core.Search;

namespace SmartStore.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product attribute
    /// </summary>
	[DataContract]
	public partial class ProductAttribute : BaseEntity, ILocalizedEntity, ISearchAlias
	{
		private ICollection<ProductAttributeOptionsSet> _productAttributeOptionsSets;

        /// <summary>
        /// Gets or sets the product attribute alias 
        /// </summary>
		[DataMember]
        public string Alias { get; set; }
        
        /// <summary>
        /// Gets or sets the name
        /// </summary>
		[DataMember]
		public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
		[DataMember]
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets whether the attribute can be filtered
		/// </summary>
		[DataMember]
		public bool AllowFiltering { get; set; }

		/// <summary>
		/// Gets or sets the display order
		/// </summary>
		[DataMember]
		public int DisplayOrder { get; set; }

		/// <summary>
		/// Gets or sets the prooduct attribute option sets
		/// </summary>
		[DataMember]
		public virtual ICollection<ProductAttributeOptionsSet> ProductAttributeOptionsSets
		{
			get { return _productAttributeOptionsSets ?? (_productAttributeOptionsSets = new HashSet<ProductAttributeOptionsSet>()); }
			protected set { _productAttributeOptionsSets = value; }
		}
	}
}
