using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Deloitte.NAA.Data.Entities
{
    public partial class ReviewPointComment
    {
        public int ReviewPointCommentId { get; set; }
        public int ReviewPointId { get; set; }
        public string Comment { get; set; }
        public string Response { get; set; }
        public int CommentByReviewUserId { get; set; }
        public int? ResponseByReviewerUserId { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual User CommentByReviewUser { get; set; }
        public virtual User ResponseByReviewerUser { get; set; }
        public virtual ReviewPoint ReviewPoint { get; set; }
    }
}
