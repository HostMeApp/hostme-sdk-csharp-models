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
    public partial class LoyaltySettings :  IEquatable<LoyaltySettings>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltySettings" /> class.
        /// Initializes a new instance of the <see cref="LoyaltySettings" />class.
        /// </summary>
        /// <param name="CheckinPoints">CheckinPoints.</param>
        /// <param name="IsEnabled">IsEnabled.</param>
        /// <param name="MembershipLevelRules">MembershipLevelRules.</param>
        /// <param name="PurchasePointsRules">PurchasePointsRules.</param>
        /// <param name="SignupPoints">SignupPoints.</param>
        /// <param name="WaitingPointsRules">WaitingPointsRules.</param>

        public LoyaltySettings(int? CheckinPoints = null, bool? IsEnabled = null, List<MembershipLevel> MembershipLevelRules = null, List<PurchaseToPoints> PurchasePointsRules = null, int? SignupPoints = null, List<MinutesToPoints> WaitingPointsRules = null)
        {
            this.CheckinPoints = CheckinPoints;
            this.IsEnabled = IsEnabled;
            this.MembershipLevelRules = MembershipLevelRules;
            this.PurchasePointsRules = PurchasePointsRules;
            this.SignupPoints = SignupPoints;
            this.WaitingPointsRules = WaitingPointsRules;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CheckinPoints
        /// </summary>
        [DataMember(Name="checkinPoints", EmitDefaultValue=false)]
        public int? CheckinPoints { get; set; }
    
        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or Sets MembershipLevelRules
        /// </summary>
        [DataMember(Name="membershipLevelRules", EmitDefaultValue=false)]
        public List<MembershipLevel> MembershipLevelRules { get; set; }
    
        /// <summary>
        /// Gets or Sets PurchasePointsRules
        /// </summary>
        [DataMember(Name="purchasePointsRules", EmitDefaultValue=false)]
        public List<PurchaseToPoints> PurchasePointsRules { get; set; }
    
        /// <summary>
        /// Gets or Sets SignupPoints
        /// </summary>
        [DataMember(Name="signupPoints", EmitDefaultValue=false)]
        public int? SignupPoints { get; set; }
    
        /// <summary>
        /// Gets or Sets WaitingPointsRules
        /// </summary>
        [DataMember(Name="waitingPointsRules", EmitDefaultValue=false)]
        public List<MinutesToPoints> WaitingPointsRules { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltySettings {\n");
            sb.Append("  CheckinPoints: ").Append(CheckinPoints).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  MembershipLevelRules: ").Append(MembershipLevelRules).Append("\n");
            sb.Append("  PurchasePointsRules: ").Append(PurchasePointsRules).Append("\n");
            sb.Append("  SignupPoints: ").Append(SignupPoints).Append("\n");
            sb.Append("  WaitingPointsRules: ").Append(WaitingPointsRules).Append("\n");
            
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
            return this.Equals(obj as LoyaltySettings);
        }

        /// <summary>
        /// Returns true if LoyaltySettings instances are equal
        /// </summary>
        /// <param name="other">Instance of LoyaltySettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltySettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CheckinPoints == other.CheckinPoints ||
                    this.CheckinPoints != null &&
                    this.CheckinPoints.Equals(other.CheckinPoints)
                ) && 
                (
                    this.IsEnabled == other.IsEnabled ||
                    this.IsEnabled != null &&
                    this.IsEnabled.Equals(other.IsEnabled)
                ) && 
                (
                    this.MembershipLevelRules == other.MembershipLevelRules ||
                    this.MembershipLevelRules != null &&
                    this.MembershipLevelRules.SequenceEqual(other.MembershipLevelRules)
                ) && 
                (
                    this.PurchasePointsRules == other.PurchasePointsRules ||
                    this.PurchasePointsRules != null &&
                    this.PurchasePointsRules.SequenceEqual(other.PurchasePointsRules)
                ) && 
                (
                    this.SignupPoints == other.SignupPoints ||
                    this.SignupPoints != null &&
                    this.SignupPoints.Equals(other.SignupPoints)
                ) && 
                (
                    this.WaitingPointsRules == other.WaitingPointsRules ||
                    this.WaitingPointsRules != null &&
                    this.WaitingPointsRules.SequenceEqual(other.WaitingPointsRules)
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
                
                if (this.CheckinPoints != null)
                    hash = hash * 59 + this.CheckinPoints.GetHashCode();
                
                if (this.IsEnabled != null)
                    hash = hash * 59 + this.IsEnabled.GetHashCode();
                
                if (this.MembershipLevelRules != null)
                    hash = hash * 59 + this.MembershipLevelRules.GetHashCode();
                
                if (this.PurchasePointsRules != null)
                    hash = hash * 59 + this.PurchasePointsRules.GetHashCode();
                
                if (this.SignupPoints != null)
                    hash = hash * 59 + this.SignupPoints.GetHashCode();
                
                if (this.WaitingPointsRules != null)
                    hash = hash * 59 + this.WaitingPointsRules.GetHashCode();
                
                return hash;
            }
        }

    }


}
