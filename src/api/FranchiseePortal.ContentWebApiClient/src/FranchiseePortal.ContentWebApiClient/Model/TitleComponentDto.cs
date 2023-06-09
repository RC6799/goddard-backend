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
    /// TitleComponentDto
    /// </summary>
    [DataContract(Name = "TitleComponentDto")]
    public partial class TitleComponentDto : IEquatable<TitleComponentDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleComponentDto" /> class.
        /// </summary>
        /// <param name="cqpropertyInheritanceCancelled">cqpropertyInheritanceCancelled.</param>
        /// <param name="title">title.</param>
        public TitleComponentDto(List<string> cqpropertyInheritanceCancelled = default(List<string>), string title = default(string))
        {
            this.CqpropertyInheritanceCancelled = cqpropertyInheritanceCancelled;
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets CqpropertyInheritanceCancelled
        /// </summary>
        [DataMember(Name = "cq:propertyInheritanceCancelled", EmitDefaultValue = true)]
        public List<string> CqpropertyInheritanceCancelled { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TitleComponentDto {\n");
            sb.Append("  CqpropertyInheritanceCancelled: ").Append(CqpropertyInheritanceCancelled).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as TitleComponentDto);
        }

        /// <summary>
        /// Returns true if TitleComponentDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TitleComponentDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TitleComponentDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CqpropertyInheritanceCancelled == input.CqpropertyInheritanceCancelled ||
                    this.CqpropertyInheritanceCancelled != null &&
                    input.CqpropertyInheritanceCancelled != null &&
                    this.CqpropertyInheritanceCancelled.SequenceEqual(input.CqpropertyInheritanceCancelled)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.CqpropertyInheritanceCancelled != null)
                {
                    hashCode = (hashCode * 59) + this.CqpropertyInheritanceCancelled.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
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
