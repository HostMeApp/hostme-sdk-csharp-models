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
    public partial class TableInfo :  IEquatable<TableInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TableInfo" /> class.
        /// Initializes a new instance of the <see cref="TableInfo" />class.
        /// </summary>
        /// <param name="TableNumber">TableNumber.</param>
        /// <param name="IsComb">IsComb.</param>
        /// <param name="TableTopSize">TableTopSize.</param>
        /// <param name="Area">Area.</param>

        public TableInfo(string TableNumber = null, bool? IsComb = null, int? TableTopSize = null, string Area = null)
        {
            this.TableNumber = TableNumber;
            this.IsComb = IsComb;
            this.TableTopSize = TableTopSize;
            this.Area = Area;
            
        }
        
    
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=false)]
        public string TableNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets IsComb
        /// </summary>
        [DataMember(Name="isComb", EmitDefaultValue=false)]
        public bool? IsComb { get; set; }
    
        /// <summary>
        /// Gets or Sets TableTopSize
        /// </summary>
        [DataMember(Name="tableTopSize", EmitDefaultValue=false)]
        public int? TableTopSize { get; set; }
    
        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableInfo {\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  IsComb: ").Append(IsComb).Append("\n");
            sb.Append("  TableTopSize: ").Append(TableTopSize).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            
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
            return this.Equals(obj as TableInfo);
        }

        /// <summary>
        /// Returns true if TableInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of TableInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
                ) && 
                (
                    this.IsComb == other.IsComb ||
                    this.IsComb != null &&
                    this.IsComb.Equals(other.IsComb)
                ) && 
                (
                    this.TableTopSize == other.TableTopSize ||
                    this.TableTopSize != null &&
                    this.TableTopSize.Equals(other.TableTopSize)
                ) && 
                (
                    this.Area == other.Area ||
                    this.Area != null &&
                    this.Area.Equals(other.Area)
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
                
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                
                if (this.IsComb != null)
                    hash = hash * 59 + this.IsComb.GetHashCode();
                
                if (this.TableTopSize != null)
                    hash = hash * 59 + this.TableTopSize.GetHashCode();
                
                if (this.Area != null)
                    hash = hash * 59 + this.Area.GetHashCode();
                
                return hash;
            }
        }

    }


}
