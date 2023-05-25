/*
 * Goddard iPaaS Leads API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
using OpenAPIDateConverter = FranchiseePortal.LeadsWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.LeadsWebApiClient.Model
{
    /// <summary>
    /// PhoneValidationResult
    /// </summary>
    [DataContract(Name = "PhoneValidationResult")]
    public partial class PhoneValidationResult : IEquatable<PhoneValidationResult>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Rejection
        /// </summary>
        [DataMember(Name = "rejection", EmitDefaultValue = true)]
        public ValidationRejection? Rejection { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public ValidationStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneValidationResult" /> class.
        /// </summary>
        /// <param name="integrationAuditLogId">integrationAuditLogId.</param>
        /// <param name="rejection">rejection.</param>
        /// <param name="phoneType">phoneType.</param>
        /// <param name="providerResult">providerResult.</param>
        /// <param name="formattedPhoneNumber">formattedPhoneNumber.</param>
        /// <param name="confidenceLevel">confidenceLevel.</param>
        /// <param name="status">status.</param>
        /// <param name="succeeded">succeeded.</param>
        public PhoneValidationResult(long? integrationAuditLogId = default(long?), ValidationRejection? rejection = default(ValidationRejection?), string phoneType = default(string), string providerResult = default(string), string formattedPhoneNumber = default(string), string confidenceLevel = default(string), ValidationStatus? status = default(ValidationStatus?), bool succeeded = default(bool))
        {
            this.IntegrationAuditLogId = integrationAuditLogId;
            this.Rejection = rejection;
            this.PhoneType = phoneType;
            this.ProviderResult = providerResult;
            this.FormattedPhoneNumber = formattedPhoneNumber;
            this.ConfidenceLevel = confidenceLevel;
            this.Status = status;
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Gets or Sets IntegrationAuditLogId
        /// </summary>
        [DataMember(Name = "integrationAuditLogId", EmitDefaultValue = true)]
        public long? IntegrationAuditLogId { get; set; }

        /// <summary>
        /// Gets or Sets PhoneType
        /// </summary>
        [DataMember(Name = "phoneType", EmitDefaultValue = true)]
        public string PhoneType { get; set; }

        /// <summary>
        /// Gets or Sets ProviderResult
        /// </summary>
        [DataMember(Name = "providerResult", EmitDefaultValue = true)]
        public string ProviderResult { get; set; }

        /// <summary>
        /// Gets or Sets FormattedPhoneNumber
        /// </summary>
        [DataMember(Name = "formattedPhoneNumber", EmitDefaultValue = true)]
        public string FormattedPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ConfidenceLevel
        /// </summary>
        [DataMember(Name = "confidenceLevel", EmitDefaultValue = true)]
        public string ConfidenceLevel { get; set; }

        /// <summary>
        /// Gets or Sets Succeeded
        /// </summary>
        [DataMember(Name = "succeeded", EmitDefaultValue = true)]
        public bool Succeeded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PhoneValidationResult {\n");
            sb.Append("  IntegrationAuditLogId: ").Append(IntegrationAuditLogId).Append("\n");
            sb.Append("  Rejection: ").Append(Rejection).Append("\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
            sb.Append("  ProviderResult: ").Append(ProviderResult).Append("\n");
            sb.Append("  FormattedPhoneNumber: ").Append(FormattedPhoneNumber).Append("\n");
            sb.Append("  ConfidenceLevel: ").Append(ConfidenceLevel).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Succeeded: ").Append(Succeeded).Append("\n");
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
            return this.Equals(input as PhoneValidationResult);
        }

        /// <summary>
        /// Returns true if PhoneValidationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneValidationResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IntegrationAuditLogId == input.IntegrationAuditLogId ||
                    (this.IntegrationAuditLogId != null &&
                    this.IntegrationAuditLogId.Equals(input.IntegrationAuditLogId))
                ) && 
                (
                    this.Rejection == input.Rejection ||
                    this.Rejection.Equals(input.Rejection)
                ) && 
                (
                    this.PhoneType == input.PhoneType ||
                    (this.PhoneType != null &&
                    this.PhoneType.Equals(input.PhoneType))
                ) && 
                (
                    this.ProviderResult == input.ProviderResult ||
                    (this.ProviderResult != null &&
                    this.ProviderResult.Equals(input.ProviderResult))
                ) && 
                (
                    this.FormattedPhoneNumber == input.FormattedPhoneNumber ||
                    (this.FormattedPhoneNumber != null &&
                    this.FormattedPhoneNumber.Equals(input.FormattedPhoneNumber))
                ) && 
                (
                    this.ConfidenceLevel == input.ConfidenceLevel ||
                    (this.ConfidenceLevel != null &&
                    this.ConfidenceLevel.Equals(input.ConfidenceLevel))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Succeeded == input.Succeeded ||
                    this.Succeeded.Equals(input.Succeeded)
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
                if (this.IntegrationAuditLogId != null)
                {
                    hashCode = (hashCode * 59) + this.IntegrationAuditLogId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rejection.GetHashCode();
                if (this.PhoneType != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneType.GetHashCode();
                }
                if (this.ProviderResult != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderResult.GetHashCode();
                }
                if (this.FormattedPhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.FormattedPhoneNumber.GetHashCode();
                }
                if (this.ConfidenceLevel != null)
                {
                    hashCode = (hashCode * 59) + this.ConfidenceLevel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Succeeded.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}