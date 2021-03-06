#region Copyright and terms of services
// Copyright (c) 2015-2016 Meplato GmbH.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
// in compliance with the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License
// is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
// or implied. See the License for the specific language governing permissions and limitations under
// the License.
#endregion

// THIS FILE IS AUTO-GENERATED. DO NOT MODIFY!

// The file implements the Meplato Store API.
//
// Author:  Meplato API Team <support@meplato.com>
// Version: 2.1.5
// License: Copyright (c) 2015-2018 Meplato GmbH. All rights reserved.
// See <a href="https://developer.meplato.com/store2/#terms">Terms of Service</a>
// See <a href="https://developer.meplato.com/store2/">External documentation</a>

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Meplato.Store2;

namespace Meplato.Store2.Products
{
	/// <summary>
	///     The Meplato Store API enables technical integration of
	///     customers and partners. 
	/// </summary>
	public class Service
	{
		#region Service
		public const string Title = "Meplato Store API";
		public const string Version = "2.1.5";
		public const string UserAgent = "meplato-csharp-client/2.0";
		public const string DefaultBaseURL = "https://store.meplato.com/api/v2";

		/// <summary>
		///     Initializes a new <see cref="Service"/>.
		/// </summary>
		/// <param name="client">Client to use for requests</param>
		public Service(IClient client)
		{
			Client = client;
			BaseURL = DefaultBaseURL;
		}

		/// <summary>
		///     Returns the <see cref="IClient"/> to perform requests.
		/// </summary>
		public IClient Client { get; private set; }

		/// <summary>
		///     Represents the BaseURL to use for requests (default is <see
		///     cref="DefaultBaseURL"/>).
		/// </summary>
		public string BaseURL { get; set; }

		/// <summary>
		///     Specifies the username to authenticate requests.
		/// </summary>
		public string User { get; set; }

		/// <summary>
		///     Specifies the password to authenticate requests.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		///     Returns the authentication header for HTTP Basic Author
		///     <code>null</code> for unauthenticated requests.
		/// </summary>
		public string GetAuthorizationHeader()
		{
			if (!string.IsNullOrEmpty(User) || !string.IsNullOrEmpty(Password))
			{
				string userPass = "";
				if (!string.IsNullOrEmpty(User))
				{
					userPass = User;
				}
				userPass = userPass + ":";
				if (!string.IsNullOrEmpty(Password))
				{
					userPass = userPass + Password;
				}
				var bytes = Encoding.UTF8.GetBytes(userPass);
				var credentials = Convert.ToBase64String(bytes);
				return "Basic " + credentials;
			}
			return null;
		}

		/// <summary>
		///     Create a new product in the given catalog and area.
		/// </summary>
		public CreateService Create() {
			return new CreateService(this);
		}

		/// <summary>
		///     Delete a product.
		/// </summary>
		public DeleteService Delete() {
			return new DeleteService(this);
		}

		/// <summary>
		///     Get returns a single product by its Supplier Part Number (SPN).
		/// </summary>
		public GetService Get() {
			return new GetService(this);
		}

		/// <summary>
		///     Replace all fields of a product. Use Update to update only
		///     certain fields of a product.
		/// </summary>
		public ReplaceService Replace() {
			return new ReplaceService(this);
		}

		/// <summary>
		///     Scroll through products of a catalog (area). If you need to
		///     iterate through all products in a catalog, this is the most
		///     effective way to do so. If you want to search for products, use
		///     the Search endpoint. 
		/// </summary>
		public ScrollService Scroll() {
			return new ScrollService(this);
		}

		/// <summary>
		///     Search for products. Do not use this method for iterating
		///     through all of the products in a catalog; use the Scroll
		///     endpoint instead. It is much more efficient. 
		/// </summary>
		public SearchService Search() {
			return new SearchService(this);
		}

		/// <summary>
		///     Update the fields of a product selectively. Use Replace to
		///     replace the product as a whole.
		/// </summary>
		public UpdateService Update() {
			return new UpdateService(this);
		}

		/// <summary>
		///     Upsert a product in the given catalog and area. Upsert will
		///     create if the product does not exist yet, otherwise it will
		///     update.
		/// </summary>
		public UpsertService Upsert() {
			return new UpsertService(this);
		}
		#endregion // Service
	}

	/// <summary>
	///     Availability details product availability.
	/// </summary>
	public class Availability
	{
		#region Availability

		/// <summary>
		///     Message gives a textual description of the availability
		///     message, e.g. "in stock", "out of stock", "limited
		///     availability", or "on display to order". 
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; set; }

		/// <summary>
		///     Qty describes the quantity for certain kinds of availability
		///     messages. E.g. you can indicate the number of items in stock. 
		/// </summary>
		[JsonProperty("qty")]
		public double? Qty { get; set; }

		/// <summary>
		///     Updated indicates when the availability message has been last
		///     updated. 
		/// </summary>
		[JsonProperty("updated")]
		public string Updated { get; set; }

