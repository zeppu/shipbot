/* 
 * Argo
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AutoDeploy.ArgoSupport.Workflows.Model
{
    /// <summary>
    /// Arguments to a template
    /// </summary>
    [DataContract]
    public partial class ArgoArguments :  IEquatable<ArgoArguments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgoArguments" /> class.
        /// </summary>
        /// <param name="artifacts">Artifacts is the list of artifacts to pass to the template or workflow.</param>
        /// <param name="parameters">Parameters is the list of parameters to pass to the template or workflow.</param>
        public ArgoArguments(List<ArgoArtifact> artifacts = default(List<ArgoArtifact>), List<ArgoParameter> parameters = default(List<ArgoParameter>))
        {
            this.Artifacts = artifacts;
            this.Parameters = parameters;
        }
        
        /// <summary>
        /// Artifacts is the list of artifacts to pass to the template or workflow
        /// </summary>
        /// <value>Artifacts is the list of artifacts to pass to the template or workflow</value>
        [DataMember(Name="artifacts", EmitDefaultValue=false)]
        public List<ArgoArtifact> Artifacts { get; set; }

        /// <summary>
        /// Parameters is the list of parameters to pass to the template or workflow
        /// </summary>
        /// <value>Parameters is the list of parameters to pass to the template or workflow</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<ArgoParameter> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArgoArguments {\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArgoArguments);
        }

        /// <summary>
        /// Returns true if ArgoArguments instances are equal
        /// </summary>
        /// <param name="input">Instance of ArgoArguments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArgoArguments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.Artifacts != null)
                    hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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
