//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Videohost.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Video
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Video()
        {
            this.LikeDislikes = new HashSet<LikeDislike>();
        }
    
        public int Id { get; set; }
        public string link_video { get; set; }
        public int id_game { get; set; }
        public int id_user { get; set; }
    
        public virtual Game Game { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LikeDislike> LikeDislikes { get; set; }
        public virtual User User { get; set; }
    }
}