		#endregion // Availability
	}

	/// <summary>
	///     Blob describes external product data, e.g. an image or a
	///     datasheet.
	/// </summary>
	public class Blob
	{
		#region Blob

		/// <summary>
		///     Kind describes the type of blob, e.g. image, detail, thumbnail,
		///     datasheet, or safetysheet.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Language indicates the language of the blob, e.g. the language
		///     of a datasheet.
		/// </summary>
		[JsonProperty("lang")]
		public string Language { get; set; }

		/// <summary>
		///     Source is either a (relative) file name or a URL.
		/// </summary>
		[JsonProperty("source")]
		public string Source { get; set; }

		/// <summary>
		///     Text gives a textual description the blob.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		///     URL is the URL to the blob.
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }

		#endregion // Blob
	}

	/// <summary>
	///     Condition describes a product status, e.g. refurbished or used.
	/// </summary>
	public class Condition
	{
		#region Condition

		/// <summary>
		///     Kind describes the condition, e.g. bargain, new_product,
		///     old_product, new, used, refurbished, or core_product.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Text gives a textual description of the condition.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		#endregion // Condition
	}

	/// <summary>
	///     CreateProduct holds the properties of a new product.
	/// </summary>
	public class CreateProduct
	{
		#region CreateProduct

		/// <summary>
		///     ASIN is the unique Amazon article number of the product.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		///     AutoConfigure is a flag that indicates whether this product can
		///     be configured automatically. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("autoConfigure")]
		public bool? AutoConfigure { get; set; }

		/// <summary>
		///     Availability allows the update of product availability data,
		///     e.g. the number of items in stock or the date when the product
		///     will be available again. 
		/// </summary>
		[JsonProperty("availability")]
		public Availability Availability { get; set; }

		/// <summary>
		///     Blobs specifies external data, e.g. images or datasheets.
		/// </summary>
		[JsonProperty("blobs")]
		public Blob[] Blobs { get; set; }

		/// <summary>
		///     BoostFactor represents a positive or negative boost for the
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("boostFactor")]
		public double? BoostFactor { get; set; }

		/// <summary>
		///     BPN is the buyer part number of the product.
		/// </summary>
		[JsonProperty("bpn")]
		public string Bpn { get; set; }

		/// <summary>
		///     CatalogManaged is a flag that indicates whether this product is
		///     configurable (or catalog managed in OCI parlance).
		/// </summary>
		[JsonProperty("catalogManaged")]
		public bool CatalogManaged { get; set; }

		/// <summary>
		///     Categories is a list of (supplier-specific) category names the
		///     product belongs to.
		/// </summary>
		[JsonProperty("categories")]
		public string[] Categories { get; set; }

		/// <summary>
		///     Conditions describes the product conditions, e.g. refurbished
		///     or used.
		/// </summary>
		[JsonProperty("conditions")]
		public Condition[] Conditions { get; set; }

		/// <summary>
		///     Contract represents the contract number to be used when
		///     purchasing this product. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("contract")]
		public string Contract { get; set; }

		/// <summary>
		///     ContractItem represents line number in the contract to be used
		///     when purchasing this product. See also Contract. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("contractItem")]
		public string ContractItem { get; set; }

		/// <summary>
		///     ConversionDenumerator is the denumerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionDenumerator")]
		public double? ConversionDenumerator { get; set; }

		/// <summary>
		///     ConversionNumerator is the numerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionNumerator")]
		public double? ConversionNumerator { get; set; }

		/// <summary>
		///     Country represents the ISO code of the country of origin, i.e.
		///     the country where the product has been created/produced, e.g.
		///     DE. If unspecified, the field is initialized with the catalog's
		///     country field. 
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <summary>
		///     ContentUnit is the content unit of the product, a 3-character
		///     ISO code (usually project-specific).
		/// </summary>
		[JsonProperty("cu")]
		public string ContentUnit { get; set; }

		/// <summary>
		///     CuPerOu describes the number of content units per order unit,
		///     e.g. the 12 in '1 case contains 12 bottles'.
		/// </summary>
		[JsonProperty("cuPerOu")]
		public double? CuPerOu { get; set; }

		/// <summary>
		///     CustField1 is the CUST_FIELD1 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField1")]
		public string CustField1 { get; set; }

		/// <summary>
		///     CustField2 is the CUST_FIELD2 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField2")]
		public string CustField2 { get; set; }

		/// <summary>
		///     CustField3 is the CUST_FIELD3 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField3")]
		public string CustField3 { get; set; }

		/// <summary>
		///     CustField4 is the CUST_FIELD4 of the SAP OCI specification. It
		///     has a maximum length of 20 characters. 
		/// </summary>
		[JsonProperty("custField4")]
		public string CustField4 { get; set; }

		/// <summary>
		///     CustField5 is the CUST_FIELD5 of the SAP OCI specification. It
		///     has a maximum length of 50 characters. 
		/// </summary>
		[JsonProperty("custField5")]
		public string CustField5 { get; set; }

		/// <summary>
		///     CustFields is an array of generic name/value pairs for
		///     customer-specific attributes.
		/// </summary>
		[JsonProperty("custFields")]
		public CustField[] CustFields { get; set; }

		/// <summary>
		///     CustomField10 represents the 10th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField10")]
		public string CustomField10 { get; set; }

		/// <summary>
		///     CustomField11 represents the 11th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField11")]
		public string CustomField11 { get; set; }

		/// <summary>
		///     CustomField12 represents the 12th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField12")]
		public string CustomField12 { get; set; }

		/// <summary>
		///     CustomField13 represents the 13th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField13")]
		public string CustomField13 { get; set; }

		/// <summary>
		///     CustomField14 represents the 14th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField14")]
		public string CustomField14 { get; set; }

		/// <summary>
		///     CustomField15 represents the 15th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField15")]
		public string CustomField15 { get; set; }

		/// <summary>
		///     CustomField16 represents the 16th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField16")]
		public string CustomField16 { get; set; }

		/// <summary>
		///     CustomField17 represents the 17th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField17")]
		public string CustomField17 { get; set; }

		/// <summary>
		///     CustomField18 represents the 18th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField18")]
		public string CustomField18 { get; set; }

		/// <summary>
		///     CustomField19 represents the 19th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField19")]
		public string CustomField19 { get; set; }

		/// <summary>
		///     CustomField20 represents the 20th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField20")]
		public string CustomField20 { get; set; }

		/// <summary>
		///     CustomField21 represents the 21st customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField21")]
		public string CustomField21 { get; set; }

		/// <summary>
		///     CustomField22 represents the 22nd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField22")]
		public string CustomField22 { get; set; }

		/// <summary>
		///     CustomField23 represents the 23rd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField23")]
		public string CustomField23 { get; set; }

		/// <summary>
		///     CustomField24 represents the 24th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField24")]
		public string CustomField24 { get; set; }

		/// <summary>
		///     CustomField25 represents the 25th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField25")]
		public string CustomField25 { get; set; }

		/// <summary>
		///     CustomField26 represents the 26th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField26")]
		public string CustomField26 { get; set; }

		/// <summary>
		///     CustomField27 represents the 27th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField27")]
		public string CustomField27 { get; set; }

		/// <summary>
		///     CustomField28 represents the 28th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField28")]
		public string CustomField28 { get; set; }

		/// <summary>
		///     CustomField29 represents the 29th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField29")]
		public string CustomField29 { get; set; }

		/// <summary>
		///     CustomField30 represents the 30th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField30")]
		public string CustomField30 { get; set; }

		/// <summary>
		///     CustomField6 represents the 6th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField6")]
		public string CustomField6 { get; set; }

		/// <summary>
		///     CustomField7 represents the 7th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField7")]
		public string CustomField7 { get; set; }

		/// <summary>
		///     CustomField8 represents the 8th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField8")]
		public string CustomField8 { get; set; }

		/// <summary>
		///     CustomField9 represents the 9th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField9")]
		public string CustomField9 { get; set; }

		/// <summary>
		///     Datasheet is the name of an datasheet file (in the media files)
		///     or a URL to the datasheet on the internet.
		/// </summary>
		[JsonProperty("datasheet")]
		public string Datasheet { get; set; }

		/// <summary>
		///     Description of the product.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     Eclasses is a list of eCl@ss categories the product belongs to.
		/// </summary>
		[JsonProperty("eclasses")]
		public Eclass[] Eclasses { get; set; }

		/// <summary>
		///     erpGroupSupplier is the material group of the product on the
		///     merchant-/supplier-side.
		/// </summary>
		[JsonProperty("erpGroupSupplier")]
		public string ErpGroupSupplier { get; set; }

		/// <summary>
		///     Excluded is a flag that indicates whether to exclude this
		///     product from the catalog. If true, this product will not be
		///     published into the live area.
		/// </summary>
		[JsonProperty("excluded")]
		public bool Excluded { get; set; }

		/// <summary>
		///     ExtCategory is the EXT_CATEGORY field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategory")]
		public string ExtCategory { get; set; }

		/// <summary>
		///     ExtCategoryID is the EXT_CATEGORY_ID field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategoryId")]
		public string ExtCategoryId { get; set; }

		/// <summary>
		///     ExtConfigForm represents information required to make the
		///     product configurable. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("extConfigForm")]
		public string ExtConfigForm { get; set; }

		/// <summary>
		///     ExtConfigService represents additional information required to
		///     make the product configurable. See also ExtConfigForm. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("extConfigService")]
		public string ExtConfigService { get; set; }

		/// <summary>
		///     ExtProductID is the EXT_PRODUCT_ID field of the SAP OCI
		///     specification. It is e.g. required for configurable/catalog
		///     managed products.
		/// </summary>
		[JsonProperty("extProductId")]
		public string ExtProductId { get; set; }

		/// <summary>
		///     ExtSchemaType is the EXT_SCHEMA_TYPE field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extSchemaType")]
		public string ExtSchemaType { get; set; }

		/// <summary>
		///     Features defines product features, i.e. additional properties
		///     of the product.
		/// </summary>
		[JsonProperty("features")]
		public Feature[] Features { get; set; }

		/// <summary>
		///     GLAccount represents the GL account number to use for this
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("glAccount")]
		public string GlAccount { get; set; }

		/// <summary>
		///     GTIN is the global trade item number of the product (used to be
		///     EAN).
		/// </summary>
		[JsonProperty("gtin")]
		public string Gtin { get; set; }

		/// <summary>
		///     Hazmats classifies hazardous/dangerous goods.
		/// </summary>
		[JsonProperty("hazmats")]
		public Hazmat[] Hazmats { get; set; }

		/// <summary>
		///     Image is the name of an image file (in the media files) or a
		///     URL to the image on the internet.
		/// </summary>
		[JsonProperty("image")]
		public string Image { get; set; }

		/// <summary>
		///     Incomplete is a flag that indicates whether this product is
		///     incomplete. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("incomplete")]
		public bool? Incomplete { get; set; }

		/// <summary>
		///     Intrastat specifies required data for Intrastat messages. 
		/// </summary>
		[JsonProperty("intrastat")]
		public Intrastat Intrastat { get; set; }

		/// <summary>
		///     IsPassword is a flag that indicates whether this product will
		///     be used to purchase a password, e.g. for a software product.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("isPassword")]
		public bool? IsPassword { get; set; }

		/// <summary>
		///     KeepPrice is a flag that indicates whether the price of the
		///     product will or will not be calculated by the catalog. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("keepPrice")]
		public bool? KeepPrice { get; set; }

		/// <summary>
		///     Keywords is a list of aliases for the product.
		/// </summary>
		[JsonProperty("keywords")]
		public string[] Keywords { get; set; }

		/// <summary>
		///     Leadtime is the number of days for delivery.
		/// </summary>
		[JsonProperty("leadtime")]
		public double? Leadtime { get; set; }

		/// <summary>
		///     ListPrice is the net list price of the product.
		/// </summary>
		[JsonProperty("listPrice")]
		public double? ListPrice { get; set; }

		/// <summary>
		///     Manufactcode is the manufacturer code as used in the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("manufactcode")]
		public string Manufactcode { get; set; }

		/// <summary>
		///     Manufacturer is the name of the manufacturer.
		/// </summary>
		[JsonProperty("manufacturer")]
		public string Manufacturer { get; set; }

		/// <summary>
		///     Matgroup is the material group of the product on the buy-side.
		/// </summary>
		[JsonProperty("matgroup")]
		public string Matgroup { get; set; }

		/// <summary>
		///     MPN is the manufacturer part number.
		/// </summary>
		[JsonProperty("mpn")]
		public string Mpn { get; set; }

		/// <summary>
		///     MultiSupplierID represents an optional field for the unique
		///     identifier of a supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierId")]
		public string MultiSupplierId { get; set; }

		/// <summary>
		///     MultiSupplierName represents an optional field for the name of
		///     the supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierName")]
		public string MultiSupplierName { get; set; }

		/// <summary>
		///     Name of the product.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     NeedsGoodsReceipt is a flag that indicates whether this product
		///     requires a goods receipt process. Please consult your Store
		///     Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("needsGoodsReceipt")]
		public bool? NeedsGoodsReceipt { get; set; }

		/// <summary>
		///     NFBasePrice represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfBasePrice")]
		public double? NfBasePrice { get; set; }

		/// <summary>
		///     NFBasePriceQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfBasePriceQuantity")]
		public double? NfBasePriceQuantity { get; set; }

		/// <summary>
		///     NFCndID represents the key to calculate metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfCndId")]
		public string NfCndId { get; set; }

		/// <summary>
		///     NFScale represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfScale")]
		public double? NfScale { get; set; }

		/// <summary>
		///     NFScaleQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfScaleQuantity")]
		public double? NfScaleQuantity { get; set; }

		/// <summary>
		///     Orderable is a flag that indicates whether this product will be
		///     orderable to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("orderable")]
		public bool? Orderable { get; set; }

		/// <summary>
		///     OrderUnit is the order unit of the product, a 3-character ISO
		///     code (usually project-specific).
		/// </summary>
		[JsonProperty("ou")]
		public string OrderUnit { get; set; }

		/// <summary>
		///     Price is the net price (per order unit) of the product for the
		///     end-user.
		/// </summary>
		[JsonProperty("price")]
		public double Price { get; set; }

		/// <summary>
		///     PriceFormula represents the formula to calculate the price of
		///     the product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("priceFormula")]
		public string PriceFormula { get; set; }

		/// <summary>
		///     PriceQty is the quantity for which the price is specified
		///     (default: 1.0).
		/// </summary>
		[JsonProperty("priceQty")]
		public double? PriceQty { get; set; }

		/// <summary>
		///     QuantityInterval is the interval in which this product can be
		///     ordered. E.g. if the quantity interval is 5, the end-user can
		///     only order in quantities of 5,10,15 etc. 
		/// </summary>
		[JsonProperty("quantityInterval")]
		public double? QuantityInterval { get; set; }

		/// <summary>
		///     QuantityMax is the maximum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMax")]
		public double? QuantityMax { get; set; }

		/// <summary>
		///     QuantityMin is the minimum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMin")]
		public double? QuantityMin { get; set; }

		/// <summary>
		///     Rateable is a flag that indicates whether the product can be
		///     rated by end-users. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("rateable")]
		public bool? Rateable { get; set; }

		/// <summary>
		///     RateableOnlyIfOrdered is a flag that indicates whether the
		///     product can be rated only after being ordered. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("rateableOnlyIfOrdered")]
		public bool? RateableOnlyIfOrdered { get; set; }

		/// <summary>
		///     References defines cross-product references, e.g. alternatives
		///     or follow-up products.
		/// </summary>
		[JsonProperty("references")]
		public Reference[] References { get; set; }

		/// <summary>
		///     Safetysheet is the name of an safetysheet file (in the media
		///     files) or a URL to the safetysheet on the internet.
		/// </summary>
		[JsonProperty("safetysheet")]
		public string Safetysheet { get; set; }

		/// <summary>
		///     ScalePrices can be used when the price of the product is
		///     dependent on the ordered quantity.
		/// </summary>
		[JsonProperty("scalePrices")]
		public ScalePrice[] ScalePrices { get; set; }

		/// <summary>
		///     Service indicates if the is a good (false) or a service (true).
		///     The default value is false.
		/// </summary>
		[JsonProperty("service")]
		public bool Service { get; set; }

		/// <summary>
		///     SPN is the supplier part number.
		/// </summary>
		[JsonProperty("spn")]
		public string Spn { get; set; }

		/// <summary>
		///     TaxCode to use for this product. This is typically
		///     project-specific.
		/// </summary>
		[JsonProperty("taxCode")]
		public string TaxCode { get; set; }

		/// <summary>
		///     TaxRate for this product, a numeric value between 0.0 and 1.0.
		/// </summary>
		[JsonProperty("taxRate")]
		public double TaxRate { get; set; }

		/// <summary>
		///     Thumbnail is the name of an thumbnail image file (in the media
		///     files) or a URL to the image on the internet.
		/// </summary>
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

		/// <summary>
		///     Unspscs is a list of UNSPSC categories the product belongs to.
		/// </summary>
		[JsonProperty("unspscs")]
		public Unspsc[] Unspscs { get; set; }

		/// <summary>
		///     Visible is a flag that indicates whether this product will be
		///     visible to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("visible")]
		public bool? Visible { get; set; }

		#endregion // CreateProduct
	}

	/// <summary>
	///     CreateProductResponse is the outcome of a successful request to
	///     create a product.
	/// </summary>
	public class CreateProductResponse
	{
		#region CreateProductResponse

		/// <summary>
		///     Kind describes this entity.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Link returns a URL to the representation of the newly created
		///     product.
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		#endregion // CreateProductResponse
	}

	/// <summary>
	///     CustField describes a generic name/value pair. Its purpose is
	///     to provide a mechanism for customer-specific fields.
	/// </summary>
	public class CustField
	{
		#region CustField

		/// <summary>
		///     Name is the name of the customer-specific field, e.g. TaxRate.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     Value is the value of the customer-specific field, e.g. 19%.
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }

		#endregion // CustField
	}

	/// <summary>
	///     Eclass is used to tie a product to an eCl@ss schema.
	/// </summary>
	public class Eclass
	{
		#region Eclass

		/// <summary>
		///     Code is the eCl@ss code. Only use digits for encoding, e.g.
		///     19010203.
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     Version is the eCl@ss version in the major.minor format, e.g.
		///     5.1 or 7.0.
		/// </summary>
		[JsonProperty("version")]
		public string Version { get; set; }

		#endregion // Eclass
	}

	/// <summary>
	///     Feature describes additional features of a product.
	/// </summary>
	public class Feature
	{
		#region Feature

		/// <summary>
		///     Kind describes the type of feature, e.g. ECLASS-5.1 to describe
		///     a feature of eCl@ss 5.1.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Name specifies the name/code of the feature. If you are
		///     refering to a standard classification like eCl@ss, you should
		///     use the code of the feature. Otherwise, you are free to use a
		///     textual description like "Weight" or "Diameter" or "Voltage". 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     Unit is a unit of measurement to describe the feature value.
		///     E.g. if you specify the weight, you should probably use KGM as
		///     unit to describe that the weight is given in kilograms. 
		/// </summary>
		[JsonProperty("unit")]
		public string Unit { get; set; }

		/// <summary>
		///     Values describes the feature value(s).
		/// </summary>
		[JsonProperty("values")]
		public string[] Values { get; set; }

		#endregion // Feature
	}

	/// <summary>
	///     Hazmat describes a hazardous/dangerous good.
	/// </summary>
	public class Hazmat
	{
		#region Hazmat

		/// <summary>
		///     Kind describes the classification system, e.g. GGVS.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Text gives a textual description or a code of the harm that the
		///     product can do to people, property, or the environment.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		#endregion // Hazmat
	}

	/// <summary>
	///     Intrastat represents data required for Intrastat messages.
	/// </summary>
	public class Intrastat
	{
		#region Intrastat

		/// <summary>
		///     Code represents an identifier for a product group, e.g. the
		///     tariff code of "85167100" for "Electro-thermic coffee or tea
		///     makers, for domestic use". See
		///     https://www.zolltarifnummern.de/2018 for details. This is a
		///     required field. 
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     GrossWeight represents the gross weight of the product. 
		/// </summary>
		[JsonProperty("grossWeight")]
		public double GrossWeight { get; set; }

		/// <summary>
		///     MeansOfTransport indicates how the product was delivered to its
		///     destination, e.g. by air or by train. According to the
		///     INTRASTAT documentation, the following values are permitted
		///     (see
		///     https://www-idev.destatis.de/idev/doc/intra/doc/Intrahandel_Leit
		///     faden.pdf for a complete list): 1 - Maritime traffic 2 - Rail
		///     transport 3 - Road traffic 4 - Air traffic 5 - Mailings /
		///     postal service 7 - Pipings 8 - Inland waterways 9 - Own drive
		///     The value of "6" is missing in that list, and it's not a typo. 
		/// </summary>
		[JsonProperty("meansOfTransport")]
		public string MeansOfTransport { get; set; }

		/// <summary>
		///     NetWeight represents the net weight of the product. 
		/// </summary>
		[JsonProperty("netWeight")]
		public double NetWeight { get; set; }

		/// <summary>
		///     OriginCountry represents the ISO code of the country where the
		///     product has been created/produced, e.g. DE. This is a required
		///     field. 
		/// </summary>
		[JsonProperty("originCountry")]
		public string OriginCountry { get; set; }

		/// <summary>
		///     TransactionType indicates the type of transaction, e.g. if it
		///     represents a purchase or a leasing contract. In the INTRASTAT
		///     documentation, this is represented by two digits, e.g. "11" for
		///     a purchase and "14" for leasing. See
		///     https://www-idev.destatis.de/idev/doc/intra/doc/Intrahandel_Leit
		///     faden.pdf for details. 
		/// </summary>
		[JsonProperty("transactionType")]
		public string TransactionType { get; set; }

		/// <summary>
		///     WeightUnit is the ISO code of for NetWeight and/or GrossWeight,
		///     e.g. KGM. 
		/// </summary>
		[JsonProperty("weightUnit")]
		public string WeightUnit { get; set; }

		#endregion // Intrastat
	}

	/// <summary>
	///     Product is a good or service in a catalog.
	/// </summary>
	public class Product
	{
		#region Product

		/// <summary>
		///     ASIN is the unique Amazon article number of the product.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		///     AutoConfigure is a flag that indicates whether this product can
		///     be configured automatically.
		/// </summary>
		[JsonProperty("autoConfigure")]
		public bool? AutoConfigure { get; set; }

		/// <summary>
		///     Availability allows the update of product availability data,
		///     e.g. the number of items in stock or the date when the product
		///     will be available again. 
		/// </summary>
		[JsonProperty("availability")]
		public Availability Availability { get; set; }

		/// <summary>
		///     Blobs specifies external data, e.g. images or datasheets.
		/// </summary>
		[JsonProperty("blobs")]
		public Blob[] Blobs { get; set; }

		/// <summary>
		///     BoostFactor represents a positive or negative boost for the
		///     product.
		/// </summary>
		[JsonProperty("boostFactor")]
		public double? BoostFactor { get; set; }

		/// <summary>
		///     BPN is the buyer part number of the product.
		/// </summary>
		[JsonProperty("bpn")]
		public string Bpn { get; set; }

		/// <summary>
		///     ID of the catalog this products belongs to.
		/// </summary>
		[JsonProperty("catalogId")]
		public long CatalogId { get; set; }

		/// <summary>
		///     CatalogManaged is a flag that indicates whether this product is
		///     configurable (or catalog managed in OCI parlance).
		/// </summary>
		[JsonProperty("catalogManaged")]
		public bool CatalogManaged { get; set; }

		/// <summary>
		///     Categories is a list of (supplier-specific) category names the
		///     product belongs to.
		/// </summary>
		[JsonProperty("categories")]
		public string[] Categories { get; set; }

		/// <summary>
		///     Conditions describes the product conditions, e.g. refurbished
		///     or used.
		/// </summary>
		[JsonProperty("conditions")]
		public Condition[] Conditions { get; set; }

		/// <summary>
		///     Contract represents the contract number to be used when
		///     purchasing this product.
		/// </summary>
		[JsonProperty("contract")]
		public string Contract { get; set; }

		/// <summary>
		///     ContractItem represents line number in the contract to be used
		///     when purchasing this product. See also Contract.
		/// </summary>
		[JsonProperty("contractItem")]
		public string ContractItem { get; set; }

		/// <summary>
		///     ConversionDenumerator is the denumerator for calculating price
		///     quantities.
		/// </summary>
		[JsonProperty("conversionDenumerator")]
		public double? ConversionDenumerator { get; set; }

		/// <summary>
		///     ConversionNumerator is the numerator for calculating price
		///     quantities.
		/// </summary>
		[JsonProperty("conversionNumerator")]
		public double? ConversionNumerator { get; set; }

		/// <summary>
		///     Country represents the ISO code of the country of origin, i.e.
		///     the country where the product has been created/produced, e.g.
		///     DE. If unspecified, the field is initialized with the catalog's
		///     country field. 
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <summary>
		///     Created is the creation date and time of the product.
		/// </summary>
		[JsonProperty("created")]
		public DateTimeOffset? Created { get; set; }

		/// <summary>
		///     ContentUnit is the content unit of the product, a 3-character
		///     ISO code (usually project-specific).
		/// </summary>
		[JsonProperty("cu")]
		public string ContentUnit { get; set; }

		/// <summary>
		///     CuPerOu describes the number of content units per order unit,
		///     e.g. the 12 in '1 case contains 12 bottles'.
		/// </summary>
		[JsonProperty("cuPerOu")]
		public double CuPerOu { get; set; }

		/// <summary>
		///     Currency is the ISO currency code for the prices, e.g. EUR or
		///     GBP.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		/// <summary>
		///     CustField1 is the CUST_FIELD1 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField1")]
		public string CustField1 { get; set; }

		/// <summary>
		///     CustField2 is the CUST_FIELD2 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField2")]
		public string CustField2 { get; set; }

		/// <summary>
		///     CustField3 is the CUST_FIELD3 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField3")]
		public string CustField3 { get; set; }

		/// <summary>
		///     CustField4 is the CUST_FIELD4 of the SAP OCI specification. It
		///     has a maximum length of 20 characters. 
		/// </summary>
		[JsonProperty("custField4")]
		public string CustField4 { get; set; }

		/// <summary>
		///     CustField5 is the CUST_FIELD5 of the SAP OCI specification. It
		///     has a maximum length of 50 characters. 
		/// </summary>
		[JsonProperty("custField5")]
		public string CustField5 { get; set; }

		/// <summary>
		///     CustFields is an array of generic name/value pairs for
		///     customer-specific attributes.
		/// </summary>
		[JsonProperty("custFields")]
		public CustField[] CustFields { get; set; }

		/// <summary>
		///     CustomField10 represents the 10th customer-specific field.
		/// </summary>
		[JsonProperty("customField10")]
		public string CustomField10 { get; set; }

		/// <summary>
		///     CustomField11 represents the 11th customer-specific field.
		/// </summary>
		[JsonProperty("customField11")]
		public string CustomField11 { get; set; }

		/// <summary>
		///     CustomField12 represents the 12th customer-specific field.
		/// </summary>
		[JsonProperty("customField12")]
		public string CustomField12 { get; set; }

		/// <summary>
		///     CustomField13 represents the 13th customer-specific field.
		/// </summary>
		[JsonProperty("customField13")]
		public string CustomField13 { get; set; }

		/// <summary>
		///     CustomField14 represents the 14th customer-specific field.
		/// </summary>
		[JsonProperty("customField14")]
		public string CustomField14 { get; set; }

		/// <summary>
		///     CustomField15 represents the 15th customer-specific field.
		/// </summary>
		[JsonProperty("customField15")]
		public string CustomField15 { get; set; }

		/// <summary>
		///     CustomField16 represents the 16th customer-specific field.
		/// </summary>
		[JsonProperty("customField16")]
		public string CustomField16 { get; set; }

		/// <summary>
		///     CustomField17 represents the 17th customer-specific field.
		/// </summary>
		[JsonProperty("customField17")]
		public string CustomField17 { get; set; }

		/// <summary>
		///     CustomField18 represents the 18th customer-specific field.
		/// </summary>
		[JsonProperty("customField18")]
		public string CustomField18 { get; set; }

		/// <summary>
		///     CustomField19 represents the 19th customer-specific field.
		/// </summary>
		[JsonProperty("customField19")]
		public string CustomField19 { get; set; }

		/// <summary>
		///     CustomField20 represents the 20th customer-specific field.
		/// </summary>
		[JsonProperty("customField20")]
		public string CustomField20 { get; set; }

		/// <summary>
		///     CustomField21 represents the 21st customer-specific field.
		/// </summary>
		[JsonProperty("customField21")]
		public string CustomField21 { get; set; }

		/// <summary>
		///     CustomField22 represents the 22nd customer-specific field.
		/// </summary>
		[JsonProperty("customField22")]
		public string CustomField22 { get; set; }

		/// <summary>
		///     CustomField23 represents the 23rd customer-specific field.
		/// </summary>
		[JsonProperty("customField23")]
		public string CustomField23 { get; set; }

		/// <summary>
		///     CustomField24 represents the 24th customer-specific field.
		/// </summary>
		[JsonProperty("customField24")]
		public string CustomField24 { get; set; }

		/// <summary>
		///     CustomField25 represents the 25th customer-specific field.
		/// </summary>
		[JsonProperty("customField25")]
		public string CustomField25 { get; set; }

		/// <summary>
		///     CustomField26 represents the 26th customer-specific field.
		/// </summary>
		[JsonProperty("customField26")]
		public string CustomField26 { get; set; }

		/// <summary>
		///     CustomField27 represents the 27th customer-specific field.
		/// </summary>
		[JsonProperty("customField27")]
		public string CustomField27 { get; set; }

		/// <summary>
		///     CustomField28 represents the 28th customer-specific field.
		/// </summary>
		[JsonProperty("customField28")]
		public string CustomField28 { get; set; }

		/// <summary>
		///     CustomField29 represents the 29th customer-specific field.
		/// </summary>
		[JsonProperty("customField29")]
		public string CustomField29 { get; set; }

		/// <summary>
		///     CustomField30 represents the 30th customer-specific field.
		/// </summary>
		[JsonProperty("customField30")]
		public string CustomField30 { get; set; }

		/// <summary>
		///     CustomField6 represents the 6th customer-specific field.
		/// </summary>
		[JsonProperty("customField6")]
		public string CustomField6 { get; set; }

		/// <summary>
		///     CustomField7 represents the 7th customer-specific field.
		/// </summary>
		[JsonProperty("customField7")]
		public string CustomField7 { get; set; }

		/// <summary>
		///     CustomField8 represents the 8th customer-specific field.
		/// </summary>
		[JsonProperty("customField8")]
		public string CustomField8 { get; set; }

		/// <summary>
		///     CustomField9 represents the 9th customer-specific field.
		/// </summary>
		[JsonProperty("customField9")]
		public string CustomField9 { get; set; }

		/// <summary>
		///     Datasheet is the name of an datasheet file (in the media files)
		///     or a URL to the datasheet on the internet.
		/// </summary>
		[JsonProperty("datasheet")]
		public string Datasheet { get; set; }

		/// <summary>
		///     DatasheetURL is the URL to the data sheet (if available).
		/// </summary>
		[JsonProperty("datasheetURL")]
		public string DatasheetURL { get; set; }

		/// <summary>
		///     Description of the product.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     Eclasses is a list of eCl@ss categories the product belongs to.
		/// </summary>
		[JsonProperty("eclasses")]
		public Eclass[] Eclasses { get; set; }

		/// <summary>
		///     erpGroupSupplier is the material group of the product on the
		///     merchant-/supplier-side.
		/// </summary>
		[JsonProperty("erpGroupSupplier")]
		public string ErpGroupSupplier { get; set; }

		/// <summary>
		///     Excluded is a flag that indicates whether to exclude this
		///     product from the catalog. If true, this product will not be
		///     published into the live area.
		/// </summary>
		[JsonProperty("excluded")]
		public bool Excluded { get; set; }

		/// <summary>
		///     ExtCategory is the EXT_CATEGORY field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategory")]
		public string ExtCategory { get; set; }

		/// <summary>
		///     ExtCategoryID is the EXT_CATEGORY_ID field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategoryId")]
		public string ExtCategoryId { get; set; }

		/// <summary>
		///     ExtConfigForm represents information required to make the
		///     product configurable.
		/// </summary>
		[JsonProperty("extConfigForm")]
		public string ExtConfigForm { get; set; }

		/// <summary>
		///     ExtConfigService represents additional information required to
		///     make the product configurable. See also ExtConfigForm.
		/// </summary>
		[JsonProperty("extConfigService")]
		public string ExtConfigService { get; set; }

		/// <summary>
		///     ExtProductID is the EXT_PRODUCT_ID field of the SAP OCI
		///     specification. It is e.g. required for configurable/catalog
		///     managed products.
		/// </summary>
		[JsonProperty("extProductId")]
		public string ExtProductId { get; set; }

		/// <summary>
		///     ExtSchemaType is the EXT_SCHEMA_TYPE field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extSchemaType")]
		public string ExtSchemaType { get; set; }

		/// <summary>
		///     Features defines product features, i.e. additional properties
		///     of the product.
		/// </summary>
		[JsonProperty("features")]
		public Feature[] Features { get; set; }

		/// <summary>
		///     GLAccount represents the GL account number to use for this
		///     product.
		/// </summary>
		[JsonProperty("glAccount")]
		public string GlAccount { get; set; }

		/// <summary>
		///     GTIN is the global trade item number of the product (used to be
		///     EAN).
		/// </summary>
		[JsonProperty("gtin")]
		public string Gtin { get; set; }

		/// <summary>
		///     Hazmats classifies hazardous/dangerous goods.
		/// </summary>
		[JsonProperty("hazmats")]
		public Hazmat[] Hazmats { get; set; }

		/// <summary>
		///     ID is a unique (internal) identifier of the product.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     Image is the name of an image file (in the media files) or a
		///     URL to the image on the internet.
		/// </summary>
		[JsonProperty("image")]
		public string Image { get; set; }

		/// <summary>
		///     ImageURL is the URL to the image.
		/// </summary>
		[JsonProperty("imageURL")]
		public string ImageURL { get; set; }

		/// <summary>
		///     Incomplete is a flag that indicates whether this product is
		///     incomplete.
		/// </summary>
		[JsonProperty("incomplete")]
		public bool? Incomplete { get; set; }

		/// <summary>
		///     Intrastat specifies required data for Intrastat messages. 
		/// </summary>
		[JsonProperty("intrastat")]
		public Intrastat Intrastat { get; set; }

		/// <summary>
		///     IsPassword is a flag that indicates whether this product will
		///     be used to purchase a password, e.g. for a software product.
		/// </summary>
		[JsonProperty("isPassword")]
		public bool? IsPassword { get; set; }

		/// <summary>
		///     KeepPrice is a flag that indicates whether the price of the
		///     product will or will not be calculated by the catalog.
		/// </summary>
		[JsonProperty("keepPrice")]
		public bool? KeepPrice { get; set; }

		/// <summary>
		///     Keywords is a list of aliases for the product.
		/// </summary>
		[JsonProperty("keywords")]
		public string[] Keywords { get; set; }

		/// <summary>
		///     Kind is store#product for a product entity.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Leadtime is the number of days for delivery.
		/// </summary>
		[JsonProperty("leadtime")]
		public double? Leadtime { get; set; }

		/// <summary>
		///     ListPrice is the net list price of the product.
		/// </summary>
		[JsonProperty("listPrice")]
		public double ListPrice { get; set; }

		/// <summary>
		///     Manufactcode is the manufacturer code as used in the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("manufactcode")]
		public string Manufactcode { get; set; }

		/// <summary>
		///     Manufacturer is the name of the manufacturer.
		/// </summary>
		[JsonProperty("manufacturer")]
		public string Manufacturer { get; set; }

		/// <summary>
		///     Matgroup is the material group of the product on the buy-side.
		/// </summary>
		[JsonProperty("matgroup")]
		public string Matgroup { get; set; }

		/// <summary>
		///     MeplatoPrice is the Meplato price of the product.
		/// </summary>
		[JsonProperty("meplatoPrice")]
		public double MeplatoPrice { get; set; }

		/// <summary>
		///     ID of the merchant.
		/// </summary>
		[JsonProperty("merchantId")]
		public long MerchantId { get; set; }

		/// <summary>
		///     MPN is the manufacturer part number.
		/// </summary>
		[JsonProperty("mpn")]
		public string Mpn { get; set; }

		/// <summary>
		///     MultiSupplierID represents an optional field for the unique
		///     identifier of a supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierId")]
		public string MultiSupplierId { get; set; }

		/// <summary>
		///     MultiSupplierName represents an optional field for the name of
		///     the supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierName")]
		public string MultiSupplierName { get; set; }

		/// <summary>
		///     Name of the product.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     NeedsGoodsReceipt is a flag that indicates whether this product
		///     requires a goods receipt process.
		/// </summary>
		[JsonProperty("needsGoodsReceipt")]
		public bool? NeedsGoodsReceipt { get; set; }

		/// <summary>
		///     NFBasePrice represents a part for calculating metal surcharges.
		/// </summary>
		[JsonProperty("nfBasePrice")]
		public double? NfBasePrice { get; set; }

		/// <summary>
		///     NFBasePriceQuantity represents a part for calculating metal
		///     surcharges.
		/// </summary>
		[JsonProperty("nfBasePriceQuantity")]
		public double? NfBasePriceQuantity { get; set; }

		/// <summary>
		///     NFCndID represents the key to calculate metal surcharges.
		/// </summary>
		[JsonProperty("nfCndId")]
		public string NfCndId { get; set; }

		/// <summary>
		///     NFScale represents a part for calculating metal surcharges.
		/// </summary>
		[JsonProperty("nfScale")]
		public double? NfScale { get; set; }

		/// <summary>
		///     NFScaleQuantity represents a part for calculating metal
		///     surcharges.
		/// </summary>
		[JsonProperty("nfScaleQuantity")]
		public double? NfScaleQuantity { get; set; }

		/// <summary>
		///     Orderable is a flag that indicates whether this product will be
		///     orderable to the end-user when shopping.
		/// </summary>
		[JsonProperty("orderable")]
		public bool? Orderable { get; set; }

		/// <summary>
		///     OrderUnit is the order unit of the product, a 3-character ISO
		///     code (usually project-specific).
		/// </summary>
		[JsonProperty("ou")]
		public string OrderUnit { get; set; }

		/// <summary>
		///     Price is the net price (per order unit) of the product for the
		///     end-user.
		/// </summary>
		[JsonProperty("price")]
		public double Price { get; set; }

		/// <summary>
		///     PriceFormula represents the formula to calculate the price of
		///     the product.
		/// </summary>
		[JsonProperty("priceFormula")]
		public string PriceFormula { get; set; }

		/// <summary>
		///     PriceQty is the quantity for which the price is specified
		///     (default: 1.0).
		/// </summary>
		[JsonProperty("priceQty")]
		public double PriceQty { get; set; }

		/// <summary>
		///     ID of the project.
		/// </summary>
		[JsonProperty("projectId")]
		public long ProjectId { get; set; }

		/// <summary>
		///     QuantityInterval is the interval in which this product can be
		///     ordered. E.g. if the quantity interval is 5, the end-user can
		///     only order in quantities of 5,10,15 etc. 
		/// </summary>
		[JsonProperty("quantityInterval")]
		public double? QuantityInterval { get; set; }

		/// <summary>
		///     QuantityMax is the maximum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMax")]
		public double? QuantityMax { get; set; }

		/// <summary>
		///     QuantityMin is the minimum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMin")]
		public double? QuantityMin { get; set; }

		/// <summary>
		///     Rateable is a flag that indicates whether the product can be
		///     rated by end-users.
		/// </summary>
		[JsonProperty("rateable")]
		public bool? Rateable { get; set; }

		/// <summary>
		///     RateableOnlyIfOrdered is a flag that indicates whether the
		///     product can be rated only after being ordered.
		/// </summary>
		[JsonProperty("rateableOnlyIfOrdered")]
		public bool? RateableOnlyIfOrdered { get; set; }

		/// <summary>
		///     References defines cross-product references, e.g. alternatives
		///     or follow-up products.
		/// </summary>
		[JsonProperty("references")]
		public Reference[] References { get; set; }

		/// <summary>
		///     Safetysheet is the name of an safetysheet file (in the media
		///     files) or a URL to the safetysheet on the internet.
		/// </summary>
		[JsonProperty("safetysheet")]
		public string Safetysheet { get; set; }

		/// <summary>
		///     SafetysheetURL is the URL to the safety data sheet (if
		///     available).
		/// </summary>
		[JsonProperty("safetysheetURL")]
		public string SafetysheetURL { get; set; }

		/// <summary>
		///     ScalePrices can be used when the price of the product is
		///     dependent on the ordered quantity.
		/// </summary>
		[JsonProperty("scalePrices")]
		public ScalePrice[] ScalePrices { get; set; }

		/// <summary>
		///     URL to this page.
		/// </summary>
		[JsonProperty("selfLink")]
		public string SelfLink { get; set; }

		/// <summary>
		///     Service indicates if the is a good (false) or a service (true).
		///     The default value is false.
		/// </summary>
		[JsonProperty("service")]
		public bool Service { get; set; }

		/// <summary>
		///     SPN is the supplier part number.
		/// </summary>
		[JsonProperty("spn")]
		public string Spn { get; set; }

		/// <summary>
		///     TaxCode to use for this product.
		/// </summary>
		[JsonProperty("taxCode")]
		public string TaxCode { get; set; }

		/// <summary>
		///     TaxRate for this product, a numeric value between 0.0 and 1.0.
		/// </summary>
		[JsonProperty("taxRate")]
		public double TaxRate { get; set; }

		/// <summary>
		///     Thumbnail is the name of an thumbnail image file (in the media
		///     files) or a URL to the image on the internet.
		/// </summary>
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

		/// <summary>
		///     ThubmnailURL is the URL to the thumbnail image.
		/// </summary>
		[JsonProperty("thumbnailURL")]
		public string ThumbnailURL { get; set; }

		/// <summary>
		///     Unspscs is a list of UNSPSC categories the product belongs to.
		/// </summary>
		[JsonProperty("unspscs")]
		public Unspsc[] Unspscs { get; set; }

		/// <summary>
		///     Updated is the last modification date and time of the product.
		/// </summary>
		[JsonProperty("updated")]
		public DateTimeOffset? Updated { get; set; }

		/// <summary>
		///     Visible is a flag that indicates whether this product will be
		///     visible to the end-user when shopping.
		/// </summary>
		[JsonProperty("visible")]
		public bool? Visible { get; set; }

		#endregion // Product
	}

	/// <summary>
	///     Reference describes a reference from one product to another
	///     product.
	/// </summary>
	public class Reference
	{
		#region Reference

		/// <summary>
		///     Kind describes the type of reference.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Qty describes the quantity for certain kinds of references.
		///     E.g. the consists_of kind must use the quantity field to be
		///     useful for the end-user. 
		/// </summary>
		[JsonProperty("qty")]
		public double? Qty { get; set; }

		/// <summary>
		///     SPN specifies the supplier product number of the other product.
		/// </summary>
		[JsonProperty("spn")]
		public string Spn { get; set; }

		#endregion // Reference
	}

	/// <summary>
	///     ReplaceProduct replace all properties of an existing product.
	/// </summary>
	public class ReplaceProduct
	{
		#region ReplaceProduct

		/// <summary>
		///     ASIN is the unique Amazon article number of the product.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		///     AutoConfigure is a flag that indicates whether this product can
		///     be configured automatically. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("autoConfigure")]
		public bool? AutoConfigure { get; set; }

		/// <summary>
		///     Availability allows the update of product availability data,
		///     e.g. the number of items in stock or the date when the product
		///     will be available again. 
		/// </summary>
		[JsonProperty("availability")]
		public Availability Availability { get; set; }

		/// <summary>
		///     Blobs contains information about external data, e.g.
		///     attachments like images or datasheets.
		/// </summary>
		[JsonProperty("blobs")]
		public Blob[] Blobs { get; set; }

		/// <summary>
		///     BoostFactor represents a positive or negative boost for the
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("boostFactor")]
		public double? BoostFactor { get; set; }

		/// <summary>
		///     BPN is the buyer part number of the product.
		/// </summary>
		[JsonProperty("bpn")]
		public string Bpn { get; set; }

		/// <summary>
		///     CatalogManaged is a flag that indicates whether this product is
		///     configurable (or catalog managed in OCI parlance).
		/// </summary>
		[JsonProperty("catalogManaged")]
		public bool CatalogManaged { get; set; }

		/// <summary>
		///     Categories is a list of (supplier-specific) category names the
		///     product belongs to.
		/// </summary>
		[JsonProperty("categories")]
		public string[] Categories { get; set; }

		/// <summary>
		///     Conditions describes the product conditions, e.g. refurbished
		///     or used.
		/// </summary>
		[JsonProperty("conditions")]
		public Condition[] Conditions { get; set; }

		/// <summary>
		///     Contract represents the contract number to be used when
		///     purchasing this product. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("contract")]
		public string Contract { get; set; }

		/// <summary>
		///     ContractItem represents line number in the contract to be used
		///     when purchasing this product. See also Contract. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("contractItem")]
		public string ContractItem { get; set; }

		/// <summary>
		///     ConversionDenumerator is the denumerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionDenumerator")]
		public double? ConversionDenumerator { get; set; }

		/// <summary>
		///     ConversionNumerator is the numerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionNumerator")]
		public double? ConversionNumerator { get; set; }

		/// <summary>
		///     Country represents the ISO code of the country of origin, i.e.
		///     the country where the product has been created/produced, e.g.
		///     DE. If unspecified, the field is initialized with the catalog's
		///     country field. 
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <summary>
		///     ContentUnit is the content unit of the product, a 3-character
		///     ISO code (usually project-specific).
		/// </summary>
		[JsonProperty("cu")]
		public string ContentUnit { get; set; }

		/// <summary>
		///     CuPerOu describes the number of content units per order unit,
		///     e.g. the 12 in '1 case contains 12 bottles'.
		/// </summary>
		[JsonProperty("cuPerOu")]
		public double? CuPerOu { get; set; }

		/// <summary>
		///     CustField1 is the CUST_FIELD1 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField1")]
		public string CustField1 { get; set; }

		/// <summary>
		///     CustField2 is the CUST_FIELD2 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField2")]
		public string CustField2 { get; set; }

		/// <summary>
		///     CustField3 is the CUST_FIELD3 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField3")]
		public string CustField3 { get; set; }

		/// <summary>
		///     CustField4 is the CUST_FIELD4 of the SAP OCI specification. It
		///     has a maximum length of 20 characters. 
		/// </summary>
		[JsonProperty("custField4")]
		public string CustField4 { get; set; }

		/// <summary>
		///     CustField5 is the CUST_FIELD5 of the SAP OCI specification. It
		///     has a maximum length of 50 characters. 
		/// </summary>
		[JsonProperty("custField5")]
		public string CustField5 { get; set; }

		/// <summary>
		///     CustFields is an array of generic name/value pairs for
		///     customer-specific attributes.
		/// </summary>
		[JsonProperty("custFields")]
		public CustField[] CustFields { get; set; }

		/// <summary>
		///     CustomField10 represents the 10th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField10")]
		public string CustomField10 { get; set; }

		/// <summary>
		///     CustomField11 represents the 11th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField11")]
		public string CustomField11 { get; set; }

		/// <summary>
		///     CustomField12 represents the 12th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField12")]
		public string CustomField12 { get; set; }

		/// <summary>
		///     CustomField13 represents the 13th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField13")]
		public string CustomField13 { get; set; }

		/// <summary>
		///     CustomField14 represents the 14th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField14")]
		public string CustomField14 { get; set; }

		/// <summary>
		///     CustomField15 represents the 15th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField15")]
		public string CustomField15 { get; set; }

		/// <summary>
		///     CustomField16 represents the 16th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField16")]
		public string CustomField16 { get; set; }

		/// <summary>
		///     CustomField17 represents the 17th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField17")]
		public string CustomField17 { get; set; }

		/// <summary>
		///     CustomField18 represents the 18th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField18")]
		public string CustomField18 { get; set; }

		/// <summary>
		///     CustomField19 represents the 19th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField19")]
		public string CustomField19 { get; set; }

		/// <summary>
		///     CustomField20 represents the 20th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField20")]
		public string CustomField20 { get; set; }

		/// <summary>
		///     CustomField21 represents the 21st customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField21")]
		public string CustomField21 { get; set; }

		/// <summary>
		///     CustomField22 represents the 22nd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField22")]
		public string CustomField22 { get; set; }

		/// <summary>
		///     CustomField23 represents the 23rd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField23")]
		public string CustomField23 { get; set; }

		/// <summary>
		///     CustomField24 represents the 24th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField24")]
		public string CustomField24 { get; set; }

		/// <summary>
		///     CustomField25 represents the 25th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField25")]
		public string CustomField25 { get; set; }

		/// <summary>
		///     CustomField26 represents the 26th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField26")]
		public string CustomField26 { get; set; }

		/// <summary>
		///     CustomField27 represents the 27th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField27")]
		public string CustomField27 { get; set; }

		/// <summary>
		///     CustomField28 represents the 28th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField28")]
		public string CustomField28 { get; set; }

		/// <summary>
		///     CustomField29 represents the 29th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField29")]
		public string CustomField29 { get; set; }

		/// <summary>
		///     CustomField30 represents the 30th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField30")]
		public string CustomField30 { get; set; }

		/// <summary>
		///     CustomField6 represents the 6th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField6")]
		public string CustomField6 { get; set; }

		/// <summary>
		///     CustomField7 represents the 7th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField7")]
		public string CustomField7 { get; set; }

		/// <summary>
		///     CustomField8 represents the 8th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField8")]
		public string CustomField8 { get; set; }

		/// <summary>
		///     CustomField9 represents the 9th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField9")]
		public string CustomField9 { get; set; }

		/// <summary>
		///     Datasheet is the name of an datasheet file (in the media files)
		///     or a URL to the datasheet on the internet.
		/// </summary>
		[JsonProperty("datasheet")]
		public string Datasheet { get; set; }

		/// <summary>
		///     Description of the product.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     Eclasses is a list of eCl@ss categories the product belongs to.
		/// </summary>
		[JsonProperty("eclasses")]
		public Eclass[] Eclasses { get; set; }

		/// <summary>
		///     erpGroupSupplier is the material group of the product on the
		///     merchant-/supplier-side.
		/// </summary>
		[JsonProperty("erpGroupSupplier")]
		public string ErpGroupSupplier { get; set; }

		/// <summary>
		///     Excluded is a flag that indicates whether to exclude this
		///     product from the catalog. If true, this product will not be
		///     published into the live area.
		/// </summary>
		[JsonProperty("excluded")]
		public bool Excluded { get; set; }

		/// <summary>
		///     ExtCategory is the EXT_CATEGORY field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategory")]
		public string ExtCategory { get; set; }

		/// <summary>
		///     ExtCategoryID is the EXT_CATEGORY_ID field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategoryId")]
		public string ExtCategoryId { get; set; }

		/// <summary>
		///     ExtConfigForm represents information required to make the
		///     product configurable. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("extConfigForm")]
		public string ExtConfigForm { get; set; }

		/// <summary>
		///     ExtConfigService represents additional information required to
		///     make the product configurable. See also ExtConfigForm. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("extConfigService")]
		public string ExtConfigService { get; set; }

		/// <summary>
		///     ExtProductID is the EXT_PRODUCT_ID field of the SAP OCI
		///     specification. It is e.g. required for configurable/catalog
		///     managed products.
		/// </summary>
		[JsonProperty("extProductId")]
		public string ExtProductId { get; set; }

		/// <summary>
		///     ExtSchemaType is the EXT_SCHEMA_TYPE field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extSchemaType")]
		public string ExtSchemaType { get; set; }

		/// <summary>
		///     Features defines product features, i.e. additional properties
		///     of the product.
		/// </summary>
		[JsonProperty("features")]
		public Feature[] Features { get; set; }

		/// <summary>
		///     GLAccount represents the GL account number to use for this
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("glAccount")]
		public string GlAccount { get; set; }

		/// <summary>
		///     GTIN is the global trade item number of the product (used to be
		///     EAN).
		/// </summary>
		[JsonProperty("gtin")]
		public string Gtin { get; set; }

		/// <summary>
		///     Hazmats classifies hazardous/dangerous goods.
		/// </summary>
		[JsonProperty("hazmats")]
		public Hazmat[] Hazmats { get; set; }

		/// <summary>
		///     Image is the name of an image file (in the media files) or a
		///     URL to the image on the internet.
		/// </summary>
		[JsonProperty("image")]
		public string Image { get; set; }

		/// <summary>
		///     Incomplete is a flag that indicates whether this product is
		///     incomplete. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("incomplete")]
		public bool? Incomplete { get; set; }

		/// <summary>
		///     Intrastat specifies required data for Intrastat messages. 
		/// </summary>
		[JsonProperty("intrastat")]
		public Intrastat Intrastat { get; set; }

		/// <summary>
		///     IsPassword is a flag that indicates whether this product will
		///     be used to purchase a password, e.g. for a software product.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("isPassword")]
		public bool? IsPassword { get; set; }

		/// <summary>
		///     KeepPrice is a flag that indicates whether the price of the
		///     product will or will not be calculated by the catalog. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("keepPrice")]
		public bool? KeepPrice { get; set; }

		/// <summary>
		///     Keywords is a list of aliases for the product.
		/// </summary>
		[JsonProperty("keywords")]
		public string[] Keywords { get; set; }

		/// <summary>
		///     Leadtime is the number of days for delivery.
		/// </summary>
		[JsonProperty("leadtime")]
		public double? Leadtime { get; set; }

		/// <summary>
		///     ListPrice is the net list price of the product.
		/// </summary>
		[JsonProperty("listPrice")]
		public double? ListPrice { get; set; }

		/// <summary>
		///     Manufactcode is the manufacturer code as used in the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("manufactcode")]
		public string Manufactcode { get; set; }

		/// <summary>
		///     Manufacturer is the name of the manufacturer.
		/// </summary>
		[JsonProperty("manufacturer")]
		public string Manufacturer { get; set; }

		/// <summary>
		///     Matgroup is the material group of the product on the buy-side.
		/// </summary>
		[JsonProperty("matgroup")]
		public string Matgroup { get; set; }

		/// <summary>
		///     MPN is the manufacturer part number.
		/// </summary>
		[JsonProperty("mpn")]
		public string Mpn { get; set; }

		/// <summary>
		///     MultiSupplierID represents an optional field for the unique
		///     identifier of a supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierId")]
		public string MultiSupplierId { get; set; }

		/// <summary>
		///     MultiSupplierName represents an optional field for the name of
		///     the supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierName")]
		public string MultiSupplierName { get; set; }

		/// <summary>
		///     Name of the product.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     NeedsGoodsReceipt is a flag that indicates whether this product
		///     requires a goods receipt process. Please consult your Store
		///     Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("needsGoodsReceipt")]
		public bool? NeedsGoodsReceipt { get; set; }

		/// <summary>
		///     NFBasePrice represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfBasePrice")]
		public double? NfBasePrice { get; set; }

		/// <summary>
		///     NFBasePriceQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfBasePriceQuantity")]
		public double? NfBasePriceQuantity { get; set; }

		/// <summary>
		///     NFCndID represents the key to calculate metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfCndId")]
		public string NfCndId { get; set; }

		/// <summary>
		///     NFScale represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfScale")]
		public double? NfScale { get; set; }

		/// <summary>
		///     NFScaleQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfScaleQuantity")]
		public double? NfScaleQuantity { get; set; }

		/// <summary>
		///     Orderable is a flag that indicates whether this product will be
		///     orderable to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("orderable")]
		public bool? Orderable { get; set; }

		/// <summary>
		///     OrderUnit is the order unit of the product, a 3-character ISO
		///     code (usually project-specific).
		/// </summary>
		[JsonProperty("ou")]
		public string OrderUnit { get; set; }

		/// <summary>
		///     Price is the net price (per order unit) of the product for the
		///     end-user.
		/// </summary>
		[JsonProperty("price")]
		public double Price { get; set; }

		/// <summary>
		///     PriceFormula represents the formula to calculate the price of
		///     the product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("priceFormula")]
		public string PriceFormula { get; set; }

		/// <summary>
		///     PriceQty is the quantity for which the price is specified
		///     (default: 1.0).
		/// </summary>
		[JsonProperty("priceQty")]
		public double PriceQty { get; set; }

		/// <summary>
		///     QuantityInterval is the interval in which this product can be
		///     ordered. E.g. if the quantity interval is 5, the end-user can
		///     only order in quantities of 5,10,15 etc. 
		/// </summary>
		[JsonProperty("quantityInterval")]
		public double? QuantityInterval { get; set; }

		/// <summary>
		///     QuantityMax is the maximum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMax")]
		public double? QuantityMax { get; set; }

		/// <summary>
		///     QuantityMin is the minimum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMin")]
		public double? QuantityMin { get; set; }

		/// <summary>
		///     Rateable is a flag that indicates whether the product can be
		///     rated by end-users. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("rateable")]
		public bool? Rateable { get; set; }

		/// <summary>
		///     RateableOnlyIfOrdered is a flag that indicates whether the
		///     product can be rated only after being ordered. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("rateableOnlyIfOrdered")]
		public bool? RateableOnlyIfOrdered { get; set; }

		/// <summary>
		///     References defines cross-product references, e.g. alternatives
		///     or follow-up products.
		/// </summary>
		[JsonProperty("references")]
		public Reference[] References { get; set; }

		/// <summary>
		///     Safetysheet is the name of an safetysheet file (in the media
		///     files) or a URL to the safetysheet on the internet.
		/// </summary>
		[JsonProperty("safetysheet")]
		public string Safetysheet { get; set; }

		/// <summary>
		///     ScalePrices can be used when the price of the product is
		///     dependent on the ordered quantity.
		/// </summary>
		[JsonProperty("scalePrices")]
		public ScalePrice[] ScalePrices { get; set; }

		/// <summary>
		///     Service indicates if the is a good (false) or a service (true).
		///     The default value is false.
		/// </summary>
		[JsonProperty("service")]
		public bool Service { get; set; }

		/// <summary>
		///     TaxCode to use for this product. This is typically
		///     project-specific.
		/// </summary>
		[JsonProperty("taxCode")]
		public string TaxCode { get; set; }

		/// <summary>
		///     TaxRate for this product, a numeric value between 0.0 and 1.0.
		/// </summary>
		[JsonProperty("taxRate")]
		public double TaxRate { get; set; }

		/// <summary>
		///     Thumbnail is the name of an thumbnail image file (in the media
		///     files) or a URL to the image on the internet.
		/// </summary>
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

		/// <summary>
		///     Unspscs is a list of UNSPSC categories the product belongs to.
		/// </summary>
		[JsonProperty("unspscs")]
		public Unspsc[] Unspscs { get; set; }

		/// <summary>
		///     Visible is a flag that indicates whether this product will be
		///     visible to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("visible")]
		public bool? Visible { get; set; }

		#endregion // ReplaceProduct
	}

	/// <summary>
	///     ReplaceProductResponse is the outcome of a successful
	///     replacement of a product.
	/// </summary>
	public class ReplaceProductResponse
	{
		#region ReplaceProductResponse

		/// <summary>
		///     Kind describes this entity.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Link returns a URL to the representation of the replaced
		///     product.
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		#endregion // ReplaceProductResponse
	}

	/// <summary>
	///     ScalePrice describes a price that is dependent on the ordered
	///     quantity.
	/// </summary>
	public class ScalePrice
	{
		#region ScalePrice

		/// <summary>
		///     LBound is the lower bound when this price will become
		///     effective.
		/// </summary>
		[JsonProperty("lbound")]
		public double Lbound { get; set; }

		/// <summary>
		///     ListPrice is the list price for the given lower bound.
		/// </summary>
		[JsonProperty("listPrice")]
		public double? ListPrice { get; set; }

		/// <summary>
		///     MeplatoPrice is the Meplato price for the given lower bound.
		/// </summary>
		[JsonProperty("meplatoPrice")]
		public double? MeplatoPrice { get; set; }

		/// <summary>
		///     Price is the net price for the given lower bound.
		/// </summary>
		[JsonProperty("price")]
		public double Price { get; set; }

		#endregion // ScalePrice
	}

	/// <summary>
	///     ScrollResponse is a slice of products from a catalog.
	/// </summary>
	public class ScrollResponse
	{
		#region ScrollResponse

		/// <summary>
		///     Items is the slice of products of this result.
		/// </summary>
		[JsonProperty("items")]
		public Product[] Items { get; set; }

		/// <summary>
		///     Kind is store#products/scroll for this kind of response.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     NextLink returns the URL to the next slice of products (if
		///     any).
		/// </summary>
		[JsonProperty("nextLink")]
		public string NextLink { get; set; }

		/// <summary>
		///     PageToken needs to be passed to get the next slice of products.
		///     It is blank if there are no more products. Instead of using
		///     pageToken for your next request, you can also follow nextLink.
		/// </summary>
		[JsonProperty("pageToken")]
		public string PageToken { get; set; }

		/// <summary>
		///     PreviousLink returns the URL of the previous slice of products
		///     (if any).
		/// </summary>
		[JsonProperty("previousLink")]
		public string PreviousLink { get; set; }

		/// <summary>
		///     SelfLink returns the URL to this page.
		/// </summary>
		[JsonProperty("selfLink")]
		public string SelfLink { get; set; }

		/// <summary>
		///     TotalItems describes the total number of products found.
		/// </summary>
		[JsonProperty("totalItems")]
		public long TotalItems { get; set; }

		#endregion // ScrollResponse
	}

	/// <summary>
	///     SearchResponse is a partial listing of products.
	/// </summary>
	public class SearchResponse
	{
		#region SearchResponse

		/// <summary>
		///     Items is the slice of products of this result.
		/// </summary>
		[JsonProperty("items")]
		public Product[] Items { get; set; }

		/// <summary>
		///     Kind is store#products/search for this kind of response.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     NextLink returns the URL to the next slice of products (if
		///     any).
		/// </summary>
		[JsonProperty("nextLink")]
		public string NextLink { get; set; }

		/// <summary>
		///     PreviousLink returns the URL of the previous slice of products
		///     (if any).
		/// </summary>
		[JsonProperty("previousLink")]
		public string PreviousLink { get; set; }

		/// <summary>
		///     SelfLink returns the URL to this page.
		/// </summary>
		[JsonProperty("selfLink")]
		public string SelfLink { get; set; }

		/// <summary>
		///     TotalItems describes the total number of products found.
		/// </summary>
		[JsonProperty("totalItems")]
		public long TotalItems { get; set; }

		#endregion // SearchResponse
	}

	/// <summary>
	///     Unspsc is used to tie a product to a UNSPSC schema.
	/// </summary>
	public class Unspsc
	{
		#region Unspsc

		/// <summary>
		///     Code is the UNSPSC code. Only use digits for encoding, e.g.
		///     43211503.
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     Version is the UNSPSC version in the major.minor format, e.g.
		///     16.0901.
		/// </summary>
		[JsonProperty("version")]
		public string Version { get; set; }

		#endregion // Unspsc
	}

	/// <summary>
	///     UpdateProduct holds the properties of a product that need to be
	///     updated.
	/// </summary>
	public class UpdateProduct
	{
		#region UpdateProduct

		/// <summary>
		///     ASIN is the unique Amazon article number of the product.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		///     AutoConfigure is a flag that indicates whether this product can
		///     be configured automatically. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("autoConfigure")]
		public bool? AutoConfigure { get; set; }

		/// <summary>
		///     Availability allows the update of product availability data,
		///     e.g. the number of items in stock or the date when the product
		///     will be available again. 
		/// </summary>
		[JsonProperty("availability")]
		public Availability Availability { get; set; }

		/// <summary>
		///     Blobs specifies external data, e.g. images or datasheets.
		/// </summary>
		[JsonProperty("blobs")]
		public Blob[] Blobs { get; set; }

		/// <summary>
		///     BoostFactor represents a positive or negative boost for the
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("boostFactor")]
		public double? BoostFactor { get; set; }

		/// <summary>
		///     BPN is the buyer part number of the product.
		/// </summary>
		[JsonProperty("bpn")]
		public string Bpn { get; set; }

		/// <summary>
		///     CatalogManaged is a flag that indicates whether this product is
		///     configurable (or catalog managed in OCI parlance).
		/// </summary>
		[JsonProperty("catalogManaged")]
		public bool? CatalogManaged { get; set; }

		/// <summary>
		///     Categories is a list of (supplier-specific) category names the
		///     product belongs to.
		/// </summary>
		[JsonProperty("categories")]
		public string[] Categories { get; set; }

		/// <summary>
		///     Conditions describes the product conditions, e.g. refurbished
		///     or used.
		/// </summary>
		[JsonProperty("conditions")]
		public Condition[] Conditions { get; set; }

		/// <summary>
		///     Contract represents the contract number to be used when
		///     purchasing this product. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("contract")]
		public string Contract { get; set; }

		/// <summary>
		///     ContractItem represents line number in the contract to be used
		///     when purchasing this product. See also Contract. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("contractItem")]
		public string ContractItem { get; set; }

		/// <summary>
		///     ConversionDenumerator is the denumerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionDenumerator")]
		public double? ConversionDenumerator { get; set; }

		/// <summary>
		///     ConversionNumerator is the numerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionNumerator")]
		public double? ConversionNumerator { get; set; }

		/// <summary>
		///     Country represents the ISO code of the country of origin, i.e.
		///     the country where the product has been created/produced, e.g.
		///     DE. If unspecified, the field is initialized with the catalog's
		///     country field. 
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <summary>
		///     ContentUnit is the content unit of the product, a 3-character
		///     ISO code (usually project-specific).
		/// </summary>
		[JsonProperty("cu")]
		public string ContentUnit { get; set; }

		/// <summary>
		///     CuPerOu describes the number of content units per order unit,
		///     e.g. the 12 in '1 case contains 12 bottles'.
		/// </summary>
		[JsonProperty("cuPerOu")]
		public double? CuPerOu { get; set; }

		/// <summary>
		///     CustField1 is the CUST_FIELD1 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField1")]
		public string CustField1 { get; set; }

		/// <summary>
		///     CustField2 is the CUST_FIELD2 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField2")]
		public string CustField2 { get; set; }

		/// <summary>
		///     CustField3 is the CUST_FIELD3 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField3")]
		public string CustField3 { get; set; }

		/// <summary>
		///     CustField4 is the CUST_FIELD4 of the SAP OCI specification. It
		///     has a maximum length of 20 characters. 
		/// </summary>
		[JsonProperty("custField4")]
		public string CustField4 { get; set; }

		/// <summary>
		///     CustField5 is the CUST_FIELD5 of the SAP OCI specification. It
		///     has a maximum length of 50 characters. 
		/// </summary>
		[JsonProperty("custField5")]
		public string CustField5 { get; set; }

		/// <summary>
		///     CustFields is an array of generic name/value pairs for
		///     customer-specific attributes.
		/// </summary>
		[JsonProperty("custFields")]
		public CustField[] CustFields { get; set; }

		/// <summary>
		///     CustomField10 represents the 10th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField10")]
		public string CustomField10 { get; set; }

		/// <summary>
		///     CustomField11 represents the 11th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField11")]
		public string CustomField11 { get; set; }

		/// <summary>
		///     CustomField12 represents the 12th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField12")]
		public string CustomField12 { get; set; }

		/// <summary>
		///     CustomField13 represents the 13th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField13")]
		public string CustomField13 { get; set; }

		/// <summary>
		///     CustomField14 represents the 14th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField14")]
		public string CustomField14 { get; set; }

		/// <summary>
		///     CustomField15 represents the 15th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField15")]
		public string CustomField15 { get; set; }

		/// <summary>
		///     CustomField16 represents the 16th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField16")]
		public string CustomField16 { get; set; }

		/// <summary>
		///     CustomField17 represents the 17th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField17")]
		public string CustomField17 { get; set; }

		/// <summary>
		///     CustomField18 represents the 18th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField18")]
		public string CustomField18 { get; set; }

		/// <summary>
		///     CustomField19 represents the 19th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField19")]
		public string CustomField19 { get; set; }

		/// <summary>
		///     CustomField20 represents the 20th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField20")]
		public string CustomField20 { get; set; }

		/// <summary>
		///     CustomField21 represents the 21st customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField21")]
		public string CustomField21 { get; set; }

		/// <summary>
		///     CustomField22 represents the 22nd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField22")]
		public string CustomField22 { get; set; }

		/// <summary>
		///     CustomField23 represents the 23rd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField23")]
		public string CustomField23 { get; set; }

		/// <summary>
		///     CustomField24 represents the 24th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField24")]
		public string CustomField24 { get; set; }

		/// <summary>
		///     CustomField25 represents the 25th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField25")]
		public string CustomField25 { get; set; }

		/// <summary>
		///     CustomField26 represents the 26th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField26")]
		public string CustomField26 { get; set; }

		/// <summary>
		///     CustomField27 represents the 27th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField27")]
		public string CustomField27 { get; set; }

		/// <summary>
		///     CustomField28 represents the 28th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField28")]
		public string CustomField28 { get; set; }

		/// <summary>
		///     CustomField29 represents the 29th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField29")]
		public string CustomField29 { get; set; }

		/// <summary>
		///     CustomField30 represents the 30th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField30")]
		public string CustomField30 { get; set; }

		/// <summary>
		///     CustomField6 represents the 6th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField6")]
		public string CustomField6 { get; set; }

		/// <summary>
		///     CustomField7 represents the 7th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField7")]
		public string CustomField7 { get; set; }

		/// <summary>
		///     CustomField8 represents the 8th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField8")]
		public string CustomField8 { get; set; }

		/// <summary>
		///     CustomField9 represents the 9th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField9")]
		public string CustomField9 { get; set; }

		/// <summary>
		///     Datasheet is the name of an datasheet file (in the media files)
		///     or a URL to the datasheet on the internet.
		/// </summary>
		[JsonProperty("datasheet")]
		public string Datasheet { get; set; }

		/// <summary>
		///     Description of the product.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     Eclasses is a list of eCl@ss categories the product belongs to.
		/// </summary>
		[JsonProperty("eclasses")]
		public Eclass[] Eclasses { get; set; }

		/// <summary>
		///     erpGroupSupplier is the material group of the product on the
		///     merchant-/supplier-side.
		/// </summary>
		[JsonProperty("erpGroupSupplier")]
		public string ErpGroupSupplier { get; set; }

		/// <summary>
		///     Excluded is a flag that indicates whether to exclude this
		///     product from the catalog. If true, this product will not be
		///     published into the live area.
		/// </summary>
		[JsonProperty("excluded")]
		public bool? Excluded { get; set; }

		/// <summary>
		///     ExtCategory is the EXT_CATEGORY field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategory")]
		public string ExtCategory { get; set; }

		/// <summary>
		///     ExtCategoryID is the EXT_CATEGORY_ID field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategoryId")]
		public string ExtCategoryId { get; set; }

		/// <summary>
		///     ExtConfigForm represents information required to make the
		///     product configurable. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("extConfigForm")]
		public string ExtConfigForm { get; set; }

		/// <summary>
		///     ExtConfigService represents additional information required to
		///     make the product configurable. See also ExtConfigForm. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("extConfigService")]
		public string ExtConfigService { get; set; }

		/// <summary>
		///     ExtProductID is the EXT_PRODUCT_ID field of the SAP OCI
		///     specification. It is e.g. required for configurable/catalog
		///     managed products.
		/// </summary>
		[JsonProperty("extProductId")]
		public string ExtProductId { get; set; }

		/// <summary>
		///     ExtSchemaType is the EXT_SCHEMA_TYPE field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extSchemaType")]
		public string ExtSchemaType { get; set; }

		/// <summary>
		///     Features defines product features, i.e. additional properties
		///     of the product.
		/// </summary>
		[JsonProperty("features")]
		public Feature[] Features { get; set; }

		/// <summary>
		///     GLAccount represents the GL account number to use for this
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("glAccount")]
		public string GlAccount { get; set; }

		/// <summary>
		///     GTIN is the global trade item number of the product (used to be
		///     EAN).
		/// </summary>
		[JsonProperty("gtin")]
		public string Gtin { get; set; }

		/// <summary>
		///     Hazmats classifies hazardous/dangerous goods.
		/// </summary>
		[JsonProperty("hazmats")]
		public Hazmat[] Hazmats { get; set; }

		/// <summary>
		///     Image is the name of an image file (in the media files) or a
		///     URL to the image on the internet.
		/// </summary>
		[JsonProperty("image")]
		public string Image { get; set; }

		/// <summary>
		///     Incomplete is a flag that indicates whether this product is
		///     incomplete. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("incomplete")]
		public bool? Incomplete { get; set; }

		/// <summary>
		///     Intrastat specifies required data for Intrastat messages. 
		/// </summary>
		[JsonProperty("intrastat")]
		public Intrastat Intrastat { get; set; }

		/// <summary>
		///     IsPassword is a flag that indicates whether this product will
		///     be used to purchase a password, e.g. for a software product.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("isPassword")]
		public bool? IsPassword { get; set; }

		/// <summary>
		///     KeepPrice is a flag that indicates whether the price of the
		///     product will or will not be calculated by the catalog. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("keepPrice")]
		public bool? KeepPrice { get; set; }

		/// <summary>
		///     Keywords is a list of aliases for the product.
		/// </summary>
		[JsonProperty("keywords")]
		public string[] Keywords { get; set; }

		/// <summary>
		///     Leadtime is the number of days for delivery.
		/// </summary>
		[JsonProperty("leadtime")]
		public double? Leadtime { get; set; }

		/// <summary>
		///     ListPrice is the net list price of the product.
		/// </summary>
		[JsonProperty("listPrice")]
		public double? ListPrice { get; set; }

		/// <summary>
		///     Manufactcode is the manufacturer code as used in the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("manufactcode")]
		public string Manufactcode { get; set; }

		/// <summary>
		///     Manufacturer is the name of the manufacturer.
		/// </summary>
		[JsonProperty("manufacturer")]
		public string Manufacturer { get; set; }

		/// <summary>
		///     Matgroup is the material group of the product on the buy-side.
		/// </summary>
		[JsonProperty("matgroup")]
		public string Matgroup { get; set; }

		/// <summary>
		///     MPN is the manufacturer part number.
		/// </summary>
		[JsonProperty("mpn")]
		public string Mpn { get; set; }

		/// <summary>
		///     MultiSupplierID represents an optional field for the unique
		///     identifier of a supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierId")]
		public string MultiSupplierId { get; set; }

		/// <summary>
		///     MultiSupplierName represents an optional field for the name of
		///     the supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierName")]
		public string MultiSupplierName { get; set; }

		/// <summary>
		///     Name of the product.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     NeedsGoodsReceipt is a flag that indicates whether this product
		///     requires a goods receipt process. Please consult your Store
		///     Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("needsGoodsReceipt")]
		public bool? NeedsGoodsReceipt { get; set; }

		/// <summary>
		///     NFBasePrice represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfBasePrice")]
		public double? NfBasePrice { get; set; }

		/// <summary>
		///     NFBasePriceQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfBasePriceQuantity")]
		public double? NfBasePriceQuantity { get; set; }

		/// <summary>
		///     NFCndID represents the key to calculate metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfCndId")]
		public string NfCndId { get; set; }

		/// <summary>
		///     NFScale represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfScale")]
		public double? NfScale { get; set; }

		/// <summary>
		///     NFScaleQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfScaleQuantity")]
		public double? NfScaleQuantity { get; set; }

		/// <summary>
		///     Orderable is a flag that indicates whether this product will be
		///     orderable to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("orderable")]
		public bool? Orderable { get; set; }

		/// <summary>
		///     OrderUnit is the order unit of the product, a 3-character ISO
		///     code (usually project-specific).
		/// </summary>
		[JsonProperty("ou")]
		public string OrderUnit { get; set; }

		/// <summary>
		///     Price is the net price (per order unit) of the product for the
		///     end-user.
		/// </summary>
		[JsonProperty("price")]
		public double? Price { get; set; }

		/// <summary>
		///     PriceFormula represents the formula to calculate the price of
		///     the product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("priceFormula")]
		public string PriceFormula { get; set; }

		/// <summary>
		///     PriceQty is the quantity for which the price is specified
		///     (default: 1.0).
		/// </summary>
		[JsonProperty("priceQty")]
		public double? PriceQty { get; set; }

		/// <summary>
		///     QuantityInterval is the interval in which this product can be
		///     ordered. E.g. if the quantity interval is 5, the end-user can
		///     only order in quantities of 5,10,15 etc. 
		/// </summary>
		[JsonProperty("quantityInterval")]
		public double? QuantityInterval { get; set; }

		/// <summary>
		///     QuantityMax is the maximum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMax")]
		public double? QuantityMax { get; set; }

		/// <summary>
		///     QuantityMin is the minimum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMin")]
		public double? QuantityMin { get; set; }

		/// <summary>
		///     Rateable is a flag that indicates whether the product can be
		///     rated by end-users. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("rateable")]
		public bool? Rateable { get; set; }

		/// <summary>
		///     RateableOnlyIfOrdered is a flag that indicates whether the
		///     product can be rated only after being ordered. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("rateableOnlyIfOrdered")]
		public bool? RateableOnlyIfOrdered { get; set; }

		/// <summary>
		///     References defines cross-product references, e.g. alternatives
		///     or follow-up products.
		/// </summary>
		[JsonProperty("references")]
		public Reference[] References { get; set; }

		/// <summary>
		///     Safetysheet is the name of an safetysheet file (in the media
		///     files) or a URL to the safetysheet on the internet.
		/// </summary>
		[JsonProperty("safetysheet")]
		public string Safetysheet { get; set; }

		/// <summary>
		///     ScalePrices can be used when the price of the product is
		///     dependent on the ordered quantity.
		/// </summary>
		[JsonProperty("scalePrices")]
		public ScalePrice[] ScalePrices { get; set; }

		/// <summary>
		///     Service indicates if the is a good (false) or a service (true).
		///     The default value is false.
		/// </summary>
		[JsonProperty("service")]
		public bool? Service { get; set; }

		/// <summary>
		///     TaxCode to use for this product. This is typically
		///     project-specific.
		/// </summary>
		[JsonProperty("taxCode")]
		public string TaxCode { get; set; }

		/// <summary>
		///     TaxRate for this product, a numeric value between 0.0 and 1.0.
		/// </summary>
		[JsonProperty("taxRate")]
		public double? TaxRate { get; set; }

		/// <summary>
		///     Thumbnail is the name of an thumbnail image file (in the media
		///     files) or a URL to the image on the internet.
		/// </summary>
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

		/// <summary>
		///     Unspscs is a list of UNSPSC categories the product belongs to.
		/// </summary>
		[JsonProperty("unspscs")]
		public Unspsc[] Unspscs { get; set; }

		/// <summary>
		///     Visible is a flag that indicates whether this product will be
		///     visible to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("visible")]
		public bool? Visible { get; set; }

		#endregion // UpdateProduct
	}

	/// <summary>
	///     UpdateProductResponse is the outcome of a successful request to
	///     update a product.
	/// </summary>
	public class UpdateProductResponse
	{
		#region UpdateProductResponse

		/// <summary>
		///     Kind describes this entity.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Link returns a URL to the representation of the updated
		///     product.
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		#endregion // UpdateProductResponse
	}

	/// <summary>
	///     UpsertProduct holds the properties of the product to create or
	///     update.
	/// </summary>
	public class UpsertProduct
	{
		#region UpsertProduct

		/// <summary>
		///     ASIN is the unique Amazon article number of the product.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		///     AutoConfigure is a flag that indicates whether this product can
		///     be configured automatically. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("autoConfigure")]
		public bool? AutoConfigure { get; set; }

		/// <summary>
		///     Availability allows the update of product availability data,
		///     e.g. the number of items in stock or the date when the product
		///     will be available again. 
		/// </summary>
		[JsonProperty("availability")]
		public Availability Availability { get; set; }

		/// <summary>
		///     Blobs specifies external data, e.g. images or datasheets.
		/// </summary>
		[JsonProperty("blobs")]
		public Blob[] Blobs { get; set; }

		/// <summary>
		///     BoostFactor represents a positive or negative boost for the
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("boostFactor")]
		public double? BoostFactor { get; set; }

		/// <summary>
		///     BPN is the buyer part number of the product.
		/// </summary>
		[JsonProperty("bpn")]
		public string Bpn { get; set; }

		/// <summary>
		///     CatalogManaged is a flag that indicates whether this product is
		///     configurable (or catalog managed in OCI parlance).
		/// </summary>
		[JsonProperty("catalogManaged")]
		public bool CatalogManaged { get; set; }

		/// <summary>
		///     Categories is a list of (supplier-specific) category names the
		///     product belongs to.
		/// </summary>
		[JsonProperty("categories")]
		public string[] Categories { get; set; }

		/// <summary>
		///     Conditions describes the product conditions, e.g. refurbished
		///     or used.
		/// </summary>
		[JsonProperty("conditions")]
		public Condition[] Conditions { get; set; }

		/// <summary>
		///     Contract represents the contract number to be used when
		///     purchasing this product. Please consult your Store Manager
		///     before setting a value for this field.
		/// </summary>
		[JsonProperty("contract")]
		public string Contract { get; set; }

		/// <summary>
		///     ContractItem represents line number in the contract to be used
		///     when purchasing this product. See also Contract. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("contractItem")]
		public string ContractItem { get; set; }

		/// <summary>
		///     ConversionDenumerator is the denumerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionDenumerator")]
		public double? ConversionDenumerator { get; set; }

		/// <summary>
		///     ConversionNumerator is the numerator for calculating price
		///     quantities. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("conversionNumerator")]
		public double? ConversionNumerator { get; set; }

		/// <summary>
		///     Country represents the ISO code of the country of origin, i.e.
		///     the country where the product has been created/produced, e.g.
		///     DE. If unspecified, the field is initialized with the catalog's
		///     country field. 
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <summary>
		///     ContentUnit is the content unit of the product, a 3-character
		///     ISO code (usually project-specific).
		/// </summary>
		[JsonProperty("cu")]
		public string ContentUnit { get; set; }

		/// <summary>
		///     CuPerOu describes the number of content units per order unit,
		///     e.g. the 12 in '1 case contains 12 bottles'.
		/// </summary>
		[JsonProperty("cuPerOu")]
		public double? CuPerOu { get; set; }

		/// <summary>
		///     CustField1 is the CUST_FIELD1 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField1")]
		public string CustField1 { get; set; }

		/// <summary>
		///     CustField2 is the CUST_FIELD2 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField2")]
		public string CustField2 { get; set; }

		/// <summary>
		///     CustField3 is the CUST_FIELD3 of the SAP OCI specification. It
		///     has a maximum length of 10 characters. 
		/// </summary>
		[JsonProperty("custField3")]
		public string CustField3 { get; set; }

		/// <summary>
		///     CustField4 is the CUST_FIELD4 of the SAP OCI specification. It
		///     has a maximum length of 20 characters. 
		/// </summary>
		[JsonProperty("custField4")]
		public string CustField4 { get; set; }

		/// <summary>
		///     CustField5 is the CUST_FIELD5 of the SAP OCI specification. It
		///     has a maximum length of 50 characters. 
		/// </summary>
		[JsonProperty("custField5")]
		public string CustField5 { get; set; }

		/// <summary>
		///     CustFields is an array of generic name/value pairs for
		///     customer-specific attributes.
		/// </summary>
		[JsonProperty("custFields")]
		public CustField[] CustFields { get; set; }

		/// <summary>
		///     CustomField10 represents the 10th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField10")]
		public string CustomField10 { get; set; }

		/// <summary>
		///     CustomField11 represents the 11th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField11")]
		public string CustomField11 { get; set; }

		/// <summary>
		///     CustomField12 represents the 12th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField12")]
		public string CustomField12 { get; set; }

		/// <summary>
		///     CustomField13 represents the 13th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField13")]
		public string CustomField13 { get; set; }

		/// <summary>
		///     CustomField14 represents the 14th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField14")]
		public string CustomField14 { get; set; }

		/// <summary>
		///     CustomField15 represents the 15th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField15")]
		public string CustomField15 { get; set; }

		/// <summary>
		///     CustomField16 represents the 16th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField16")]
		public string CustomField16 { get; set; }

		/// <summary>
		///     CustomField17 represents the 17th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField17")]
		public string CustomField17 { get; set; }

		/// <summary>
		///     CustomField18 represents the 18th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField18")]
		public string CustomField18 { get; set; }

		/// <summary>
		///     CustomField19 represents the 19th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField19")]
		public string CustomField19 { get; set; }

		/// <summary>
		///     CustomField20 represents the 20th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField20")]
		public string CustomField20 { get; set; }

		/// <summary>
		///     CustomField21 represents the 21st customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField21")]
		public string CustomField21 { get; set; }

		/// <summary>
		///     CustomField22 represents the 22nd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField22")]
		public string CustomField22 { get; set; }

		/// <summary>
		///     CustomField23 represents the 23rd customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField23")]
		public string CustomField23 { get; set; }

		/// <summary>
		///     CustomField24 represents the 24th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField24")]
		public string CustomField24 { get; set; }

		/// <summary>
		///     CustomField25 represents the 25th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField25")]
		public string CustomField25 { get; set; }

		/// <summary>
		///     CustomField26 represents the 26th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField26")]
		public string CustomField26 { get; set; }

		/// <summary>
		///     CustomField27 represents the 27th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField27")]
		public string CustomField27 { get; set; }

		/// <summary>
		///     CustomField28 represents the 28th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField28")]
		public string CustomField28 { get; set; }

		/// <summary>
		///     CustomField29 represents the 29th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField29")]
		public string CustomField29 { get; set; }

		/// <summary>
		///     CustomField30 represents the 30th customer-specific field.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("customField30")]
		public string CustomField30 { get; set; }

		/// <summary>
		///     CustomField6 represents the 6th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField6")]
		public string CustomField6 { get; set; }

		/// <summary>
		///     CustomField7 represents the 7th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField7")]
		public string CustomField7 { get; set; }

		/// <summary>
		///     CustomField8 represents the 8th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField8")]
		public string CustomField8 { get; set; }

		/// <summary>
		///     CustomField9 represents the 9th customer-specific field. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("customField9")]
		public string CustomField9 { get; set; }

		/// <summary>
		///     Datasheet is the name of an datasheet file (in the media files)
		///     or a URL to the datasheet on the internet.
		/// </summary>
		[JsonProperty("datasheet")]
		public string Datasheet { get; set; }

		/// <summary>
		///     Description of the product.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     Eclasses is a list of eCl@ss categories the product belongs to.
		/// </summary>
		[JsonProperty("eclasses")]
		public Eclass[] Eclasses { get; set; }

		/// <summary>
		///     erpGroupSupplier is the material group of the product on the
		///     merchant-/supplier-side.
		/// </summary>
		[JsonProperty("erpGroupSupplier")]
		public string ErpGroupSupplier { get; set; }

		/// <summary>
		///     Excluded is a flag that indicates whether to exclude this
		///     product from the catalog. If true, this product will not be
		///     published into the live area.
		/// </summary>
		[JsonProperty("excluded")]
		public bool Excluded { get; set; }

		/// <summary>
		///     ExtCategory is the EXT_CATEGORY field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategory")]
		public string ExtCategory { get; set; }

		/// <summary>
		///     ExtCategoryID is the EXT_CATEGORY_ID field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extCategoryId")]
		public string ExtCategoryId { get; set; }

		/// <summary>
		///     ExtConfigForm represents information required to make the
		///     product configurable. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("extConfigForm")]
		public string ExtConfigForm { get; set; }

		/// <summary>
		///     ExtConfigService represents additional information required to
		///     make the product configurable. See also ExtConfigForm. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("extConfigService")]
		public string ExtConfigService { get; set; }

		/// <summary>
		///     ExtProductID is the EXT_PRODUCT_ID field of the SAP OCI
		///     specification. It is e.g. required for configurable/catalog
		///     managed products.
		/// </summary>
		[JsonProperty("extProductId")]
		public string ExtProductId { get; set; }

		/// <summary>
		///     ExtSchemaType is the EXT_SCHEMA_TYPE field of the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("extSchemaType")]
		public string ExtSchemaType { get; set; }

		/// <summary>
		///     Features defines product features, i.e. additional properties
		///     of the product.
		/// </summary>
		[JsonProperty("features")]
		public Feature[] Features { get; set; }

		/// <summary>
		///     GLAccount represents the GL account number to use for this
		///     product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("glAccount")]
		public string GlAccount { get; set; }

		/// <summary>
		///     GTIN is the global trade item number of the product (used to be
		///     EAN).
		/// </summary>
		[JsonProperty("gtin")]
		public string Gtin { get; set; }

		/// <summary>
		///     Hazmats classifies hazardous/dangerous goods.
		/// </summary>
		[JsonProperty("hazmats")]
		public Hazmat[] Hazmats { get; set; }

		/// <summary>
		///     Image is the name of an image file (in the media files) or a
		///     URL to the image on the internet.
		/// </summary>
		[JsonProperty("image")]
		public string Image { get; set; }

		/// <summary>
		///     Incomplete is a flag that indicates whether this product is
		///     incomplete. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("incomplete")]
		public bool? Incomplete { get; set; }

		/// <summary>
		///     Intrastat specifies required data for Intrastat messages. 
		/// </summary>
		[JsonProperty("intrastat")]
		public Intrastat Intrastat { get; set; }

		/// <summary>
		///     IsPassword is a flag that indicates whether this product will
		///     be used to purchase a password, e.g. for a software product.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("isPassword")]
		public bool? IsPassword { get; set; }

		/// <summary>
		///     KeepPrice is a flag that indicates whether the price of the
		///     product will or will not be calculated by the catalog. Please
		///     consult your Store Manager before setting a value for this
		///     field.
		/// </summary>
		[JsonProperty("keepPrice")]
		public bool? KeepPrice { get; set; }

		/// <summary>
		///     Keywords is a list of aliases for the product.
		/// </summary>
		[JsonProperty("keywords")]
		public string[] Keywords { get; set; }

		/// <summary>
		///     Leadtime is the number of days for delivery.
		/// </summary>
		[JsonProperty("leadtime")]
		public double? Leadtime { get; set; }

		/// <summary>
		///     ListPrice is the net list price of the product.
		/// </summary>
		[JsonProperty("listPrice")]
		public double? ListPrice { get; set; }

		/// <summary>
		///     Manufactcode is the manufacturer code as used in the SAP OCI
		///     specification.
		/// </summary>
		[JsonProperty("manufactcode")]
		public string Manufactcode { get; set; }

		/// <summary>
		///     Manufacturer is the name of the manufacturer.
		/// </summary>
		[JsonProperty("manufacturer")]
		public string Manufacturer { get; set; }

		/// <summary>
		///     Matgroup is the material group of the product on the buy-side.
		/// </summary>
		[JsonProperty("matgroup")]
		public string Matgroup { get; set; }

		/// <summary>
		///     MPN is the manufacturer part number.
		/// </summary>
		[JsonProperty("mpn")]
		public string Mpn { get; set; }

		/// <summary>
		///     MultiSupplierID represents an optional field for the unique
		///     identifier of a supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierId")]
		public string MultiSupplierId { get; set; }

		/// <summary>
		///     MultiSupplierName represents an optional field for the name of
		///     the supplier in a multi-supplier catalog.
		/// </summary>
		[JsonProperty("multiSupplierName")]
		public string MultiSupplierName { get; set; }

		/// <summary>
		///     Name of the product. The product name is a required field
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     NeedsGoodsReceipt is a flag that indicates whether this product
		///     requires a goods receipt process. Please consult your Store
		///     Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("needsGoodsReceipt")]
		public bool? NeedsGoodsReceipt { get; set; }

		/// <summary>
		///     NFBasePrice represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfBasePrice")]
		public double? NfBasePrice { get; set; }

		/// <summary>
		///     NFBasePriceQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfBasePriceQuantity")]
		public double? NfBasePriceQuantity { get; set; }

		/// <summary>
		///     NFCndID represents the key to calculate metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfCndId")]
		public string NfCndId { get; set; }

		/// <summary>
		///     NFScale represents a part for calculating metal surcharges.
		///     Please consult your Store Manager before setting a value for
		///     this field.
		/// </summary>
		[JsonProperty("nfScale")]
		public double? NfScale { get; set; }

		/// <summary>
		///     NFScaleQuantity represents a part for calculating metal
		///     surcharges. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("nfScaleQuantity")]
		public double? NfScaleQuantity { get; set; }

		/// <summary>
		///     Orderable is a flag that indicates whether this product will be
		///     orderable to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("orderable")]
		public bool? Orderable { get; set; }

		/// <summary>
		///     OrderUnit is the order unit of the product, a 3-character ISO
		///     code (usually project-specific). OrderUnit is a required field.
		/// </summary>
		[JsonProperty("ou")]
		public string OrderUnit { get; set; }

		/// <summary>
		///     Price is the net price (per order unit) of the product for the
		///     end-user. Price is a required field.
		/// </summary>
		[JsonProperty("price")]
		public double Price { get; set; }

		/// <summary>
		///     PriceFormula represents the formula to calculate the price of
		///     the product. Please consult your Store Manager before setting a
		///     value for this field.
		/// </summary>
		[JsonProperty("priceFormula")]
		public string PriceFormula { get; set; }

		/// <summary>
		///     PriceQty is the quantity for which the price is specified
		///     (default: 1.0).
		/// </summary>
		[JsonProperty("priceQty")]
		public double? PriceQty { get; set; }

		/// <summary>
		///     QuantityInterval is the interval in which this product can be
		///     ordered. E.g. if the quantity interval is 5, the end-user can
		///     only order in quantities of 5,10,15 etc. 
		/// </summary>
		[JsonProperty("quantityInterval")]
		public double? QuantityInterval { get; set; }

		/// <summary>
		///     QuantityMax is the maximum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMax")]
		public double? QuantityMax { get; set; }

		/// <summary>
		///     QuantityMin is the minimum order quantity for this product.
		/// </summary>
		[JsonProperty("quantityMin")]
		public double? QuantityMin { get; set; }

		/// <summary>
		///     Rateable is a flag that indicates whether the product can be
		///     rated by end-users. Please consult your Store Manager before
		///     setting a value for this field.
		/// </summary>
		[JsonProperty("rateable")]
		public bool? Rateable { get; set; }

		/// <summary>
		///     RateableOnlyIfOrdered is a flag that indicates whether the
		///     product can be rated only after being ordered. Please consult
		///     your Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("rateableOnlyIfOrdered")]
		public bool? RateableOnlyIfOrdered { get; set; }

		/// <summary>
		///     References defines cross-product references, e.g. alternatives
		///     or follow-up products.
		/// </summary>
		[JsonProperty("references")]
		public Reference[] References { get; set; }

		/// <summary>
		///     Safetysheet is the name of an safetysheet file (in the media
		///     files) or a URL to the safetysheet on the internet.
		/// </summary>
		[JsonProperty("safetysheet")]
		public string Safetysheet { get; set; }

		/// <summary>
		///     ScalePrices can be used when the price of the product is
		///     dependent on the ordered quantity.
		/// </summary>
		[JsonProperty("scalePrices")]
		public ScalePrice[] ScalePrices { get; set; }

		/// <summary>
		///     Service indicates if the is a good (false) or a service (true).
		///     The default value is false.
		/// </summary>
		[JsonProperty("service")]
		public bool Service { get; set; }

		/// <summary>
		///     SPN is the supplier part number. SPN is a required field.
		/// </summary>
		[JsonProperty("spn")]
		public string Spn { get; set; }

		/// <summary>
		///     TaxCode to use for this product. This is typically
		///     project-specific.
		/// </summary>
		[JsonProperty("taxCode")]
		public string TaxCode { get; set; }

		/// <summary>
		///     TaxRate for this product, a numeric value between 0.0 and 1.0.
		/// </summary>
		[JsonProperty("taxRate")]
		public double TaxRate { get; set; }

		/// <summary>
		///     Thumbnail is the name of an thumbnail image file (in the media
		///     files) or a URL to the image on the internet.
		/// </summary>
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

		/// <summary>
		///     Unspscs is a list of UNSPSC categories the product belongs to.
		/// </summary>
		[JsonProperty("unspscs")]
		public Unspsc[] Unspscs { get; set; }

		/// <summary>
		///     Visible is a flag that indicates whether this product will be
		///     visible to the end-user when shopping. Please consult your
		///     Store Manager before setting a value for this field.
		/// </summary>
		[JsonProperty("visible")]
		public bool? Visible { get; set; }

		#endregion // UpsertProduct
	}

	/// <summary>
	///     UpsertProductResponse is the outcome of a successful request to
	///     upsert a product.
	/// </summary>
	public class UpsertProductResponse
	{
		#region UpsertProductResponse

		/// <summary>
		///     Kind describes this entity.
		/// </summary>
		[JsonProperty("kind")]
		public string Kind { get; set; }

		/// <summary>
		///     Link returns a URL to the representation of the created or
		///     updated product.
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }

		#endregion // UpsertProductResponse
	}

	/// <summary>
	///     CreateService: Create a new product in the given catalog and
	///     area.
	/// </summary>
	public class CreateService
	{
		#region CreateService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;
		private CreateProduct _product;

		/// <summary>
		///     Creates a new instance of CreateService.
		/// </summary>
		public CreateService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public CreateService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public CreateService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     Product properties of the new product.
		/// </summary>
		public CreateService Product(CreateProduct product)
		{
			_product = product;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task<CreateProductResponse> Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products";
			var response = await _service.Client.Execute(
				HttpMethod.Post,
				uriTemplate,
				parameters,
				headers,
				_product);
			return response.GetBodyJSON<CreateProductResponse>();
		}

		#endregion // CreateService
	}

	/// <summary>
	///     DeleteService: Delete a product.
	/// </summary>
	public class DeleteService
	{
		#region DeleteService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;
		private string _spn;

		/// <summary>
		///     Creates a new instance of DeleteService.
		/// </summary>
		public DeleteService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public DeleteService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public DeleteService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     SPN is the supplier part number of the product to delete.
		/// </summary>
		public DeleteService Spn(string spn)
		{
			_spn = spn;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);
			// UriTemplates package wants path parameters as strings
			parameters["spn"] = string.Format("{0}", _spn);

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products/{spn}";
			await _service.Client.Execute(
				HttpMethod.Delete,
				uriTemplate,
				parameters,
				headers,
				null);
		}

		#endregion // DeleteService
	}

	/// <summary>
	///     GetService: Get returns a single product by its Supplier Part
	///     Number (SPN).
	/// </summary>
	public class GetService
	{
		#region GetService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;
		private string _spn;

		/// <summary>
		///     Creates a new instance of GetService.
		/// </summary>
		public GetService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public GetService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public GetService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     SPN is the supplier part number of the product to get.
		/// </summary>
		public GetService Spn(string spn)
		{
			_spn = spn;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task<Product> Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);
			// UriTemplates package wants path parameters as strings
			parameters["spn"] = string.Format("{0}", _spn);

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products/{spn}";
			var response = await _service.Client.Execute(
				HttpMethod.Get,
				uriTemplate,
				parameters,
				headers,
				null);
			return response.GetBodyJSON<Product>();
		}

		#endregion // GetService
	}

	/// <summary>
	///     ReplaceService: Replace all fields of a product. Use Update to
	///     update only certain fields of a product.
	/// </summary>
	public class ReplaceService
	{
		#region ReplaceService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;
		private string _spn;
		private ReplaceProduct _product;

		/// <summary>
		///     Creates a new instance of ReplaceService.
		/// </summary>
		public ReplaceService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public ReplaceService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public ReplaceService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     New properties of the product.
		/// </summary>
		public ReplaceService Product(ReplaceProduct product)
		{
			_product = product;
			return this;
		}

		/// <summary>
		///     SPN is the supplier part number of the product to replace.
		/// </summary>
		public ReplaceService Spn(string spn)
		{
			_spn = spn;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task<ReplaceProductResponse> Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);
			// UriTemplates package wants path parameters as strings
			parameters["spn"] = string.Format("{0}", _spn);

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products/{spn}";
			var response = await _service.Client.Execute(
				HttpMethod.Put,
				uriTemplate,
				parameters,
				headers,
				_product);
			return response.GetBodyJSON<ReplaceProductResponse>();
		}

		#endregion // ReplaceService
	}

	/// <summary>
	///     ScrollService: Scroll through products of a catalog (area). If
	///     you need to iterate through all products in a catalog, this is
	///     the most effective way to do so. If you want to search for
	///     products, use the Search endpoint. 
	/// </summary>
	public class ScrollService
	{
		#region ScrollService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;

		/// <summary>
		///     Creates a new instance of ScrollService.
		/// </summary>
		public ScrollService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public ScrollService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PageToken must be passed in the 2nd and all consective requests
		///     to get the next page of results. You do not need to pass the
		///     page token manually. You should just follow the nextUrl link in
		///     the metadata to get the next slice of data. If there is no
		///     nextUrl returned, you have reached the last page of products
		///     for the given catalog. A scroll request is kept alive for 2
		///     minutes. If you fail to ask for the next slice of products
		///     within this period, a new scroll request will be created and
		///     you start over at the first page of results. 
		/// </summary>
		public ScrollService PageToken(string pageToken)
		{
			_opt["pageToken"] = pageToken;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public ScrollService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task<ScrollResponse> Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			if (_opt.ContainsKey("pageToken"))
			{
				// UriTemplates package wants query parameters as strings
				parameters["pageToken"] = string.Format("{0}", _opt["pageToken"]);
			}
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products/scroll{?pageToken}";
			var response = await _service.Client.Execute(
				HttpMethod.Get,
				uriTemplate,
				parameters,
				headers,
				null);
			return response.GetBodyJSON<ScrollResponse>();
		}

		#endregion // ScrollService
	}

	/// <summary>
	///     SearchService: Search for products. Do not use this method for
	///     iterating through all of the products in a catalog; use the
	///     Scroll endpoint instead. It is much more efficient. 
	/// </summary>
	public class SearchService
	{
		#region SearchService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;

		/// <summary>
		///     Creates a new instance of SearchService.
		/// </summary>
		public SearchService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public SearchService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public SearchService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     Q defines are full text query.
		/// </summary>
		public SearchService Q(string q)
		{
			_opt["q"] = q;
			return this;
		}

		/// <summary>
		///     Skip specifies how many products to skip (default 0).
		/// </summary>
		public SearchService Skip(long skip)
		{
			_opt["skip"] = skip;
			return this;
		}

		/// <summary>
		///     Sort order, e.g. name, spn, id or -created (default: score).
		/// </summary>
		public SearchService Sort(string sort)
		{
			_opt["sort"] = sort;
			return this;
		}

		/// <summary>
		///     Take defines how many products to return (max 100, default 20).
		/// </summary>
		public SearchService Take(long take)
		{
			_opt["take"] = take;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task<SearchResponse> Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);
			if (_opt.ContainsKey("q"))
			{
				// UriTemplates package wants query parameters as strings
				parameters["q"] = string.Format("{0}", _opt["q"]);
			}
			if (_opt.ContainsKey("skip"))
			{
				// UriTemplates package wants query parameters as strings
				parameters["skip"] = string.Format("{0}", _opt["skip"]);
			}
			if (_opt.ContainsKey("sort"))
			{
				// UriTemplates package wants query parameters as strings
				parameters["sort"] = string.Format("{0}", _opt["sort"]);
			}
			if (_opt.ContainsKey("take"))
			{
				// UriTemplates package wants query parameters as strings
				parameters["take"] = string.Format("{0}", _opt["take"]);
			}

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products{?q,skip,take,sort}";
			var response = await _service.Client.Execute(
				HttpMethod.Get,
				uriTemplate,
				parameters,
				headers,
				null);
			return response.GetBodyJSON<SearchResponse>();
		}

		#endregion // SearchService
	}

	/// <summary>
	///     UpdateService: Update the fields of a product selectively. Use
	///     Replace to replace the product as a whole.
	/// </summary>
	public class UpdateService
	{
		#region UpdateService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;
		private string _spn;
		private UpdateProduct _product;

		/// <summary>
		///     Creates a new instance of UpdateService.
		/// </summary>
		public UpdateService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public UpdateService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public UpdateService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     Products properties of the updated product.
		/// </summary>
		public UpdateService Product(UpdateProduct product)
		{
			_product = product;
			return this;
		}

		/// <summary>
		///     SPN is the supplier part number of the product to update.
		/// </summary>
		public UpdateService Spn(string spn)
		{
			_spn = spn;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task<UpdateProductResponse> Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);
			// UriTemplates package wants path parameters as strings
			parameters["spn"] = string.Format("{0}", _spn);

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products/{spn}";
			var response = await _service.Client.Execute(
				HttpMethod.Post,
				uriTemplate,
				parameters,
				headers,
				_product);
			return response.GetBodyJSON<UpdateProductResponse>();
		}

		#endregion // UpdateService
	}

	/// <summary>
	///     UpsertService: Upsert a product in the given catalog and area.
	///     Upsert will create if the product does not exist yet, otherwise
	///     it will update.
	/// </summary>
	public class UpsertService
	{
		#region UpsertService

		private readonly Service _service;
		private readonly IDictionary<string, object> _opt = new Dictionary<string, object>();
		private readonly IDictionary<string, string> _hdr = new Dictionary<string, string>();

		private string _pin;
		private string _area;
		private UpsertProduct _product;

		/// <summary>
		///     Creates a new instance of UpsertService.
		/// </summary>
		public UpsertService(Service service)
		{
			_service = service;
		}

		/// <summary>
		///     Area of the catalog, e.g. work or live.
		/// </summary>
		public UpsertService Area(string area)
		{
			_area = area;
			return this;
		}

		/// <summary>
		///     PIN of the catalog.
		/// </summary>
		public UpsertService Pin(string pin)
		{
			_pin = pin;
			return this;
		}

		/// <summary>
		///     Product properties of the new product.
		/// </summary>
		public UpsertService Product(UpsertProduct product)
		{
			_product = product;
			return this;
		}

		/// <summary>
		///     Execute the operation.
		/// </summary>
		public async Task<UpsertProductResponse> Do()
			{
			// Make a copy of the parameters and add the path parameters to it
			var parameters = new Dictionary<string, object>();
			// UriTemplates package wants path parameters as strings
			parameters["area"] = string.Format("{0}", _area);
			// UriTemplates package wants path parameters as strings
			parameters["pin"] = string.Format("{0}", _pin);

			// Make a copy of the header parameters and set UA
			var headers = new Dictionary<string, string>();
			string authorization = _service.GetAuthorizationHeader();
			if (!string.IsNullOrEmpty(authorization))
			{
				headers["Authorization"] = authorization;
			}

			var uriTemplate = _service.BaseURL + "/catalogs/{pin}/{area}/products/upsert";
			var response = await _service.Client.Execute(
				HttpMethod.Post,
				uriTemplate,
				parameters,
				headers,
				_product);
			return response.GetBodyJSON<UpsertProductResponse>();
		}

		#endregion // UpsertService
	}
}

