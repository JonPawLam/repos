namespace WebServerHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hotel")]
    public partial class Hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel()
        {
            Room = new HashSet<Room>();
        }

        [Key]
        public int HotelNo { get; set; }

        [Required]
        [StringLength(30)]
        public string HotelName { get; set; }

        [Required]
        [StringLength(50)]
        public string HotelAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Room { get; set; }


        public override string ToString()
        {
            return $"{nameof(HotelNo)}: {HotelNo}, {nameof(HotelName)}: {HotelName}, {nameof(HotelAddress)}: {HotelAddress}";
        }
    }
}
