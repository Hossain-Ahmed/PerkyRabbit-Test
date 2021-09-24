using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Demo.Foundation.Entities
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength =2)]
        [Required(ErrorMessage ="Please enter the title")]
        public string Title { get; set; }
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the author name")]
        public string Author { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the description")]
        public string Description { get; set; }
        //[Required(ErrorMessage = "Please choose the category")]
        //public string Category { get; set; }
        //[Required(ErrorMessage = "Please choose the language")]
        //public string Language { get; set; }
        [Required(ErrorMessage = "Please enter the Number of Total Pages")]
        [Display(Name ="Total Pages")]
        public int? TotalPages { get; set; }
        //public DateTime? CreatedOn { get; set; }
        //public DateTime? UpdatedOn { get; set; }
        //[Required(ErrorMessage = "Please select the cover photo ")]
        //[Display(Name = "Cover Photo")]
        //public string CoverPhotoUrl { get; set; }
        //public IList<BookGallery> BookGalleryUrl { get; set; }
        //[Required(ErrorMessage = "Please select the Pdf file ")]
        //[Display(Name = "Pdf File")]
        //public string PdfUrl { get; set; }  
    }
}
