using Newtonsoft.Json;
using System;

namespace SB.Customer.Management.Contracts.Common
{
	public class Comment
	{
		public string CommentText { get; }
		public CommentReason CommentReason { get; }
		public string AddedBy { get; }
		public DateTime AddedDate { get; }

		[JsonConstructor]
		private Comment(string commentText, CommentReason commentReason, string addedBy, DateTime addedDate)
		{
			CommentText = commentText;
			CommentReason = commentReason;
			AddedBy = addedBy;
			AddedDate = addedDate;
		}

		public static Comment Create(string commentText, CommentReason commentReason, string addedBy, DateTime addedDate)
		{
			return new Comment(commentText, commentReason, addedBy, addedDate);
		}

	}
}
