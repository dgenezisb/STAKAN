//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace Syte.Models
//{
//    public class Reviews
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        public int Id { get; set; }
//        public string Name { set; get; }
//        public string Review { set; get; }
//        public int BookID { set; get; }
//        [ForeignKey(nameof(BookID))]
//        public virtual Book Book { set; get; }

//    }
//}
