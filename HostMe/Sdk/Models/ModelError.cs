using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace HostMe.Sdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ModelError :  IEquatable<ModelError>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelError" /> class.
        /// Initializes a new instance of the <see cref="ModelError" />class.
        /// </summary>
        /// <param name="Exception">Exception.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>

        public ModelError(Object Exception = null, string ErrorMessage = null)
        {
            this.Exception = Exception;
            this.ErrorMessage = ErrorMessage;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        [DataMember(Name="exception", EmitDefaultValue=false)]
        public Object Exception { get; set; }
    
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelError {\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ModelError);
        }

        /// <summary>
        /// Returns true if ModelError instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Exception == other.Exception ||
                    this.Exception != null &&
                    this.Exception.Equals(other.Exception)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Exception != null)
                    hash = hash * 59 + this.Exception.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                return hash;
            }
        }

    }


}
