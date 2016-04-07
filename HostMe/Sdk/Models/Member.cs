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
    public partial class Member :  IEquatable<Member>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// Initializes a new instance of the <see cref="Member" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="MembershipLevel">MembershipLevel.</param>
        /// <param name="Points">Points.</param>
        /// <param name="JoinDate">JoinDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="NumberOfVisits30Days">NumberOfVisits30Days.</param>
        /// <param name="NumberOfVisitsTotal">NumberOfVisitsTotal.</param>
        /// <param name="LastVisitDate">LastVisitDate.</param>
        /// <param name="Customer">Customer.</param>

        public Member(int? Id = null, string MembershipLevel = null, long? Points = null, DateTimeOffset? JoinDate = null, string Status = null, int? NumberOfVisits30Days = null, int? NumberOfVisitsTotal = null, DateTimeOffset? LastVisitDate = null, UserProfile Customer = null)
        {
            this.Id = Id;
            this.MembershipLevel = MembershipLevel;
            this.Points = Points;
            this.JoinDate = JoinDate;
            this.Status = Status;
            this.NumberOfVisits30Days = NumberOfVisits30Days;
            this.NumberOfVisitsTotal = NumberOfVisitsTotal;
            this.LastVisitDate = LastVisitDate;
            this.Customer = Customer;
            
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
        /// Gets or Sets NumberOfVisits30Days
        /// </summary>
        [DataMember(Name="numberOfVisits30Days", EmitDefaultValue=false)]
        public int? NumberOfVisits30Days { get; set; }
    
        /// <summary>
        /// Gets or Sets NumberOfVisitsTotal
        /// </summary>
        [DataMember(Name="numberOfVisitsTotal", EmitDefaultValue=false)]
        public int? NumberOfVisitsTotal { get; set; }
    
        /// <summary>
        /// Gets or Sets LastVisitDate
        /// </summary>
        [DataMember(Name="lastVisitDate", EmitDefaultValue=false)]
        public DateTimeOffset? LastVisitDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public UserProfile Customer { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Member {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MembershipLevel: ").Append(MembershipLevel).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NumberOfVisits30Days: ").Append(NumberOfVisits30Days).Append("\n");
            sb.Append("  NumberOfVisitsTotal: ").Append(NumberOfVisitsTotal).Append("\n");
            sb.Append("  LastVisitDate: ").Append(LastVisitDate).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            
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
            return this.Equals(obj as Member);
        }

        /// <summary>
        /// Returns true if Member instances are equal
        /// </summary>
        /// <param name="other">Instance of Member to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Member other)
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
                    this.NumberOfVisits30Days == other.NumberOfVisits30Days ||
                    this.NumberOfVisits30Days != null &&
                    this.NumberOfVisits30Days.Equals(other.NumberOfVisits30Days)
                ) && 
                (
                    this.NumberOfVisitsTotal == other.NumberOfVisitsTotal ||
                    this.NumberOfVisitsTotal != null &&
                    this.NumberOfVisitsTotal.Equals(other.NumberOfVisitsTotal)
                ) && 
                (
                    this.LastVisitDate == other.LastVisitDate ||
                    this.LastVisitDate != null &&
                    this.LastVisitDate.Equals(other.LastVisitDate)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
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
                
                if (this.NumberOfVisits30Days != null)
                    hash = hash * 59 + this.NumberOfVisits30Days.GetHashCode();
                
                if (this.NumberOfVisitsTotal != null)
                    hash = hash * 59 + this.NumberOfVisitsTotal.GetHashCode();
                
                if (this.LastVisitDate != null)
                    hash = hash * 59 + this.LastVisitDate.GetHashCode();
                
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                
                return hash;
            }
        }

    }


}
