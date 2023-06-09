/*
 * Goddard.AuthorizationApi
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
using OpenAPIDateConverter = FranchiseePortal.AuthorizationWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.AuthorizationWebApiClient.Model
{
    /// <summary>
    /// AuthorizedSchool
    /// </summary>
    [DataContract(Name = "AuthorizedSchool")]
    public partial class AuthorizedSchool : IEquatable<AuthorizedSchool>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedSchool" /> class.
        /// </summary>
        /// <param name="crmId">crmId.</param>
        /// <param name="roles">roles.</param>
        public AuthorizedSchool(string crmId = default(string), List<string> roles = default(List<string>))
        {
            this.CrmId = crmId;
            this.Roles = roles;
        }

        /// <summary>
        /// Gets or Sets CrmId
        /// </summary>
        [DataMember(Name = "crmId", EmitDefaultValue = true)]
        public string CrmId { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizedSchool {\n");
            sb.Append("  CrmId: ").Append(CrmId).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as AuthorizedSchool);
        }

        /// <summary>
        /// Returns true if AuthorizedSchool instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizedSchool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizedSchool input)
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
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
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
