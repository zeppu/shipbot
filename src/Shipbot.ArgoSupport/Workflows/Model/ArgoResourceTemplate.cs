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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AutoDeploy.ArgoSupport.Workflows.Model
{
    /// <summary>
    /// ResourceTemplate is a template subtype to manipulate kubernetes resources
    /// </summary>
    [DataContract]
    public partial class ArgoResourceTemplate :  IEquatable<ArgoResourceTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgoResourceTemplate" /> class.
        /// </summary>
        [JsonConstructor]
        protected ArgoResourceTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgoResourceTemplate" /> class.
        /// </summary>
        /// <param name="action">Action is the action to perform to the resource. Must be one of: get, create, apply, delete, replace, patch (required).</param>
        /// <param name="failureCondition">FailureCondition is a label selector expression which describes the conditions of the k8s resource in which the step was considered failed.</param>
        /// <param name="manifest">Manifest contains the kubernetes manifest (required).</param>
        /// <param name="mergeStrategy">MergeStrategy is the strategy used to merge a patch. It defaults to \&quot;strategic\&quot; Must be one of: strategic, merge, json.</param>
        /// <param name="setOwnerReference">SetOwnerReference sets the reference to the workflow on the OwnerReference of generated resource..</param>
        /// <param name="successCondition">SuccessCondition is a label selector expression which describes the conditions of the k8s resource in which it is acceptable to proceed to the following step.</param>
        public ArgoResourceTemplate(string action = default(string), string failureCondition = default(string), string manifest = default(string), string mergeStrategy = default(string), bool? setOwnerReference = default(bool?), string successCondition = default(string))
        {
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for ArgoResourceTemplate and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            // to ensure "manifest" is required (not null)
            if (manifest == null)
            {
                throw new InvalidDataException("manifest is a required property for ArgoResourceTemplate and cannot be null");
            }
            else
            {
                this.Manifest = manifest;
            }
            this.FailureCondition = failureCondition;
            this.MergeStrategy = mergeStrategy;
            this.SetOwnerReference = setOwnerReference;
            this.SuccessCondition = successCondition;
        }
        
        /// <summary>
        /// Action is the action to perform to the resource. Must be one of: get, create, apply, delete, replace, patch
        /// </summary>
        /// <value>Action is the action to perform to the resource. Must be one of: get, create, apply, delete, replace, patch</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// FailureCondition is a label selector expression which describes the conditions of the k8s resource in which the step was considered failed
        /// </summary>
        /// <value>FailureCondition is a label selector expression which describes the conditions of the k8s resource in which the step was considered failed</value>
        [DataMember(Name="failureCondition", EmitDefaultValue=false)]
        public string FailureCondition { get; set; }

        /// <summary>
        /// Manifest contains the kubernetes manifest
        /// </summary>
        /// <value>Manifest contains the kubernetes manifest</value>
        [DataMember(Name="manifest", EmitDefaultValue=false)]
        public string Manifest { get; set; }

        /// <summary>
        /// MergeStrategy is the strategy used to merge a patch. It defaults to \&quot;strategic\&quot; Must be one of: strategic, merge, json
        /// </summary>
        /// <value>MergeStrategy is the strategy used to merge a patch. It defaults to \&quot;strategic\&quot; Must be one of: strategic, merge, json</value>
        [DataMember(Name="mergeStrategy", EmitDefaultValue=false)]
        public string MergeStrategy { get; set; }

        /// <summary>
        /// SetOwnerReference sets the reference to the workflow on the OwnerReference of generated resource.
        /// </summary>
        /// <value>SetOwnerReference sets the reference to the workflow on the OwnerReference of generated resource.</value>
        [DataMember(Name="setOwnerReference", EmitDefaultValue=false)]
        public bool? SetOwnerReference { get; set; }

        /// <summary>
        /// SuccessCondition is a label selector expression which describes the conditions of the k8s resource in which it is acceptable to proceed to the following step
        /// </summary>
        /// <value>SuccessCondition is a label selector expression which describes the conditions of the k8s resource in which it is acceptable to proceed to the following step</value>
        [DataMember(Name="successCondition", EmitDefaultValue=false)]
        public string SuccessCondition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArgoResourceTemplate {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  FailureCondition: ").Append(FailureCondition).Append("\n");
            sb.Append("  Manifest: ").Append(Manifest).Append("\n");
            sb.Append("  MergeStrategy: ").Append(MergeStrategy).Append("\n");
            sb.Append("  SetOwnerReference: ").Append(SetOwnerReference).Append("\n");
            sb.Append("  SuccessCondition: ").Append(SuccessCondition).Append("\n");
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
            return this.Equals(input as ArgoResourceTemplate);
        }

        /// <summary>
        /// Returns true if ArgoResourceTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ArgoResourceTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArgoResourceTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.FailureCondition == input.FailureCondition ||
                    (this.FailureCondition != null &&
                    this.FailureCondition.Equals(input.FailureCondition))
                ) && 
                (
                    this.Manifest == input.Manifest ||
                    (this.Manifest != null &&
                    this.Manifest.Equals(input.Manifest))
                ) && 
                (
                    this.MergeStrategy == input.MergeStrategy ||
                    (this.MergeStrategy != null &&
                    this.MergeStrategy.Equals(input.MergeStrategy))
                ) && 
                (
                    this.SetOwnerReference == input.SetOwnerReference ||
                    (this.SetOwnerReference != null &&
                    this.SetOwnerReference.Equals(input.SetOwnerReference))
                ) && 
                (
                    this.SuccessCondition == input.SuccessCondition ||
                    (this.SuccessCondition != null &&
                    this.SuccessCondition.Equals(input.SuccessCondition))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.FailureCondition != null)
                    hashCode = hashCode * 59 + this.FailureCondition.GetHashCode();
                if (this.Manifest != null)
                    hashCode = hashCode * 59 + this.Manifest.GetHashCode();
                if (this.MergeStrategy != null)
                    hashCode = hashCode * 59 + this.MergeStrategy.GetHashCode();
                if (this.SetOwnerReference != null)
                    hashCode = hashCode * 59 + this.SetOwnerReference.GetHashCode();
                if (this.SuccessCondition != null)
                    hashCode = hashCode * 59 + this.SuccessCondition.GetHashCode();
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
