﻿namespace MusicBeePlugin.AndroidRemote.Commands.Requests
{
    using Interfaces;
    class RequestLibrarySync : ICommand
    {
        public void Dispose()
        {
            
        }

        public void Execute(IEvent eEvent)
        {
            Plugin.Instance.SyncLibrary();    
        }
    }
}
