/*
 * Goddard School Features API
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
using OpenAPIDateConverter = FranchiseePortal.FeaturesWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.FeaturesWebApiClient.Model
{
    /// <summary>
    /// SchoolFeaturesModel
    /// </summary>
    [DataContract(Name = "SchoolFeaturesModel")]
    public partial class SchoolFeaturesModel : IEquatable<SchoolFeaturesModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolFeaturesModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="schoolNumber">schoolNumber.</param>
        /// <param name="schoolId">schoolId.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="features">features.</param>
        /// <param name="transportationStops">transportationStops.</param>
        public SchoolFeaturesModel(string id = default(string), string schoolNumber = default(string), string schoolId = default(string), bool isActive = default(bool), List<SchoolFeature> features = default(List<SchoolFeature>), List<TransportationStop> transportationStops = default(List<TransportationStop>))
        {
            this.Id = id;
            this.SchoolNumber = schoolNumber;
            this.SchoolId = schoolId;
            this.IsActive = isActive;
            this.Features = features;
            this.TransportationStops = transportationStops;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SchoolNumber
        /// </summary>
        [DataMember(Name = "schoolNumber", EmitDefaultValue = true)]
        public string SchoolNumber { get; set; }

        /// <summary>
        /// Gets or Sets SchoolId
        /// </summary>
        [DataMember(Name = "schoolId", EmitDefaultValue = true)]
        public string SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = true)]
        public List<SchoolFeature> Features { get; set; }

        /// <summary>
        /// Gets or Sets TransportationStops
        /// </summary>
        [DataMember(Name = "transportationStops", EmitDefaultValue = true)]
        public List<TransportationStop> TransportationStops { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolFeaturesModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchoolNumber: ").Append(SchoolNumber).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  TransportationStops: ").Append(TransportationStops).Append("\n");
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
            return this.Equals(input as SchoolFeaturesModel);
        }

        /// <summary>
        /// Returns true if SchoolFeaturesModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolFeaturesModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolFeaturesModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SchoolNumber == input.SchoolNumber ||
                    (this.SchoolNumber != null &&
                    this.SchoolNumber.Equals(input.SchoolNumber))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.TransportationStops == input.TransportationStops ||
                    this.TransportationStops != null &&
                    input.TransportationStops != null &&
                    this.TransportationStops.SequenceEqual(input.TransportationStops)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SchoolNumber != null)
                    hashCode = hashCode * 59 + this.SchoolNumber.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.TransportationStops != null)
                    hashCode = hashCode * 59 + this.TransportationStops.GetHashCode();
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
