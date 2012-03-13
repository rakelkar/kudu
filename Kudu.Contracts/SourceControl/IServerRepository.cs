﻿namespace Kudu.Core.SourceControl
{
    public interface IServerRepository
    {
        string CurrentId { get; }
        bool Exists { get; }
        PushInfo GetPushInfo();
        void Initialize();
        ChangeSet GetChangeSet(string id);
        void Update(string id);
        void Update();
        void Clean();
        RepositoryType GetRepositoryType();
    }
}
