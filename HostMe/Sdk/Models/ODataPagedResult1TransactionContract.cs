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
    public partial class ODataPagedResult1TransactionContract :  IEquatable<ODataPagedResult1TransactionContract>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataPagedResult1TransactionContract" /> class.
        /// Initializes a new instance of the <see cref="ODataPagedResult1TransactionContract" />class.
        /// </summary>
        /// <param name="Results">Results.</param>
        /// <param name="Count">Count.</param>

        public ODataPagedResult1TransactionContract(List<Transaction> Results = null, int? Count = null)
        {
            this.Results = Results;
            this.Count = Count;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<Transaction> Results { get; set; }
    
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ODataPagedResult1TransactionContract {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            
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
            return this.Equals(obj as ODataPagedResult1TransactionContract);
        }

        /// <summary>
        /// Returns true if ODataPagedResult1TransactionContract instances are equal
        /// </summary>
        /// <param name="other">Instance of ODataPagedResult1TransactionContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ODataPagedResult1TransactionContract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                return hash;
            }
        }

    }


}
