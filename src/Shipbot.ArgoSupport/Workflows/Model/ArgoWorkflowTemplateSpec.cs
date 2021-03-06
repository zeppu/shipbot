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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AutoDeploy.ArgoSupport.Workflows.Model
{
    /// <summary>
    /// WorkflowTemplateSpec is a spec of WorkflowTemplate.
    /// </summary>
    [DataContract]
    public partial class ArgoWorkflowTemplateSpec :  IEquatable<ArgoWorkflowTemplateSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgoWorkflowTemplateSpec" /> class.
        /// </summary>
        [JsonConstructor]
        protected ArgoWorkflowTemplateSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgoWorkflowTemplateSpec" /> class.
        /// </summary>
        /// <param name="arguments">Arguments hold arguments to the template..</param>
        /// <param name="templates">Templates is a list of workflow templates. (required).</param>
        public ArgoWorkflowTemplateSpec(ArgoArguments arguments = default(ArgoArguments), List<ArgoTemplate> templates = default(List<ArgoTemplate>))
        {
            // to ensure "templates" is required (not null)
            if (templates == null)
            {
                throw new InvalidDataException("templates is a required property for ArgoWorkflowTemplateSpec and cannot be null");
            }
            else
            {
                this.Templates = templates;
            }
            this.Arguments = arguments;
        }
        
        /// <summary>
        /// Arguments hold arguments to the template.
        /// </summary>
        /// <value>Arguments hold arguments to the template.</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public ArgoArguments Arguments { get; set; }

        /// <summary>
        /// Templates is a list of workflow templates.
        /// </summary>
        /// <value>Templates is a list of workflow templates.</value>
        [DataMember(Name="templates", EmitDefaultValue=false)]
        public List<ArgoTemplate> Templates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArgoWorkflowTemplateSpec {\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
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
            return this.Equals(input as ArgoWorkflowTemplateSpec);
        }

        /// <summary>
        /// Returns true if ArgoWorkflowTemplateSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of ArgoWorkflowTemplateSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArgoWorkflowTemplateSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arguments == input.Arguments ||
                    (this.Arguments != null &&
                    this.Arguments.Equals(input.Arguments))
                ) && 
                (
                    this.Templates == input.Templates ||
                    this.Templates != null &&
                    this.Templates.SequenceEqual(input.Templates)
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
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
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
