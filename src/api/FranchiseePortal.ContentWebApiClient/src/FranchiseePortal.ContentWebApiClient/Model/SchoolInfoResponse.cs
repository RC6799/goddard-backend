/*
 * Goddard.ContentWebApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FranchiseePortal.ContentWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.ContentWebApiClient.Model
{
    /// <summary>
    /// SchoolInfoResponse
    /// </summary>
    [DataContract(Name = "SchoolInfoResponse")]
    public partial class SchoolInfoResponse : IEquatable<SchoolInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolInfoResponse" /> class.
        /// </summary>
        /// <param name="crmId">crmId.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="fmsId">fmsId.</param>
        /// <param name="hasGeolocation">hasGeolocation.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isClosed">isClosed.</param>
        /// <param name="isComingSoon">isComingSoon.</param>
        /// <param name="isInTraining">isInTraining.</param>
        /// <param name="hours">hours.</param>
        /// <param name="showOnPublicWebsite">showOnPublicWebsite.</param>
        /// <param name="socialMediaId">socialMediaId.</param>
        /// <param name="telephone">telephone.</param>
        /// <param name="heroImage">heroImage.</param>
        /// <param name="cfPath">cfPath.</param>
        /// <param name="url">url.</param>
        /// <param name="scheduleTourUrl">scheduleTourUrl.</param>
        /// <param name="facultyDamPath">facultyDamPath.</param>
        /// <param name="iconCardsJson">iconCardsJson.</param>
        /// <param name="customHeroImageDamPath">customHeroImageDamPath.</param>
        /// <param name="homePageImageCardsPath">homePageImageCardsPath.</param>
        public SchoolInfoResponse(string crmId = default(string), string emailAddress = default(string), string fmsId = default(string), bool hasGeolocation = default(bool), bool isActive = default(bool), bool isClosed = default(bool), bool isComingSoon = default(bool), bool isInTraining = default(bool), string hours = default(string), bool showOnPublicWebsite = default(bool), string socialMediaId = default(string), string telephone = default(string), string heroImage = default(string), string cfPath = default(string), string url = default(string), string scheduleTourUrl = default(string), string facultyDamPath = default(string), string iconCardsJson = default(string), string customHeroImageDamPath = default(string), string homePageImageCardsPath = default(string))
        {
            this.CrmId = crmId;
            this.EmailAddress = emailAddress;
            this.FmsId = fmsId;
            this.HasGeolocation = hasGeolocation;
            this.IsActive = isActive;
            this.IsClosed = isClosed;
            this.IsComingSoon = isComingSoon;
            this.IsInTraining = isInTraining;
            this.Hours = hours;
            this.ShowOnPublicWebsite = showOnPublicWebsite;
            this.SocialMediaId = socialMediaId;
            this.Telephone = telephone;
            this.HeroImage = heroImage;
            this.CfPath = cfPath;
            this.Url = url;
            this.ScheduleTourUrl = scheduleTourUrl;
            this.FacultyDamPath = facultyDamPath;
            this.IconCardsJson = iconCardsJson;
            this.CustomHeroImageDamPath = customHeroImageDamPath;
            this.HomePageImageCardsPath = homePageImageCardsPath;
        }

        /// <summary>
        /// Gets or Sets CrmId
        /// </summary>
        [DataMember(Name = "crmId", EmitDefaultValue = true)]
        public string CrmId { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name = "emailAddress", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets FmsId
        /// </summary>
        [DataMember(Name = "fmsId", EmitDefaultValue = true)]
        public string FmsId { get; set; }

        /// <summary>
        /// Gets or Sets HasGeolocation
        /// </summary>
        [DataMember(Name = "hasGeolocation", EmitDefaultValue = true)]
        public bool HasGeolocation { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsClosed
        /// </summary>
        [DataMember(Name = "isClosed", EmitDefaultValue = true)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Gets or Sets IsComingSoon
        /// </summary>
        [DataMember(Name = "isComingSoon", EmitDefaultValue = true)]
        public bool IsComingSoon { get; set; }

        /// <summary>
        /// Gets or Sets IsInTraining
        /// </summary>
        [DataMember(Name = "isInTraining", EmitDefaultValue = true)]
        public bool IsInTraining { get; set; }

        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name = "hours", EmitDefaultValue = true)]
        public string Hours { get; set; }

        /// <summary>
        /// Gets or Sets ShowOnPublicWebsite
        /// </summary>
        [DataMember(Name = "showOnPublicWebsite", EmitDefaultValue = true)]
        public bool ShowOnPublicWebsite { get; set; }

        /// <summary>
        /// Gets or Sets SocialMediaId
        /// </summary>
        [DataMember(Name = "socialMediaId", EmitDefaultValue = true)]
        public string SocialMediaId { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        [DataMember(Name = "telephone", EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets HeroImage
        /// </summary>
        [DataMember(Name = "heroImage", EmitDefaultValue = true)]
        public string HeroImage { get; set; }

        /// <summary>
        /// Gets or Sets CfPath
        /// </summary>
        [DataMember(Name = "cfPath", EmitDefaultValue = true)]
        public string CfPath { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleTourUrl
        /// </summary>
        [DataMember(Name = "scheduleTourUrl", EmitDefaultValue = true)]
        public string ScheduleTourUrl { get; set; }

        /// <summary>
        /// Gets or Sets FacultyDamPath
        /// </summary>
        [DataMember(Name = "facultyDamPath", EmitDefaultValue = true)]
        public string FacultyDamPath { get; set; }

        /// <summary>
        /// Gets or Sets IconCardsJson
        /// </summary>
        [DataMember(Name = "iconCardsJson", EmitDefaultValue = true)]
        public string IconCardsJson { get; set; }

        /// <summary>
        /// Gets or Sets CustomHeroImageDamPath
        /// </summary>
        [DataMember(Name = "customHeroImageDamPath", EmitDefaultValue = true)]
        public string CustomHeroImageDamPath { get; set; }

        /// <summary>
        /// Gets or Sets HomePageImageCardsPath
        /// </summary>
        [DataMember(Name = "homePageImageCardsPath", EmitDefaultValue = true)]
        public string HomePageImageCardsPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolInfoResponse {\n");
            sb.Append("  CrmId: ").Append(CrmId).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FmsId: ").Append(FmsId).Append("\n");
            sb.Append("  HasGeolocation: ").Append(HasGeolocation).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  IsComingSoon: ").Append(IsComingSoon).Append("\n");
            sb.Append("  IsInTraining: ").Append(IsInTraining).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  ShowOnPublicWebsite: ").Append(ShowOnPublicWebsite).Append("\n");
            sb.Append("  SocialMediaId: ").Append(SocialMediaId).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  HeroImage: ").Append(HeroImage).Append("\n");
            sb.Append("  CfPath: ").Append(CfPath).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ScheduleTourUrl: ").Append(ScheduleTourUrl).Append("\n");
            sb.Append("  FacultyDamPath: ").Append(FacultyDamPath).Append("\n");
            sb.Append("  IconCardsJson: ").Append(IconCardsJson).Append("\n");
            sb.Append("  CustomHeroImageDamPath: ").Append(CustomHeroImageDamPath).Append("\n");
            sb.Append("  HomePageImageCardsPath: ").Append(HomePageImageCardsPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchoolInfoResponse);
        }

        /// <summary>
        /// Returns true if SchoolInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CrmId == input.CrmId ||
                    (this.CrmId != null &&
                    this.CrmId.Equals(input.CrmId))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.FmsId == input.FmsId ||
                    (this.FmsId != null &&
                    this.FmsId.Equals(input.FmsId))
                ) && 
                (
                    this.HasGeolocation == input.HasGeolocation ||
                    this.HasGeolocation.Equals(input.HasGeolocation)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.IsClosed == input.IsClosed ||
                    this.IsClosed.Equals(input.IsClosed)
                ) && 
                (
                    this.IsComingSoon == input.IsComingSoon ||
                    this.IsComingSoon.Equals(input.IsComingSoon)
                ) && 
                (
                    this.IsInTraining == input.IsInTraining ||
                    this.IsInTraining.Equals(input.IsInTraining)
                ) && 
                (
                    this.Hours == input.Hours ||
                    (this.Hours != null &&
                    this.Hours.Equals(input.Hours))
                ) && 
                (
                    this.ShowOnPublicWebsite == input.ShowOnPublicWebsite ||
                    this.ShowOnPublicWebsite.Equals(input.ShowOnPublicWebsite)
                ) && 
                (
                    this.SocialMediaId == input.SocialMediaId ||
                    (this.SocialMediaId != null &&
                    this.SocialMediaId.Equals(input.SocialMediaId))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.HeroImage == input.HeroImage ||
                    (this.HeroImage != null &&
                    this.HeroImage.Equals(input.HeroImage))
                ) && 
                (
                    this.CfPath == input.CfPath ||
                    (this.CfPath != null &&
                    this.CfPath.Equals(input.CfPath))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ScheduleTourUrl == input.ScheduleTourUrl ||
                    (this.ScheduleTourUrl != null &&
                    this.ScheduleTourUrl.Equals(input.ScheduleTourUrl))
                ) && 
                (
                    this.FacultyDamPath == input.FacultyDamPath ||
                    (this.FacultyDamPath != null &&
                    this.FacultyDamPath.Equals(input.FacultyDamPath))
                ) && 
                (
                    this.IconCardsJson == input.IconCardsJson ||
                    (this.IconCardsJson != null &&
                    this.IconCardsJson.Equals(input.IconCardsJson))
                ) && 
                (
                    this.CustomHeroImageDamPath == input.CustomHeroImageDamPath ||
                    (this.CustomHeroImageDamPath != null &&
                    this.CustomHeroImageDamPath.Equals(input.CustomHeroImageDamPath))
                ) && 
                (
                    this.HomePageImageCardsPath == input.HomePageImageCardsPath ||
                    (this.HomePageImageCardsPath != null &&
                    this.HomePageImageCardsPath.Equals(input.HomePageImageCardsPath))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CrmId != null)
                    hashCode = hashCode * 59 + this.CrmId.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FmsId != null)
                    hashCode = hashCode * 59 + this.FmsId.GetHashCode();
                hashCode = hashCode * 59 + this.HasGeolocation.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                hashCode = hashCode * 59 + this.IsClosed.GetHashCode();
                hashCode = hashCode * 59 + this.IsComingSoon.GetHashCode();
                hashCode = hashCode * 59 + this.IsInTraining.GetHashCode();
                if (this.Hours != null)
                    hashCode = hashCode * 59 + this.Hours.GetHashCode();
                hashCode = hashCode * 59 + this.ShowOnPublicWebsite.GetHashCode();
                if (this.SocialMediaId != null)
                    hashCode = hashCode * 59 + this.SocialMediaId.GetHashCode();
                if (this.Telephone != null)
                    hashCode = hashCode * 59 + this.Telephone.GetHashCode();
                if (this.HeroImage != null)
                    hashCode = hashCode * 59 + this.HeroImage.GetHashCode();
                if (this.CfPath != null)
                    hashCode = hashCode * 59 + this.CfPath.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ScheduleTourUrl != null)
                    hashCode = hashCode * 59 + this.ScheduleTourUrl.GetHashCode();
                if (this.FacultyDamPath != null)
                    hashCode = hashCode * 59 + this.FacultyDamPath.GetHashCode();
                if (this.IconCardsJson != null)
                    hashCode = hashCode * 59 + this.IconCardsJson.GetHashCode();
                if (this.CustomHeroImageDamPath != null)
                    hashCode = hashCode * 59 + this.CustomHeroImageDamPath.GetHashCode();
                if (this.HomePageImageCardsPath != null)
                    hashCode = hashCode * 59 + this.HomePageImageCardsPath.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
