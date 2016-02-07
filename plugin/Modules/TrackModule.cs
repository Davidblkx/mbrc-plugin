﻿#region

using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MusicBeePlugin.AndroidRemote.Enumerations;
using MusicBeePlugin.AndroidRemote.Model;
using MusicBeePlugin.AndroidRemote.Utilities;
using MusicBeePlugin.Rest.ServiceModel.Type;
using NLog;

#endregion

namespace MusicBeePlugin.Modules
{
    using MusicBeePlugin.ApiAdapters;

    public class TrackModule
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly ITrackApiAdapter api;
        private readonly LyricCoverModel _model;

        public TrackModule(ITrackApiAdapter api, LyricCoverModel model)
        {
            this.api = api;
            _model = model;
        }

        public TrackInfoResponse GetTrackInfo()
        {
            return this.api.GetTrackInfo();
        }

        /// <summary>
        ///     If the given rating string is not null or empty and the value of the string is a float number in the [0,5]
        ///     the function will set the new rating as the current index's new index rating. In any other case it will
        ///     just return the rating for the current index.
        /// </summary>
        /// <returns>Track Rating</returns>
        public float GetRating()
        {
            return this.api.GetRating();
        }

        public float SetRating(float rating)
        {
            return this.api.SetRating(rating);
        }

        /// <summary>
        ///     Requests the Now Playing Track Cover. If the cover is available it is dispatched along with an event.
        ///     If not, and the ApiRevision is equal or greater than r17 a request for the downloaded artwork is
        ///     initiated. The cover is dispatched along with an event when ready.
        /// </summary>
        public void RequestNowPlayingTrackCover()
        {
            //todo: not sure if this will work refactor if required
            this.api.RequestCover(_model);
        }

        /// <summary>
        ///     Sets the position of the playing track
        /// </summary>
        /// <param name="newPosition"></param>
        public PositionResponse SetPosition(int newPosition)
        {
            return this.api.SetPosition(newPosition);
        }

        public PositionResponse GetPosition()
        {
            return this.api.GetPosition();
        }

        /// <summary>
        ///     This function is used to change the playing index's last.fm love rating.
        /// </summary>
        /// <param name="action">
        ///     The action can be either love, or ban.
        /// </param>
        public LastfmStatus RequestLoveStatus(string action)
        {
            return this.api.GetLoveStatus(action);
        }

        public Stream GetBinaryCoverData()
        {
            return Utilities.GetCoverStreamFromBase64(_model.Cover);
        }
    }
}