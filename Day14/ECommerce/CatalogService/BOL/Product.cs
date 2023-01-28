namespace BOL;
using System.ComponentModel.DataAnnotations;
public class Product {

        public int Id{get;set;}

        [Required]
        public string Title{get;set;}
        public string Description{get;set;}

        [Range(minimum:5,maximum:20)]
        public int UnitPrice{get;set;}
        public int Quantity{get;set;}

}