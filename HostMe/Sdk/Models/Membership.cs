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
    public partial class Membership :  IEquatable<Membership>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Membership" /> class.
        /// Initializes a new instance of the <see cref="Membership" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="MembershipLevel">MembershipLevel.</param>
        /// <param name="Points">Points.</param>
        /// <param name="JoinDate">JoinDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Restaurant">Restaurant.</param>
        /// <param name="IsMember">IsMember.</param>
        /// <param name="Profile">Profile.</param>

        public Membership(int? Id = null, string MembershipLevel = null, long? Points = null, DateTimeOffset? JoinDate = null, string Status = null, RestaurantInfo Restaurant = null, bool? IsMember = null, UserProfile Profile = null)
        {
            this.Id = Id;
            this.MembershipLevel = MembershipLevel;
            this.Points = Points;
            this.JoinDate = JoinDate;
            this.Status = Status;
            this.Restaurant = Restaurant;
            this.IsMember = IsMember;
            this.Profile = Profile;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets MembershipLevel
        /// </summary>
        [DataMember(Name="membershipLevel", EmitDefaultValue=false)]
        public string MembershipLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public long? Points { get; set; }
    
        /// <summary>
        /// Gets or Sets JoinDate
        /// </summary>
        [DataMember(Name="joinDate", EmitDefaultValue=false)]
        public DateTimeOffset? JoinDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or Sets Restaurant
        /// </summary>
        [DataMember(Name="restaurant", EmitDefaultValue=false)]
        public RestaurantInfo Restaurant { get; set; }
    
        /// <summary>
        /// Gets or Sets IsMember
        /// </summary>
        [DataMember(Name="isMember", EmitDefaultValue=false)]
        public bool? IsMember { get; set; }
    
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public UserProfile Profile { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Membership {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MembershipLevel: ").Append(MembershipLevel).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Restaurant: ").Append(Restaurant).Append("\n");
            sb.Append("  IsMember: ").Append(IsMember).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            
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
            return this.Equals(obj as Membership);
        }

        /// <summary>
        /// Returns true if Membership instances are equal
        /// </summary>
        /// <param name="other">Instance of Membership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Membership other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.MembershipLevel == other.MembershipLevel ||
                    this.MembershipLevel != null &&
                    this.MembershipLevel.Equals(other.MembershipLevel)
                ) && 
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) && 
                (
                    this.JoinDate == other.JoinDate ||
                    this.JoinDate != null &&
                    this.JoinDate.Equals(other.JoinDate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Restaurant == other.Restaurant ||
                    this.Restaurant != null &&
                    this.Restaurant.Equals(other.Restaurant)
                ) && 
                (
                    this.IsMember == other.IsMember ||
                    this.IsMember != null &&
                    this.IsMember.Equals(other.IsMember)
                ) && 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.MembershipLevel != null)
                    hash = hash * 59 + this.MembershipLevel.GetHashCode();
                
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                
                if (this.JoinDate != null)
                    hash = hash * 59 + this.JoinDate.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Restaurant != null)
                    hash = hash * 59 + this.Restaurant.GetHashCode();
                
                if (this.IsMember != null)
                    hash = hash * 59 + this.IsMember.GetHashCode();
                
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
                
                return hash;
            }
        }

    }


}
