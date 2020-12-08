using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        //fully define the relationship between the photo table and appuser table
        //each photo will have an ID and on delete the user the photo will be deleted
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

    }
}