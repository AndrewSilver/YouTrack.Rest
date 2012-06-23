using System.Collections.Generic;

namespace YouTrack.Rest
{
    public interface IIssueProxy
    {
        string Id { get; }
        void AttachFile(string filePath);
        IEnumerable<IAttachment> GetAttachments();
        void AddComment(string comment);
        ICollection<IComment> Comments { get; }
    }
}