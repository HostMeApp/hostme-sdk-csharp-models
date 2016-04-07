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
    public partial class WithAccessTokenContract1RestaurantContract :  IEquatable<WithAccessTokenContract1RestaurantContract>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WithAccessTokenContract1RestaurantContract" /> class.
        /// Initializes a new instance of the <see cref="WithAccessTokenContract1RestaurantContract" />class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="AccessToken">AccessToken.</param>

        public WithAccessTokenContract1RestaurantContract(Restaurant Data = null, string AccessToken = null)
        {
            this.Data = Data;
            this.AccessToken = AccessToken;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Restaurant Data { get; set; }
    
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WithAccessTokenContract1RestaurantContract {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            
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
            return this.Equals(obj as WithAccessTokenContract1RestaurantContract);
        }

        /// <summary>
        /// Returns true if WithAccessTokenContract1RestaurantContract instances are equal
        /// </summary>
        /// <param name="other">Instance of WithAccessTokenContract1RestaurantContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithAccessTokenContract1RestaurantContract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
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
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                
                return hash;
            }
        }

    }


}
